using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class DatosGeneralesEntidad
    {
        public string Dato { get; set; }
        public List<TipoDato> TipoDatos { get; set; } = new List<TipoDato>();
    }
}
