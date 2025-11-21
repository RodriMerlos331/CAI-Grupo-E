using Grupo_E.F03_ImposicionEnCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grupo_E.Almacenes;


namespace Grupo_E.F02_ImposicionEnAgencia
{
    public class F02_ImposicionEnAgenciaModel
    {
        public string[] Localidad => LocalidadAlmacen.Localidad
    .Select(l => l.Nombre).ToArray();

        public string[] TamanoBulto => Enum.GetValues(typeof(TipoBultoEnum))
                                               .Cast<TipoBultoEnum>()
                                               .Select(t => t.ToString())
                                               .ToArray();



        public List<string> ClientesLista =>
                   ClienteAlmacen.Cliente
                       .Select(c => $"{c.CUIT} , {c.RazonSocial}")
                       .ToList();


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


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string nombreD, string apellidoD, int dniD)
        {
            
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;
            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.CodigoCD == codCentroDistribucionOrigen)
               .Select(l => l.CodigoLocalidad)
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
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = null,
                DNIDestinatario = dniD,

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = null,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

                //ejemplo cualquiera, en este caso la parada es retiro y 5 Grutas ??, pero debería generarse la ruta real, quizas desde ObtenerRuta?
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
                "Centro de distribución destino: " + centroDistribucionDestino + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + nombreD + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string nombreD, string apellidoD, int dniD, string localidad)
        {

            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;

            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.CodigoCD == codCentroDistribucionOrigen)
               .Select(l => l.CodigoLocalidad)
               .FirstOrDefault();

            var codLocalidadDestino = LocalidadAlmacen.Localidad
                           .Where(l => l.Nombre == localidad)
                           .Select(l => l.CodigoLocalidad)
                           .FirstOrDefault();

            var codCentroDistribucionDestino = LocalidadAlmacen.Localidad
                            .Where(l => l.Nombre == localidad)
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
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = direccionParticular,
                DNIDestinatario = dniD,

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = codCentroDistribucionDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = null,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

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
                "Direccion particular: " + nuevaEncomienda.DireccionDestinatario + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + nombreD + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string nombreD, string apellidoD, int dniD)
        {
            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;
            var codLocalidadOrigen = LocalidadAlmacen.Localidad
               .Where(l => l.CodigoCD == codCentroDistribucionOrigen)
               .Select(l => l.CodigoLocalidad)
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
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = nombreD,
                ApellidoDestinatario = apellidoD,
                DireccionDestinatario = null,
                DNIDestinatario = dniD,

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = ObtenerCDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = CodAgenciaDestino,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

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
                "Datos del destinatario: " + nombreD + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
