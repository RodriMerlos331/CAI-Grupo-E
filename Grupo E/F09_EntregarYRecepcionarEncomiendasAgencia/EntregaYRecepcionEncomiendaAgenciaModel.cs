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
        public readonly Dictionary<int, GuiaDeEncomiendas> data;

          public FleteroEntidad BuscarFleteroPorDni(int dni)
          {
            var fleteros = FleteroAlmacen.Fletero ?? new List<FleteroEntidad>();

            // Buscamos el fletero en el almacén
            var fletero = fleteros.FirstOrDefault(f => f.DniFletero == dni);

            // Si no existe, mostramos un error
            if (fletero == null)
            {
                MessageBox.Show("No existe un fletero registrado con ese DNI.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return fletero;
          }

        public List<string> ObtenerTrackingsPorFletero(int dni)
        {
            var hdrs = HDRDistribucionUMAlmacen.HDRDistribucionUM ?? new List<HDRDistribucionUMEntidad>();

            var trackings =
                hdrs
                .Where(h => h.DniFleteroAsignado == dni)
                .SelectMany(h => h.Encomiendas ?? Enumerable.Empty<string>())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Select(t => t.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            return trackings;
        }

        public List<EncomiendaEntidad> ObtenerEncomiendasDelFletero(int dni)
        {
            var trackings = ObtenerTrackingsPorFletero(dni);

            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();

            var set = new HashSet<string>(trackings.Select(t => t.Trim()), System.StringComparer.OrdinalIgnoreCase);

            var encomiendasAsignadas =
                encomiendas
                .Where(e => !string.IsNullOrWhiteSpace(e.Tracking) && set.Contains(e.Tracking.Trim()))
                .ToList();

            return encomiendasAsignadas;
        }

        private static string Norm(string s) => (s ?? "").Trim().ToUpperInvariant();

        public List<EncomiendaEntidad> ObtenerAEntregarEnAgenciaActual(int dni)
        {
            var agencia = AgenciaAlmacen.AgenciaActual;
            if (agencia == null)
            {
                MessageBox.Show("No hay una Agencia Actual seleccionada.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<EncomiendaEntidad>();
            }

            var NomAgencia = Norm(agencia.NombreAgencia);
            var encomiendas = ObtenerEncomiendasDelFletero(dni);

            return encomiendas
                .Where(e =>
                    string.Equals(Norm(e.AgenciaOrigen), NomAgencia, StringComparison.OrdinalIgnoreCase) &&
                    e.Estado == EstadoEncomiendaEnum.RuteadaRetiroAgencia)
                .ToList();
        }

       
        public List<EncomiendaEntidad> ObtenerARecibirEnAgenciaActual(int dni)
        {
            var agencia = AgenciaAlmacen.AgenciaActual;
            if (agencia == null)
            {
                MessageBox.Show("No hay una Agencia Actual seleccionada.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<EncomiendaEntidad>();
            }

            var NomAgencia = Norm(agencia.NombreAgencia);
            var encomiendas = ObtenerEncomiendasDelFletero(dni);

            return encomiendas
                .Where(e =>
                    string.Equals(Norm(e.AgenciaDestino), NomAgencia, StringComparison.OrdinalIgnoreCase) &&
                    e.Estado == EstadoEncomiendaEnum.PendienteEntregaAgencia)
                .ToList();
        }




    }
}
