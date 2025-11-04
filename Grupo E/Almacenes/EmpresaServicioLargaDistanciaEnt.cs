using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    internal class EmpresaServicioLargaDistanciaEnt
    {
        public string CuitEmpresaOmnibus { get; set; }
        public string RazonSocial { get; set; }
        public List<Arrendamiento> Arrendamientos { get; set; } = new List<Arrendamiento>();
    }
}
