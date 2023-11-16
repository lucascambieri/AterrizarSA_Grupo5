using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Modulos
{
    public static class ItinerarioMod
    {
        public static ItinerarioEnt ItinerarioActivo { get; set; }
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
        public static ItinerarioEnt BuscarItinerario(int idItinerario)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == idItinerario)
                {
                    return itinerario;
                }
            }
            return null;
        }
        public static int ObtenerUltimoId()
        {
            int ultimoId = 0;
            foreach(var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                ultimoId = itinerario.Id;
            }
            ultimoId++;
            return ultimoId;
        }
        public static int AgregarHabitacion(HotelEnt habitacionesSelec,int cantAdultos, int cantMenores, int cantInfantes)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == ItinerarioActivo.Id)
                {
                    itinerario.HabitacionesSelec.Add(habitacionesSelec);
                    itinerario.CantAdultos += cantAdultos;
                    itinerario.CantMenores += cantMenores;
                    itinerario.CantInfantes += cantInfantes;
                    return 0;
                }
            }
            return -1;
        }
        public static int AgregarPasaje(VueloEnt pasajesSelec)
        {
            foreach (var itinerario in ItinerarioAlmacen.Itinerarios)
            {
                if (itinerario.Id == ItinerarioActivo.Id)
                {
                    itinerario.PasajesSelec.Add(pasajesSelec);
                    switch (pasajesSelec.Pasajes[0].TipoPasajero)
                    {
                        case "Adulto":
                            itinerario.CantAdultos++;
                            break;
                        case "Menor":
                            itinerario.CantMenores++;
                            break;
                        case "Infante":
                            itinerario.CantInfantes++;
                            break;
                    }
                    return 0;
                }
            }
            return -1;
        }

    }
}
