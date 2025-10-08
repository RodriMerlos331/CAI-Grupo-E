namespace Grupo_E.GestionarOmnibus
{
    public class ItemHDR
    {
        public int IdHDR { get; set; }           // ID de la Hoja de Ruta
        public string Patente { get; set; }     // Patente del micro
        public string NumeroGuia { get; set; }  // Número de tracking / guía
        public string TipoBulto { get; set; }   // S, M, L, XL
        public string Ubicacion { get; set; }   // "Recepcion" o "Despacho"
    }
}
