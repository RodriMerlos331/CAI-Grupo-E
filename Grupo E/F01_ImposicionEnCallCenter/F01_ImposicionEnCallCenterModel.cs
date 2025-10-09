using Grupo_E.GestionarFletero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.ImposicionEnCallCenter
{
    internal class F01_ImposicionEnCallCenterModel
    {
        private List<Cliente> clientes = new List<Cliente>();

        public F01_ImposicionEnCallCenterModel()
        {
        //  Datos de prueba

            clientes.Add(new Cliente { Cuit = 12345678910 });
            clientes.Add(new Cliente { Cuit = 01234567890 });
        }
        //  Validar existencia del cliente
        internal Cliente ExisteClientePorCUIT(long cuit)
        {
            var cliente = clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
            {
                MessageBox.Show("No existe un cliente con ese CUIT.");
                return null;
            }

            return cliente;
        }
    }
}
