using System;
using System.Collections.Generic;
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
        private string UltimoCUITConsultado;
        private Dictionary<string, List<EncomiendaFactura>> encomiendasPorCUIT = new Dictionary<string, List<EncomiendaFactura>>();

        internal bool ValidarCUIT(string cuit)
        {
            if (!Regex.IsMatch(cuit, @"^\d{2}-\d{8}-\d{2}$"))
            {
                MessageBox.Show("El CUIT debe tener el formato 00-00000000-00", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        internal List<EncomiendaEntidad> BuscarEncomiendasNoFacturadasPorCUIT(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            if (todasLasEncomiendas == null || !todasLasEncomiendas.Any())
            {
                MessageBox.Show("No hay encomiendas disponibles para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new List<EncomiendaEntidad>();
            }

            string cuitNormalizado = new string(cuit.Where(char.IsDigit).ToArray());
            DateTime hoy = DateTime.Today;
            DateTime primerDiaMesActual = new DateTime(hoy.Year, hoy.Month, 1);

            // Encomiendas no facturadas para el CUIT
            var encomiendasNoFacturadas = todasLasEncomiendas
                .Where(e =>
                    !e.Facturada &&
                    new string(e.CUITCliente.Where(char.IsDigit).ToArray()) == cuitNormalizado
                ).ToList();

            // De esas, las que cumplen con la fecha
            var resultado = encomiendasNoFacturadas
                .Where(e =>
                    e.FechaEntrega.HasValue &&
                    e.FechaEntrega.Value.Year > 1900 && // <-- Validación extra
                    e.FechaEntrega.Value.Date < primerDiaMesActual
                ).ToList();


            if (!resultado.Any())
            {
                if (encomiendasNoFacturadas.Any())
                {
                    MessageBox.Show("Todas las encomiendas no facturadas para este CUIT tienen fecha de entrega posterior al último día del mes anterior.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay encomiendas no facturadas para este CUIT.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return resultado;
        }

        internal List<EncomiendaFacturaDTO> PrepararFacturasParaForm(string cuit, List<EncomiendaEntidad> todasLasEncomiendas)
        {
            var encomiendas = BuscarEncomiendasNoFacturadasPorCUIT(cuit, todasLasEncomiendas);
            var resultado = new List<EncomiendaFacturaDTO>();

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
                        Importe = encomienda.EncomiendaFactura.PrecioCombinacionTamanoOrigenDestino.ToString("C"),
                        ExtraRetiro = encomienda.EncomiendaFactura.ExtraRetiro.ToString("C"),
                        ExtraEntrega = encomienda.EncomiendaFactura.ExtraEntrega.ToString("C"),
                        ExtraAgencia = encomienda.EncomiendaFactura.ExtraAgencia.ToString("C"),
                        PrecioTotal = encomienda.EncomiendaFactura.PrecioTotalEncomienda.ToString("C")
                    });
                }
             
            }

            return resultado;
        }

        internal void GenerarFactura(
            string cuitCliente,
            List<string> encomiendasIncluidas,
            decimal subtotal,
            DateTime? fechaPago
        )
        {
            if (DatosGeneralesAlmacen.DatosGenerales == null || !DatosGeneralesAlmacen.DatosGenerales.Any())
            {
                MessageBox.Show("No se encontraron datos generales. Verifique el archivo de configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            ivaPorcentaje = ivaPorcentaje / 100m; // <-- CORRECCIÓN

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
                FechadePago = fechaPago
            };

            FacturaAlmacen.Facturas.Add(nuevaFactura);
            FacturaAlmacen.Grabar();
    
        }
    }

}