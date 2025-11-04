namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal enum EstadoEnvio
    {
        ImpuestaPendienteRetiroDomicilio, //cuando se impone en CC 0 
        ImpuestaPendienteRetiroAgencia, //cuando se impone en agencia 1
        RuteadaRetiroDomicilio, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro domicilio 2
        RuteadaRetiroAgencia, //Desde el CD le indico al fletero que tiene que ir a buscar encomiendas pendiente retiro agencia 3
        EnTransitoUMOrigen, //Fletero pasó por el CD, y está yendo a buscar ruteadasdomicilio y ruteadasagencia 4
        Admitida, //Fletero llegó al domicilio/agencia y la encomienda fue admitida en CD Origne 5 
        EnTransitoMD, //Encomeindas admitidas en CD Origen y están en tránsito hacia CD Destino  6 
        //EnCDDestino, //Despachas en CD , esperando retiro o distribución UM, no sería necesario este estado
        PendienteRetiroCD, //7
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

