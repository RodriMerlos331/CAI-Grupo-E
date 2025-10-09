using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal class EstadoDeEncomienda
    {
        public int TrackingId { get; set; }
        public EstadoEnvio EstadoActual { get; set; }
        public DateTime FechaHoraUltimoCambio { get; set; }
        public string LocalidadActual { get; set; }
        public List<Movimiento> Historial { get; set; } = new List<Movimiento>();
    }
}

