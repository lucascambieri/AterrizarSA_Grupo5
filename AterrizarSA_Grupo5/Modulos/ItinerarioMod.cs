using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Modulos
{
    internal static class ItinerarioMod
    {
        public static string AgregarItinerario(ItinerarioEnt nuevoItinerario)
        {
            // validaciones ... (esta es de ejemplo no más, no sirve de mucho)

            foreach (var itinerario in ItinerarioAlmacen.Itinerarios) 
            {
                if(itinerario.Id == nuevoItinerario.Id)
                {
                    return "Ya existe un itinerario con ese ID";
                }
            
            }

            ItinerarioAlmacen.Itinerarios.Add(nuevoItinerario);
            return null;
        }

        public static ItinerarioEnt BuscarItinerario(int idBuscado)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == idBuscado)
                {
                    return itinerario;
                }
            }
            return null;
        }

    }
}
