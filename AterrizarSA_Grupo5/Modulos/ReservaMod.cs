using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Modulos
{
    public static class ReservaMod
    {
        public static ReservaEnt ReservaDelItinerarioActivo {  get; set; }
        public static void CrearReserva()
        {
            int reservaId = 0;
            foreach(var reserva in ReservasAlmacen.Reservas)
            {
                if(reserva != null)
                {
                    if (reserva.IdItinerario == ItinerarioMod.ItinerarioActivo.Id)
                    {
                        ReservaDelItinerarioActivo = reserva;
                    }
                    reservaId = reserva.IdReserva;
                }
            }
            if(ReservaDelItinerarioActivo == null)
            {
                ReservaEnt nuevaReserva = new ReservaEnt();
                nuevaReserva.IdReserva = reservaId + 1;
                nuevaReserva.IdItinerario = ItinerarioMod.ItinerarioActivo.Id;
                nuevaReserva.PasajeroPorHabitacion = new List<PasajerosPorHabitacionEnt>();
                nuevaReserva.EstadoReserva = "Creada";
                nuevaReserva.EstadoPago = "Pendiente";
                ReservasAlmacen.Reservas.Add(nuevaReserva);
                ReservaDelItinerarioActivo = nuevaReserva;
            }
        }
        public static List<PasajeroEnt> PasajerosPorHabitacion(int habitacionSelec)
        {
            List<PasajeroEnt> pasajeros = new List<PasajeroEnt>();
            if (ReservaDelItinerarioActivo != null) { 
                foreach(var hotel in ReservaDelItinerarioActivo.PasajeroPorHabitacion)
                {
                    foreach(var hab in hotel.HotelHabitacion.Habitaciones)
                    {
                        if (hab.IdHabitacion == habitacionSelec)
                        {
                            foreach (var pasajero in hotel.Pasajeros)
                            {
                                pasajeros.Add(pasajero);
                            }
                        }
                    }
                    
                }
            }
            return pasajeros;
        }
        public static int AgregarPasajero(PasajeroEnt nuevoPasajero, HotelEnt habitacionSelec)
        {
            PasajerosPorHabitacionEnt pasajeroPorHabitacion = new PasajerosPorHabitacionEnt();
            if (ReservaDelItinerarioActivo.PasajeroPorHabitacion.Count == 0)
            {
                pasajeroPorHabitacion.HotelHabitacion = habitacionSelec;
                if (pasajeroPorHabitacion.Pasajeros == null)
                {
                    List<PasajeroEnt> listaNuevoPasajero = new List<PasajeroEnt>() { nuevoPasajero };
                    pasajeroPorHabitacion.Pasajeros = listaNuevoPasajero;
                }
                else
                {
                    pasajeroPorHabitacion.Pasajeros.Add(nuevoPasajero);
                }
                ReservaDelItinerarioActivo.PasajeroPorHabitacion.Add(pasajeroPorHabitacion);
                return 0;
            }
            else
            {
                foreach (var hotel in ReservaDelItinerarioActivo.PasajeroPorHabitacion)
                {
                    if(hotel.HotelHabitacion.IdHotel == habitacionSelec.IdHotel)
                    {
                        foreach (var hab in hotel.HotelHabitacion.Habitaciones)
                        {
                            if (hab.IdHabitacion == habitacionSelec.Habitaciones[0].IdHabitacion)
                            {
                                hotel.Pasajeros.Add(nuevoPasajero);
                                return 0;
                            }
                        }
                    }
                }
            }
            pasajeroPorHabitacion.HotelHabitacion = habitacionSelec;
            if (pasajeroPorHabitacion.Pasajeros == null)
            {
                List<PasajeroEnt> listaNuevoPasajero = new List<PasajeroEnt>() { nuevoPasajero };
                pasajeroPorHabitacion.Pasajeros = listaNuevoPasajero;
            }
            else
            {
                pasajeroPorHabitacion.Pasajeros.Add(nuevoPasajero);
            }
            ReservaDelItinerarioActivo.PasajeroPorHabitacion.Add(pasajeroPorHabitacion);
            return 0;
        }
        public static int QuitarPasajero(int eliminarPasajero, HotelEnt habitacionSelec)
        {
            foreach (var hotel in ReservaDelItinerarioActivo.PasajeroPorHabitacion)
            {
                // Revisar, si hay dos habitaciones con el mismo ID
                if (hotel.HotelHabitacion.IdHotel == habitacionSelec.IdHotel)
                {
                    foreach (var hab in hotel.HotelHabitacion.Habitaciones)
                    {
                        if (hab.IdHabitacion == habitacionSelec.Habitaciones[0].IdHabitacion)
                        {
                            foreach (var pasajero in hotel.Pasajeros)
                            {
                                if (pasajero.DNI == eliminarPasajero)
                                {
                                    hotel.Pasajeros.Remove(pasajero);
                                    return 0;
                                }
                            }
                        }
                    }
                    
                }
            }
            return -1;

        }
    }
}
