using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.EstadoCuentasCorrientes
{
    public partial class FormEstadoCuentasCorrientes : Form
    {
        public FormEstadoCuentasCorrientes()
        {
            InitializeComponent();
        }

        private void FormEstadoCuentasCorrientes_Load(object sender, EventArgs e)
        {
            // Código a modificar aquí
        }

        private bool ValidarFechas()
        {
            // Asumimos que los controles son dtpFechaDesde y dtpFechaHasta
            if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
            {
                MessageBox.Show("La 'Fecha desde' no puede ser posterior a la 'Fecha hasta'.", "Error de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Focus(); // Opcional: enfoca el control para que el usuario sepa dónde corregir
                return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // PRUEBA DE VALIDACIÓN 1: Rango de Fechas Lógico
            if (!ValidarFechas())
            {
                return; // Si la fecha es inválida, salimos y no hacemos la búsqueda.
            }

            // Si la validación es exitosa, el código de búsqueda iría aquí (aún no implementado).
            MessageBox.Show("¡Validación de fechas exitosa! La búsqueda podría continuar ahora.", "Validación OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Código a modificar aquí
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Código a modificar aquí
        }
    }
}
