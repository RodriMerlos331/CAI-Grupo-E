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
        //ejemplo "Retiro -Mar del Plata"
        public string CuitEmpresaOmnibus { get; set; }
        //ejemplo "20-12345678-9"
        public string Patente { get; set; }
        //AAA001-CD
        public TipoArrendamientoEnum Tipo { get; set; }
        public int CapacidadActual { get; set; }
        //depende de tipo de arrendamiento: ejemplo Hasta 20 cajas tipo XL o equivalentes menores.
        //OJOTa que si no entran encomiendas, prioridad ORDERBY fechaimposicion
        public List<ServicioParada> Paradas { get; set; } = new List<ServicioParada>();
    }
}
