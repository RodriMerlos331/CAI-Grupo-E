using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class AgenciaAlmacen
    {
        public static List<AgenciaEntidad> Agencia { get; }

        static AgenciaAlmacen()
        {
            if (File.Exists("Agencias.json"))
            {
                var AgenciaJson = File.ReadAllText("Agencias.json");
                Agencia = System.Text.Json.JsonSerializer.Deserialize<List<AgenciaEntidad>>(AgenciaJson) ?? new List<AgenciaEntidad>();
            }
        }

        public static void Grabar()
        {
            var AgenciaJson = System.Text.Json.JsonSerializer.Serialize(Agencia);
            File.WriteAllText("Agencias.json", AgenciaJson);
        }
    }
}
