using System;
using System.Collections.Generic;
using System.Linq;
using Grupo_E.Almacenes;

namespace Grupo_E.EstadoCuentasCorrientes
{
    public class EstadoCuentasCorrientesModel
    {
        public List<MovimientoCC> ObtenerMovimientos(
            string cuit,
            DateTime fechaDesde,
            DateTime fechaHasta,
            string estadoFiltro,
            out decimal saldoDeudor,
            out decimal saldoAcreedor)
        {
            saldoDeudor = 0m;
            saldoAcreedor = 0m;

            // 1) Validar que el cliente exista
            bool clienteExiste = ClienteAlmacen.Cliente.Any(c => c.CUIT == cuit);
            if (!clienteExiste)
            {
                return new List<MovimientoCC>();
            }

            // 2) Traer facturas del cliente en el rango de fechas
            List<FacturaEntidad> facturasCliente = FacturaAlmacen.Facturas
                .Where(f => f.CuitCliente == cuit)
                .Where(f => f.FechaEmision.Date >= fechaDesde.Date
                         && f.FechaEmision.Date <= fechaHasta.Date)
                .ToList();

            List<MovimientoCC> movimientos = new List<MovimientoCC>();

            // 3) Armar movimientos según si tienen o no FechadePago
            foreach (FacturaEntidad f in facturasCliente)
            {
                string estado;
                decimal debe = 0m;
                decimal haber = 0m;

                if (f.FechadePago == null)
                {
                    // Factura impaga -> Pendiente
                    estado = "Pendiente";
                    debe = f.Total;
                }
                else
                {
                    // Factura con fecha de pago -> Pagada
                    estado = "Pagada";
                    haber = f.Total;
                }

                MovimientoCC mov = new MovimientoCC
                {
                    FechaEmision = f.FechaEmision,
                    NroFactura = f.NroFactura,
                    Estado = estado,
                    Debe = debe,
                    Haber = haber,
                    CUIT = f.CuitCliente
                };

                movimientos.Add(mov);
            }

            // 4) Filtro por estado (combo: "Todas / Pagada / Pendiente")
            List<MovimientoCC> filtrados = movimientos
                .Where(m => estadoFiltro == "Todas" || m.Estado == estadoFiltro)
                .OrderBy(m => m.FechaEmision)
                .ToList();

            // 5) Calcular totales deudor/acreedor que se van a mostrar abajo
            decimal totalDebe = filtrados.Sum(m => m.Debe);
            decimal totalHaber = filtrados.Sum(m => m.Haber);

            if (totalDebe >= totalHaber)
            {
                // Cliente deudor
                saldoDeudor = totalDebe - totalHaber;
                saldoAcreedor = 0m;
            }
            else
            {
                // Cliente acreedor
                saldoDeudor = 0m;
                saldoAcreedor = totalHaber - totalDebe;
            }

            return filtrados;
        }
    }
}

