using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
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
        //public int CantidadCamasAdultos { get; set; }
        //public int CantidadCamasMenores { get; set; }
        //public int CantidadCamasInfantes { get; set; }
        public double PrecioNoche { get; set; }
        public DateTime FechaInicioDisp {  get; set; }
        public DateTime FechaFinDisp { get; set; }

        public ListadoHotelesModel(int idHotel, string codHotel, string nombre, string ciudad, string calificacion, string direccion, int idHabitacion, string descripcion, int capacidadMaxima, double precioNoche, DateTime fechaInic, DateTime fechaFin)
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
            this.PrecioNoche = precioNoche;
            this.FechaInicioDisp = fechaInic;
            this.FechaFinDisp = fechaFin;
        }

        public ListadoHotelesModel()
        {

        }
        public static List<ListadoHotelesModel> ListarHabitaciones()
        {
            List<ListadoHotelesModel> listaHabitaciones = new List<ListadoHotelesModel>();
            int i = 0;
            foreach (var habitacion in InventarioAlmacen.Hoteles)
            {
                foreach(var disponibilidad in habitacion.Habitaciones[i].Disponibilidad)
                {
                    ListadoHotelesModel habitacionModel = new ListadoHotelesModel(habitacion.IdHotel, habitacion.CodHotel, habitacion.Nombre, habitacion.Ciudad, habitacion.Calificacion, habitacion.Direccion, habitacion.Habitaciones[i].IdHabitacion, habitacion.Habitaciones[i].Descripcion, habitacion.Habitaciones[i].CapacidadMaxima, habitacion.Habitaciones[i].PrecioNoche, disponibilidad.FechaInicioDisp, disponibilidad.FechaFinDisp);
                    listaHabitaciones.Add(habitacionModel);
                }
                i++;
            }

            return listaHabitaciones;
        }
    }
}
