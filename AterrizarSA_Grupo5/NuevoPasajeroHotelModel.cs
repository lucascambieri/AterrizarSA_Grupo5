using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5
{
    internal class NuevoPasajeroHotelModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DisponibilidadAdultos { get; set; }
        public int DisponibilidadMenores { get; set; }
        public int DisponibilidadInfantes { get; set; }
        public int AdultosAgregados { get; set; }
        public int MenoresAgregados { get; set; }
        public int InfantesAgregados { get; set; }

        // HotelHabitacion
        public int IdHotel { get; set; }
        public string CodHotel { get; set; }
        public string NombreHotel { get; set; }
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

        public NuevoPasajeroHotelModel() 
        { 
        
        }
        public string ValidarDatos()
        {
            // Nombre
            if (string.IsNullOrEmpty(Nombre))
            {
                return "Debe ingresar un nombre";
            }
            if (Nombre.Length > 50)
            {
                return "El nombre no debe superar los 50 caracteres";
            }
            // Solo letras
            if (!(Regex.IsMatch(Nombre, @"^[a-zA-Z]+$")))
            {
                return "Nombre: solo puede ingresar letras";
            }

            // Apellido
            if (string.IsNullOrEmpty(Apellido))
            {
                return "Debe ingresar un apellido";
            }
            if (Apellido.Length > 50)
            {
                return "El apellido no debe superar los 50 caracteres";
            }
            // Solo letras
            if (!(Regex.IsMatch(Apellido, @"^[a-zA-Z]+$")))
            {
                return "Apellido: solo puede ingresar letras";
            }

            //DNI
            if (!int.TryParse(DNI, out int dniValidado))
            {
                return "El DNI ingresado no es válido";
            }
            if (!(dniValidado >= 1000000 && dniValidado <= 99999999))
            {
                return "El DNI debe estar entre 1000000 y 99999999";
            }

            //Fecha nacimiento
            if (FechaNacimiento.Date >= DateTime.Today)
            {
                return "La fecha de nacimiento debe ser anterior a hoy";
            }
            return "OK";
        }
        //public void CrearReserva()
        //{
        //    ReservaMod.CrearReserva();
        //}
        public List<PasajeroEnt> ListarPasajerosPorHabitacion(int habitacionSelec)
        {
            List<PasajeroEnt> pasajeros = ReservaMod.PasajerosPorHabitacion(habitacionSelec);
            return pasajeros;
        }
        public List<HotelEnt> ListarHabitacionesDelItinerario()
        {
            List<HotelEnt> listaHabitaciones = new List<HotelEnt>();
            listaHabitaciones = ItinerarioMod.ItinerarioActivo.HabitacionesSelec;
            return listaHabitaciones;
        }
        public int AgregarPasajero()
        {
            PasajeroEnt nuevoPasajero = new PasajeroEnt();
            nuevoPasajero.Nombre = this.Nombre;
            nuevoPasajero.Apellido = this.Apellido;
            nuevoPasajero.DNI = int.Parse(this.DNI);
            nuevoPasajero.FechaNacimiento = this.FechaNacimiento;

            HotelEnt hotelHabitacionAgregar = new HotelEnt();
            HabitacionEnt habitacionAgregar = new HabitacionEnt();
            DisponibilidadHabitacionEnt disponibilidadHabitacion = new DisponibilidadHabitacionEnt();

            hotelHabitacionAgregar.IdHotel = this.IdHotel;
            hotelHabitacionAgregar.CodHotel = this.CodHotel;
            hotelHabitacionAgregar.Nombre = this.Nombre;
            hotelHabitacionAgregar.Ciudad = this.Ciudad;
            hotelHabitacionAgregar.Calificacion = this.Calificacion;
            hotelHabitacionAgregar.Direccion = this.Direccion;
            habitacionAgregar.IdHabitacion = this.IdHabitacion;
            habitacionAgregar.Descripcion = this.Descripcion;
            habitacionAgregar.CapacidadMaxima = this.CapacidadMaxima;
            habitacionAgregar.CantidadCamasAdultos = this.CantidadCamasAdultos;
            habitacionAgregar.CantidadCamasMenores = this.CantidadCamasMenores;
            habitacionAgregar.CantidadCamasInfantes = this.CantidadCamasInfantes;
            habitacionAgregar.PrecioNoche = this.PrecioNoche;
            disponibilidadHabitacion.FechaInicioDisp = this.FechaDesde;
            disponibilidadHabitacion.FechaFinDisp = this.FechaHasta;
            List<DisponibilidadHabitacionEnt> listaDisponibilidadHabitacion = new List<DisponibilidadHabitacionEnt>() { disponibilidadHabitacion };
            habitacionAgregar.Disponibilidad = listaDisponibilidadHabitacion;
            List<HabitacionEnt> listaHabitacionAgregar = new List<HabitacionEnt>() { habitacionAgregar };
            hotelHabitacionAgregar.Habitaciones = listaHabitacionAgregar;

            return ReservaMod.AgregarPasajeroHabitacion(nuevoPasajero, hotelHabitacionAgregar);
        }
        public int QuitarPasajero(int eliminarPasajero)
        {
            HotelEnt hotelHabitacionAgregar = new HotelEnt();
            HabitacionEnt habitacionAgregar = new HabitacionEnt();
            DisponibilidadHabitacionEnt disponibilidadHabitacion = new DisponibilidadHabitacionEnt();

            hotelHabitacionAgregar.IdHotel = this.IdHotel;
            hotelHabitacionAgregar.CodHotel = this.CodHotel;
            hotelHabitacionAgregar.Nombre = this.Nombre;
            hotelHabitacionAgregar.Ciudad = this.Ciudad;
            hotelHabitacionAgregar.Calificacion = this.Calificacion;
            hotelHabitacionAgregar.Direccion = this.Direccion;
            habitacionAgregar.IdHabitacion = this.IdHabitacion;
            habitacionAgregar.Descripcion = this.Descripcion;
            habitacionAgregar.CapacidadMaxima = this.CapacidadMaxima;
            habitacionAgregar.CantidadCamasAdultos = this.CantidadCamasAdultos;
            habitacionAgregar.CantidadCamasMenores = this.CantidadCamasMenores;
            habitacionAgregar.CantidadCamasInfantes = this.CantidadCamasInfantes;
            habitacionAgregar.PrecioNoche = this.PrecioNoche;
            disponibilidadHabitacion.FechaInicioDisp = this.FechaDesde;
            disponibilidadHabitacion.FechaFinDisp = this.FechaHasta;
            List<DisponibilidadHabitacionEnt> listaDisponibilidadHabitacion = new List<DisponibilidadHabitacionEnt>() { disponibilidadHabitacion };
            habitacionAgregar.Disponibilidad = listaDisponibilidadHabitacion;
            List<HabitacionEnt> listaHabitacionAgregar = new List<HabitacionEnt>() { habitacionAgregar };
            hotelHabitacionAgregar.Habitaciones = listaHabitacionAgregar;
            return ReservaMod.QuitarPasajeroHabitacion(eliminarPasajero, hotelHabitacionAgregar);
        }
        public int CargarDisponibilidades()
        {
            this.DisponibilidadAdultos = (this.CantidadCamasAdultos * 2) - this.AdultosAgregados;
            this.DisponibilidadMenores = this.CantidadCamasMenores - this.MenoresAgregados;
            this.DisponibilidadInfantes = this.CantidadCamasInfantes - this.InfantesAgregados;
            return 0;
        }
        public int ValidarDisponibilidad(string tipoPasajero)
        {
            switch (tipoPasajero)
            {
                case "Adulto":
                    if (this.DisponibilidadAdultos >= 1)
                    {
                        return 0;
                    }
                    break;
                case "Menor":
                    if (this.DisponibilidadMenores >= 1)
                    {
                        return 0;
                    }
                    break;
                case "Infante":
                    if (this.DisponibilidadInfantes >= 1)
                    {
                        return 0;
                    }
                    break;
            }
            return -1;
        }
        public int RestarDisponibilidad(string tipoPasajero)
        {
            switch (tipoPasajero)
            {
                case "Adulto":
                    this.DisponibilidadAdultos--;
                    break;
                case "Menor":
                    this.DisponibilidadMenores--;
                    break;
                case "Infante":
                    this.DisponibilidadInfantes--;
                    break;
            }
            return 0;
        }
        public int ActualizarDisponibilidad(string tipoPasajero)
        {
            switch (tipoPasajero)
            {
                case "Adulto":
                    this.DisponibilidadAdultos++;
                    break;
                case "Menor":
                    this.DisponibilidadMenores++;
                    break;
                case "Infante":
                    this.DisponibilidadInfantes++;
                    break;
            }
            return 0;
        }
    }
}
