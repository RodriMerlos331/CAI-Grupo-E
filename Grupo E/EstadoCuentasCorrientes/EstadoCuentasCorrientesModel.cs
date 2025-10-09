using System;
using System.Collections.Generic;
using System.Linq;

namespace Grupo_E.EstadoCuentasCorrientes
{
    // Clase que simula el acceso a datos y la lógica de negocio (Modelo)
    public class EstadoCuentasCorrientesModel
    {
        // 1. Datos Ficticios (Simulación de la base de datos)
        private readonly List<MovimientoCC> _movimientosDePrueba = new List<MovimientoCC>()
        {
            // --- MOVIMIENTOS BASE (CLIENTE 30712345674) ---
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 1), NroFactura = "0001-00000010", Estado = "Pagada", Debe = 10000.00M, Haber = 10000.00M, CUIT = "30712345674" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 15), NroFactura = "0001-00000025", Estado = "Vencida", Debe = 5500.00M, Haber = 0.00M, CUIT = "30712345674" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 8), NroFactura = "0001-00000050", Estado = "Pendiente", Debe = 12000.00M, Haber = 0.00M, CUIT = "30712345674" },
            // Nuevos ejemplos
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 15), NroFactura = "0001-00000075", Estado = "Pendiente", Debe = 5000.00M, Haber = 0.00M, CUIT = "30712345674" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 20), NroFactura = "0001-00000076", Estado = "Pagada", Debe = 0.00M, Haber = 10000.00M, CUIT = "30712345674" },

            // --- NUEVO CLIENTE PARA SALDO ACREEDOR (CUIT 27888888889) ---
            new MovimientoCC { FechaEmision = new DateTime(2025, 7, 1), NroFactura = "0002-00000001", Estado = "Pagada", Debe = 1000.00M, Haber = 0.00M, CUIT = "27888888889" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 8, 5), NroFactura = "0002-00000002", Estado = "Pagada", Debe = 0.00M, Haber = 5000.00M, CUIT = "27888888889" },

            // --- NUEVO CLIENTE PARA SALDO DEUDOR (CUIT 01234567891) ---
            new MovimientoCC { FechaEmision = new DateTime(2025, 9, 1), NroFactura = "0002-00000001", Estado = "Pagada", Debe = 1000.00M, Haber = 0.00M, CUIT = "01234567891" },
            new MovimientoCC { FechaEmision = new DateTime(2025, 10, 7), NroFactura = "0002-00000002", Estado = "Pagada", Debe = 25000.00M, Haber = 0.00M, CUIT = "01234567891" },
        };

        // 2. Método de búsqueda y cálculo
        public List<MovimientoCC> ObtenerMovimientos(string cuit, DateTime fechaDesde, DateTime fechaHasta, string estadoFiltro, out decimal saldoFinal)
        {
            saldoFinal = 0M;

            // Validación de Negocio (4to Nivel): ¿Es un CUIT conocido?
            if (cuit != "30712345674" && cuit != "27888888889" && cuit != "01234567891")
            {
                return new List<MovimientoCC>();
            }

            // Aplicar filtros
            var movimientosFiltrados = _movimientosDePrueba
                .Where(m => m.CUIT == cuit)
                .Where(m => m.FechaEmision >= fechaDesde && m.FechaEmision <= fechaHasta)
                .Where(m => estadoFiltro == "Todas" || m.Estado == estadoFiltro)
                .OrderBy(m => m.FechaEmision)
                .ToList();

            // 3. Calcular el saldo final
            foreach (var m in movimientosFiltrados)
            {
                saldoFinal = saldoFinal + m.Debe - m.Haber;
            }

            return movimientosFiltrados;
        }
    }
}