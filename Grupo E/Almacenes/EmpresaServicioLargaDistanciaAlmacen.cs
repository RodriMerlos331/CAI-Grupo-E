using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{
    static class EmpresaServicioLargaDistanciaAlmacen
    {
        public static List<EmpresaServicioLargaDistanciaEntidad> EmpresaServicioLargaDistancia { get; }

        static EmpresaServicioLargaDistanciaAlmacen()
        {
            EmpresaServicioLargaDistancia = new List<EmpresaServicioLargaDistanciaEntidad>();

            // Nombre corregido al que existe en tu proyecto: EmpresaServicioLargaDistancia.json
            var path = @"Datos/EmpresaServicioLargaDistancia.json";
            if (File.Exists(path))
            {
                var EmpresaServicioLargaDistanciaJson = File.ReadAllText(path);
                var parsed = JsonConvert.DeserializeObject<List<EmpresaServicioLargaDistanciaEntidad>>(EmpresaServicioLargaDistanciaJson);
                if (parsed != null)
                {
                    EmpresaServicioLargaDistancia = parsed;
                }
            }
        }

        public static void Grabar()
        {
            var EmpresaServicioLargaDistanciaJson = JsonConvert.SerializeObject(EmpresaServicioLargaDistancia);
            File.WriteAllText(@"Datos/EmpresaServicioLargaDistancia.json", EmpresaServicioLargaDistanciaJson);
        }
    }
}


