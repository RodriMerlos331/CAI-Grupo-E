using System;

namespace Grupo_E.F12_CostoVsVentas
{
    internal class CostosVsVentasModel
{
    internal ResultadoCostosVentas Consultar(CostosVsVentasQuery query)
    {
        (bool existe, string nombre) = BuscarEmpresa(query.Cuit);
        if (!existe)
        {
            throw new Exception("No se encontró ninguna empresa con el CUIT ingresado.");
        }

        (decimal costos, decimal ventas) = ObtenerTotales(query.Cuit, query.FechaInicial, query.FechaFinal);

        if (costos == 0 && ventas == 0)
        {
            throw new Exception("No se registran registros para la empresa en el año seleccionado.");
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
        if (cuit == "20-12345678-0")
        {
            return (true, "Empresa Ejemplo S.A.");
        }
        return (false, string.Empty);
    }

    private (decimal Costos, decimal Ventas) ObtenerTotales(string cuit, DateTime fIni, DateTime fFin)
    {
        if (cuit == "20-12345678-0" && fIni.Year == 2025)
        {
            return (50000.00m, 95000.00m);
        }
        return (0m, 0m);
    }
}
}