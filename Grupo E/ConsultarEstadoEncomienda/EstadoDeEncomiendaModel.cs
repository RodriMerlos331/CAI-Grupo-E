using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal enum EstadoEnvio
    {
        EsperandoRetiro,
        Admitido,
        EnCaminoACD,           // centro de distribución
        EnCentroDistribucion,
        EnCaminoAAgenciaDestino,
        EnCaminoADestino,
        Entregado,
        Cancelado
    }

    internal class Movimiento
    {
        public EstadoEnvio Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public string UbicacionAnterior { get; set; }
        public string TransportistaAsignado { get; set; }
        public string IdHojaRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string TipoDeBulto { get; set; }
      
    }

    internal class EstadoDeEncomiendaModel
    {
        public int TrackingId { get; set; }
        public EstadoEnvio EstadoActual { get; set; }
        public DateTime FechaHoraUltimoCambio { get; set; }
        public string LocalidadActual { get; set; }
        public List<Movimiento> Historial { get; set; } = new List<Movimiento>();
    }
}

