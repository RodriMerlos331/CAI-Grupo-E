using Grupo_E.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal class EstadoDeEncomiendaModel
    {
        // Clave = tracking string
        public readonly Dictionary<string, EstadoDeEncomienda> data;
        private static string Key(string s) => (s ?? "").Trim().ToUpperInvariant();

        public EstadoDeEncomiendaModel()
        {
            data = new Dictionary<string, EstadoDeEncomienda>();

            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();


            foreach (var enc in encomiendas)
            {

                if (string.IsNullOrWhiteSpace(enc.Tracking))
                    continue;

                var key = Key(enc.Tracking);


                // Fecha del último cambio
                var fechaUlt =
                    enc.HistorialCambios?
                       .Where(h => h.Tracking == enc.Tracking)
                       .OrderByDescending(h => h.FechaPrevia)
                       .Select(h => (DateTime?)h.FechaPrevia)
                       .FirstOrDefault()
                    ?? (enc.FechaEntrega > DateTime.MinValue ? enc.FechaEntrega
                       : (enc.FechaAdmision > DateTime.MinValue ? enc.FechaAdmision : enc.FechaImposicion));


                // Origen y destino 
                var origen = enc.CodLocalidadOrigen;


                var destino =
                    (CentroDeDistribucionAlmacen.CentroDeDistribucion ?? new List<CentroDeDistribucionEntidad>())
                    .Where(cd => cd.CodigoCD == enc.CodCentroDistribucionDestino)
                    .Select(cd => cd.CodigoLocalidad)
                    .FirstOrDefault() ?? enc.CodCentroDistribucionDestino;


                // Historial → Movimiento 
                var movimientos =
                    (enc.HistorialCambios ?? new List<Historial>())
                    .Where(h => h.Tracking == enc.Tracking)
                    .OrderByDescending(h => h.FechaPrevia)
                    .Select(h => new Movimiento
                    {
                        Estado = (EstadoEnvio)Enum.Parse(typeof(EstadoEnvio), h.EstadoPrevio.ToString(), true),
                        FechaHora = h.FechaPrevia,
                        UbicacionAnterior = h.UbicacionPrevia,
                        TransportistaAsignado = h.FleteroAsignado,
                        IdHojaRuta = (h.NumeroHDRMD > 0
                                      ? h.NumeroHDRMD.ToString()
                                      : (h.NumeroHDRUM > 0 ? h.NumeroHDRUM.ToString() : "-"))
                    })
                    .ToList();



                var dto = new EstadoDeEncomienda
                {
                    TrackingId = enc.Tracking,
                    EstadoActual = (EstadoEnvio)Enum.Parse(typeof(EstadoEnvio), enc.Estado.ToString(), true),
                    FechaHoraUltimoCambio = fechaUlt,
                    LocalidadActual = enc.CodCDActual,
                    Origen = origen,
                    Destino = destino,
                    TipoDeBulto = enc.TipoBulto.ToString(),
                    Historial = movimientos
                };
                Console.WriteLine(dto);

                if (!data.ContainsKey(key)) data.Add(key, dto);
            }
        }

        public bool TryGet(string trackingId, out EstadoDeEncomienda model) 
        { 
            return data.TryGetValue(trackingId, out model); 
        }
    }
}




