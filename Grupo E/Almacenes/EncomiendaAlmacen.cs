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
        public static List<EncomiendaEntidad> Encomienda { get; }

        static EncomiendaAlmacen()
        {
            if (File.Exists("Encomiendas.json"))
            {
                var EncomiendaJson = File.ReadAllText("Encomiendas.json");
                Encomienda = JsonConvert.DeserializeObject<List<EncomiendaEntidad>>(EncomiendaJson);
            }
        }

        public static void Grabar()
        {
            var EncomiendaJson = JsonConvert.SerializeObject(Encomienda);
            File.WriteAllText("Encomiendas.json", EncomiendaJson);
        }
    }
}
