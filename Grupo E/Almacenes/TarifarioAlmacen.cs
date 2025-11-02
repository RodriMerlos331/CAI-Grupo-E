using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class TarifarioAlmacen
    {
        public static List<TarifarioEntidad> Tarifario { get; }

        static TarifarioAlmacen()
        {
            if (File.Exists("Tarifarios.json"))
            {
                var TarifarioJson = File.ReadAllText("Tarifarios.json");
                Tarifario = System.Text.Json.JsonSerializer.Deserialize<List<TarifarioEntidad>>(TarifarioJson) ?? new List<TarifarioEntidad>();
            }
        }

        public static void Grabar()
        {
            var TarifarioJson = System.Text.Json.JsonSerializer.Serialize(Tarifario);
            File.WriteAllText("Tarifarios.json", TarifarioJson);
        }
    }
}
