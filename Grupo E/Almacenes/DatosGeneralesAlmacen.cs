using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class DatosGeneralesAlmacen
    {
        public static List<DatosGeneralesEntidad> DatosGenerales { get; }

        static DatosGeneralesAlmacen()
        {
            if (File.Exists("DatosGeneraless.json"))
            {
                var DatosGeneralesJson = File.ReadAllText("DatosGeneraless.json");
                DatosGenerales = System.Text.Json.JsonSerializer.Deserialize<List<DatosGeneralesEntidad>>(DatosGeneralesJson) ?? new List<DatosGeneralesEntidad>();
            }
        }

        public static void Grabar()
        {
            var DatosGeneralesJson = System.Text.Json.JsonSerializer.Serialize(DatosGenerales);
            File.WriteAllText("DatosGeneraless.json", DatosGeneralesJson);
        }
    }
}
