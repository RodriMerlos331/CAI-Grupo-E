using Grupo_E.Almacenes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grupo_E
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipalForm()); // <-- Menú como formulario inicial
           
            
            
           
            EncomiendaAlmacen.Grabar();
            FacturaAlmacen.Grabar();
            HDRDistribucionUMAlmacen.Grabar();
            HDR_Distribucion_MDAlmacen.Grabar();

        }
    }
}
