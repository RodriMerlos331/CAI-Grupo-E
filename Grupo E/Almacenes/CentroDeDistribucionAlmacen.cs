using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_E.Almacenes
{
    internal class CentroDeDistribucionAlmacen
    {
        public static List<CentroDeDistribucionEnt> CentroDeDistribucion { get; }

        static CentroDeDistribucionAlmacen()
        {
            if (File.Exists(@"Datos/CentrosDistribucion.json"))
            {
                var CDJson = File.ReadAllText((@"Datos/CentrosDistribucion.json"));
                CentroDeDistribucion = JsonConvert.DeserializeObject<List<CentroDeDistribucionEnt>>(CDJson);
            }
        }

        public static void Grabar()
        {
            var CDJson = JsonConvert.SerializeObject(CentroDeDistribucion);
            File.WriteAllText(@"Datos/CentrosDistribucion.json", CDJson);
        }
    }
}
