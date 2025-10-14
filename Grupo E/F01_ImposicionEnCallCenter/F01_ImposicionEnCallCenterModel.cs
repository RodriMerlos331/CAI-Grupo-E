//using Grupo_E.F03_ImposicionEnCD;
//using Grupo_E.GestionarFletero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F01_ImposicionEnCallCenter
{
    public class F01_ImposicionEnCallCenterModel
    {
        //Tiene sentido las localidades disponibles cargarlas acá? O se podrían hacer directamente desde la clase ? 
        public string[] Localidad = new string[] { "CABA", "GBA", "Córdoba" };
        //Localidades a sumar: , "Tucumán","Corrientes","Neuquén","Viedma"

        public string[] TamanoBulto = new string[] { "S", "M", "L", "XL" };

        public readonly Dictionary<string, string> clientes = new Dictionary<string, string>
        {
            { "30-12345678-01", "Sanitarios S.A" },
            { "30-87654321-09", "Gomeria Altamirano" },
            { "30-11223344-05", "Huggies" }
        };

        //COPILOT SUGIRIÓ ESTA FORMA DE HACERLO, PREGUNTAR SI ESTÁ BIEN:
        public Dictionary<string, (List<string> AgenciasCC, List<string> TerminalesCC)> Localidades =
        new Dictionary<string, (List<string>, List<string>)>
        {
            { "CABA", (new List<string> { "Alto Palermo", "DOT", "Abasto" }, new List<string> { "Retiro", "Dellepiane", "Liniers" }) },
            { "GBA", (new List<string> { "Kiosco", "Shopping", "Local" }, new List<string> { "La Plata", "Pacheco", "Morón" }) },
            { "Córdoba", (new List<string> { "Cerrito", "Montaña", "Arroyo" }, new List<string> { "Villa Carlos Paz", "La Falda", "Río Cuarto" }) }
        };


        /*
         * public class ImposicionConDestinoCC
    {
        string CUITCliente { get; set; }
        string CentroDistribucionDestino { get; set; }

        string TamañoBulto { get; set; }

        string DatosDestinatario { get; set; } 
    }
         */
        private int trackingActual = 1;

        private int ObtenerSiguienteTracking()
        {
            return trackingActual++;
        }
        public void ImposicionConDestinoCC(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {
            ImposicionConDestinoCC nuevaImposicion = new ImposicionConDestinoCC
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

        public void ImposicionDomicilioParticularCC(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario)
        {
            ImposicionDomicilioParticularCC nuevaImposicion = new ImposicionDomicilioParticularCC
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

        public void ImposicionAgenciaCC(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            ImposicionAgenciaCC nuevaImposicion = new ImposicionAgenciaCC
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
