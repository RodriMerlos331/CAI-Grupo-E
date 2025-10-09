using System.Collections.Generic;

namespace Grupo_E.GestionarOmnibus
{
    internal class F04_GestionarOmnibusModel
    {
        public F04_GestionarOmnibusModel()
        {
            CargarDatosFalsos();
        }

        public List<ItemHDR> Datos { get; private set; }

        private void CargarDatosFalsos()
        {
            Datos = new List<ItemHDR>
            {
                new ItemHDR { IdHDR = 101, Patente = "AB123CD", NumeroGuia = "000145", TipoBulto = "M", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 102, Patente = "AB123CD", NumeroGuia = "000146", TipoBulto = "S", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 103, Patente = "AB123CD", NumeroGuia = "000147", TipoBulto = "L", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 104, Patente = "AB123CD", NumeroGuia = "000148", TipoBulto = "XL", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 101, Patente = "AB123CD", NumeroGuia = "000150", TipoBulto = "XL", Ubicacion = "Despacho" },
                new ItemHDR { IdHDR = 202, Patente = "AB123CD", NumeroGuia = "000151", TipoBulto = "S", Ubicacion = "Despacho" },
                new ItemHDR { IdHDR = 303, Patente = "XY789ZT", NumeroGuia = "000160", TipoBulto = "L", Ubicacion = "Despacho" },
                new ItemHDR { IdHDR = 303, Patente = "XY789ZT", NumeroGuia = "000180", TipoBulto = "M", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 105, Patente = "AB456CD", NumeroGuia = "000208", TipoBulto = "XL", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 105, Patente = "AB456CD", NumeroGuia = "000304", TipoBulto = "S", Ubicacion = "Recepcion" },
                new ItemHDR { IdHDR = 106, Patente = "AB456CD", NumeroGuia = "000506", TipoBulto = "M", Ubicacion = "Despacho" },

            };
        }
    }
}
