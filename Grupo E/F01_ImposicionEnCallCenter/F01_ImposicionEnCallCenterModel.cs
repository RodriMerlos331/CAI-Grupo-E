
using Grupo_E.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F01_ImposicionEnCallCenter
{
    public class F01_ImposicionEnCallCenterModel
    {
        public string[] Localidad => LocalidadAlmacen.Localidad
   .Select(l => l.Nombre).ToArray();

        public string[] TamanoBulto => Enum.GetValues(typeof(TipoBultoEnum))
                                               .Cast<TipoBultoEnum>()
                                               .Select(t => t.ToString())
                                               .ToArray();



        public Dictionary<string, string> clientes => ClienteAlmacen.Cliente.ToDictionary(c => c.CUIT, c => c.Domicilio);



        public Dictionary<string, (List<string> Agencias, List<string> Terminales)> Localidades =>
    LocalidadAlmacen.Localidad.ToDictionary(
        loc => loc.Nombre,
        loc =>
        {
            var CDLocalidad = LocalidadAlmacen.Localidad
                .Where(l => l.Nombre == loc.Nombre)
                .Select(l => l.CodigoCD)
                .FirstOrDefault();

            var terminal = CentroDeDistribucionAlmacen.CentroDeDistribucion
                .Where(cd => cd.CodigoCD == CDLocalidad)
                .Select(cd => cd.NombreTerminal)
                .Distinct()
                .ToList();

            var agencias = AgenciaAlmacen.Agencia
                                    .Where(a => terminal.Any(cd => a.CodigoCD == CDLocalidad))
                                    .Select(a =>
                                        a.NombreAgencia)
                                    .Distinct()
                                    .ToList();

            return (agencias, terminal);
        });



        int ultimoNumero = EncomiendaAlmacen.Encomienda
             .Select(e => int.Parse(e.Tracking.Split('_').Last()))
             .DefaultIfEmpty(0)
             .Max();


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario, string datosRetiro, string localidadOrigen)
        {

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoLocalidad)
               .FirstOrDefault();

            var codCentroDistribucionOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoCD)
               .FirstOrDefault();

            var ObtenerCDDestino = CentroDeDistribucionAlmacen.CentroDeDistribucion
                    .Where(cd => cd.NombreTerminal == centroDistribucionDestino)
                    .Select(cd => cd.CodigoCD)
                    .FirstOrDefault();

            var CDDestino = ObtenerCDDestino;

            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamañoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = CDDestino + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = null,
                FechaEntrega = null,

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = datosRetiro,

                RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                //historial queda vacio pq no hay movimientos previos
                HistorialCambios = new List<Historial>(),

                EncomiendaFactura = null,

            };


            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);


            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Centro de distribución destino: " + centroDistribucionDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario, string datosRetiro, string localidadDestino, string localidadOrigen)
        {

            var codCentroDistribucionDestino = LocalidadAlmacen.Localidad
                .Where(l => l.Nombre == localidadDestino)
                .Select(l => l.CodigoCD)
                .FirstOrDefault();

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoLocalidad)
               .FirstOrDefault();

            var codCentroDistribucionOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoCD)
               .FirstOrDefault();

        

            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = "DOM" + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = null,
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = direccionParticular,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = codCentroDistribucionDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio,

                AgenciaDestino = null,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = datosRetiro,

                RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                EncomiendaFactura = null,

            };


            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Direccion particular destino: " + nuevaEncomienda.DireccionDestinatario + "\n" +
                "Dirección particular origen: " + nuevaEncomienda.DatosRetiroADomicilio + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario, string datosRetiro, string localidadOrigen)
        {

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoLocalidad)
               .FirstOrDefault();

            var codCentroDistribucionOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.Nombre == localidadOrigen)
               .Select(l => l.CodigoCD)
               .FirstOrDefault();

            var ObtenerCDDestino = AgenciaAlmacen.Agencia
                                .Where(a => a.NombreAgencia == agenciaDestino)
                                .Select(a => a.CodigoCD)
                                .FirstOrDefault();
            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            var CodAgenciaDestino = AgenciaAlmacen.Agencia
                    .Where(a => a.NombreAgencia == agenciaDestino)
                    .Select(a => a.CodigoAgencia)
                    .FirstOrDefault();

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = CodAgenciaDestino + "_" + (ultimoNumero + 1).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = null,
                FechaEntrega = null,

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = ObtenerCDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroDomicilio,

                AgenciaDestino = CodAgenciaDestino,
                AgenciaOrigen = null,
                DatosRetiroADomicilio = datosRetiro,

                RecorridoPlanificado = new List<ParadaPlanificada>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                EncomiendaFactura = null,

            };

            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Agencia destino: " + nuevaEncomienda.CodCentroDistribucionDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
