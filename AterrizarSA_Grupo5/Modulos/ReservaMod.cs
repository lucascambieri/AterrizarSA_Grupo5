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
    public static class ReservaMod
    {
        public static ReservaEnt ReservaDelItinerarioActivo {  get; set; }
        public static PasajerosPorPasajeEnt VueloSeleccionado { get; set; }
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
                nuevaReserva.PasajeroPorPasaje = new List<PasajerosPorPasajeEnt>();
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
        public static int AgregarPasajeroHabitacion(PasajeroEnt nuevoPasajero, HotelEnt habitacionSelec)
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
        public static int QuitarPasajeroHabitacion(int eliminarPasajero, HotelEnt habitacionSelec)
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
        public static int CrearPasajeroVuelo(int idPasajeroPasaje, VueloEnt vueloPasaje)
        {
            PasajerosPorPasajeEnt pasajeroPorPasaje = new PasajerosPorPasajeEnt();
            pasajeroPorPasaje.IdPasajeroPasaje = idPasajeroPasaje;
            pasajeroPorPasaje.VueloPasaje = vueloPasaje;
            if (ReservaDelItinerarioActivo.PasajeroPorPasaje == null)
            {
                List<PasajerosPorPasajeEnt> listaPasajeroPorPasaje = new List<PasajerosPorPasajeEnt> { pasajeroPorPasaje };
                ReservaDelItinerarioActivo.PasajeroPorPasaje = listaPasajeroPorPasaje;
            }
            else
            {
                ReservaDelItinerarioActivo.PasajeroPorPasaje.Add(pasajeroPorPasaje);
            }

            return 0;
        }
        public static int AgregarPasajeroVuelo(PasajeroEnt nuevoPasajero)
        {
            foreach (var pasajeVuelo in ReservaDelItinerarioActivo.PasajeroPorPasaje)
            {
                if(pasajeVuelo.IdPasajeroPasaje == VueloSeleccionado.IdPasajeroPasaje)
                {
                    pasajeVuelo.Pasajero = nuevoPasajero;
                }
            }
            return 0;
        }
        public static int RevisarPasajeroCargadoVuelo(int idVuelo, int idPasaje, int idPasajeroPasaje)
        {
            if (ReservaDelItinerarioActivo.PasajeroPorPasaje != null)
            {
                foreach (var pasajes in ReservaDelItinerarioActivo.PasajeroPorPasaje)
                {
                    if (pasajes.VueloPasaje.IdVuelo == idVuelo && pasajes.VueloPasaje.Pasajes[0].IdPasaje == idPasaje && pasajes.IdPasajeroPasaje == idPasajeroPasaje)
                    {
                        if (pasajes.Pasajero != null)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return 0;
        }
        public static int QuitarPasajeroVuelo(int idVuelo, int idPasaje, int idPasajeroPasaje)
        {
            if (ReservaDelItinerarioActivo.PasajeroPorPasaje != null)
            {
                foreach (var pasajes in ReservaDelItinerarioActivo.PasajeroPorPasaje)
                {
                    if (pasajes.VueloPasaje.IdVuelo == idVuelo && pasajes.VueloPasaje.Pasajes[0].IdPasaje == idPasaje && pasajes.IdPasajeroPasaje == idPasajeroPasaje)
                    {
                        if (pasajes.Pasajero != null)
                        {
                            pasajes.Pasajero = null;
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }
        public static List<PasajerosPorPasajeEnt> PasajerosPorPasajes()
        {
            List<PasajerosPorPasajeEnt> pasajeros = new List<PasajerosPorPasajeEnt>();
            if (ReservaDelItinerarioActivo != null)
            {
                foreach (var vuelo in ReservaDelItinerarioActivo.PasajeroPorPasaje)
                {
                    pasajeros.Add(vuelo);
                }
            }
            return pasajeros;
        }
        public static int ObtenerUltimoIdPasajeroPasaje()
        {
            /*
            int id = 0;
            for (int i = 0; i <= pos; i++)
            {
                try 
                {
                    id = ReservaDelItinerarioActivo.PasajeroPorPasaje[i].IdPasajeroPasaje; 
                } 
                catch 
                { 
                    id = i;
                }
            }
            return id;
            */
            int id = 0;
            foreach (var pasajePasajero in ReservaDelItinerarioActivo.PasajeroPorPasaje)
            {
                if(pasajePasajero.VueloPasaje != null)
                {
                    id = pasajePasajero.IdPasajeroPasaje;
                    id++;
                }
            }
            return id;
        }
        public static int ValidarPasajerosCargadosHotel()
        {
            if(ReservaDelItinerarioActivo == null)
            {
                return -1;
            }
            else
            {
                int i = 0;
                int j = 0;
                List<HotelHabitacionEnt> listHotelesHabitacionesItinerario = new List<HotelHabitacionEnt>(); ;
                foreach (var hotel in ItinerarioMod.ItinerarioActivo.HabitacionesSelec)
                {
                    foreach(var habitacion in hotel.Habitaciones)
                    {
                        HotelHabitacionEnt hotelesHabitacionesItinerario = new HotelHabitacionEnt();
                        hotelesHabitacionesItinerario.IdHotel = hotel.IdHotel;
                        hotelesHabitacionesItinerario.IdHabitacion = habitacion.IdHabitacion;
                        listHotelesHabitacionesItinerario.Add(hotelesHabitacionesItinerario);
                    }
                }
                foreach(var item in listHotelesHabitacionesItinerario)
                {
                    foreach (var pasajeroHabitacion in ReservaDelItinerarioActivo.PasajeroPorHabitacion)
                    {
                        foreach (var habitacion in pasajeroHabitacion.HotelHabitacion.Habitaciones)
                        {
                            if (item.IdHotel == pasajeroHabitacion.HotelHabitacion.IdHotel && item.IdHabitacion == habitacion.IdHabitacion)
                            {
                                if (pasajeroHabitacion.Pasajeros.Count >= 1)
                                {
                                    j++;
                                }
                            }
                        }
                    }
                    i++;
                }
                if (i == j)
                {
                    return 0;
                }
            }
            return -1;
        }
        public static int ValidarPasajerosCargadosVuelo()
        {
            if (ReservaDelItinerarioActivo == null)
            {
                return -1;
            }
            else
            {
                int i = 0;
                int j = 0;
                foreach (var pasajeroVuelo in ReservaDelItinerarioActivo.PasajeroPorPasaje)
                {
                    if (pasajeroVuelo.Pasajero != null)
                    {
                        j++;
                    }
                    i++;
                }
                if (i == j)
                {
                    return 0;
                }
                return -1;
            }
        }
        public static int GenerarPreReserva()
        {
            /*
             -1 no existe reserva activa
             -2 no se pudo actualizar la disponibilidad
             */
            if (ReservaDelItinerarioActivo == null)
            {
                return -1;
            }
            else
            {
                if(InventarioMod.ActualizarDisponibilidad() == 0)
                {
                    ReservaDelItinerarioActivo.FechaPreReserva = DateTime.Today;
                    ReservaDelItinerarioActivo.EstadoReserva = "Pre-reservada";
                    ReservaDelItinerarioActivo.EstadoPago = "Pendiente";
                }
                else
                {
                    return -2;
                }
                return 0;
            }
            
        }
        public static int ValidarPagoReserva()
        {
            foreach(var reserva in ReservasAlmacen.Reservas)
            {
                if(reserva.IdItinerario == ItinerarioMod.ItinerarioActivo.Id)
                {
                    if (reserva.EstadoPago == "Pendiente" && reserva.FechaPreReserva > DateTime.Today.AddDays(-2))
                    {
                        return -2;
                    }
                    else
                    {
                        if (reserva.EstadoPago == "Pendiente")
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return -1;
        }
        public static int GenerarReserva()
        {
            /*
             -1 no existe reserva activa
             -2 no se pudo confirmar la reserva
             */
            if (ReservaDelItinerarioActivo == null)
            {
                return -1;
            }
            else
            {
                if(ReservaDelItinerarioActivo.EstadoReserva == "Pre-reservada")
                {
                    ReservaDelItinerarioActivo.EstadoReserva = "Confirmada";
                }
                else
                {
                    if(ItinerarioMod.ItinerarioActivo.HabitacionesSelec.Count >= 1 && ItinerarioMod.ItinerarioActivo.PasajesSelec.Count >= 1)
                    {
                        if (ValidarPasajerosCargadosHotel() == 0 && ValidarPasajerosCargadosVuelo() == 0)
                        {
                            if (GenerarPreReserva() == 0)
                            {
                                ReservaDelItinerarioActivo.EstadoReserva = "Confirmada";
                                return 0;
                            }
                        }
                    }
                }
                return -2;
            }
        }
        public static int QuitarPasaje()
        {
            foreach (var pasajeVuelo in ReservaDelItinerarioActivo.PasajeroPorPasaje)
            {
                if (pasajeVuelo.IdPasajeroPasaje == VueloSeleccionado.IdPasajeroPasaje)
                {
                    ReservaDelItinerarioActivo.PasajeroPorPasaje.Remove(pasajeVuelo);
                    return 0;
                }
            }
            return 0;
        }
        public static int QuitarHabitacion(HotelEnt hotelHabEliminado)
        {
            foreach (var hotel in ReservaDelItinerarioActivo.PasajeroPorHabitacion)
            {
                if (hotel.HotelHabitacion.IdHotel == hotelHabEliminado.IdHotel)
                {
                    foreach (var hab in hotel.HotelHabitacion.Habitaciones)
                    {
                        if (hab.IdHabitacion == hotelHabEliminado.Habitaciones[0].IdHabitacion)
                        {
                            ReservaDelItinerarioActivo.PasajeroPorHabitacion.Remove(hotel);
                            return 0;
                        }
                    }
                }
            }
            return -1;
        }
        public static int EliminarReserva(int idItinerarioEliminado)
        {
            foreach (var reserva in ReservasAlmacen.Reservas)
            {
                if (reserva.IdItinerario == idItinerarioEliminado)
                {
                    ReservasAlmacen.Reservas.Remove(reserva);
                    return 0;
                }
            }
            return -1;
        }
    }
}
