using Grupo_E.F04_GestionarOmnibus;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Grupo_E.GestionarOmnibus
{
    internal class F04_GestionarOmnibusModel
    {


        //DNIS de prueba: AB123CD, ST789UV, HI456JK

        private Dictionary<string, List<EncomiendasABajar>> EncomiendasARecepcionarPorPatente = new Dictionary<string, List<EncomiendasABajar>>();
        private Dictionary<string, List<EncomiendasASubir>> EncomiendasAEntregarPorPatente = new Dictionary<string, List<EncomiendasASubir>>();
        internal List<EncomiendasABajar> EncomiendasABajar(string patente)
        {

            //ME FALTA CODEAR QUÉ PASA SI LA PATENTE NO EXISTE! Esta en el Caso de uso y en los diagramas de secuencia pero acá no.
            //AGREGARLO!

            //ahora validamos si la patente tiene algo asignado  en el diccionario 


            // --> CORREJIR ESTO. deben ser 2 chequeos diferentes. puede ser que tenga solo cosas para subir o solo para bajar. el mensaje de error deberia
            //contemplar las 2 opciones. y en el caso de que no haya nada, devolver null. PENDIENTE!

            if (!EncomiendasAEntregarPorPatente.ContainsKey(patente) && !EncomiendasARecepcionarPorPatente.ContainsKey(patente))
            {
                MessageBox.Show("No se encontraron encomiendas pendientes de rendicion para la patente ingresada.");
                return null;

            }

            

            

            return EncomiendasARecepcionarPorPatente[patente];
            
        }

        // no hace falta validar xq se hizo en el otro metodo

        internal List <EncomiendasASubir> EncomiendasASubir(string patente)
        {
            return  EncomiendasAEntregarPorPatente[patente];


        }

        public F04_GestionarOmnibusModel() //Esto es un constructor para inicializar los datos de prueba
        {
            // Datos de prueba para AB123CD
            EncomiendasARecepcionarPorPatente["AB123CD"] = new List<EncomiendasABajar>
            {
                new EncomiendasABajar { IdHdr = "201", Tracking = "AB001", TipoDeBulto = "M" },
                new EncomiendasABajar { IdHdr = "202", Tracking = "AB002", TipoDeBulto = "S" }
            };
            EncomiendasAEntregarPorPatente["AB123CD"] = new List<EncomiendasASubir>
            {
                new EncomiendasASubir { IdHdr = "301", Tracking = "AB101", TipoDeBulto = "L" },
                new EncomiendasASubir { IdHdr = "302", Tracking = "AB102", TipoDeBulto = "XL" }
            };

            // Datos de prueba para ST789UV
            EncomiendasARecepcionarPorPatente["ST789UV"] = new List<EncomiendasABajar>
            {
                new EncomiendasABajar { IdHdr = "203", Tracking = "ST001", TipoDeBulto = "XL" },
                new EncomiendasABajar { IdHdr = "204", Tracking = "ST002", TipoDeBulto = "M" }
            };
            EncomiendasAEntregarPorPatente["ST789UV"] = new List<EncomiendasASubir>
            {
                new EncomiendasASubir { IdHdr = "303", Tracking = "ST101", TipoDeBulto = "S" },
                new EncomiendasASubir { IdHdr = "304", Tracking = "ST102", TipoDeBulto = "L" }
            };

            // Datos de prueba para HI456JK
            EncomiendasARecepcionarPorPatente["HI456JK"] = new List<EncomiendasABajar>
            {
                new EncomiendasABajar { IdHdr = "205", Tracking = "HI001", TipoDeBulto = "S" },
                new EncomiendasABajar { IdHdr = "206", Tracking = "HI002", TipoDeBulto = "L" }
            };
            EncomiendasAEntregarPorPatente["HI456JK"] = new List<EncomiendasASubir>
            {
                new EncomiendasASubir { IdHdr = "305", Tracking = "HI101", TipoDeBulto = "M" },
                new EncomiendasASubir { IdHdr = "306", Tracking = "HI102", TipoDeBulto = "XL" }
            };

            EncomiendasRecepcionadasEnCDOrigen = new List<EncomiendasABajar>();
            EncomiendasEnTransito = new List<EncomiendasASubir>();
        }

        public List<EncomiendasABajar> EncomiendasRecepcionadasEnCDOrigen { get; } = new List<EncomiendasABajar>();
        public List<EncomiendasASubir> EncomiendasEnTransito { get; } = new List<EncomiendasASubir>();
    }
}
