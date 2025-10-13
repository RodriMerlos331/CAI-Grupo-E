using System;

namespace Grupo_E.F12_CostoVsVentas
{
    internal class Datos
    {
        public string Cuit { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
    }

    internal class ResultadoCostosVentas
    {
        public string NombreEmpresa { get; set; }
        public decimal TotalCostos { get; set; }
        public decimal TotalVentas { get; set; }

        public ResultadoCostosVentas()
        {
            NombreEmpresa = string.Empty;
            TotalCostos = 0m;
            TotalVentas = 0m;
        }
    }
}