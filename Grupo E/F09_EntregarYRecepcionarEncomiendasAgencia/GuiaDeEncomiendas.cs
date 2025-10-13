
using Grupo_E.EntregarYRecepcionarEncomiendaAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia
{
    internal class GuiaDeEncomiendas
    {
        public int TrackingId { get; set; }
        public EstadoDeEnvio EstadoEnvio { get; set; }
        public string CUIT { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DNIDestinatario { get; set; }
        public string LocalidadDestino { get; set; }
        public string AgenciaDestino { get; set; }
        public string TamañoBulto { get; set; }
        public Fletero FleteroAsignado { get; set; }
    }
}
