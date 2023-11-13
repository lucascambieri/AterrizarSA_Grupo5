using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public double PrecioNoche { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public double TarifaTotalHotel { get; set; }

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
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string TipoPasajero { get; set; }
        public int CantidadElegida { get; set; }
        public double TarifaTotalVuelo { get; set; }

        // Model Habitacion
        public VerItinerarioModel(int idHotel, string codHotel, string nombre, string ciudad, string calificacion, string direccion, int idHabitacion, string descripcion, int capacidadMaxima, int camasAdultos, int camasMenores, int camasInfantes, double precioNoche, DateTime fechaInic, DateTime fechaFin, double tarifaTotalHotel)
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
            this.TarifaTotalHotel = tarifaTotalHotel;
        }
        
        // Model Pasaje
        public VerItinerarioModel(int idVuelo, string origen, string destino, string paradas, DateTime fechaPartida, DateTime fechaLlegada, string timepoViaje, string aerolinea, int idPasaje, string categoria, double precio, string tipoPasajero, int cantidadElegida, double tarifaTotalVuelo)
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
            this.TarifaTotalVuelo = tarifaTotalVuelo;
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
                        // Falta acomodar que la tarifa sea la suma de los precios de las habitaciones
                        VerItinerarioModel habitacionModel = new VerItinerarioModel(seleccion.IdHotel, seleccion.CodHotel, seleccion.Nombre, seleccion.Ciudad, seleccion.Calificacion, seleccion.Direccion, habitacion.IdHabitacion, habitacion.Descripcion, habitacion.CapacidadMaxima, habitacion.CantidadCamasAdultos, habitacion.CantidadCamasMenores, habitacion.CantidadCamasInfantes, habitacion.PrecioNoche, habitacion.Disponibilidad[0].FechaInicioDisp, habitacion.Disponibilidad[0].FechaFinDisp, ItinerarioMod.ItinerarioActivo.TarifaTotal);
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
                foreach (var vuelo in ItinerarioMod.ItinerarioActivo.PasajesSelec)
                {
                    foreach (var pasaje in vuelo.Pasajes)
                    {
                        // Falta acomodar que la tarifa sea la suma de los precios de los pasajes
                        // Falta acomodar cantidad disponible / elegida
                        VerItinerarioModel vueloModel = new VerItinerarioModel(vuelo.IdVuelo, vuelo.Origen, vuelo.Destino, vuelo.Paradas, vuelo.FechayHoraPartida, vuelo.FechayHoraLlegada, vuelo.TiempoViaje, vuelo.Aerolinea, pasaje.IdPasaje, pasaje.Categoria, pasaje.Precio, pasaje.TipoPasajero, pasaje.CantidadDisponible, ItinerarioMod.ItinerarioActivo.TarifaTotal);
                        listaVuelos.Add(vueloModel);
                    }
                }
            }
            return listaVuelos;
        }


    }
}
