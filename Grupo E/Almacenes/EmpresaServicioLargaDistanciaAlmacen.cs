using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Grupo_E.Almacenes
{

        static class EmpresaServicioLargaDistanciaAlmacen
        {
            public static List<EmpresaServicioLargaDistanciaEntidad> EmpresaServicioLargaDistancia { get; }

            static EmpresaServicioLargaDistanciaAlmacen()
            {
                if (File.Exists("EmpresaServicioLargaDistancias.json"))
                {
                    var EmpresaServicioLargaDistanciaJson = File.ReadAllText("EmpresaServicioLargaDistancias.json");
                    EmpresaServicioLargaDistancia = System.Text.Json.JsonSerializer.Deserialize<List<EmpresaServicioLargaDistanciaEntidad>>(EmpresaServicioLargaDistanciaJson) ?? new List<EmpresaServicioLargaDistanciaEntidad>();
                }
            }

            public static void Grabar()
            {
                var EmpresaServicioLargaDistanciaJson = System.Text.Json.JsonSerializer.Serialize(EmpresaServicioLargaDistancia);
                File.WriteAllText("EmpresaServicioLargaDistancias.json", EmpresaServicioLargaDistanciaJson);
            }
        }
}
