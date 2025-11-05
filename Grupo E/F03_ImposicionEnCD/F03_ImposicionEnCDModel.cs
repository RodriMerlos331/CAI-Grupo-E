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

        //Localidades a sumar: , "Tucumán","Corrientes","Neuquén","Viedma"

        public string[] TamanoBulto => Enum.GetValues(typeof(TipoBultoEnum))
                                               .Cast<TipoBultoEnum>()
                                               .Select(t => t.ToString())
                                               .ToArray();

        //new string[] { "S", "M", "L", "XL" };


        /*
        public readonly Dictionary<string, string> clientes = new Dictionary<string, string>
        {
            { "30-12345678-01", "Sanitarios S.A" },
            { "30-87654321-09", "Gomeria Altamirano" },
            { "30-11223344-05", "Huggies" }
        };
        */

        public Dictionary<string, string> clientes => ClienteAlmacen.Cliente.ToDictionary(c => c.CUIT, c => c.Domicilio);



        //COPILOT SUGIRIÓ ESTA FORMA DE HACERLO, PREGUNTAR SI ESTÁ BIEN:
        /*
        public Dictionary<string, (List<string> Agencias, List<string> Terminales)> Localidades =
        new Dictionary<string, (List<string>, List<string>)>
        {
          { "CABA", (new List<string> { "Alto Palermo", "DOT", "Abasto" }, new List<string> { "Retiro", "Dellepiane", "Liniers" }) },
          { "GBA", (new List<string> { "Kiosco", "Shopping", "Local" }, new List<string> { "La Plata", "Pacheco", "Morón" }) },
          { "Córdoba", (new List<string> { "Cerrito", "Montaña", "Arroyo" }, new List<string> { "Villa Carlos Paz", "La Falda", "Río Cuarto" }) }
        };
        */


        //REVISAR

        public Dictionary<string, (List<string> Agencias, List<string> Terminales)> Localidades =>
    LocalidadAlmacen.Localidad.ToDictionary(
        loc => loc.Nombre,
        loc =>
        {

            var cds = CentroDeDistribucionAlmacen.CentroDeDistribucion
                        .Where(cd => cd.CodigoLocalidad == loc.CodigoLocalidad)
                        .ToList();

            var agencias = AgenciaAlmacen.Agencia
                        .Where(a => cds.Any(cd => cd.CodigoCD == a.CodigoCD))
                        .Select(a =>
                            a.NombreAgencia)
                        .Distinct()
                        .ToList();

            var terminales = cds
                        .Select(cd => cd.NombreTerminal)
                        .Distinct()
                        .ToList();

            return (agencias, terminales);
        });


        //acá debería buscar tracking "más alto" en datos encomienda?

        //private int trackingActual = 1;


        //acá me está tomando el ultimo q está en la carpeta "Datos" y no en "bin" 

        int ultimoNumero = EncomiendaAlmacen.Encomienda
          .Select(e => e.Tracking.Split('_').Last())
          .Select(n => int.Parse(n))
          .DefaultIfEmpty(1)
          .Max();

        /*
         * public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {
            ImposicionConDestinoACD nuevaImposicion = new ImposicionConDestinoACD
            {
                /*
                Tracking = ObtenerSiguienteTracking().ToString("D8"), // Ejemplo: 00000001
                CUITCliente = cuitCliente,
                CentroDistribucionDestino = centroDistribucionDestino,
                TamañoBulto = tamañoBulto,
                DatosDestinatario = datosDestinatario
               

            };

    string mensaje =
    "Guía impuesta exitosamente.\n\n" +
    $"Tracking: {nuevaImposicion.Tracking}\n" +
    $"CUIT del cliente: {nuevaImposicion.CUITCliente}\n" +
    $"Centro de distribución destino: {nuevaImposicion.CentroDistribucionDestino}\n" +
    $"Tamaño del bulto: {nuevaImposicion.TamañoBulto}\n" +
    $"Datos del destinatario: {nuevaImposicion.DatosDestinatario}";

    MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
*/


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {
            var cdDestino = CentroDeDistribucionAlmacen.CentroDeDistribucion
                    .First(cd => cd.NombreTerminal == centroDistribucionDestino)
                    .CodigoCD;

            EncomiendaEntidad NuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = cdDestino + "_" + (ultimoNumero++).ToString(),
                CUITCliente = cuitCliente,
                CodCentroDistribucionDestino = cdDestino,
                TipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamañoBulto),
                DireccionDestinatario = null, //queda en null pq solo se usa cuando es a domicilio
                Estado = EstadoEncomiendaEnum.Admitida, //imposicion en CD = Se admite directamente ahí
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, //no está entregada aún
                //cómo lleno esto? no sabemos en qué CD estoy parado "ahora" , tendría sentido un menú? o sumar un campo de en este caso "CD ACTUAL"?
                CodCDActual = "CD01",
                CodLocalidadOrigen = "CABA",
                CodCentroDistribucionOrigen = "CD01", //CABA
                //hoy DatosDestinatarioText tiene nombre, apellido y dni todo junto :((( así q lo pongo acá repetido:
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                AgenciaOrigen = null, //impuesto en CD
                AgenciaDestino = null, //impuesto en CD

                DatosRetiroADomicilio = null, //Admitido en CD. 

                ParadasRuta = new List<int>(), //vacio pq todavía no se ruteo ??

                EncomiendaFactura = null //no se factura aún

            };

            EncomiendaAlmacen.Encomienda.Add(NuevaEncomienda);


            string mensaje =
            "Guía impuesta exitosamente.\n\n" +
            $"Tracking: {NuevaEncomienda.Tracking}\n" +
            $"CUIT del cliente: {NuevaEncomienda.CUITCliente}\n" +
            $"Centro de distribución destino: {NuevaEncomienda.CodCentroDistribucionDestino}\n" +
            $"Tamaño del bulto: {NuevaEncomienda.TipoBulto}\n" +
            $"Datos del destinatario: {datosDestinatario}";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionDomicilioParticular(
        string cuitCliente,
        string direccionParticular,
        string tamanoBulto,
        string datosDestinatario,
        string localidad)
        {
            var codCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;
            var codLocalidadOrigen = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoLocalidad;
            var codCentroDistribucionOrigen = CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD;

            //lo sumé acá: pero querría hacerlo como se toma CD desde el menú
            var codLocalidadDestino = LocalidadAlmacen.Localidad
                .Where(l => l.Nombre == localidad)
                .Select(l => l.CodigoLocalidad)
                .FirstOrDefault();

            var codCentroDistribucionDestino = ObtenerCodigoCDPrimerEncontrado(codLocalidadDestino);

            // Parse del tamaño de bulto (compatible con C# 7.3)
            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            // Instancio la encomienda
            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = "DOM_" + (ultimoNumero++).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, // aún no entregada

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

                //ejemplo cualquiera, en este caso la parada es retiro y 5 Grutas ??, pero debería generarse la ruta real, quizas desde ObtenerRuta
                ParadasRuta = new List<int> { 1, 5 },

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                };


            nuevaEncomienda.HistorialCambios.Add(new Historial
            {
                Tracking = nuevaEncomienda.Tracking,
                FechaPrevia = DateTime.Now,
                UbicacionPrevia = codCDActual,
                FleteroAsignado = 0,
                NumeroHDRUM = 0,
                NumeroHDRMD = 0,
                EstadoPrevio = EstadoEncomiendaEnum.Admitida
            });

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


        //Ejemplo de cómo estaba antes: 
        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            ImposicionAgencia nuevaImposicion = new ImposicionAgencia
            {
                Tracking = "CD01AG01_" + (ultimoNumero++).ToString(),
                CUIT = cuitCliente,
                Agencia = agenciaDestino,
                TamanoBulto = tamanoBulto,
                DatosDestinatario = datosDestinatario
            };

            string mensaje =
            "Guía impuesta exitosamente.\n\n" +
            $"Tracking: {nuevaImposicion.Tracking}\n" +
            $"CUIT del cliente: {nuevaImposicion.CUIT}\n" +
            $"Agencia de destino: {nuevaImposicion.Agencia}\n" +
            $"Tamaño del bulto: {nuevaImposicion.TamanoBulto}\n" +
            $"Datos del destinatario: {nuevaImposicion.DatosDestinatario}";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Debería tener alguna logica que matchee direccion particular con CD más cercano?
        private string ObtenerCodigoCDPrimerEncontrado(string codigoLocalidad)
        {
            return CentroDeDistribucionAlmacen.CentroDeDistribucion
                       .First(cd => cd.CodigoLocalidad == codigoLocalidad)
                       .CodigoCD;
        }

        private List<int> ObtenerParadasRutaBasica(string codCDOrigen, string codCDDestino)
        {
            // Construyo un mapa simple CodigoCD -> CodigoParada (índice + 1)
            var mapa = CentroDeDistribucionAlmacen.CentroDeDistribucion
                        .Select((cd, idx) => new { cd.CodigoCD, CodigoParada = idx + 1 })
                        .ToDictionary(x => x.CodigoCD, x => x.CodigoParada);

            int paradaOrigen = mapa[codCDOrigen];
            int paradaDestino = mapa[codCDDestino];

            // Ruta mínima: primera parada (origen) y última (destino)
            if (paradaOrigen == paradaDestino)
                return new List<int> { paradaOrigen };

            return new List<int> { paradaOrigen, paradaDestino };
        }

       
    }
}


