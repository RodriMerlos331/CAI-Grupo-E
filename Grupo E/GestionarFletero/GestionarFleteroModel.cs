using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    internal class GestionarFleteroModel
    {
        private List<Fletero> fleteros = new List<Fletero>();
        private List<HDR> hdrs = new List<HDR>();


        public GestionarFleteroModel()
        {
            // 🔹 Datos de prueba

            fleteros.Add(new Fletero { Dni = 12345678 });
            fleteros.Add(new Fletero { Dni = 87654321 });

            hdrs.Add(new HDR
            {
                IdHDR = 1001,
                Tipo = "Entrega",
                DniFleteroAsignado = 12345678,
                Guias = new List<Guia>
                {
                    new Guia { NroHDR = 1001, Tracking = 5001 },
                    new Guia { NroHDR = 1001, Tracking = 5002 }
                }
            });

            hdrs.Add(new HDR
            {
                IdHDR = 1002,
                Tipo = "Retiro",
                DniFleteroAsignado = 12345678,
                Guias = new List<Guia>
                {
                    new Guia { NroHDR = 1002, Tracking = 6001 },
                    new Guia { NroHDR = 1002, Tracking = 6002 }
                }
            });

            hdrs.Add(new HDR
            {
                IdHDR = 1003,
                Tipo = "Entrega",
                DniFleteroAsignado = 87654321,
                Guias = new List<Guia>
                {
                    new Guia { NroHDR = 1003, Tracking = 7001 }
                }
            });
        }

        // 🔹 Buscar fletero por DNI
        internal List<HDR> ObtenerHDRAsignadas(int dni)
        {
            var fletero = fleteros.FirstOrDefault(f => f.Dni == dni);

            if (fletero == null)
            {
                MessageBox.Show("No existe un fletero con ese DNI.");
                return new List<HDR>();
            }

            var hdrAsignadas = hdrs.Where(h => h.DniFleteroAsignado == dni).ToList();

            if (hdrAsignadas.Count == 0)
            {
                MessageBox.Show("El fletero no tiene HDR asignadas.");
            }

            return hdrAsignadas;
        }

        internal void ActualizarCumplimientoHDR(int idHDR, bool cumplida)
        {
            // Recorro todas las HDR
            foreach (var hoja in hdrs)
            {
                // Si encuentro la que tiene ese número, la actualizo
                if (hoja.IdHDR == idHDR)
                {
                    hoja.Cumplida = cumplida;
                    break; // ya está, salgo del bucle
                }
            }
        }

        internal List<HDR> ObtenerHDRPorFletero(int dniFletero)
        {
            // Devuelvo solo las HDR asignadas a ese DNI
            return hdrs.Where(h => h.DniFleteroAsignado == dniFletero).ToList();
        }




    }
}