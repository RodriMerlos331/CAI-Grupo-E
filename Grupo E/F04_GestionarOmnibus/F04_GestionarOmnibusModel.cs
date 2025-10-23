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

        private string UltimaPatenteBuscada = "-1";

        //DNIS de prueba: AB123CD, ST789UV, HI456JK

        private Dictionary<string, List<EncomiendasARecepcionar>> EncomiendasARecepcionarPorPatente = new Dictionary<string, List<EncomiendasARecepcionar>>();
        private Dictionary<string, List<EncomiendasAEntregar>> EncomiendasAEntregarPorPatente = new Dictionary<string, List<EncomiendasAEntregar>>();
        internal List<EncomiendasARecepcionar> EncomiendasARecepcionar(string patente)
        {


            //ahora validamos si la patente existe en el diccionario (en ambos)

            if (!EncomiendasAEntregarPorPatente.ContainsKey(patente) && !EncomiendasARecepcionarPorPatente.ContainsKey(patente))
            {
                MessageBox.Show("No se encontraron encomiendas pendientes de rendicion para la patente ingresada.");
                return null;

            }

            //ME FALTA CODEAR QUÉ PASA SI LA PATENTE NO EXISTE! Esta en el Caso de uso y en los diagramas de secuencia pero acá no.
            //AGREGARLO!

            UltimaPatenteBuscada = patente;

            return EncomiendasARecepcionarPorPatente[patente];
            
        }

        // no hace falta validar xq se hizo en el otro metodo

        internal List <EncomiendasAEntregar> ObtenerGuiasEntrega(string patente)
        {
            return  EncomiendasAEntregarPorPatente[patente];


        }

        public F04_GestionarOmnibusModel() //Esto es un constructor para inicializar los datos de prueba
        {
            // Datos de prueba para AB123CD
            EncomiendasARecepcionarPorPatente["AB123CD"] = new List<EncomiendasARecepcionar>
            {
                new EncomiendasARecepcionar { IdHdr = "201", Tracking = "AB001", TipoDeBulto = "M" },
                new EncomiendasARecepcionar { IdHdr = "202", Tracking = "AB002", TipoDeBulto = "S" }
            };
            EncomiendasAEntregarPorPatente["AB123CD"] = new List<EncomiendasAEntregar>
            {
                new EncomiendasAEntregar { IdHdr = "301", Tracking = "AB101", TipoDeBulto = "L" },
                new EncomiendasAEntregar { IdHdr = "302", Tracking = "AB102", TipoDeBulto = "XL" }
            };

            // Datos de prueba para ST789UV
            EncomiendasARecepcionarPorPatente["ST789UV"] = new List<EncomiendasARecepcionar>
            {
                new EncomiendasARecepcionar { IdHdr = "203", Tracking = "ST001", TipoDeBulto = "XL" },
                new EncomiendasARecepcionar { IdHdr = "204", Tracking = "ST002", TipoDeBulto = "M" }
            };
            EncomiendasAEntregarPorPatente["ST789UV"] = new List<EncomiendasAEntregar>
            {
                new EncomiendasAEntregar { IdHdr = "303", Tracking = "ST101", TipoDeBulto = "S" },
                new EncomiendasAEntregar { IdHdr = "304", Tracking = "ST102", TipoDeBulto = "L" }
            };

            // Datos de prueba para HI456JK
            EncomiendasARecepcionarPorPatente["HI456JK"] = new List<EncomiendasARecepcionar>
            {
                new EncomiendasARecepcionar { IdHdr = "205", Tracking = "HI001", TipoDeBulto = "S" },
                new EncomiendasARecepcionar { IdHdr = "206", Tracking = "HI002", TipoDeBulto = "L" }
            };
            EncomiendasAEntregarPorPatente["HI456JK"] = new List<EncomiendasAEntregar>
            {
                new EncomiendasAEntregar { IdHdr = "305", Tracking = "HI101", TipoDeBulto = "M" },
                new EncomiendasAEntregar { IdHdr = "306", Tracking = "HI102", TipoDeBulto = "XL" }
            };

            EncomiendasRecepcionadasEnCDOrigen = new List<EncomiendasARecepcionar>();
            EncomiendasEnTransito = new List<EncomiendasAEntregar>();
        }

        public List<EncomiendasARecepcionar> EncomiendasRecepcionadasEnCDOrigen { get; } = new List<EncomiendasARecepcionar>();
        public List<EncomiendasAEntregar> EncomiendasEnTransito { get; } = new List<EncomiendasAEntregar>();
    }
}
