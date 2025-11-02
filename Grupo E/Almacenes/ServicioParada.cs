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
        //ejemplo"Retiro"
        public int CodigoParada { get; set; }
        //"01"
        public DateTime FechaYHoraLlega { get; set; }
        //jueves 18hs
        public DateTime FechaYHoraSale { get; set; }
        //viernes 21hs


        //duda acá: no debería ser indendpendiente? mientras no esté asignada van a estar en null? 
        public List<int> HDRDistribucionMD { get; set; } = new List<int>();

        public List<int> ABajar { get; set; } = new List<int>();
        public List<int> ASubir { get; set; } = new List<int>();
    }
}
