using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.GestionarFletero
{
    internal class HDR
    {
        public int IdHDR { get; set; }
        public string Tipo { get; set; } 
        public bool Cumplida { get; set; } = false;

        public int DniFleteroAsignado { get; set; }
        public List<Guia> GuiasHDR { get; set; } = new List<Guia>();


    }
}
