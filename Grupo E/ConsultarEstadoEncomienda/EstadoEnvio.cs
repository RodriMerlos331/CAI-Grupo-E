namespace Grupo_E.ConsultarEstadoEncomienda
{
    internal enum EstadoEnvio
    {
        EsperandoRetiro,
        Admitido,
        EnCaminoACD,           // centro de distribución
        EnCentroDistribucion,
        EnCaminoAAgenciaDestino,
        EnCaminoADestino,
        Entregado,
        Cancelado
    }
}

