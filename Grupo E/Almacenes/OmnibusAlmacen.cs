using System;
using System.Collections.Generic;
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
            if (File.Exists("Omnibuss.json"))
            {
                var OmnibusJson = File.ReadAllText("Omnibuss.json");
                Omnibus = System.Text.Json.JsonSerializer.Deserialize<List<OmnibusEntidad>>(OmnibusJson) ?? new List<OmnibusEntidad>();
            }
        }

        public static void Grabar()
        {
            var OmnibusJson = System.Text.Json.JsonSerializer.Serialize(Omnibus);
            File.WriteAllText("Omnibuss.json", OmnibusJson);
        }
    }
}
