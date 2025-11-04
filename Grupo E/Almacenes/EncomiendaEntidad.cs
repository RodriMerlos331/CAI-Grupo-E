using System;
using System.Collections.Generic;

namespace Grupo_E.Almacenes
{
    internal class EncomiendaEntidad
    {
        public string Tracking { get; set; }
        public string CodLocalidadOrigen { get; set; }
        public string CodCentroDistribucionOrigen { get; set; }
        public string CodCentroDistribucionDestino { get; set; }
        
        public EstadoEncomiendaEnum Estado { get; set; }
        public TipoBultoEnum TipoBulto { get; set; }
        public string CUITCliente { get; set; }

        public int DNIDestinatario { get; set; }

        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public string DireccionDestinatario { get; set; }         //direccion solo importa cuando es a domicilio
        public string AgenciaOrigen { get; set; }
        public string AgenciaDestino { get; set; }
        public string DatosRetiroADomicilio { get; set; }
        public string CodCDActual { get; set; }
        public List<int> ParadasRuta { get; set; }

        //esto no podría ir directamente en historial??
        public DateTime FechaImposicion { get; set; }
        public DateTime? FechaAdmision { get; set; }
        public DateTime? FechaEntrega { get; set; }

       

       //está ok así esto?
        public EncomiendaFactura DatosFacturacion { get; set; }

        public List <Historial> HistorialCambios { get; set; } = new List<Historial>();


    }
}
