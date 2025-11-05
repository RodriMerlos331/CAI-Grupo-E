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
        
        public static List<TarifarioEntidad> Tarifario { get; }

        static TarifarioAlmacen()
        {
            if (File.Exists(@"Datos/Tarifario.json"))
            {
                var TarifarioJson = File.ReadAllText(@"Datos/Tarifario.json");
                Tarifario = JsonConvert.DeserializeObject<List<TarifarioEntidad>>(TarifarioJson);
            }
        }

        public static void Grabar()
        {
            var TarifarioJson = JsonConvert.SerializeObject(Tarifario);
            File.WriteAllText(@"Datos/Tarifario.json", TarifarioJson);
        }
        
    }
}
