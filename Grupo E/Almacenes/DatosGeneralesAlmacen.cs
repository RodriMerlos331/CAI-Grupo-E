using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class DatosGeneralesAlmacen
    {
        public static List<DatosGeneralesEnt> DatosGenerales { get; }

        static DatosGeneralesAlmacen()
        {
            if (File.Exists(@"Datos/DatosGeneraless.json"))
            {
                var DatosGeneralesJson = File.ReadAllText(@"Datos/DatosGeneraless.json");
                DatosGenerales = JsonConvert.DeserializeObject<List<DatosGeneralesEnt>>(DatosGeneralesJson);
            }
        }

        public static void Grabar()
        {
            var DatosGeneralesJson = JsonConvert.SerializeObject(DatosGenerales);
            File.WriteAllText(@"Datos/DatosGeneraless.json", DatosGeneralesJson);
        }
    }
}

