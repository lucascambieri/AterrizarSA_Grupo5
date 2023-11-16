using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Entidades.Secundarias;
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
            // Valido que esa habitación no exista en las habitaciones del itinerario
            List<HotelHabitacionEnt> listaHotelHabitacion = new List<HotelHabitacionEnt>();
            foreach (var hotel in ItinerarioActivo.HabitacionesSelec)
            {
                foreach(var habitacion in hotel.Habitaciones)
                {
                    HotelHabitacionEnt hotelHabitacion = new HotelHabitacionEnt();
                    hotelHabitacion.IdHotel = hotel.IdHotel;
                    hotelHabitacion.IdHabitacion = habitacion.IdHabitacion;
                    listaHotelHabitacion.Add(hotelHabitacion);
                }
            }
            foreach (var item in listaHotelHabitacion)
            {
                foreach (var hotel in ItinerarioActivo.HabitacionesSelec)
                {
                    foreach (var habitacion in hotel.Habitaciones)
                    {
                        if (item.IdHotel == hotel.IdHotel && item.IdHabitacion == habitacion.IdHabitacion)
                            // Ya tiene esta habitación asignada
                            return -2;
                    }

                }
            }
            
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
        public static string ValidarEstadoReserva()
        {
            foreach(var reserva in ReservasAlmacen.Reservas)
            {
                if(ItinerarioActivo.Id == reserva.IdItinerario)
                {
                    //if (reserva.EstadoReserva == "Pre-reservada" || reserva.EstadoReserva == "Confirmada")
                    //{
                    //    return "Tiene";
                    //}
                    return reserva.EstadoReserva;
                }
            }
            return "No hay reserva";
        }

    }
}
