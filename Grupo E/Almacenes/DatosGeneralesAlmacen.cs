using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Grupo_E.Almacenes
{
    static class DatosGeneralesAlmacen
    {
        public static List<DatosGeneralesEntidad> DatosGenerales { get; }

        static DatosGeneralesAlmacen()
        {
            if (File.Exists("DatosGeneraless.json"))
            {
                var DatosGeneralesJson = File.ReadAllText("DatosGenerales.json");
                DatosGenerales = JsonConvert.DeserializeObject<List<DatosGeneralesEntidad>>(DatosGeneralesJson) ?? new List<DatosGeneralesEntidad>();
            }
        }

        public static void Grabar()
        {
            var DatosGeneralesJson = JsonConvert.SerializeObject(DatosGenerales);
            File.WriteAllText("DatosGeneraless.json", DatosGeneralesJson);
        }
    }
}
