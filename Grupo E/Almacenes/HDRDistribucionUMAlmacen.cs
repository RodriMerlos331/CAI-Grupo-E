using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class HDRDistribucionUMAlmacen
    {
        public static List<HDRDistribucionUMEntidad> HDR_Distribucion_UM { get; }

        static HDRDistribucionUMAlmacen()
        {
            if (File.Exists("HDR_Distribucion_UMs.json"))
            {
                var HDR_Distribucion_UMJson = File.ReadAllText("HDR_Distribucion_UMs.json");
                HDR_Distribucion_UM = System.Text.Json.JsonSerializer.Deserialize<List<HDRDistribucionUMEntidad>>(HDR_Distribucion_UMJson) ?? new List<HDRDistribucionUMEntidad>();
            }
        }

        public static void Grabar()
        {
            var HDR_Distribucion_UMJson = System.Text.Json.JsonSerializer.Serialize(HDR_Distribucion_UM);
            File.WriteAllText("HDR_Distribucion_UMs.json", HDR_Distribucion_UMJson);
        }
    }
}
