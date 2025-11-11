namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal enum EstadoEnvio
    {
        ImpuestaPendienteRetiroDomicilio, //0
        ImpuestaPendienteRetiroAgencia, //1
        RuteadaRetiroDomicilio, //2
        RuteadaRetiroAgencia, //3
        EnTransitoUMOrigen, //4
        Admitida, //5 
        EnTransitoMD, //6 
        PendienteRetiroCD, //7
        PendienteEntregaDomicilio,//8
        PendienteEntregaAgencia,//9
        EnTransitoUMDestino, //10
        PendienteRetiroAgencia,  //11
        Entregada, //12
        NoEntregada, //13
        Cancelada,//14
        RetiradaAgenciaFletero //15

    }
}

