using Grupo_E.Almacenes;
using Grupo_E.ConsultarEstadoEncomienda;
using Grupo_E.EntregarYRecepcionarEncomiendaAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia
{
	internal class EntregaYRecepcionEncomiendaAgenciaModel
	{
        private static string Norm(string s) => (s ?? "").Trim().ToUpperInvariant();

        public Tuple<List<EncomiendaEntidad>, List<EncomiendaEntidad>> ObtenerListasParaForm(int dni)
        {
            // Validar fletero
            var fleteros = FleteroAlmacen.Fletero ?? new List<FleteroEntidad>();
            var fletero = fleteros.FirstOrDefault(f => f.DniFletero == dni);
            if (fletero == null)
            {
                MessageBox.Show("No existe un fletero registrado con ese DNI.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Tuple.Create(new List<EncomiendaEntidad>(), new List<EncomiendaEntidad>());
            }

            /*
           // Validar agencia actual
            var agencia = AgenciaAlmacen.AgenciaActual;
            if (agencia == null)
            {
                MessageBox.Show("No hay una Agencia Actual seleccionada.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Tuple.Create(new List<EncomiendaEntidad>(), new List<EncomiendaEntidad>());
            }
            var nomAgencia = Norm(agencia.NombreAgencia); */

            // HDR donde el fletero este asignado saco los trackings trackings
            var hdrs = HDRDistribucionUMAlmacen.HDRDistribucionUM ?? new List<HDRDistribucionUMEntidad>();
            var trackings = hdrs
                .Where(h => h.DniFleteroAsignado == dni)
                .SelectMany(h => h.Encomiendas ?? Enumerable.Empty<string>())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Select(t => t.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (trackings.Count == 0)
                return Tuple.Create(new List<EncomiendaEntidad>(), new List<EncomiendaEntidad>());

            // hago el Join con Encomiendas para comparar aquellas encomiedas que si tengo asigandas y traigo entidades en lugar de strings
            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();
            var set = new HashSet<string>(trackings, StringComparer.OrdinalIgnoreCase);
            var delFletero = encomiendas
                .Where(e => !string.IsNullOrWhiteSpace(e.Tracking) && set.Contains(e.Tracking.Trim()))
                .ToList();

            //  Filtrar por agencia y estado
            var aEntregar = delFletero
                .Where(e =>
                    //Norm(e.AgenciaOrigen) == nomAgencia &&
                    e.Estado == EstadoEncomiendaEnum.RuteadaRetiroAgencia)
                .ToList();

            var aRecibir = delFletero
                .Where(e =>
                    //Norm(e.AgenciaDestino) == nomAgencia &&
                    e.Estado == EstadoEncomiendaEnum.PendienteEntregaAgencia)
                .ToList();

            return Tuple.Create(aEntregar, aRecibir);
        }

        public Tuple<int, int> ConfirmarCambiosDesdeListas(IEnumerable<string> trackingsAEntregar, IEnumerable<string> trackingsARecibir)
        {
            int aEnTransitoUMOrigen = 0;
            int aPendienteRetiroAgencia = 0;

            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();

            var aEntregarKeys = (trackingsAEntregar ?? Enumerable.Empty<string>())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Select(t => t.Trim())
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var aRecibirKeys = (trackingsARecibir ?? Enumerable.Empty<string>())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Select(t => t.Trim())
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var enc in encomiendas)
            {
                var tk = (enc.Tracking ?? "").Trim();
                if (tk.Length == 0) continue;

                if (aEntregarKeys.Contains(tk) &&
                    enc.Estado == EstadoEncomiendaEnum.RuteadaRetiroAgencia)
                {
                    enc.Estado = EstadoEncomiendaEnum.EnTransitoUMOrigen;
                    aEnTransitoUMOrigen++;
                }
                else if (aRecibirKeys.Contains(tk) &&
                         enc.Estado == EstadoEncomiendaEnum.PendienteEntregaAgencia)
                {
                    enc.Estado = EstadoEncomiendaEnum.PendienteRetiroAgencia;
                    aPendienteRetiroAgencia++;
                }
            }

            try
            {
                EncomiendaAlmacen.Grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo grabar el archivo de encomiendas.\n" + ex.Message,
                    "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Tuple.Create(aEnTransitoUMOrigen, aPendienteRetiroAgencia);
        }


    }
}
