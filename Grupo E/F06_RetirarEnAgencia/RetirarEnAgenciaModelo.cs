using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.RetirarEnAgencia
{
    internal class RetirarEnAgenciaModelo
    {
        internal void chequearEncomienda(EncomiendaRA encomienda)
        {
            List<EncomiendaRA> EncomiendasEnAgencia = new List<EncomiendaRA>
            {
                new EncomiendaRA(12345, "Juan", "Perez", 12345678),
                new EncomiendaRA(67890, "Maria", "Gomez", 87654321),
                new EncomiendaRA(40040, "Martin", "Calvo", 13120375),
                new EncomiendaRA(50050, "Felipe", "Castro", 17837818)
            };
            var encomiendaEncontrada = EncomiendasEnAgencia.FirstOrDefault(e =>
                e.NumeroDeTracking == encomienda.NumeroDeTracking &&
                e.Nombre.Equals(encomienda.Nombre, StringComparison.OrdinalIgnoreCase) &&
                e.Apellido.Equals(encomienda.Apellido, StringComparison.OrdinalIgnoreCase) &&
                e.DNI == encomienda.DNI);

            if (encomiendaEncontrada != null)
            {
                MessageBox.Show("Encomienda encontrada, entregela.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                MessageBox.Show("No se encontró la encomienda o los datos no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal bool ExisteEncomiendaPorTracking(int numeroDeTracking)
        {
            List<EncomiendaRA> EncomiendasEnAgencia = new List<EncomiendaRA>
            {
                new EncomiendaRA(12345, "Juan", "Perez", 12345678),
                new EncomiendaRA(67890, "Maria", "Gomez", 87654321),
                new EncomiendaRA(40040, "Martin", "Calvo", 13120375),
                new EncomiendaRA(50050, "Felipe", "Castro", 17837818)
            };
            return EncomiendasEnAgencia.Any(e => e.NumeroDeTracking == numeroDeTracking);
        }
    }
}
