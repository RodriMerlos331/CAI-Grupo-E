using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    public enum EstadoEncomiendaEnum
    {
        ImpuestaPendienteRetiroDomicilio, //cuando se impone en CC
        ImpuestaPendienteRetiroAgencia, //cuando se impone en agencia
        RuteadaRetiroDomicilio, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro domicilio
        RuteadaRetiroAgencia, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro agencia
        EnTransitoUMOrigen, //Fletero pasó por el CD, y está yendo a buscar ruteadasdomicilio y ruteadasagencia
        Admitida, //Fletero llegó al domicilio/agencia y la encomienda fue admitida en CD Origne
        EnTransitoMD, //Encomeindas admitidas en CD Origen y están en tránsito hacia CD Destino
        //EnCDDestino, //Despachas en CD , esperando retiro o distribución UM, no sería necesario este estado
        PendienteRetiroCD,
        PendienteEntregaDomicilio,
        PendienteEntregaAgencia,
        //se podrían resumir en PendienteEntregaUM ?
        //RuteadaUM, //no necesario
        //quedan en CD hasta que pasa fletero y armo HDR distribucion UM
        EnTransitoUMDestino, //Fletero pasó por el CD Destino y está yendo a entregar encomiendas pendiente entrega domicilio/agencia
        PendienteRetiroAgencia,  ////Fletero entrega en agencia, esperando que el cliente retire
        Entregada, //sea en casa, agencia o CD ? 
        Cancelada

    }
}


/*ideal si tuviesemos un menu donde al inicio ya te dice donde está la encomienda. 
        Impuesta,
        Ruteada, 
        Admitida,
        EnTransitoMD,
        EnCDDestino,
        PendienteEntrega,
        RuteadaUM,
        PendienteRetiroCD,
        PendienteRetiroAgencia, 
        Entregada,
        Cancelada
        */
