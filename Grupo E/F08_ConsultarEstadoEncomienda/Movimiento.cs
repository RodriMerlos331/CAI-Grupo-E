using System;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal class Movimiento
    {
        public EstadoEnvio Estado { get; set; }
        public DateTime FechaHora { get; set; }
        public string UbicacionAnterior { get; set; }
        public int TransportistaAsignado { get; set; }
        public string IdHojaRuta { get; set; }
       
    }
}

