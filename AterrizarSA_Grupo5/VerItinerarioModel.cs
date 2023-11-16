using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5
{
    internal class VerItinerarioModel
    {
        // Habitaciones
        public int IdHotel { get; set; }
        public string CodHotel { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Calificacion { get; set; }
        public string Direccion { get; set; }
        public int IdHabitacion { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadMaxima { get; set; }
        public int CantidadCamasAdultos { get; set; }
        public int CantidadCamasMenores { get; set; }
        public int CantidadCamasInfantes { get; set; }
        public decimal PrecioNoche { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal TarifaTotalHotel { get; set; }

        // Pasajes
        public int IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Paradas { get; set; }
        public DateTime FechayHoraPartida { get; set; }
        public DateTime FechayHoraLlegada { get; set; }
        public string TiempoViaje { get; set; }
        public string Aerolinea { get; set; }
        public int IdPasaje { get; set; }
        public int IdPasajeroPasaje { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string TipoPasajero { get; set; }
        public int CantidadElegida { get; set; }
        public decimal TarifaTotalVuelo { get; set; }

        // Model Habitacion
        public VerItinerarioModel(int idHotel, string codHotel, string nombre, string ciudad, string calificacion, string direccion, int idHabitacion, string descripcion, int capacidadMaxima, int camasAdultos, int camasMenores, int camasInfantes, decimal precioNoche, DateTime fechaInic, DateTime fechaFin)
        {
            this.IdHotel = idHotel;
            this.CodHotel = codHotel;
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Calificacion = calificacion;
            this.Direccion = direccion;
            this.IdHabitacion = idHabitacion;
            this.Descripcion = descripcion;
            this.CapacidadMaxima = capacidadMaxima;
            this.CantidadCamasAdultos = camasAdultos;
            this.CantidadCamasMenores = camasMenores;
            this.CantidadCamasInfantes = camasInfantes;
            this.PrecioNoche = precioNoche;
            this.FechaDesde = fechaInic;
            this.FechaHasta = fechaFin;
        }
        
        // Model Pasaje
        public VerItinerarioModel(int idVuelo, string origen, string destino, string paradas, DateTime fechaPartida, DateTime fechaLlegada, string timepoViaje, string aerolinea, int idPasaje, string categoria, decimal precio, string tipoPasajero, int cantidadElegida, int idPasajeroPasaje)
        {
            this.IdVuelo = idVuelo;
            this.Origen = origen;
            this.Destino = destino;
            this.Paradas = paradas;
            this.FechayHoraPartida = fechaPartida;
            this.FechayHoraLlegada = fechaLlegada;
            this.TiempoViaje = timepoViaje;
            this.Aerolinea = aerolinea;
            this.IdPasaje = idPasaje;
            this.Categoria = categoria;
            this.Precio = precio;
            this.TipoPasajero = tipoPasajero;
            this.CantidadElegida = cantidadElegida;
            this.IdPasajeroPasaje = idPasajeroPasaje;
        }
        public VerItinerarioModel()
        {

        }

        public List<VerItinerarioModel> ListarHabitacionesSeleccionadas()
        {
            List<VerItinerarioModel> listaHabitaciones = new List<VerItinerarioModel>();
            if (ItinerarioMod.ItinerarioActivo.HabitacionesSelec != null)
            {
                foreach (var seleccion in ItinerarioMod.ItinerarioActivo.HabitacionesSelec)
                {
                    foreach (var habitacion in seleccion.Habitaciones)
                    {
                        VerItinerarioModel habitacionModel = new VerItinerarioModel(seleccion.IdHotel, seleccion.CodHotel, seleccion.Nombre, seleccion.Ciudad, seleccion.Calificacion, seleccion.Direccion, habitacion.IdHabitacion, habitacion.Descripcion, habitacion.CapacidadMaxima, habitacion.CantidadCamasAdultos, habitacion.CantidadCamasMenores, habitacion.CantidadCamasInfantes, habitacion.PrecioNoche, habitacion.Disponibilidad[0].FechaInicioDisp, habitacion.Disponibilidad[0].FechaFinDisp);
                        listaHabitaciones.Add(habitacionModel);
                    }

                }
            }
            return listaHabitaciones;
        }
        public List<VerItinerarioModel> ListarPasajesSeleccionados()
        {
            List<VerItinerarioModel> listaVuelos = new List<VerItinerarioModel>();
            if(ItinerarioMod.ItinerarioActivo.PasajesSelec != null)
            {
                int idPasajeroPasaje = 0;
                int j = 0;
                List<PasajerosPorPasajeEnt> listaPasajerosPasajes = ReservaMod.PasajerosPorPasajes();
                foreach (var vuelo in ItinerarioMod.ItinerarioActivo.PasajesSelec)
                {
                    foreach (var pasaje in vuelo.Pasajes)
                    {
                        //int ultimoid = ReservaMod.ObtenerUltimoIdPasajeroPasaje();
                        if(listaPasajerosPasajes.Count == 0)
                        //if (ultimoid == 0)
                        {
                            idPasajeroPasaje++;
                            VerItinerarioModel vueloModel = new VerItinerarioModel(vuelo.IdVuelo, vuelo.Origen, vuelo.Destino, vuelo.Paradas, vuelo.FechayHoraPartida, vuelo.FechayHoraLlegada, vuelo.TiempoViaje, vuelo.Aerolinea, pasaje.IdPasaje, pasaje.Categoria, pasaje.Precio, pasaje.TipoPasajero, pasaje.CantidadDisponible, idPasajeroPasaje);
                            listaVuelos.Add(vueloModel);
                            VueloEnt vueloPasaje = new VueloEnt();
                            PasajeEnt pasajeTemp = new PasajeEnt();
                            vueloPasaje.IdVuelo = vueloModel.IdVuelo;
                            vueloPasaje.Origen = vueloModel.Origen;
                            vueloPasaje.Destino = vueloModel.Destino;
                            vueloPasaje.Paradas = vueloModel.Paradas;
                            vueloPasaje.FechayHoraPartida = vueloModel.FechayHoraPartida;
                            vueloPasaje.FechayHoraLlegada = vueloModel.FechayHoraLlegada;
                            vueloPasaje.TiempoViaje = vueloModel.TiempoViaje;
                            vueloPasaje.Aerolinea = vueloModel.Aerolinea;
                            pasajeTemp.IdPasaje = vueloModel.IdPasaje;
                            pasajeTemp.Categoria = vueloModel.Categoria;
                            pasajeTemp.Precio = vueloModel.Precio;
                            pasajeTemp.TipoPasajero = vueloModel.TipoPasajero;
                            List<PasajeEnt> listaPasajeTemp = new List<PasajeEnt>() { pasajeTemp };
                            vueloPasaje.Pasajes = listaPasajeTemp;
                            ReservaMod.CrearPasajeroVuelo(idPasajeroPasaje,vueloPasaje);
                        }
                        else
                        {
                            PasajerosPorPasajeEnt pasajeroPasaje = listaPasajerosPasajes[j];
                            VerItinerarioModel vueloModel = new VerItinerarioModel(vuelo.IdVuelo, vuelo.Origen, vuelo.Destino, vuelo.Paradas, vuelo.FechayHoraPartida, vuelo.FechayHoraLlegada, vuelo.TiempoViaje, vuelo.Aerolinea, pasaje.IdPasaje, pasaje.Categoria, pasaje.Precio, pasaje.TipoPasajero, pasaje.CantidadDisponible, pasajeroPasaje.IdPasajeroPasaje);
                            listaVuelos.Add(vueloModel);
                        }
                    }
                    j++;
                }
            }
            return listaVuelos;
        }
        public void ActivarPasajeSeleccionado()
        {
            VueloEnt vueloSeleccionado = new VueloEnt();
            PasajeEnt pasajeSeleccionado = new PasajeEnt();
            PasajerosPorPasajeEnt vueloPasajero = new PasajerosPorPasajeEnt();
            vueloSeleccionado.IdVuelo = this.IdVuelo;
            vueloSeleccionado.Origen = this.Origen;
            vueloSeleccionado.Destino = this.Destino;
            vueloSeleccionado.Paradas = this.Paradas;
            vueloSeleccionado.FechayHoraPartida = this.FechayHoraPartida;
            vueloSeleccionado.FechayHoraLlegada = this.FechayHoraLlegada;
            vueloSeleccionado.TiempoViaje = this.TiempoViaje;
            vueloSeleccionado.Aerolinea = this.Aerolinea;
            pasajeSeleccionado.IdPasaje = this.IdPasaje;
            pasajeSeleccionado.Categoria = this.Categoria;
            pasajeSeleccionado.Precio = this.Precio;
            pasajeSeleccionado.TipoPasajero = this.TipoPasajero;
            List<PasajeEnt> listaPasajeSeleccionado = new List<PasajeEnt>() { pasajeSeleccionado };
            vueloSeleccionado.Pasajes = listaPasajeSeleccionado;
            vueloPasajero.VueloPasaje = vueloSeleccionado;
            vueloPasajero.IdPasajeroPasaje = this.IdPasajeroPasaje;
            ReservaMod.VueloSeleccionado = vueloPasajero;
        }
        public int RevisarPasajeroCargado()
        {
            return ReservaMod.RevisarPasajeroCargadoVuelo(this.IdVuelo, this.IdPasaje, this.IdPasajeroPasaje);
        }
        public int QuitarPasajero()
        {
            return ReservaMod.QuitarPasajeroVuelo(this.IdVuelo,this.IdPasaje);
        }
        public void CrearReserva()
        {
            ReservaMod.CrearReserva();
        }
        public string ValidarPasajerosCargados()
        {
            string resVuelo = "";
            string resHotel = "";
            int i = ReservaMod.ValidarPasajerosCargadosVuelo();
            if(i != 0)
            {
                resVuelo = "Faltan cargar pasajeros en los vuelos";
            }
            int j = ReservaMod.ValidarPasajerosCargadosHotel();
            if(j != 0)
            {
                resHotel = "Faltan cargar pasajeros en los hoteles";
            }
            if(i+j == 0)
            {
                return "OK";
            }
            else
            {
                return resVuelo + "\n" + resHotel;
            }
            
        }
        public string GenerarPreReserva()
        {
            if(ReservaMod.GenerarPreReserva() == 0)
            {
                return "OK";
            }
            return "Error";
        }
        public string QuitarPasaje()
        {
            VueloEnt vueloSeleccionado = new VueloEnt();
            PasajeEnt pasajeSeleccionado = new PasajeEnt();
            vueloSeleccionado.IdVuelo = this.IdVuelo;
            vueloSeleccionado.Aerolinea = this.Aerolinea;
            vueloSeleccionado.Origen = this.Origen;
            vueloSeleccionado.Destino = this.Destino;
            vueloSeleccionado.Paradas = this.Paradas;
            vueloSeleccionado.TiempoViaje = this.TiempoViaje;
            vueloSeleccionado.FechayHoraPartida = this.FechayHoraPartida;
            vueloSeleccionado.FechayHoraLlegada = this.FechayHoraLlegada;
            pasajeSeleccionado.IdPasaje = this.IdPasaje;
            pasajeSeleccionado.Categoria = this.Categoria;
            pasajeSeleccionado.Precio = this.Precio;
            pasajeSeleccionado.TipoPasajero = this.TipoPasajero;
            List<PasajeEnt> listaPasajeSeleccionado = new List<PasajeEnt>() { pasajeSeleccionado };
            vueloSeleccionado.Pasajes = listaPasajeSeleccionado;
            ItinerarioMod.QuitarPasaje(vueloSeleccionado);
            ActivarPasajeSeleccionado();
            ReservaMod.QuitarPasaje();
            return "OK";
        }
        public string QuitarHabitacion()
        {
            HotelEnt hotelEliminar = new HotelEnt();
            HabitacionEnt habitacionSeleccionada = new HabitacionEnt();
            DisponibilidadHabitacionEnt disponibilidadSeleccionada = new DisponibilidadHabitacionEnt();

            hotelEliminar.IdHotel = this.IdHotel;
            hotelEliminar.CodHotel = this.CodHotel;
            hotelEliminar.Nombre = this.Nombre;
            hotelEliminar.Ciudad = this.Ciudad;
            hotelEliminar.Calificacion = this.Calificacion;
            hotelEliminar.Direccion = this.Direccion;
            habitacionSeleccionada.IdHabitacion = this.IdHabitacion;
            habitacionSeleccionada.Descripcion = this.Descripcion;
            habitacionSeleccionada.CapacidadMaxima = this.CapacidadMaxima;
            habitacionSeleccionada.CantidadCamasAdultos = this.CantidadCamasAdultos;
            habitacionSeleccionada.CantidadCamasMenores = this.CantidadCamasMenores;
            habitacionSeleccionada.CantidadCamasInfantes = this.CantidadCamasInfantes;
            habitacionSeleccionada.PrecioNoche = this.PrecioNoche;
            disponibilidadSeleccionada.FechaInicioDisp = this.FechaDesde;
            disponibilidadSeleccionada.FechaFinDisp = this.FechaHasta;
            List<DisponibilidadHabitacionEnt> listaDisponibilidadHabitacion = new List<DisponibilidadHabitacionEnt>() { disponibilidadSeleccionada };
            habitacionSeleccionada.Disponibilidad = listaDisponibilidadHabitacion;
            List<HabitacionEnt> listaHabitacionAgregar = new List<HabitacionEnt>() { habitacionSeleccionada };
            hotelEliminar.Habitaciones = listaHabitacionAgregar;
            int cantidadAdultosSelec = 0;
            int cantidadMenoresSelec = 0;
            int cantidadInfantesSelec = 0;
            foreach (var hotel in ReservaMod.ReservaDelItinerarioActivo.PasajeroPorHabitacion)
            {
                if (hotel.HotelHabitacion.IdHotel == this.IdHotel)
                {
                    foreach (var hab in hotel.HotelHabitacion.Habitaciones)
                    {
                        if (hab.IdHabitacion == this.IdHabitacion)
                        {
                            foreach (var pasajero in hotel.Pasajeros)
                            {
                                var edad = DateTime.Today.Year - pasajero.FechaNacimiento.Year;
                                switch (edad)
                                {
                                    case >= 18:
                                        cantidadAdultosSelec++;
                                        break;
                                    case >= 2:
                                        cantidadMenoresSelec++;
                                        break;
                                    case >= 0:
                                        cantidadInfantesSelec++;
                                        break;
                                }
                            }
                        }
                    } 
                }
            }
            ItinerarioMod.QuitarHabitacion(hotelEliminar, cantidadAdultosSelec, cantidadMenoresSelec, cantidadInfantesSelec);
            ReservaMod.QuitarHabitacion(hotelEliminar);
            return "OK";
        }
    }
}
