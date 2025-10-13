using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia
{
    internal class Fletero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public List<GuiaDeEncomiendas> GuiasAsignadas { get; set; }

    }
}
