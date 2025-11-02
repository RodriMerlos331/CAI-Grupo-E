using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public class FleteroEntidad
    {
        public int DniFletero { get; set; }
        public string CuitEmpresaTransportista { get; set; }

        //Referencio a entidad CD:
        public List<string> CodCDAsociados { get; set; }

    }
}
