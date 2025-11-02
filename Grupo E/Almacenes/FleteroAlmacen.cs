using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using Newtonsoft.Json;


namespace Grupo_E.Almacenes
{
    static class FleteroAlmacen
    {
        public static List<FleteroEntidad> Fleteros { get; }
        static FleteroAlmacen()
        {
            if (File.Exists("fleteros.json"))
            {
                var fleterosJson = File.ReadAllText("fleteros.json");
                Fleteros = System.Text.Json.JsonSerializer.Deserialize<List<FleteroEntidad>>(fleterosJson) ?? new List<FleteroEntidad>();
            }
        }

        public static void Grabar()
        {
            //Transformar lista clientes en texto

            var fleterosJson = System.Text.Json.JsonSerializer.Serialize(Fleteros);
            File.WriteAllText("fleteros.json", fleterosJson);
        }
    }
}

/*
JSON:
1 objeto entre llaves {}
"propiedad" : "Valor"
"int" : 1234
"Fecha" : "2024-06-12T00:00:00"
Solamente existe objetos y arrays
Los arrays van entre corchetes []
Tengo una lista de objetos
[
{
    Movimientos : [
{"Fecha" : "2024-06-12T00:00:00", "Importe" : 1234},
{"Fecha" : "2024-06-13T00:00:00", "Importe" : 5678}
}
]
},
{
}
]
 */

/*
 Nivel 3 de seguridad:

        //nivel 3: Que ni siquiera se pueda modiificar la lista

        //Ventanilla
        public static FleteroEntidad Obtener(int dni)
        {
            var fletero = fleteros.FirstOrDefault(f => f.DniFletero == dni);

            //te devuelvo una copia:

            string fleterosJson = System.Text.Json.JsonSerializer.Serialize(fletero);
            var proveedorCopia = System.Text.Json.JsonSerializer.Deserialize<FleteroEntidad>(fleterosJson);

            return proveedorCopia;

            //pero si te doy copias también tengo q volver a guardarlos:

        }

        //tengo q hacer todo yo:

        public static void Cambios(int dni)
        {
            var fletero = fleteros.FirstOrDefault(f => f.DniFletero == dni);
            if (fletero == null)
            {
                throw new ArgumentException("El fletero no existe");
            }

        }
 

Nivel 2:


 //opciones:
        //1. public static List<FleteroEntidad> fleteros = new List<FleteroEntidad>() -- cualquier otra parte la puede modificar
        //nivel 2 seguridad:


        //me guardo la lista privada para mi:
        private static List<FleteroEntidad> fleteros = new List<FleteroEntidad>();

        //exponer la lista como solo lectura:
        public static IReadOnlyCollection<FleteroEntidad> Fleteros => fleteros.AsReadOnly();

        public static void Nuevo(FleteroEntidad fletero)
        {
            //Puedo agregar chequeos (NO validaciones) acá antes de agregar:
            if (fletero.DniFletero == null)
            throw new ArgumentException("El DNI del fletero no puede ser nulo.");
            //Esto cierra el programa. 

            fleteros.Add(fletero);
        }
        public static void Borrar(int dni)
        {
            fleteros.RemoveAll(f => f.DniFletero == dni);
        }




 */