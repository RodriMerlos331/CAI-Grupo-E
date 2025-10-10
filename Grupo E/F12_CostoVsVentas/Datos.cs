// internal class CostosVsVentasQuery
using System;

namespace Grupo_E.F12_CostoVsVentas
{
    internal class CostosVsVentasQuery
{
    public string Cuit { get; set; }
    public DateTime FechaInicial { get; set; }
    public DateTime FechaFinal { get; set; }
}

// Clase para el resultado final
internal class ResultadoCostosVentas
{
    public string NombreEmpresa { get; set; }
    public decimal TotalCostos { get; set; }
    public decimal TotalVentas { get; set; }
}
}