using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_E.Almacenes
{
    internal class EncomiendaAlmacen
    {
        public static List<EncomiendaEnt> Encomienda { get; }

        static EncomiendaAlmacen()
        {
            if (File.Exists(@"Datos/Encomiendas.json"))
            {
                var EncomiendaJson = File.ReadAllText(@"Datos/Encomiendas.json");
                Encomienda = JsonConvert.DeserializeObject<List<EncomiendaEnt>>(EncomiendaJson);
            }
        }

        public static void Grabar()
        {
            var EncomiendaJson = JsonConvert.SerializeObject(Encomienda);
            File.WriteAllText(@"Datos/Encomiendas.json", EncomiendaJson);
        }
    }
}
