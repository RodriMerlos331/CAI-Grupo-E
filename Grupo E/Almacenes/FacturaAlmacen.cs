using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class FacturaAlmacen
    {
        public static List<FacturaEntidad> Facturas { get; }

        static FacturaAlmacen()
        {
            if (File.Exists(@"Datos/Facturas.json"))
            {
                var FacturasJson = File.ReadAllText(@"Datos/Facturas.json");
                Facturas = JsonConvert.DeserializeObject<List<FacturaEntidad>>(FacturasJson);
            }
        }

        public static void Grabar()
        {
            var FacturasJson = JsonConvert.SerializeObject(Facturas);
            File.WriteAllText(@"Datos/Facturas.json", FacturasJson);
        }
    }
}
