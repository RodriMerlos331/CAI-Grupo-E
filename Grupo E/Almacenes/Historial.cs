using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public class Historial
    {
     
        public string Tracking { get; set; }
        public DateTime FechaPrevia { get; set; }

        public string UbicacionPrevia { get; set; }

        public int FleteroAsignado { get; set; }

        public int NumeroHDRUM { get; set; }

        public int NumeroHDRMD { get; set; }   

        public EstadoEncomiendaEnum EstadoPrevio { get; set; }
    }
}
