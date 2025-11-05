using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F04_GestionarOmnibus
{
    internal class EncomiendasABajar // CLASE de las guias que el chofer me trae y tengo que "registar" valido y paso esta 
                                           // encomienda a la lista de "EncomiendasRecepcionadasEnCDOrigen"
    {
        public string  IdHdr { get; set; }
        public string  Tracking {  get; set; }
        public string  TipoDeBulto { get; set; }     
    }
}
