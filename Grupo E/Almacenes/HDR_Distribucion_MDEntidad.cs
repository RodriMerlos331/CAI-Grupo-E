using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class HDR_Distribucion_MDEntidad
    {
        public int NumeroHDRMD { get; set; }
        public EstadoHDREnum estadoHDR { get; set; }
        public List<int> Encomiendas { get; set; } = new List<int>();
        public int CodigoParada { get; set; }
        public string Destino { get; set; }
    }
}
