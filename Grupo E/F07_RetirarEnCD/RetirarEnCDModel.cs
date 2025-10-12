using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F07_RetirarEnCD
{
    internal class RetirarEnCDModel
    {
        private List<DatosCliente> EncomiendasDisponibles = new List<DatosCliente>()
        {
            new DatosCliente { NumeroTracking = 100001, Nombre = "Juan", Apellido = "Perez", DNI = 12345678 },
            new DatosCliente { NumeroTracking = 100002, Nombre = "Maria", Apellido = "Gomez", DNI = 87654321 },
            new DatosCliente { NumeroTracking = 111222, Nombre = "Carlos", Apellido = "Lopez", DNI = 20000000 },
            new DatosCliente { NumeroTracking = 333444, Nombre = "Ana", Apellido = "Diaz", DNI = 30000000 },
            new DatosCliente { NumeroTracking = 987654, Nombre = "Lucia", Apellido = "Mendez", DNI = 40000000 },
            new DatosCliente { NumeroTracking = 555666, Nombre = "Pedro", Apellido = "Ramos", DNI = 50000000 },
            new DatosCliente { NumeroTracking = 654321, Nombre = "Sofia", Apellido = "Vazquez", DNI = 60000000 }
        };

        public DatosCliente BuscarEncomiendaPorTracking(int tracking)
        {
            return EncomiendasDisponibles.FirstOrDefault(e => e.NumeroTracking == tracking);
        }
        public void EntregarEncomienda(DatosCliente encomiendaEntregada)
        {
            var encomienda = EncomiendasDisponibles.FirstOrDefault(e => e.NumeroTracking == encomiendaEntregada.NumeroTracking);
            if (encomienda != null)
            {
                EncomiendasDisponibles.Remove(encomienda);
            }
        }
    }

}
