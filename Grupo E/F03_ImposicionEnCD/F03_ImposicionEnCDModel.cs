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



        public List<string> ClientesLista =>
                   ClienteAlmacen.Cliente
                       .Select(c => $"{c.CUIT} , {c.RazonSocial}")
                       .ToList();


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


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string nombreD, string apellidoD, int dniD)
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
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = null,
                DNIDestinatario = dniD,

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                //RecorridoPlanificado = new List<ParadaPlanificada> (),
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
            

            nuevaEncomienda.RecorridoPlanificado = ruta;

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Centro de distribución destino: " + centroDistribucionDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + dniD + "\n\n" +

                "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
                "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
                "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
                "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
                "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
                "----------------------------------\n" +
                "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string nombreD, string apellidoD, int dniD, string localidad)
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
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = direccionParticular,
                DNIDestinatario = dniD,

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = codCentroDistribucionDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                //RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                };

            var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();

          

            nuevaEncomienda.GenerarFactura(

                tarifario,
                incluirRetiro: false,
                incluirEntrega: true,
                incluirAgencia: false);

            var ruta = ObtenerRuta(nuevaEncomienda.CodCentroDistribucionOrigen, nuevaEncomienda.CodCentroDistribucionDestino);


            if (ruta == null)
            {
                MessageBox.Show(
                    $"No existe una ruta posible entre {nuevaEncomienda.CodCentroDistribucionOrigen} y {nuevaEncomienda.CodCentroDistribucionDestino}"
                );

                return;
            }


            nuevaEncomienda.RecorridoPlanificado = ruta;

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);

            

            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Dirección particular de destino: " + nuevaEncomienda.DireccionDestinatario + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + dniD + "\n\n" +

        "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
        "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
        "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
        "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
        "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
        "----------------------------------\n" +
        "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string nombreD, string apellidoD, int dniD)
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
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = null,
                DNIDestinatario = dniD,

                CodCDActual = codCDActual,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = ObtenerCDDestino,

                Estado = EstadoEncomiendaEnum.Admitida,

                AgenciaDestino = CodAgenciaDestino,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,

                //ejemplo cualquiera, en este caso la parada es retiro y 5 Grutas ??, pero debería generarse la ruta real, quizas desde ObtenerRuta?
                //RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

            };


           

            var tarifario = TarifarioAlmacen.Tarifario.FirstOrDefault();



            nuevaEncomienda.GenerarFactura(

                tarifario,
                incluirRetiro: false,
                incluirEntrega: false,
                incluirAgencia: true);

            var ruta = ObtenerRuta(nuevaEncomienda.CodCentroDistribucionOrigen, nuevaEncomienda.CodCentroDistribucionDestino);


            if (ruta == null)
            {
                MessageBox.Show(
                    $"No existe una ruta posible entre {nuevaEncomienda.CodCentroDistribucionOrigen} y {nuevaEncomienda.CodCentroDistribucionDestino}"
                );

                return;
            }


            nuevaEncomienda.RecorridoPlanificado = ruta;

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Agencia de destino: " + agenciaDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + dniD + "\n\n" +

        "---- PRECIO TOTAL DE LA ENCOMIENDA ----\n" +
        "Precio base (combinación tamaño/origen/destino): $" + nuevaEncomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino + "\n" +
        "Extra por retiro a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraRetiro + "\n" +
        "Extra por entrega en agencia: $" + nuevaEncomienda.EncomiendaFactura.ExtraAgencia + "\n" +
        "Extra por entrega a domicilio: $" + nuevaEncomienda.EncomiendaFactura.ExtraEntrega + "\n" +
        "----------------------------------\n" +
        "PRECIO TOTAL: $" + nuevaEncomienda.EncomiendaFactura.PrecioTotalEncomienda + "\n";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public List<ParadaPlanificada> ObtenerRuta(string origen, string destino)
        {
            var visitados = new List<string>();
            return BuscarRutaRec(origen, destino, visitados);
        }

        private List<ParadaPlanificada> BuscarRutaRec(string origen, string destino, List<string> visitados)
        {
            if (visitados.Contains(origen))
                return null;

            visitados.Add(origen);

            var servicios = OmnibusAlmacen.Omnibus
                .Where(o => o.Paradas.Any(p => p.CodigoCD == origen))
                .ToList();

            foreach (var servicio in servicios)
            {
                var paradas = servicio.Paradas;
                int idxOrigen = paradas.FindIndex(p => p.CodigoCD == origen);

                if (idxOrigen < 0)
                    continue;

                // 🚍 Consolidar tramo dentro del mismo servicio
                for (int idxDestino = paradas.Count - 1; idxDestino > idxOrigen; idxDestino--)
                {
                    string paradaDestino = paradas[idxDestino].CodigoCD;

                    // Caso 1: Lo encontramos directo
                    if (paradaDestino == destino)
                    {
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

                    // Caso 2: No es el destino pero podemos seguir desde ahí
                    var copiaVisitados = new List<string>(visitados);
                    var rutaResto = BuscarRutaRec(paradaDestino, destino, copiaVisitados);

                    if (rutaResto != null)
                    {
                        rutaResto.Insert(0, new ParadaPlanificada
                        {
                            ServicioId = servicio.ServicioID,
                            CodigoCDOrigen = origen,
                            CodigoCDDestino = paradaDestino
                        });

                        return rutaResto;
                    }
                }
            }

            return null;
        }



    }
}


