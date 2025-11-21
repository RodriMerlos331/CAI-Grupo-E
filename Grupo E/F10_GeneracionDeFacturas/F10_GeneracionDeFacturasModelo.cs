using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Grupo_E.Almacenes;
using Grupo_E.F10_GeneracionDeFacturas;
namespace Grupo_E.F10_GeneracionDeFacturas
{
    public class EncomiendaFacturaDTO
    {
        public string Tracking { get; set; }
        public string FechaAdmision { get; set; }
        public string Importe { get; set; }
        public string ExtraRetiro { get; set; }
        public string ExtraEntrega { get; set; }
        public string ExtraAgencia { get; set; }
        public string PrecioTotal { get; set; }
    }

    internal class F10_GeneracionDeFacturasModelo
    {
        public string UltimoCUITConsultado;
        private Dictionary<string, List<EncomiendaFactura>> encomiendasPorCUIT = new Dictionary<string, List<EncomiendaFactura>>();

        internal bool ValidarCUIT(string cuit)
        {
            if (!Regex.IsMatch(cuit, @"^\d{1,2}-\d{8}-\d{1,2}$"))
            {
                MessageBox.Show("El CUIT debe tener el formato X-00000000-X, XX-00000000-X, X-00000000-XX o XX-00000000-XX", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            UltimoCUITConsultado = cuit;
            return true;
        }



        internal decimal CalcularTotalImportes(IEnumerable<(decimal Importe, decimal ExtraRetiro, decimal ExtraEntrega, decimal ExtraAgencia)> importes)
        {
            decimal total = 0;
            foreach (var item in importes)
            {
                total += item.Importe + item.ExtraRetiro + item.ExtraEntrega + item.ExtraAgencia;
            }
            return total;
        }


        internal List<EncomiendaEntidad> BuscarEncomiendasNoFacturadasPorCUIT(string cuit)
        {
            var todasLasEncomiendas = EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();
            DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Primer filtro: por CUIT y no facturadas
            var encomiendasFiltradas = todasLasEncomiendas
                .Where(e => e.CUITCliente == cuit && !e.Facturada)
                .ToList();

            var encomiendasConFechaValida = encomiendasFiltradas
                .Where(e => e.FechaEntrega.HasValue && e.FechaEntrega.Value < primerDiaMes)
                .ToList();

            if (!encomiendasConFechaValida.Any())
            {
                MessageBox.Show(
                    "No hay encomiendas con fecha de entrega anterior al primer día del mes corriente.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return encomiendasConFechaValida;
        }

        internal List<EncomiendaFacturaDTO> PrepararFacturasParaForm(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            var encomiendas = BuscarEncomiendasNoFacturadasPorCUIT(cuit);
            var resultado = new List<EncomiendaFacturaDTO>();
            var cultura = new CultureInfo("es-AR");

            foreach (var encomienda in encomiendas)
            {
                if (encomienda.EncomiendaFactura != null)
                {
                    resultado.Add(new EncomiendaFacturaDTO
                    {
                        Tracking = encomienda.Tracking ?? "",
                        FechaAdmision = encomienda.FechaAdmision.HasValue && encomienda.FechaAdmision.Value.Year > 1
                            ? encomienda.FechaAdmision.Value.ToString("dd/MM/yyyy")
                            : "",
                        Importe = encomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino.ToString("C", cultura),
                        ExtraRetiro = encomienda.EncomiendaFactura.ExtraRetiro.ToString("C", cultura),
                        ExtraEntrega = encomienda.EncomiendaFactura.ExtraEntrega.ToString("C", cultura),
                        ExtraAgencia = encomienda.EncomiendaFactura.ExtraAgencia.ToString("C", cultura),
                        PrecioTotal = encomienda.EncomiendaFactura.PrecioTotalEncomienda.ToString("C", cultura)
                    });
                }
             
            }

            return resultado;
        }

        internal void GenerarFactura(
            string cuitCliente,
            List<string> encomiendasIncluidas,
            decimal subtotal
            
        )
        {
            var todasLasEncomiendas = Grupo_E.Almacenes.EncomiendaAlmacen.Encomienda ?? new List<EncomiendaEntidad>();
            // Buscar los datos generales por su tipo
            var cuitTutasa = DatosGeneralesAlmacen.DatosGenerales
                .FirstOrDefault(d => d.Tipo == TipoDatoEnum.CUITTutasa)?.Dato;

            var ivaStr = DatosGeneralesAlmacen.DatosGenerales
                .FirstOrDefault(d => d.Tipo == TipoDatoEnum.IVAPorcentaje)?.Dato;

            var codigoCAE = DatosGeneralesAlmacen.DatosGenerales
                .FirstOrDefault(d => d.Tipo == TipoDatoEnum.CodigoAutorizacionElectronica)?.Dato;

            // Cálculo correcto del IVA
            decimal ivaPorcentaje = 0;
            decimal.TryParse(ivaStr, out ivaPorcentaje);
            ivaPorcentaje = ivaPorcentaje / 100m; // 

            decimal iva = subtotal * ivaPorcentaje;
            decimal total = subtotal + iva;

            // Número de factura secuencial (opcional)
            int ultimoNro = 0;
            if (FacturaAlmacen.Facturas.Any())
            {
                int.TryParse(FacturaAlmacen.Facturas.Max(f => f.NroFactura), out ultimoNro);
            }
            string nroFactura = (ultimoNro + 1).ToString("D8");

            var nuevaFactura = new FacturaEntidad
            {
                NroFactura = nroFactura,
                CuitTutasa = cuitTutasa,
                CuitCliente = cuitCliente,
                FechaEmision = DateTime.Now,
                EncomiendasIncluidas = encomiendasIncluidas,
                Subtotal = subtotal,
                Iva = iva,
                Total = total,
                CodigoDeAutorizacionElectronica = codigoCAE,
                FechadePago = null
            };

            FacturaAlmacen.Facturas.Add(nuevaFactura);

            // Marcar encomiendas seleccionadas como facturadas
            foreach (var encomienda in todasLasEncomiendas.Where(e => encomiendasIncluidas.Contains(e.Tracking)))
            {
                encomienda.Facturada = true;
            }
        }
    }

}