using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class OmnibusEntidad
    {
        public string ServicioID { get; set; }
        public string CuitEmpresaOmnibus { get; set; }
        public string Patente { get; set; }
        public List<Arrendamiento> Arrendamientos { get; set; } = new List<Arrendamiento>();
        public int CapacidadActual { get; set; }
        public List<ServicioParada> Paradas { get; set; } = new List<ServicioParada>();
    }
}
