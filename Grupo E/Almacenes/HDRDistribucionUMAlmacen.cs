using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_E.Almacenes
{
    static class HDRDistribucionUMAlmacen
    {
        public static List<HDRDistribucionUMEntidad> HDRDistribucionUM{ get; }

        static HDRDistribucionUMAlmacen()
        {
            if (File.Exists(@"Datos/HdrUM.json"))
            {
                var HDRUmJSON = File.ReadAllText(@"Datos/HdrUM.json");
                HDRDistribucionUM = JsonConvert.DeserializeObject<List<HDRDistribucionUMEntidad>>(HDRUmJSON);
            }
        }

        public static void Grabar()
        {
            var HDRUmJSON = JsonConvert.SerializeObject(HDRDistribucionUM);
            File.WriteAllText(@"Datos/HdrUM.json", HDRUmJSON);
        }
    }
}
