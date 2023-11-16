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
    internal class ListadoHotelesModel
    {
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
        public DateTime FechaInicioDisp {  get; set; }
        public DateTime FechaFinDisp { get; set; }
        public int CantidadAdultosSelec {  get; set; }
        public int CantidadMenoresSelec {  get; set; }
        public int CantidadInfantesSelec { get; set; }

        public ListadoHotelesModel(int idHotel, string codHotel, string nombre, string ciudad, string calificacion, string direccion, int idHabitacion, string descripcion, int capacidadMaxima, int camasAdultos, int camasMenores, int camasInfantes, double precioNoche, DateTime fechaInic, DateTime fechaFin)
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
            this.FechaInicioDisp = fechaInic;
            this.FechaFinDisp = fechaFin;
        }

        public ListadoHotelesModel()
        {

        }
        public List<ListadoHotelesModel> ListarHabitaciones()
        {
            List<ListadoHotelesModel> listaHabitaciones = new List<ListadoHotelesModel>();
            foreach (var hotel in InventarioMod.ListarHoteles())
            {
                foreach( var habitacion in hotel.Habitaciones)
                {
                    foreach (var disponibilidad in habitacion.Disponibilidad)
                    {
                        ListadoHotelesModel habitacionModel = new ListadoHotelesModel(hotel.IdHotel, hotel.CodHotel, hotel.Nombre, hotel.Ciudad, hotel.Calificacion, hotel.Direccion, habitacion.IdHabitacion, habitacion.Descripcion, habitacion.CapacidadMaxima, habitacion.CantidadCamasAdultos, habitacion.CantidadCamasMenores, habitacion.CantidadCamasInfantes, habitacion.PrecioNoche, disponibilidad.FechaInicioDisp, disponibilidad.FechaFinDisp);
                        listaHabitaciones.Add(habitacionModel);
                    }
                }
            }

            return listaHabitaciones;
        }
        public int Guardarhabitacion()
        {
            // Valido si la fecha elegida es menor a la que tiene el itinerario, la guardo.
            if(this.FechaInicioDisp < ItinerarioMod.ItinerarioActivo.FechaInicio || ItinerarioMod.ItinerarioActivo.FechaInicio.Date == DateTime.Parse("0001-01-01"))
            {
                ItinerarioMod.ItinerarioActivo.FechaInicio = this.FechaInicioDisp;
            }
            HotelEnt hotelSeleccionado = new HotelEnt();
            HabitacionEnt habitacionSeleccionada = new HabitacionEnt();
            DisponibilidadHabitacionEnt disponibilidadSeleccionada = new DisponibilidadHabitacionEnt();

            hotelSeleccionado.IdHotel = this.IdHotel;
            hotelSeleccionado.CodHotel = this.CodHotel;
            hotelSeleccionado.Nombre = this.Nombre;
            hotelSeleccionado.Ciudad = this.Ciudad;
            hotelSeleccionado.Calificacion = this.Calificacion;
            hotelSeleccionado.Direccion = this.Direccion;
            habitacionSeleccionada.IdHabitacion = this.IdHabitacion;
            habitacionSeleccionada.Descripcion = this.Descripcion;
            habitacionSeleccionada.CapacidadMaxima = this.CapacidadMaxima;
            habitacionSeleccionada.CantidadCamasAdultos = this.CantidadCamasAdultos;
            habitacionSeleccionada.CantidadCamasMenores = this.CantidadCamasMenores;
            habitacionSeleccionada.CantidadCamasInfantes = this.CantidadCamasInfantes;
            habitacionSeleccionada.PrecioNoche = this.PrecioNoche;
            disponibilidadSeleccionada.FechaInicioDisp = this.FechaInicioDisp;
            disponibilidadSeleccionada.FechaFinDisp = this.FechaFinDisp;
            List<DisponibilidadHabitacionEnt> listaDisponibilidadHabitacion = new List<DisponibilidadHabitacionEnt>() { disponibilidadSeleccionada };
            habitacionSeleccionada.Disponibilidad = listaDisponibilidadHabitacion;
            List<HabitacionEnt> listaHabitacionAgregar = new List<HabitacionEnt>() { habitacionSeleccionada };
            hotelSeleccionado.Habitaciones = listaHabitacionAgregar;
            int result = ItinerarioMod.AgregarHabitacion(hotelSeleccionado,this.CantidadAdultosSelec,this.CantidadMenoresSelec,this.CantidadInfantesSelec);
            return result;
        }
        public string ValidarDatosBusqueda(string cantAdultos, string cantMenores, string cantInfantes, DateTime fechaEntrada, DateTime fechaSalida, string destino)
        {
            if (cantAdultos == "0" && cantMenores == "0" && cantInfantes == "0")
            {
                return "Seleccione al menos un pasajero";
            }
            if (cantInfantes != "0" && cantAdultos == "0")
            {
                return "Los infantes deben viajar con un adulto";
            }
            if (fechaSalida < fechaEntrada)
            {
                return "La fecha de salida no puede ser inferior a la de entrada";
            }
            if (fechaEntrada.Date < DateTime.Today)
            {
                return "La fecha de entrada no puede ser anterior a hoy";
            }
            if (destino == "")
            {
                return "Seleccione destino buscado";
            }
            return "OK";
        }
    }
}
