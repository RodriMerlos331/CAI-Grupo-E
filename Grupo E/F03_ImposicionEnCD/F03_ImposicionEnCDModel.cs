using Grupo_E.Almacenes;
using Grupo_E.ImposicionEnCallCenter;
using Grupo_E.RetirarEnAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F03_ImposicionEnCD
{
    public class F03_ImposicionEnCDModel
    {
        public string[] Localidad => LocalidadAlmacen.Localidad
    .Select(l => l.Nombre).ToArray();

        public string[] TamanoBulto => Enum.GetValues(typeof(TipoBultoEnum))
                                               .Cast<TipoBultoEnum>()
                                               .Select(t => t.ToString())
                                               .ToArray();

      

        public Dictionary<string, string> clientes => ClienteAlmacen.Cliente.ToDictionary(c => c.CUIT, c => c.Domicilio);



        public Dictionary<string, (List<string> Agencias, List<string> Terminales)> Localidades =>
     LocalidadAlmacen.Localidad.ToDictionary(
         loc => loc.Nombre,
         loc =>
         {
             var CDLocalidad = LocalidadAlmacen.Localidad
                 .Where(l => l.Nombre == loc.Nombre)
                 .Select(l => l.CodigoCD)
                 .FirstOrDefault();

             var terminal = CentroDeDistribucionAlmacen.CentroDeDistribucion
                 .Where(cd => cd.CodigoCD == CDLocalidad)
                 .Select(cd => cd.NombreTerminal)
                 .Distinct()
                 .ToList();

             var agencias = AgenciaAlmacen.Agencia
                                     .Where(a => terminal.Any(cd => a.CodigoCD == CDLocalidad))
                                     .Select(a =>
                                         a.NombreAgencia)
                                     .Distinct()
                                     .ToList();

             return (agencias, terminal);
         });


        int ultimoNumero = EncomiendaAlmacen.Encomienda
            .Select(e => int.Parse(e.Tracking.Split('_').Last()))
            .DefaultIfEmpty(0)
            .Max();


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {

            var codCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;
            var codLocalidadOrigen = LocalidadAlmacen.Localidad
              .Where(l => l.CodigoCD == codCDActual)
              .Select(l => l.CodigoLocalidad)
              .FirstOrDefault();

            var codCentroDistribucionOrigen = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var ObtenerCDDestino = CentroDeDistribucionAlmacen.CentroDeDistribucion
                    .Where(cd => cd.NombreTerminal == centroDistribucionDestino)
                    .Select(cd => cd.CodigoCD)
                    .FirstOrDefault();
            var CDDestino = ObtenerCDDestino;

            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamañoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = CDDestino + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, 

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                RecorridoPlanificado = new List<ParadaPlanificada> (),
                //por ahora vacío, pero debería generarse la ruta real, quizas desde ObtenerRuta?

                Facturada = false,

                HistorialCambios = new List<Historial>(),

            };

         

            var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();

            nuevaEncomienda.GenerarFactura(

                tarifario,
                incluirRetiro: false,
                incluirEntrega: false,
                incluirAgencia: false);

            var ruta = ObtenerRuta( nuevaEncomienda.CodCentroDistribucionOrigen, nuevaEncomienda.CodCentroDistribucionDestino);

            if (ruta == null)
            {
                MessageBox.Show(
                    $"No existe una ruta posible entre {nuevaEncomienda.CodCentroDistribucionOrigen} y {nuevaEncomienda.CodCentroDistribucionDestino}"
                );

                return;
            }

            // Cargar la ruta en la encomienda
            nuevaEncomienda.RecorridoPlanificado = ruta;

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Centro de distribución destino: " + centroDistribucionDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n" +

                "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
                "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
                "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
                "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
                "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
                "----------------------------------\n" +
                "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario, string localidad)
        {
            var codCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
              .Where(l => l.CodigoCD == codCDActual)
              .Select(l => l.CodigoLocalidad)
              .FirstOrDefault();

            var codCentroDistribucionOrigen = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            //lo sumé acá: pero querría hacerlo como se toma CD desde el menú
            var codLocalidadDestino = LocalidadAlmacen.Localidad
                .Where(l => l.Nombre == localidad)
                .Select(l => l.CodigoLocalidad)
                .FirstOrDefault();

            var codCentroDistribucionDestino = LocalidadAlmacen.Localidad
                .Where(l => l.Nombre == localidad)
                .Select(l => l.CodigoCD)
                .FirstOrDefault();

            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = "DOM" + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = direccionParticular,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = codCentroDistribucionDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                };

            var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();

          

            nuevaEncomienda.GenerarFactura(

                tarifario,
                incluirRetiro: false,
                incluirEntrega: true,
                incluirAgencia: false);

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);

            

            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Dirección particular de destino: " + nuevaEncomienda.DireccionDestinatario + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n" +

        "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
        "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
        "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
        "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
        "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
        "----------------------------------\n" +
        "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            var codCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
              .Where(l => l.CodigoCD == codCDActual)
              .Select(l => l.CodigoLocalidad)
              .FirstOrDefault();


            var codCentroDistribucionOrigen = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            //lo sumé acá: pero querría hacerlo como se toma CD desde el menú
           var ObtenerCDDestino = AgenciaAlmacen.Agencia
                    .Where(a => a.NombreAgencia == agenciaDestino)
                    .Select(a => a.CodigoCD)
                    .FirstOrDefault();

            var CodAgenciaDestino = AgenciaAlmacen.Agencia
                    .Where(a => a.NombreAgencia == agenciaDestino)
                    .Select(a => a.CodigoAgencia)
                    .FirstOrDefault();

            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = CodAgenciaDestino + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = ObtenerCDDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = CodAgenciaDestino,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                //ejemplo cualquiera, en este caso la parada es retiro y 5 Grutas ??, pero debería generarse la ruta real, quizas desde ObtenerRuta?
                RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

            };


           

            var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();



            nuevaEncomienda.GenerarFactura(

                tarifario,
                incluirRetiro: false,
                incluirEntrega: false,
                incluirAgencia: true);

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Agencia de destino: " + agenciaDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n" +

        "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
        "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
        "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
        "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
        "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
        "----------------------------------\n" +
        "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Este método es el que vas a llamar desde la admisión.
        // Crea una lista de CDs visitados (vacía) y arranca la búsqueda recursiva.
        public List<ParadaPlanificada> ObtenerRuta(string origen, string destino)
        {
            // Lista para registrar todos los CDs que ya visité
            // Evita que el algoritmo se meta en ciclos (CD01 → CD05 → CD01 → ...)
            var visitados = new List<string>();

            // Llamo al algoritmo recursivo real
            return BuscarRutaRec(origen, destino, visitados);
        }

        private List<ParadaPlanificada> BuscarRutaRec(string origen, string destino, List<string> visitados)
        {
            // Si ya visité este CD, NO vuelvo a explorarlo (evita ciclos infinitos)
            if (visitados.Contains(origen))
                return null;

            // Marco este CD como visitado
            visitados.Add(origen);

            // Busco todos los servicios (ómnibus) donde aparece este CD como parada
            var servicios = OmnibusAlmacen.Omnibus
                .Where(o => o.Paradas.Any(p => p.CodigoCD == origen))
                .ToList();

            // Recorro cada servicio que pasa por el CD actual
            foreach (var servicio in servicios)
            {
                var paradas = servicio.Paradas;

                // Encuentro en qué posición del servicio aparece el CD origen
                var idxOrigen = paradas.FindIndex(p => p.CodigoCD == origen);

                // Por seguridad (aunque no debería pasar)
                if (idxOrigen == -1)
                    continue;

                // SOLO avanzo hacia adelante en las paradas del servicio
                for (int i = idxOrigen + 1; i < paradas.Count; i++)
                {
                    var paradaDestino = paradas[i].CodigoCD;

                    // CASO 1: La parada que encontré es EXACTAMENTE el destino final
                    if (paradaDestino == destino)
                    {
                        // Devuelvo una ruta de UN solo tramo
                        return new List<ParadaPlanificada>
                {
                    new ParadaPlanificada
                    {
                        ServicioId = servicio.ServicioID,
                        CodigoCDOrigen = origen,
                        CodigoCDDestino = destino
                    }
                };
                    }

                    // CASO 2: La parada NO es el destino → sigo buscando desde ahí
                    // Llamada recursiva
                    var rutaResto = BuscarRutaRec(paradaDestino, destino, visitados);

                    // Si la búsqueda recursiva encontró un camino...
                    if (rutaResto != null)
                    {
                        // Creo el tramo actual
                        var tramoActual = new ParadaPlanificada
                        {
                            ServicioId = servicio.ServicioID,
                            CodigoCDOrigen = origen,
                            CodigoCDDestino = paradaDestino
                        };

                        // La ruta completa es: este tramo + el resto encontrado recursivamente
                        var ruta = new List<ParadaPlanificada>();
                        ruta.Add(tramoActual);
                        ruta.AddRange(rutaResto);

                        return ruta;
                    }
                }
            }

            // Si ningún servicio sirvió, no hay ruta desde este origen
            return null;
        }

    }
}


