using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public class HDRDistribucionUMEntidad
    {
        public int NumeroHDRUM { get; set; }
        public TipoHDREnum Tipo { get; set; }
        public int DniFleteroAsignado { get; set; }
        public bool Cumplida { get; set; }
        public bool Rendida { get; set; }
        public List<string> Encomiendas { get; set; }

        public void ActualizarEstado(bool cumplida)
        {
            if (Cumplida == cumplida)
                return;

            Cumplida = cumplida;

            foreach (var tracking in Encomiendas)
            {
                var encomienda = EncomiendaAlmacen.Encomienda
                    .FirstOrDefault(e => e.Tracking == tracking);

                //var estadoAnterior = encomienda.Estado;

                if (Tipo == TipoHDREnum.Entrega)
                {
                    encomienda.Estado = cumplida
                        ? EstadoEncomiendaEnum.Entregada
                        : EstadoEncomiendaEnum.NoEntregada; // devuelve al remitente??? O sumo estado devolucion?? cómo se qúé tiene q ir de nuevo al CD origen?
                }

                else if (Tipo == TipoHDREnum.Retiro)
                {
                    encomienda.Estado = cumplida
                        ? EstadoEncomiendaEnum.Admitida
                        : EstadoEncomiendaEnum.Cancelada; // cancela guía siempre que no se retira??
                }

                // Si el estado cambió realmente, registramos en historial
                /*
                if (estadoAnterior != encomienda.Estado)
                {
                    encomienda.HistorialCambios.Add(new Historial
                    {
                        FechaPrevia = DateTime.Now,
                        UbicacionPrevia = encomienda.CodCDActual,
                        EstadoPrevio = estadoAnterior,
                        FleteroAsignado = DniFleteroAsignado,
                        NumeroHDRUM = NumeroHDRUM
                    });
                }
                */
            }
        }

    }
}
