using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AterrizarSA_Grupo5
{
    internal class NuevoPasajeroVueloModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public NuevoPasajeroVueloModel()
        {

        }
        //public void CrearReserva()
        //{
        //    ReservaMod.CrearReserva();
        //}
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
        public int ValidarDisponibilidad(string tipoPasajero)
        {
            if(tipoPasajero == ReservaMod.VueloSeleccionado.VueloPasaje.Pasajes[0].TipoPasajero)
            {
                return 0;
            }
            return -1;
        }
        public int AgregarPasajero()
        {
            PasajeroEnt nuevoPasajero = new PasajeroEnt();
            nuevoPasajero.Nombre = this.Nombre;
            nuevoPasajero.Apellido = this.Apellido;
            nuevoPasajero.DNI = int.Parse(this.DNI);
            nuevoPasajero.FechaNacimiento = this.FechaNacimiento;
            return ReservaMod.AgregarPasajeroVuelo(nuevoPasajero);
        }
    }
}
