using System;
using System.Collections.Generic;
using System.Linq;

namespace Grupo_E.F12_CostoVsVentas
{
    internal class CostosVsVentasModel
    {
        internal ResultadoCostosVentas Consultar(Datos query)
        {
            (bool existe, string nombre) = BuscarEmpresa(query.Cuit);
            if (!existe)
            {
                throw new Exception("No se encontró ninguna empresa con el CUIT ingresado.");
            }

            (decimal costos, decimal ventas) = ObtenerTotales(query.Cuit, query.FechaInicial, query.FechaFinal);

            if (costos == 0m && ventas == 0m)
            {
                throw new Exception("No se encontraron registros para la empresa en el rango seleccionado.");
            }

            return new ResultadoCostosVentas
            {
                NombreEmpresa = nombre,
                TotalCostos = costos,
                TotalVentas = ventas
            };
        }

        private (bool Existe, string Nombre) BuscarEmpresa(string cuit)
        {
            switch (cuit)
            {
                case "20-12345678-0":
                    return (true, "Empresa Ejemplo S.A.");
                case "30-11111111-1":
                    return (true, "Nueva Empresa S.R.L.");
                case "20-55555555-5":
                    return (true, "Inversiones S.A.");
                default:
                    return (false, string.Empty);
            }
        }

        private (decimal Costos, decimal Ventas) ObtenerTotales(string cuit, DateTime fIni, DateTime fFin)
        {
            var registros = new List<(string Cuit, DateTime Inicio, DateTime Fin, decimal Costo, decimal Venta)>();


            DateTime p1_inicio = new DateTime(2025, 1, 15);
            DateTime p1_fin = new DateTime(2025, 3, 31);

            DateTime p2_inicio = new DateTime(2025, 4, 5);
            DateTime p2_fin = new DateTime(2025, 6, 30);

            DateTime p3_inicio = new DateTime(2025, 7, 11);
            DateTime p3_fin = new DateTime(2025, 10, 12);

            registros.Add(("20-12345678-0", p1_inicio, p1_fin, 15000.00m, 28000.00m)); 
            registros.Add(("20-12345678-0", p2_inicio, p2_fin, 12000.00m, 15000.00m)); 
            registros.Add(("20-12345678-0", p3_inicio, p3_fin, 23000.00m, 52000.00m)); 

            registros.Add(("30-11111111-1", p1_inicio, p1_fin, 3000.00m, 5000.00m));
            registros.Add(("30-11111111-1", p2_inicio, p2_fin, 4000.00m, 3000.00m));
            registros.Add(("30-11111111-1", p3_inicio, p3_fin, 3000.00m, 7000.00m));

            registros.Add(("20-55555555-5", p1_inicio, p1_fin, 20000.00m, 40000.00m));
            registros.Add(("20-55555555-5", p2_inicio, p2_fin, 25000.00m, 40000.00m));
            registros.Add(("20-55555555-5", p3_inicio, p3_fin, 30000.00m, 70000.00m));

            decimal costosTotales = 0m;
            decimal ventasTotales = 0m;

            var resultados = registros.Where(r =>
                r.Cuit == cuit &&
                r.Inicio >= fIni &&
                r.Fin <= fFin
            ).ToList();

            if (resultados.Any())
            {
                costosTotales = resultados.Sum(r => r.Costo);
                ventasTotales = resultados.Sum(r => r.Venta);
            }

            return (costosTotales, ventasTotales);
        }
    }
}