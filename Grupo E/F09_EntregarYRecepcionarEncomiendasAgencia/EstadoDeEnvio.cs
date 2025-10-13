namespace Grupo_E.EntregarYRecepcionarEncomiendaAgencia
{
    internal enum EstadoDeEnvio
    {
        ImpuestaPendienteRetiroDomicilio,
        ImpuestaPendienteRetiroAgencia,
        RuteadaRetiroDomicilio,
        RuteadaRetiroAgencia, //En camino a ser retira
        ImpuestaRetiradaAgencia, //Fue retirada en agencia
        AdmitidaCD,
        Transito,
        CentroDistribucionDestino,
        PendienteEntregarDomicilio,
        RuteadaEntregaDomicilio,
        RuteadaEntregaAgencia, //En camino a ser dejada en la agencia
        PendienteRetiroAgencia, //Fue dejada en la agencia
        PendienteEntregaCD, 
        EntregadaAgencia,
        EntregadaCD,
        EntregaFallida,  
        EntregadaDomicilio,
        Cancelada


    }
}

