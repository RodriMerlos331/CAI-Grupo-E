using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Grupo_E.GestionarFletero
{
    internal class F05_GestionarFleteroModel
    {
        public List<Fletero> fleteros = new List<Fletero>();
        public List<HDR> hdrs = new List<HDR>();
        public List<Guia> guias = new List<Guia>();
        public List<Guia> guiasAAdmitir = new List<Guia>();
        public List<Guia> guiasADevolver = new List<Guia>();
        private List<HDR> hdrsFletero = new List<HDR>();
        public List<HDR> NuevasHDRRetiro = new List<HDR>();
        public List<HDR> NuevasHDREntrega = new List<HDR>();
        public List<Guia> NuevasGuiasRetiro = new List<Guia>();
        public List<Guia> NuevasGuiasEntrega = new List<Guia>();

        public void CargarFleteros()
        {
            fleteros.Add(new Fletero { Dni = 12345678 });
            fleteros.Add(new Fletero { Dni = 23456789 });
            fleteros.Add(new Fletero { Dni = 34567890 });
            fleteros.Add(new Fletero { Dni = 45678901 });
            fleteros.Add(new Fletero { Dni = 56789012 });
            fleteros.Add(new Fletero { Dni = 67890123 });
        }
        public void CargarHDR()
        {
            hdrs = new List<HDR>
            {
                new HDR
                {
                    IdHDR = 1,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 12345678,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 1, Tracking = 1001, Estado = "No retirada" },
                        new Guia { NroHDRAsignada = 1, Tracking = 1002, Estado = "No retirada" },
                    }
                },
                new HDR
                {
                    IdHDR = 2,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 23456789,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 2, Tracking = 1003, Estado = "A entregar" },
                        new Guia { NroHDRAsignada = 2, Tracking = 1004, Estado = "A entregar" },
                    }
                },
                new HDR
                {
                    IdHDR = 3,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 34567890,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 3, Tracking = 1005, Estado = "No retirada" },
                        new Guia { NroHDRAsignada = 3, Tracking = 1006, Estado = "No retirada" },
                    }
                },
                new HDR
                {
                    IdHDR = 4,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 45678901,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 4, Tracking = 1007, Estado = "A entregar" },
                        new Guia { NroHDRAsignada = 4, Tracking = 1008, Estado = "A entregar" },
                    }
                },
                new HDR
                {
                    IdHDR = 5,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 56789012,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 5, Tracking = 1009, Estado = "No retirada" },
                        new Guia { NroHDRAsignada = 5, Tracking = 1010, Estado = "No retirada" },
                    }
                },
                new HDR
                {
                    IdHDR = 6,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 67890123,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 6, Tracking = 1011, Estado = "A entregar" },
                        new Guia { NroHDRAsignada = 6, Tracking = 1012, Estado = "A entregar" },
                    }
                },
                new HDR
                {
                    IdHDR = 7,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 12345678,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 7, Tracking = 1013, Estado = "No retirada" },
                        new Guia { NroHDRAsignada = 7, Tracking = 1014, Estado = "No retirada" },
                    }
                },
                new HDR
                {
                    IdHDR = 8,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 23456789,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 8, Tracking = 1015, Estado = "A entregar" },
                        new Guia { NroHDRAsignada = 8, Tracking = 1016, Estado = "A entregar" },
                    }
                },
                new HDR
                {
                    IdHDR = 9,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 34567890,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 9, Tracking = 1017, Estado = "No retirada" },
                        new Guia { NroHDRAsignada = 9, Tracking = 1018, Estado = "No retirada" },
                    }
                },
                new HDR
                {
                    IdHDR = 10,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 45678901,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>
                    {
                        new Guia { NroHDRAsignada = 10, Tracking = 1019, Estado = "A entregar" },
                        new Guia { NroHDRAsignada = 10, Tracking = 1020, Estado = "A entregar" },
                    }
                }
            };

            guias = new List<Guia>();
            foreach (var hdr in hdrs)
                guias.AddRange(hdr.GuiasHDR);
        }

        public List<HDR> ObtenerHDRAsignadas(int dniFletero)
        {

            var hdrsFiltradas = BuscarHDRFletero(dniFletero);


            if (hdrsFiltradas == null || hdrsFiltradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron HDR asignadas para el fletero con DNI " + dniFletero,
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return null;
            }

            MessageBox.Show(
                "Se encontraron " + hdrsFiltradas.Count + " HDR asignadas al fletero con DNI " + dniFletero + " que deben ser rendidas. Además, se generaron las nuevas ruta a asignar.",
                "Rendición",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            foreach (var hdr in hdrsFiltradas)
            {
                if (hdr.Tipo == "Retiro")
                    guiasAAdmitir.AddRange(hdr.GuiasHDR);
            }



            return hdrsFiltradas;


        }

        public void ProcesarHDRsActualizadas()
        {
            
            guiasAAdmitir.Clear();
            guiasADevolver.Clear();

            foreach (var hdr in hdrsFletero)
            {
                if (hdr.Tipo == "Retiro" && hdr.Cumplida)
                {
                    guiasAAdmitir.AddRange(hdr.GuiasHDR);
                }


                if (hdr.Tipo == "Entrega" && !hdr.Cumplida)
                {
                    guiasADevolver.AddRange(hdr.GuiasHDR);
                }
            }
        }

        public List<HDR> BuscarHDRFletero(int dniFletero)
        {
            hdrsFletero = hdrs
                .Where(h => h.DniFleteroAsignado == dniFletero)
                .ToList();

            return hdrsFletero;


        }

        public bool FleteroExiste(int dniFletero)
        {
            return fleteros.Any(f => f.Dni == dniFletero);
        }


        public void GenerarNuevasHDRyGuias()
        {
            NuevasHDRRetiro.Clear();
            NuevasHDREntrega.Clear();
            NuevasGuiasRetiro.Clear();
            NuevasGuiasEntrega.Clear();

            int siguienteIdHDR = hdrs.Count + 1;
            int siguienteTracking = guias.Count + 2001; 

            for (int i = 0; i < 3; i++)
            {

                var hdrRetiro = new HDR
                {
                    IdHDR = siguienteIdHDR++,
                    Tipo = "Retiro",
                    DniFleteroAsignado = 12345678, 
                    Cumplida = false,
                    GuiasHDR = new List<Guia>()
                };

                for (int j = 0; j < 2; j++)
                {
                    var guia = new Guia
                    {
                        NroHDRAsignada = hdrRetiro.IdHDR,
                        Tracking = siguienteTracking++
                    };
                    hdrRetiro.GuiasHDR.Add(guia);
                    NuevasGuiasRetiro.Add(guia);
                }

                NuevasHDRRetiro.Add(hdrRetiro);

                var hdrEntrega = new HDR
                {
                    IdHDR = siguienteIdHDR++,
                    Tipo = "Entrega",
                    DniFleteroAsignado = 12345678,
                    Cumplida = false,
                    GuiasHDR = new List<Guia>()
                };

                for (int j = 0; j < 2; j++)
                {
                    var guia = new Guia
                    {
                        NroHDRAsignada = hdrEntrega.IdHDR,
                        Tracking = siguienteTracking++
                    };
                    hdrEntrega.GuiasHDR.Add(guia);
                    NuevasGuiasEntrega.Add(guia);
                }

                NuevasHDREntrega.Add(hdrEntrega);
            }

            //MessageBox.Show($"Generadas {NuevasHDRRetiro.Count} HDR de Retiro y {NuevasHDREntrega.Count} de Entrega.");
        }

        internal void GuardarCambios()
        {

        }
    }

}