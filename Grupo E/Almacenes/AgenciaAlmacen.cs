using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
                Agencia = JsonConvert.DeserializeObject<List<AgenciaEntidad>>(AgenciaJson);
            }
        }

        public static void Grabar()
        {
            var AgenciaJson = JsonConvert.SerializeObject(Agencia);
            File.WriteAllText("Agencias.json", AgenciaJson);
        }
    }
}
