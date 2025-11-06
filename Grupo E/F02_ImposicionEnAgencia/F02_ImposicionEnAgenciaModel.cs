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



        public Dictionary<string, string> clientes => ClienteAlmacen.Cliente.ToDictionary(c => c.CUIT, c => c.Domicilio);



        public Dictionary<string, (List<string> Agencias, List<string> Terminales)> Localidades =>
    LocalidadAlmacen.Localidad.ToDictionary(
        loc => loc.Nombre,
        loc =>
        {

            var cds = CentroDeDistribucionAlmacen.CentroDeDistribucion
                        .Where(cd => cd.CodigoLocalidad == loc.CodigoLocalidad)
                        .ToList();

            var agencias = AgenciaAlmacen.Agencia
                        .Where(a => cds.Any(cd => cd.CodigoCD == a.CodigoCD))
                        .Select(a =>
                            a.NombreAgencia)
                        .Distinct()
                        .ToList();

            var terminales = cds
                        .Select(cd => cd.NombreTerminal)
                        .Distinct()
                        .ToList();

            return (agencias, terminales);
        });



        int ultimoNumero = EncomiendaAlmacen.Encomienda
          .Select(e => e.Tracking.Split('_').Last())
          .Select(n => int.Parse(n))
          .DefaultIfEmpty(1)
          .Max();


        public void ImposicionConDestinoACD(string cuitCliente, string centroDistribucionDestino, string tamañoBulto, string datosDestinatario)
        {
            
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;
            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;
            var codLocalidadOrigen = CentroDeDistribucionAlmacen.CentroDeDistribucion
                .Where(cd => cd.CodigoCD == codCentroDistribucionOrigen)
                .Select(cd => cd.CodigoLocalidad)
                .FirstOrDefault();

            var ObtenerCDDestino = CentroDeDistribucionAlmacen.CentroDeDistribucion
                    .Where(cd => cd.NombreTerminal == centroDistribucionDestino)
                    .Select(cd => cd.CodigoCD)
                    .FirstOrDefault();
            var CDDestino = ObtenerCDDestino;
            



            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamañoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = CDDestino + "_" + (ultimoNumero++).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = null,
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = null,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

                //ejemplo cualquiera, en este caso la parada es retiro y 5 Grutas ??, pero debería generarse la ruta real, quizas desde ObtenerRuta?
                ParadasRuta = new List<int>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                DatosFacturacion = null,

            };


            nuevaEncomienda.HistorialCambios.Add(new Historial
            {
                Tracking = nuevaEncomienda.Tracking,
                FechaPrevia = DateTime.Now,
                UbicacionPrevia = null,
                FleteroAsignado = 0,
                NumeroHDRUM = 0,
                NumeroHDRMD = 0,
                EstadoPrevio = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia
            });

            
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

        public void ImposicionDomicilioParticular(string cuitCliente, string direccionParticular, string tamanoBulto, string datosDestinatario, string localidad)
        {

            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;
            var codLocalidadOrigen = CentroDeDistribucionAlmacen.CentroDeDistribucion
                .Where(cd => cd.CodigoCD == codCentroDistribucionOrigen)
                .Select(cd => cd.CodigoLocalidad)
                .FirstOrDefault();

            var codLocalidadDestino = LocalidadAlmacen.Localidad
                           .Where(l => l.Nombre == localidad)
                           .Select(l => l.CodigoLocalidad)
                           .FirstOrDefault();

            var codCentroDistribucionDestino = ObtenerCodigoCDPrimerEncontrado(codLocalidadDestino);
            var CDDestino = codCentroDistribucionDestino;
            var tipoBulto = (TipoBultoEnum)Enum.Parse(typeof(TipoBultoEnum), tamanoBulto);

            var nuevaEncomienda = new EncomiendaEntidad
            {
                Tracking = "DOM" + "_" + (ultimoNumero++).ToString(),
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
                CodCentroDistribucionDestino = CDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = null,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

                ParadasRuta = new List<int>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                DatosFacturacion = null,

            };


            nuevaEncomienda.HistorialCambios.Add(new Historial
            {
                Tracking = nuevaEncomienda.Tracking,
                FechaPrevia = DateTime.Now,
                UbicacionPrevia = null,
                FleteroAsignado = 0,
                NumeroHDRUM = 0,
                NumeroHDRMD = 0,
                EstadoPrevio = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia
            });


            EncomiendaAlmacen.Encomienda.Add(nuevaEncomienda);



            string mensaje =
                "Guía impuesta exitosamente.\n\n" +
                "Tracking: " + nuevaEncomienda.Tracking + "\n" +
                "CUIT del cliente: " + nuevaEncomienda.CUITCliente + "\n" +
                "Direccion particular: " + nuevaEncomienda.DireccionDestinatario + "\n" +
                "Tamaño del bulto: " + nuevaEncomienda.TipoBulto + "\n" +
                "Datos del destinatario: " + datosDestinatario + "\n\n";


            MessageBox.Show(mensaje, "Imposición registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        public void ImposicionEnAgencia(string cuitCliente, string agenciaDestino, string tamanoBulto, string datosDestinatario)
        {
            var codAgenciaActual = AgenciaAlmacen.AgenciaActual.CodigoAgencia;
            var codCentroDistribucionOrigen = AgenciaAlmacen.AgenciaActual.CodigoCD;
            var codLocalidadOrigen = CentroDeDistribucionAlmacen.CentroDeDistribucion
                .Where(cd => cd.CodigoCD == codCentroDistribucionOrigen)
                .Select(cd => cd.CodigoLocalidad)
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
                Tracking = codAgenciaActual + "_" + (ultimoNumero++).ToString(),
                CUITCliente = cuitCliente,
                FechaImposicion = DateTime.Now,
                FechaAdmision = null,
                FechaEntrega = null, //  no entregada

                TipoBulto = tipoBulto,
                NombreDestinatario = datosDestinatario,
                ApellidoDestinatario = datosDestinatario,
                DireccionDestinatario = null,
                DNIDestinatario = int.Parse(new string(datosDestinatario.Where(char.IsDigit).ToArray())),

                CodCDActual = null,
                CodLocalidadOrigen = codLocalidadOrigen,
                CodCentroDistribucionOrigen = codCentroDistribucionOrigen,
                CodCentroDistribucionDestino = ObtenerCDDestino,

                Estado = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia,

                AgenciaDestino = CodAgenciaDestino,
                AgenciaOrigen = codAgenciaActual,
                DatosRetiroADomicilio = null,

                ParadasRuta = new List<int>(),

                Facturada = false,

                HistorialCambios = new List<Historial>(),

                DatosFacturacion = null,

            };


            nuevaEncomienda.HistorialCambios.Add(new Historial
            {
                Tracking = nuevaEncomienda.Tracking,
                FechaPrevia = DateTime.Now,
                UbicacionPrevia = null,
                FleteroAsignado = 0,
                NumeroHDRUM = 0,
                NumeroHDRMD = 0,
                EstadoPrevio = EstadoEncomiendaEnum.ImpuestaPendienteRetiroAgencia
            });


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


        //Debería tener alguna logica que matchee direccion particular con CD más cercano?
        private string ObtenerCodigoCDPrimerEncontrado(string codigoLocalidad)
        {
            return CentroDeDistribucionAlmacen.CentroDeDistribucion
                       .First(cd => cd.CodigoLocalidad == codigoLocalidad)
                       .CodigoCD;
        }

        private List<int> ObtenerParadasRutaBasica(string codCDOrigen, string codCDDestino)
        {
            // Construyo un mapa simple CodigoCD -> CodigoParada (índice + 1)
            var mapa = CentroDeDistribucionAlmacen.CentroDeDistribucion
                        .Select((cd, idx) => new { cd.CodigoCD, CodigoParada = idx + 1 })
                        .ToDictionary(x => x.CodigoCD, x => x.CodigoParada);

            int paradaOrigen = mapa[codCDOrigen];
            int paradaDestino = mapa[codCDDestino];

            // Ruta mínima: primera parada (origen) y última (destino)
            if (paradaOrigen == paradaDestino)
                return new List<int> { paradaOrigen };

            return new List<int> { paradaOrigen, paradaDestino };
        }
    }
}
