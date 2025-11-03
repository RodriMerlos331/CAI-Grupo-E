using System;
using System.Collections.Generic;

namespace Grupo_E.Almacenes
{
    internal class EncomiendaEnt
    {
        public string Tracking { get; set; }
        public string CodLocalidadOrigen { get; set; }
        public string CodCentroDistribucionOrigen { get; set; }
        public string CodCentroDistribucionDestino { get; set; }
        //public EstadoGuiaEnum Estado { get; set; }
        public TipoBultoEnum TipoBulto { get; set; }
        public string CUITCliente { get; set; }
        //public TipoEntregaEnum TipoEntrega { get; set; }
        public int DNIDestinatario { get; set; }
        public string DireccionDestinatario { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public string AgenciaOrigen { get; set; }
        public string AgenciaDestino { get; set; }
        public string DatosRetiroADomicilio { get; set; }
        public string CodCDActual { get; set; }
        public List<int> ParadasRuta { get; set; }
        public DateTime FechaImposicion { get; set; }
        public DateTime FechaAdmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool Facturada { get; set; }
       // public EncomiendaFactura DatosFacturacion { get; set; }

        public decimal PrecioCombinacionTamanoOrigenDestino { get; set; }
        public decimal ExtraRetiro { get; set; }
        public decimal ExtraAgencia { get; set; }
        public decimal ExtraEntrega { get; set; }
        public decimal PrecioTotalEncomienda { get; set; }
    }
}
