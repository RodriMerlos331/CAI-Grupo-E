using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{

    static class OmnibusAlmacen
        
    {
        
        public static List<OmnibusEntidad> Omnibus { get; }

        static OmnibusAlmacen()
        {
            if (File.Exists(@"Datos/Omnibuss.json"))
            {
                var OmnibusJson = File.ReadAllText(@"Datos/Omnibuss.json");
                Omnibus = JsonConvert.DeserializeObject<List<OmnibusEntidad>>(OmnibusJson);
             }
        }

        public static void Grabar()
        {
            var OmnibusJson = JsonConvert.SerializeObject(Omnibus);
            File.WriteAllText(@"Datos/Omnibuss.json", OmnibusJson);
        }
        
    }
       
}
