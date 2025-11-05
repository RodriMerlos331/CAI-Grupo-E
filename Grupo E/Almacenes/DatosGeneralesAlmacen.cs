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
        public static List<DatosGeneralesEntidad> DatosGenerales { get; }

        static DatosGeneralesAlmacen()
        {
            if (File.Exists(@"Datos/DatosGenerales.json"))
            {
                var DatosGeneralesJson = File.ReadAllText(@"Datos/DatosGenerales.json");
                DatosGenerales = JsonConvert.DeserializeObject<List<DatosGeneralesEntidad>>(DatosGeneralesJson);
            }
        }

        public static void Grabar()
        {
            var DatosGeneralesJson = JsonConvert.SerializeObject(DatosGenerales);
            File.WriteAllText(@"Datos/DatosGenerales.json", DatosGeneralesJson);
        }
    }
}

