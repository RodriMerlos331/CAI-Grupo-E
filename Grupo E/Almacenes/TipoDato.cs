using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class TipoDato
    {
        public enum TipoDatoEnum
        {
            CUITTutasa,
            IVAPorcentaje,
            CodigoAutorizacionElectronica
        }

        public TipoDatoEnum Tipo { get; set; }  
        public object Valor { get; set; }      
    }
}
