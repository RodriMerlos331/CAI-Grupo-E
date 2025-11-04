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
            if (File.Exists(@"Datos/EmpresaServicioLargaDistancias.json"))
            {
                var EmpresaServicioLargaDistanciaJson = File.ReadAllText(@"Datos/EmpresaServicioLargaDistancias.json");
                EmpresaServicioLargaDistancia = JsonConvert.DeserializeObject<List<EmpresaServicioLargaDistanciaEntidad>>(EmpresaServicioLargaDistanciaJson);
            }
        }

        public static void Grabar()
        {
            var EmpresaServicioLargaDistanciaJson = JsonConvert.SerializeObject(EmpresaServicioLargaDistancia);
            File.WriteAllText(@"Datos/EmpresaServicioLargaDistancias.json", EmpresaServicioLargaDistanciaJson);
        }
    }
}


