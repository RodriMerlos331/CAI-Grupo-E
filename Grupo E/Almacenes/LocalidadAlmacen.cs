using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grupo_E.Almacenes
{
    internal class LocalidadAlmacen
    {
        public static List<LocalidadEntidad> Localidad { get; }

        static LocalidadAlmacen()
        {
            if (File.Exists(@"Datos/Localidades.json"))
            {
                var LocalidadJSON = File.ReadAllText(@"Datos/Localidades.json");
                Localidad = JsonConvert.DeserializeObject<List<LocalidadEntidad>>(LocalidadJSON);
            }
        }

        public static void Grabar()
        {
            var LocalidadJSON = JsonConvert.SerializeObject(Localidad);
            File.WriteAllText(@"Datos/Localidades.json", LocalidadJSON);
        }
    }
}
