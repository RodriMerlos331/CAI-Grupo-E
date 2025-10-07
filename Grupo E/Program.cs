using System;
using System.Collections.Generic;
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
            //Application.Run(new Grupo_E.RendicionHDRLargaDistancia.Form1());
            //Application.Run(new Grupo_E.ConsultarEstadoEncomienda.EstadoDeEncomiedaForm());
            //Application.Run(new Grupo_E.GeneracionDeFacturas.GeneracionDeFacturas());
            //Application.Run(new Grupo_E.ImposicionEnAgencia.ImposicionEnAgencia());
            //Application.Run(new Grupo_E.ConsultarEstadoEncomienda.EstadoDeEncomiedaForm());
            Application.Run(new Grupo_E.GestionarFletero.GestionarFleteroForm());


        }
    }
}
