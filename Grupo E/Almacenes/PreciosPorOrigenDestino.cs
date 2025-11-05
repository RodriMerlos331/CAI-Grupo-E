using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public class PreciosPorOrigenDestino
    {
        public TipoBultoEnum Tipo { get; set; }

        public string CodigoCDOrigen { get; set; }

        public string CodigoCDDestino { get; set; }

        public decimal Precio { get; set; }

        //Está ok sumar método acá??

        public static decimal ObtenerPrecio(string codigoOrigen, string codigoDestino, TipoBultoEnum tipo)
        {
            var match = TarifarioAlmacen.Tarifario
                .SelectMany(t => t.PreciosPorOrigenDestinos)
                .First(p =>
                    p.Tipo == tipo &&
                    string.Equals(p.CodigoCDOrigen ?? string.Empty, codigoOrigen ?? string.Empty, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(p.CodigoCDDestino ?? string.Empty, codigoDestino ?? string.Empty, StringComparison.OrdinalIgnoreCase)
                );

            return match.Precio;
        }
    }
}
