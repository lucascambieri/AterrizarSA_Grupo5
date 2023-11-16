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
    internal class InventarioMod
    {
        public static List<HotelEnt> ListarHoteles()
        {
            return InventarioAlmacen.Hoteles;
        }
        public static List<VueloEnt> ListarVuelos()
        {
            return InventarioAlmacen.Vuelos;
        }
        public static int ActualizarDisponibilidad()
        {
            // Vuelos
            List<VueloPasajeEnt> listaVuelosPasajesItinerario = new List<VueloPasajeEnt>();
            foreach(var vueloItinerario in ItinerarioMod.ItinerarioActivo.PasajesSelec)
            {
                VueloPasajeEnt vuelosPasajesItinerario = new VueloPasajeEnt();
                vuelosPasajesItinerario.IdVuelo = vueloItinerario.IdVuelo;
                vuelosPasajesItinerario.IdPasaje = vueloItinerario.Pasajes[0].IdPasaje;
                foreach(var item in listaVuelosPasajesItinerario)
                {
                    if(item.IdVuelo == vuelosPasajesItinerario.IdVuelo && item.IdPasaje == vuelosPasajesItinerario.IdPasaje)
                    {
                        vuelosPasajesItinerario.CantidadElegida++;
                    }
                    else
                    {
                        vuelosPasajesItinerario.CantidadElegida = 1;
                    }
                }
            }
            foreach(var item in listaVuelosPasajesItinerario)
            {
                foreach (var vuelo in InventarioAlmacen.Vuelos)
                {
                    foreach (var pasaje in vuelo.Pasajes)
                    {
                        if(item.IdVuelo == vuelo.IdVuelo && item.IdPasaje == pasaje.IdPasaje)
                        {
                            pasaje.CantidadDisponible -= item.CantidadElegida;
                        }
                    }
                }
            }

            // Hoteles
            List<HotelHabitacionEnt> listHotelesHabitacionesItinerario = new List<HotelHabitacionEnt>(); ;
            foreach (var hotel in ItinerarioMod.ItinerarioActivo.HabitacionesSelec)
            {
                foreach (var habitacion in hotel.Habitaciones)
                {
                    HotelHabitacionEnt hotelesHabitacionesItinerario = new HotelHabitacionEnt();
                    hotelesHabitacionesItinerario.IdHotel = hotel.IdHotel;
                    hotelesHabitacionesItinerario.IdHabitacion = habitacion.IdHabitacion;
                    hotelesHabitacionesItinerario.FechaChekIn = habitacion.Disponibilidad[0].FechaInicioDisp;
                    hotelesHabitacionesItinerario.FechaChekOut = habitacion.Disponibilidad[0].FechaFinDisp;
                    listHotelesHabitacionesItinerario.Add(hotelesHabitacionesItinerario);
                }
            }
            foreach (var item in listHotelesHabitacionesItinerario)
            {
                foreach (var hotel in InventarioAlmacen.Hoteles)
                {
                    foreach (var habitacion in hotel.Habitaciones)
                    {
                        if (item.IdHotel == hotel.IdHotel && item.IdHabitacion == habitacion.IdHabitacion)
                        {
                            foreach (var disponibilidad in habitacion.Disponibilidad)
                            {
                                if (item.FechaChekIn == disponibilidad.FechaInicioDisp && item.FechaChekOut == disponibilidad.FechaFinDisp)
                                {
                                    habitacion.Disponibilidad.Remove(disponibilidad);
                                }
                                // Si el check in y el check out no son exactamente iguales a la disponibilidad, tienen que estar dentro, si no
                                // no podrían llegar a este punto. Si están dentro particiono la disponibilidad
                                //if (item.FechaChekIn >= disponibilidad.FechaInicioDisp && item.FechaChekOut <= disponibilidad.FechaFinDisp)
                                else
                                {
                                    DisponibilidadHabitacionEnt nuevaDisponibilidad1 = new DisponibilidadHabitacionEnt();
                                    DisponibilidadHabitacionEnt nuevaDisponibilidad2 = new DisponibilidadHabitacionEnt();
                                    nuevaDisponibilidad1.FechaInicioDisp = disponibilidad.FechaInicioDisp;
                                    nuevaDisponibilidad1.FechaFinDisp = item.FechaChekIn;
                                    nuevaDisponibilidad2.FechaInicioDisp = item.FechaChekOut;
                                    nuevaDisponibilidad2.FechaFinDisp = disponibilidad.FechaFinDisp;
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }

    }
}
