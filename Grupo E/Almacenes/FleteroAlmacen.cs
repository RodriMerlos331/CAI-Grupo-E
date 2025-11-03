using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;


namespace Grupo_E.Almacenes
{
    static class FleteroAlmacen
    {
        public static List<FleteroEntidad> Fletero { get; }

        static FleteroAlmacen()
        {
            if (File.Exists("Fleteros.json"))
            {
                var FleteroJson = File.ReadAllText("Fleteros.json");
                Fletero = JsonConvert.DeserializeObject<List<FleteroEntidad>>(FleteroJson);
            }
        }

        public static void Grabar()
        {
            var FleteroJson = JsonConvert.SerializeObject(Fletero);
            File.WriteAllText("Fleteros.json", FleteroJson);
        }
    }
}

