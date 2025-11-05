using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.RetirarEnAgencia
{
    internal class EncomiendaRA
    {
        public string NumeroDeTracking { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        // Constructor sin parámetros

        public EncomiendaRA(string numeroDeTracking, string nombre, string apellido, int dni)
        {
            NumeroDeTracking = numeroDeTracking;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }


    }
}





