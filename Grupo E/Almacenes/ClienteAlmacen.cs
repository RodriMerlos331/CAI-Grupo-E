using System;
using System.Collections.Generic;
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
                    Cliente = System.Text.Json.JsonSerializer.Deserialize<List<ClienteEntidad>>(ClienteJson) ?? new List<ClienteEntidad>();
                }
            }

            public static void Grabar()
            {
                var ClienteJson = System.Text.Json.JsonSerializer.Serialize(Cliente);
                File.WriteAllText("Clientes.json", ClienteJson);
            }
        
    }
}
