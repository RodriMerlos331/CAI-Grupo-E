using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class OmnibusAlmacen
    {
        public static List<OmnibusEntidad> Omnibus { get; }

        static OmnibusAlmacen()
        {
            Omnibus = new List<OmnibusEntidad>();

            // Nombre corregido al que existe en tu proyecto: Omnibus.json
            var path = @"Datos/Omnibus.json";
            if (File.Exists(path))
            {
                var OmnibusJson = File.ReadAllText(path);
                var parsed = JsonConvert.DeserializeObject<List<OmnibusEntidad>>(OmnibusJson);
                if (parsed != null)
                {
                    Omnibus = parsed;
                }
            }
        }

        public static void Grabar()
        {
            var OmnibusJson = JsonConvert.SerializeObject(Omnibus);
            File.WriteAllText(@"Datos/Omnibus.json", OmnibusJson);
        }
    }
}
