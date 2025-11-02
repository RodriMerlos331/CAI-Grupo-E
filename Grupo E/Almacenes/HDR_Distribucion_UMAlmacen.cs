using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class HDR_Distribucion_UMAlmacen
    {
        public static List<HDR_Distribucion_UMEntidad> HDR_Distribucion_UM { get; }

        static HDR_Distribucion_UMAlmacen()
        {
            if (File.Exists("HDR_Distribucion_UMs.json"))
            {
                var HDR_Distribucion_UMJson = File.ReadAllText("HDR_Distribucion_UMs.json");
                HDR_Distribucion_UM = System.Text.Json.JsonSerializer.Deserialize<List<HDR_Distribucion_UMEntidad>>(HDR_Distribucion_UMJson) ?? new List<HDR_Distribucion_UMEntidad>();
            }
        }

        public static void Grabar()
        {
            var HDR_Distribucion_UMJson = System.Text.Json.JsonSerializer.Serialize(HDR_Distribucion_UM);
            File.WriteAllText("HDR_Distribucion_UMs.json", HDR_Distribucion_UMJson);
        }
    }
}
