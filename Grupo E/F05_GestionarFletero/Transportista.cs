using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F05_GestionarFletero
{
    public class Transportista
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public List<HDR> HojasDeRuta { get; set; }

        public Transportista()
        {
            HojasDeRuta = new List<HDR>();
        }
    }
}
