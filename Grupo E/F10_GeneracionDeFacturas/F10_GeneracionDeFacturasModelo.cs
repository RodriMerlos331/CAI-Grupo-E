using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F10_GeneracionDeFacturas
{
    internal class F10_GeneracionDeFacturasModelo
    {
        internal void ListarEncomiendas(int CUIT)
        {
            if (CUIT <10_000_000)
            {
                MessageBox.Show("Ingrese un numero de CUIT validio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
