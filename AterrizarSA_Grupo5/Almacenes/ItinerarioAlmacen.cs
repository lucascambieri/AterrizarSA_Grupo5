using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using Newtonsoft.Json;

namespace AterrizarSA_Grupo5.Almacenes
{
    internal static class ItinerarioAlmacen
    {
        public static List<ItinerarioEnt> Itinerarios;

        static ItinerarioAlmacen()
        {
            var itinerariosJson = File.ReadAllText("C:\\Users\\sberro\\OneDrive - Prisma Medios de Pago\\Escritorio\\Recibos\\Facultad\\CAI\\AterrizarSA_Grupo5\\AterrizarSA_Grupo5\\Almacenes\\Itinerarios.json");
            Itinerarios = JsonConvert.DeserializeObject<List<ItinerarioEnt>>(itinerariosJson);
        }

        public static void Grabar()
        {
            var itinerariosJson = JsonConvert.SerializeObject(Itinerarios);
            File.WriteAllText("C:\\Users\\sberro\\OneDrive - Prisma Medios de Pago\\Escritorio\\Recibos\\Facultad\\CAI\\AterrizarSA_Grupo5\\AterrizarSA_Grupo5\\Almacenes\\Itinerarios.json", itinerariosJson);

            Itinerarios = null;
        }


    }
}
