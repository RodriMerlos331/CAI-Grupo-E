using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Grupo_E.Almacenes;

namespace Grupo_E.RetirarEnCD
{
    internal class F07_RetirarEnCDModelo
    {
        List<EncomiendaEntidad> encomiendas;

        public F07_RetirarEnCDModelo()
        {
            encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();
        }

        internal bool ChequearEncomiendaCD(string tracking, string nombre, string apellido, int dni)
        {
            var encontrada = encomiendas.FirstOrDefault(e => e.Tracking == tracking);

            if (encontrada == null)
            {
                MessageBox.Show("No se encontró una encomienda con ese número de tracking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (encontrada.Estado != EstadoEncomiendaEnum.PendienteRetiroCD)
            {
                MessageBox.Show("La encomienda no está disponible para retiro en CD.", "Estado incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (encontrada.DNIDestinatario != dni ||
                !string.Equals(encontrada.NombreDestinatario, nombre, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(encontrada.ApellidoDestinatario, apellido, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Los datos del destinatario no coinciden con la encomienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            encontrada.Estado = EstadoEncomiendaEnum.Entregada;

            return true;
        }

        internal bool ExisteEncomiendaPorTrackingCD(string tracking)
        {
            return encomiendas.Any(e => e.Tracking == tracking);
        }

        internal bool ExisteEncomiendaEnCDActual(string tracking)
        {
            var codCDActual = CentroDeDistribucionAlmacen.CentroDistribucionActual;

          

            return encomiendas.Any(e =>
                e.Tracking == tracking &&
                e.CodCentroDistribucionDestino == CentroDeDistribucionAlmacen.CentroDistribucionActual.CodigoCD &&
                e.Estado == EstadoEncomiendaEnum.PendienteRetiroCD
            );
        }
    }
}