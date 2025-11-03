using Grupo_E.Almacenes;
using Grupo_E.ImposicionEnCallCenter;
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
                            !string.IsNullOrEmpty(a.CodigoAgencia) ? a.CodigoAgencia :
                            a.CodigoAgencia) 
                        .ToList();

            var terminales = cds
                        .Select(cd => string.IsNullOrEmpty(cd.CodigoCD) ? cd.NombreTerminal : cd.CodigoCD)
                        .ToList();

            return (agencias, terminales);
        });


        private int trackingActual = 1;

        private int ObtenerSiguienteTracking()
        {
            return trackingActual++;
        }
        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {
            ImposicionConDestinoACD nuevaImposicion = new ImposicionConDestinoACD
            {
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

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario)
        {
            ImposicionDomicilioParticular nuevaImposicion = new ImposicionDomicilioParticular
            {
                Tracking = ObtenerSiguienteTracking().ToString("D8"),
                CUIT = cuitCliente,
                DireccionParticular = direccionParticular,
                TamanoBulto = tamanoBulto,
                DatosDestinatario = datosDestinatario
            };
            string mensaje =
             "Guía impuesta exitosamente.\n\n" +
             $"Tracking: {nuevaImposicion.Tracking}\n" +
             $"CUIT del cliente: {nuevaImposicion.CUIT}\n" +
             $"Dirección particular de destino: {nuevaImposicion.DireccionParticular}\n" +
             $"Tamaño del bulto: {nuevaImposicion.TamanoBulto}\n" +
             $"Datos del destinatario: {nuevaImposicion.DatosDestinatario}";

            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            ImposicionAgencia nuevaImposicion = new ImposicionAgencia
            {
                Tracking = ObtenerSiguienteTracking().ToString("D8"),
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
