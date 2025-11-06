using System;
using System.Collections.Generic;
using System.Linq;
using Grupo_E.Almacenes;

namespace Grupo_E.F12_CostoVsVentas
{
    internal class CostosVsVentasModel
    {
        /// <summary>
        /// Punto de entrada desde el Form.
        /// Valida el CUIT, busca la empresa y calcula costos/ventas en el rango de fechas.
        /// </summary>
        internal ResultadoCostosVentas Consultar(Datos query)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));

            // 1) Buscar la empresa de servicios de larga distancia asociada al CUIT
            EmpresaServicioLargaDistanciaEntidad empresa = BuscarEmpresaPorCuit(query.Cuit);

            if (empresa == null)
                throw new Exception("No se encontró ninguna empresa de larga distancia con el CUIT ingresado.");

            // 2) Verificar que haya al menos un ómnibus con ese CUIT en OmnibusAlmacen
            bool tieneOmnibus = (OmnibusAlmacen.Omnibus ?? new List<OmnibusEntidad>())
                .Any(o => o.CuitEmpresaOmnibus == query.Cuit);

            if (!tieneOmnibus)
                throw new Exception("No hay ómnibus asociados a la empresa seleccionada.");

            // 3) Calcular Costos y Ventas en el rango de fechas
            (decimal totalCostos, decimal totalVentas) =
                CalcularCostosYVentas(empresa, query.FechaInicial.Date, query.FechaFinal.Date);

            return new ResultadoCostosVentas
            {
                NombreEmpresa = empresa.RazonSocial,
                TotalCostos = totalCostos,
                TotalVentas = totalVentas
            };
        }

        /// <summary>
        /// Obtiene la empresa de larga distancia por CUIT leyendo el almacén
        /// EmpresaServicioLargaDistanciaAlmacen.
        /// </summary>
        private EmpresaServicioLargaDistanciaEntidad BuscarEmpresaPorCuit(string cuit)
        {
            var empresas = EmpresaServicioLargaDistanciaAlmacen.EmpresaServicioLargaDistancia
                           ?? new List<EmpresaServicioLargaDistanciaEntidad>();

            return empresas.FirstOrDefault(e => e.CuitEmpresaOmnibus == cuit);
        }

        /// <summary>
        /// Calcula:
        /// - Costos: suma de los arrendamientos de la empresa en el rango [fechaDesde, fechaHasta].
        /// - Ventas: suma del PrecioTotalEncomienda de las encomiendas entregadas en el mismo rango.
        ///   Para las ventas se usa EncomiendaAlmacen + EncomiendaEntidad.EncomiendaFactura.
        /// </summary>
        private (decimal costos, decimal ventas) CalcularCostosYVentas(
            EmpresaServicioLargaDistanciaEntidad empresa,
            DateTime fechaDesde,
            DateTime fechaHasta)
        {
            decimal costos = 0m;
            decimal ventas = 0m;

            // --- COSTOS ---
            // Arrendamientos de la empresa de larga distancia cuyo Mes cae en el rango.
            if (empresa.Arrendamientos != null)
            {
                costos = empresa.Arrendamientos
                    .Where(a => a.Mes.Date >= fechaDesde && a.Mes.Date <= fechaHasta)
                    .Sum(a => a.Costo);
            }

            // --- VENTAS ---
            // Encomiendas entregadas en el rango de fechas (uso FechaEntrega) 
            // y con EncomiendaFactura calculada (PrecioTotalEncomienda).
            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();

            ventas = encomiendas
                .Where(e =>
                    e.FechaEntrega.HasValue &&
                    e.FechaEntrega.Value.Date >= fechaDesde &&
                    e.FechaEntrega.Value.Date <= fechaHasta &&
                    e.EncomiendaFactura != null)
                .Sum(e => e.EncomiendaFactura.PrecioTotalEncomienda);

            return (costos, ventas);
        }
    }
}
