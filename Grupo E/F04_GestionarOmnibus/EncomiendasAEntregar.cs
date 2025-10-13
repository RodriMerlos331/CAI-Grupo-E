using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F04_GestionarOmnibus
{
    internal class EncomiendasAEntregar //CLASE de las guias que el chofer se lleva   validar. esto  pasa a la 
                                        // encomienda a la lista de "EncomiendasEnTransito" cuando le doy aceptar
    {
        public string  IdHdr { get; set; }
        public string  Tracking { get; set; }
        public string TipoDeBulto { get; set; }
    }
}
