using Grupo_E.Almacenes;
using Grupo_E.ConsultarEstadoEncomienda;
using Grupo_E.EntregarYRecepcionarEncomiendaAgencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.F09_EntregarYRecepcionarEncomiendasAgencia
{
	internal class EntregaYRecepcionEncomiendaAgenciaModel
	{
        public readonly Dictionary<int, GuiaDeEncomiendas> data;

        public EntregaYRecepcionEncomiendaAgenciaModel()
        {
            

           /* data = new Dictionary<int, GuiaDeEncomiendas>
            {
                [1001] = new GuiaDeEncomiendas
                {
                    TrackingId = 1001,
                    EstadoEnvio = EstadoDeEnvio.RuteadaRetiroAgencia,
                    CUIT = "20-42296338-4",
                    NombreDestinatario = "Roberto",
                    ApellidoDestinatario = "Gonzales",
                    DNIDestinatario = 40943084,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "XL",
                    FleteroAsignado = f1
                },
                [1002] = new GuiaDeEncomiendas
                {
                    TrackingId = 1002,
                    EstadoEnvio = EstadoDeEnvio.RuteadaEntregaAgencia,
                    CUIT = "30-12345678-9",
                    NombreDestinatario = "María",
                    ApellidoDestinatario = "Pérez",
                    DNIDestinatario = 30123456,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "M",
                    FleteroAsignado = f1
                },
                [1003] = new GuiaDeEncomiendas
                {
                    TrackingId = 1003,
                    EstadoEnvio = EstadoDeEnvio.RuteadaRetiroAgencia,
                    CUIT = "27-87654321-0",
                    NombreDestinatario = "Diego",
                    ApellidoDestinatario = "Ramírez",
                    DNIDestinatario = 28999888,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "L",
                    FleteroAsignado = f2
                },
                [1004] = new GuiaDeEncomiendas
                {
                    TrackingId = 1004,
                    EstadoEnvio = EstadoDeEnvio.RuteadaEntregaAgencia,
                    CUIT = "23-11223344-5",
                    NombreDestinatario = "Lucía",
                    ApellidoDestinatario = "Suárez",
                    DNIDestinatario = 37222111,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "S",
                    FleteroAsignado = f2
                },
                [1005] = new GuiaDeEncomiendas
                {
                    TrackingId = 1005,
                    EstadoEnvio = EstadoDeEnvio.RuteadaEntregaAgencia,
                    CUIT = "20-99887766-3",
                    NombreDestinatario = "Ana",
                    ApellidoDestinatario = "Domínguez",
                    DNIDestinatario = 33888777,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "XL",
                    FleteroAsignado = f1
                },
                [1006] = new GuiaDeEncomiendas
                {
                    TrackingId = 1006,
                    EstadoEnvio = EstadoDeEnvio.RuteadaRetiroAgencia,
                    CUIT = "30-44556677-0",
                    NombreDestinatario = "Carlos",
                    ApellidoDestinatario = "Gómez",
                    DNIDestinatario = 31222333,
                    LocalidadDestino = "Córdoba Capital",
                    AgenciaDestino = "Patio Olmo",
                    TamañoBulto = "M",
                    FleteroAsignado = f1
                },



            };

            */



        }
    }
}
