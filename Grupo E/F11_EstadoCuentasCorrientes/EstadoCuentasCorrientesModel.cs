using System;
using System.Collections.Generic;
using System.Linq;

namespace Grupo_E.EstadoCuentasCorrientes
{
    public class EstadoCuentasCorrientesModel
    {
        private readonly List<MovimientoCC> _movimientosDePrueba = new List<MovimientoCC>()
        {
            // 30712345674
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 1), NroFactura = "0001-00000010", Estado = "Pagada", Debe = 0.00M, Haber = 10000.00M, CUIT = "30-71234567-4" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 15), NroFactura = "0001-00000025", Estado = "Vencida", Debe = 5500.00M, Haber = 0.00M, CUIT = "30-71234567-4" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 18), NroFactura = "0001-00000050", Estado = "Pendiente", Debe = 12000.00M, Haber = 0.00M, CUIT = "30-71234567-4" },

            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 5), NroFactura = "0001-00000075", Estado = "Pendiente", Debe = 5000.00M, Haber = 0.00M, CUIT = "30-71234567-4" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 2), NroFactura = "0001-00000076", Estado = "Pagada", Debe = 0.00M, Haber = 10000.00M, CUIT = "30-71234567-4" },

            // 27888888889
            new MovimientoCC { FechaEmision = new DateTime(2025, 7, 1), NroFactura = "0002-00000001", Estado = "Pagada", Debe = 0.00M, Haber = 1000.00M, CUIT = "27-88888888-9" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 8, 5), NroFactura = "0002-00000002", Estado = "Pagada", Debe = 0.00M, Haber = 5000.00M, CUIT = "27-88888888-9" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 8, 24), NroFactura = "0002-00000003", Estado = "Pendiente", Debe = 7000.00M, Haber = 0.00M, CUIT = "27-88888888-9" },

            // 01234567891
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 1), NroFactura = "0002-00000065", Estado = "Pagada", Debe = 0.00M, Haber = 1000.00M, CUIT = "01-23456789-1" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 15), NroFactura = "0001-00000070", Estado = "Vencida", Debe = 5500.00M, Haber = 0.00M, CUIT = "01-23456789-1" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 18), NroFactura = "0001-00000071", Estado = "Vencida", Debe = 4000.00M, Haber = 0.00M, CUIT = "01-23456789-1" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 7), NroFactura = "0002-00000068", Estado = "Pagada", Debe = 0.00M, Haber = 25000.00M, CUIT = "01-23456789-1" },
        };

        public List<MovimientoCC> ObtenerMovimientos(string cuit, DateTime fechaDesde, DateTime fechaHasta, string estadoFiltro, out decimal saldoFinal)
        {
            saldoFinal = 0M;

            if (cuit != "30-71234567-4" && cuit != "27-88888888-9" && cuit != "01-23456789-1")
            {
                return new List<MovimientoCC>();
            }

            var movimientosFiltrados = _movimientosDePrueba
                .Where(m => m.CUIT == cuit)
                .Where(m => m.FechaEmision >= fechaDesde && m.FechaEmision <= fechaHasta)
                .Where(m => estadoFiltro == "Todas" || m.Estado == estadoFiltro)
                .OrderBy(m => m.FechaEmision)
                .ToList();

            foreach (var m in movimientosFiltrados)
            {
                saldoFinal = saldoFinal + m.Debe - m.Haber;
            }

            return movimientosFiltrados;
        }
    }
}