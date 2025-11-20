using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class ClienteEntidad
    {
        public string CUIT { get; set; }
        public string Domicilio { get; set; }

        public string RazonSocial { get; set; }
        public decimal AlquilerTerminal { get; set; }
    }
}
