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

        public int GuardarHabitacion(HabitacionesSelecEnt habitacionesSeleccionadas)
        {
            int result = ItinerarioMod.AgregarHabitacion(ItinerarioMod.ItinerarioActivo,habitacionesSeleccionadas);
            return result;
        }
    }
}
