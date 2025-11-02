using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class ServicioParada
    {
        public string CodigoCD { get; set; }
        public int CodigoParada { get; set; }
        public DateTime FechaYHoraLlega { get; set; }
        public DateTime FechaYHoraSale { get; set; }
        public List<int> HDRDistribucionMD { get; set; } = new List<int>();
        public List<int> ABajar { get; set; } = new List<int>();
        public List<int> ASubir { get; set; } = new List<int>();
    }
}
