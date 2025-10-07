using System;

namespace Grupo_E.ConsultarEstadoEncomienda
{
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
}

