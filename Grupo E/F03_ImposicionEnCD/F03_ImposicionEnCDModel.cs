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
                            a.NombreAgencia )
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
          .DefaultIfEmpty(0)
          .Max();

        public void ObtenerSiguienteTracking()
        {
            ultimoNumero++;
        }

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
                Tracking = cdDestino + "_" + (ultimoNumero + 1).ToString(),
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

                DatosFacturacion = null //no se factura aún

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

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario)
        {
            EncomiendaEntidad NuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = "DOM_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = DateTime.Now,
                FechaEntrega = null, //no está entregada aún

                TipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto),
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),
                //cómo lleno esto? no sabemos en qué CD estoy parado "ahora" , tendría sentido un menú? o sumar un campo de en este caso "CD ACTUAL"?
                CodCDActual = "CD01",
                CodLocalidadOrigen = "CABA",
                CodCentroDistribucionOrigen = "CD01", //Capital

                //cómo macheo CD destino con la dirección particular ingresada?? con localidad actual ?
                DireccionDestinatario = direccionParticular,


                //no:
                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = null,
                ParadasRuta = null,

                DatosFacturacion = null,

            };
            string mensaje =
             "Guía impuesta exitosamente.\n\n" +
             $"Tracking: {NuevaEncomienda.Tracking}\n" +
             $"CUIT del cliente: {NuevaEncomienda.CUITCliente}\n" +
             $"Dirección particular de destino: {NuevaEncomienda.DireccionDestinatario}\n" +
             $"Tamaño del bulto: {NuevaEncomienda.TipoBulto}\n" +
             $"Datos del destinatario: {datosDestinatario}";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Ejemplo de cómo estaba antes: 
        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            ImposicionAgencia nuevaImposicion = new ImposicionAgencia
            {
                Tracking = "CD01AG01_" + (ultimoNumero + 1).ToString(),
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
    }
}
