using AterrizarSA_Grupo5.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Almacenes
{
    internal class InventarioAlmacen
    {
        public static List<InventarioEnt> Inventario;
        public static List<HotelEnt> Hoteles;
        public static List<VueloEnt> Vuelos;

        static InventarioAlmacen()
        {
            var inventarioJson = File.ReadAllText("Inventario.json");
            // revisar como dividir el json para que los hoteles se guarden en la lista de entidad de hoteles
            // y los vuelos en las listas de entidad de vuelos
            Inventario = JsonConvert.DeserializeObject<List<InventarioEnt>>(inventarioJson);
            Hoteles = Inventario[0];
        }

        public static void Grabar()
        {
            // Revisar como hacer para guardarlos después
            var inventarioJson = JsonConvert.SerializeObject(Hoteles);
            File.WriteAllText("Inventario.json", inventarioJson);

            Hoteles = null;
        }
    }
}
