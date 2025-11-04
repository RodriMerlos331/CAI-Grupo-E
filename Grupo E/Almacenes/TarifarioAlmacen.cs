using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class TarifarioAlmacen
    {
        
        public static List<TarifarioEnt> Tarifario { get; }

        static TarifarioAlmacen()
        {
            if (File.Exists(@"Datos/Tarifarios.json"))
            {
                var TarifarioJson = File.ReadAllText(@"Datos/Tarifarios.json");
                Tarifario = JsonConvert.DeserializeObject<List<TarifarioEnt>>(TarifarioJson);
            }
        }

        public static void Grabar()
        {
            var TarifarioJson = JsonConvert.SerializeObject(Tarifario);
            File.WriteAllText(@"Datos/Tarifarios.json", TarifarioJson);
        }
        
    }
}
