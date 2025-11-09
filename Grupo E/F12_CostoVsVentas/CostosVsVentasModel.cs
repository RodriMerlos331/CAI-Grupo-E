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

            // 2) Buscar los ómnibus pertenecientes a esa empresa
            var omnibusEmpresa = (OmnibusAlmacen.Omnibus ?? new List<OmnibusEntidad>())
                .Where(o => o.CuitEmpresaOmnibus == query.Cuit)
                .ToList();

            if (!omnibusEmpresa.Any())
                throw new Exception("No hay ómnibus asociados a la empresa seleccionada.");

            // 3) Calcular Costos y Ventas en el rango de fechas
            (decimal totalCostos, decimal totalVentas) =
                CalcularCostosYVentas(empresa, omnibusEmpresa, query.FechaInicial.Date, query.FechaFinal.Date);

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
        /// - Ventas: suma del PrecioTotalEncomienda de las encomiendas entregadas en el mismo rango
        ///           y que hayan viajado en alguna HDR MD asociada a un ServicioID
        ///           de ómnibus de la empresa.
        /// </summary>
        private (decimal costos, decimal ventas) CalcularCostosYVentas(
            EmpresaServicioLargaDistanciaEntidad empresa,
            List<OmnibusEntidad> omnibusEmpresa,
            DateTime fechaDesde,
            DateTime fechaHasta)
        {
            decimal costos = 0m;
            decimal ventas = 0m;

            // --- COSTOS ---
            // Arrendamientos de la empresa cuyo Mes cae en el rango de fechas elegido.
            if (empresa.Arrendamientos != null)
            {
                costos = empresa.Arrendamientos
                    .Where(a => a.Mes.Date >= fechaDesde && a.Mes.Date <= fechaHasta)
                    .Sum(a => a.Costo);
            }

            // --- SERVICIOS DE LA EMPRESA ---
            // Sacamos los ServicioID de los ómnibus de la empresa (evitando nulos y repetidos).
            var serviciosEmpresa = omnibusEmpresa
                .Select(o => o.ServicioID)
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct()
                .ToList();

            if (!serviciosEmpresa.Any())
            {
                // La empresa tiene ómnibus pero ninguno con ServicioID definido.
                // No podemos atribuir ventas a ningún servicio.
                return (costos, 0m);
            }

            // --- HDR MD asociadas a esos servicios ---
            var hdrTodas = HDR_Distribucion_MDAlmacen.HDR_Distribucion_MD
                           ?? new List<HDR_Distribucion_MDEntidad>();

            var hdrEmpresa = hdrTodas
                .Where(h => !string.IsNullOrWhiteSpace(h.ServicioID)
                            && serviciosEmpresa.Contains(h.ServicioID))
                .ToList();

            if (!hdrEmpresa.Any())
            {
                // No hay HDR para los servicios de la empresa -> no hay ventas atribuibles
                return (costos, 0m);
            }

            // --- TRACKINGS de encomiendas que viajaron en esos HDR ---
            var trackingsEmpresa = new HashSet<string>(
                hdrEmpresa
                    .SelectMany(h => h.Encomiendas ?? new List<string>())
                    .Where(t => !string.IsNullOrWhiteSpace(t))
            );

            if (!trackingsEmpresa.Any())
            {
                // No hay encomiendas asociadas a las HDR de la empresa
                return (costos, 0m);
            }

            // --- VENTAS ---
            // Tomamos solo las encomiendas:
            // - cuyo Tracking está en los HDR de la empresa
            // - que tienen EncomiendaFactura
            // - y cuya FechaEntrega está en el rango elegido
            var encomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();

            ventas = encomiendas
                .Where(e =>
                    e.EncomiendaFactura != null &&
                    e.FechaEntrega.HasValue &&
                    e.FechaEntrega.Value.Date >= fechaDesde &&
                    e.FechaEntrega.Value.Date <= fechaHasta &&
                    trackingsEmpresa.Contains(e.Tracking))
                .Sum(e => e.EncomiendaFactura.PrecioTotalEncomienda);

            return (costos, ventas);
        }
    }
}
