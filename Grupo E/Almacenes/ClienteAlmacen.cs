using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grupo_E.Almacenes
{
    static class ClienteAlmacen
    {
        
            public static List<ClienteEntidad> Cliente { get;}

            static ClienteAlmacen()
            {
                if (File.Exists("Clientes.json"))
                {
                    var ClienteJson = File.ReadAllText("Clientes.json");
                    Cliente = JsonConvert.DeserializeObject<List<ClienteEntidad>>(ClienteJson) ?? new List<ClienteEntidad>();
                }
            }

            public static void Grabar()
            {
                var ClienteJson = JsonConvert.SerializeObject(Cliente);
                File.WriteAllText("Clientes.json", ClienteJson);
            }
        
    }
}
