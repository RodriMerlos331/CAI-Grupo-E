using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class HDR_Distribucion_MDAlmacen
    {
        public static List<HDR_Distribucion_MDEntidad> HDR_Distribucion_MD { get; }

        static HDR_Distribucion_MDAlmacen()
        {
            if (File.Exists(@"Datos/HDR_Distribucion_MD.json"))
            {
                var HDR_Distribucion_MDJson = File.ReadAllText(@"Datos/HDR_Distribucion_MD.json");
                HDR_Distribucion_MD = JsonConvert.DeserializeObject<List<HDR_Distribucion_MDEntidad>>(HDR_Distribucion_MDJson);
            }
        }

        public static void Grabar()
        {
            var HDR_Distribucion_MDJson = JsonConvert.SerializeObject(HDR_Distribucion_MD);
            File.WriteAllText(@"Datos/HDR_Distribucion_MD.json", HDR_Distribucion_MDJson);
        }
    }
}