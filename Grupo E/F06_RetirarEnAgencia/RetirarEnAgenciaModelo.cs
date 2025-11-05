using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo_E.Almacenes; // Asegúrate de importar el namespace correcto

namespace Grupo_E.RetirarEnAgencia
{
    internal class RetirarEnAgenciaModelo
    {
        List<EncomiendaEntidad> encomiendas;

        public RetirarEnAgenciaModelo()
        {
            encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();
        }

        internal bool chequearEncomienda(string tracking, string nombre, string apellido, int dni)
        {
            var encontrada = encomiendas.FirstOrDefault(e => e.Tracking == tracking);

            if (encontrada == null)
            {
                MessageBox.Show("No se encontró una encomienda con ese número de tracking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (encontrada.DNIDestinatario != dni ||
                !string.Equals(encontrada.NombreDestinatario, nombre, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(encontrada.ApellidoDestinatario, apellido, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Los datos del destinatario no coinciden con la encomienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        internal bool ExisteEncomiendaPorTracking(string tracking)
        {
            return encomiendas.Any(e => e.Tracking == tracking);
        }
    }
}













