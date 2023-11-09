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
        public static List<ItinerarioEnt> ListarItinerarios()
        {
            return ItinerarioAlmacen.Itinerarios;
        }
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
        public static int ActivarItinerario(int idItinerarioActivo)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == idItinerarioActivo)
                {
                    itinerario.EsActivo = true;
                    return 0;
                }
                if (itinerario.EsActivo && itinerario.Id  != idItinerarioActivo)
                {
                    itinerario.EsActivo = false;
                }
            }
            return -1;
        }
        public static int BuscarItinerarioActivo()
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.EsActivo)
                {
                    return itinerario.Id;
                }
            }
            return -1;
        }

        public static int AgregarHabitacion(int itinerarioSeleccionado, HabitacionesSelecEnt habitacionesSelec)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == itinerarioSeleccionado)
                {
                    itinerario.HabitacionesSelec.Add(habitacionesSelec);
                    return 0;
                }
            }
            return -1;
        }
        public static int AgregarPasaje(int itinerarioSeleccionado, PasajesSelecEnt pasajesSelec)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == itinerarioSeleccionado)
                {
                    itinerario.PasajesSelec.Add(pasajesSelec);
                    return 0;
                }
            }
            return -1;
        }

        public static ItinerarioEnt InformacionItinerario(int itinerarioBuscado)
        {
            foreach (ItinerarioEnt itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == itinerarioBuscado)
                {
                    return itinerario;
                }
            }
            return null;
        }

    }
}
