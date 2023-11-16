using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5
{
    public class GestionItinerarioModel
    {
        public int NumeroItinerario { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCreado { get; set; }
        public string EstadoItinerario { get; set; }

        public GestionItinerarioModel(int numero, string nombre, DateTime fecha, string estado)
        {
            NumeroItinerario = numero;
            NombreCliente = nombre;
            FechaCreado = fecha;
            EstadoItinerario = estado;
        }

        public GestionItinerarioModel()
        {

        }

        public List<GestionItinerarioModel> ListarItinerarios()
        {
            List<GestionItinerarioModel> listaItinerarios = new List<GestionItinerarioModel>();

            foreach(var itinerario in ItinerarioMod.ListarItinerarios())
            {
                string estado = "";
                if (ItinerarioMod.ItinerarioActivo == null)
                {
                    foreach(var reserva in ReservasAlmacen.Reservas)
                    {
                        if(itinerario.Id == reserva.IdItinerario)
                        {
                            estado = "Reserva " + reserva.EstadoReserva;
                        }
                    }
                    if(estado == "")
                    {
                        estado = "Itinerario iniciado";
                    }
                }
                else
                {
                    if (itinerario.Id == ItinerarioMod.ItinerarioActivo.Id) 
                    {
                        estado = "Activo";
                    }
                    else 
                    {
                        foreach (var reserva in ReservasAlmacen.Reservas)
                        {
                            if (itinerario.Id == reserva.IdItinerario)
                            {
                                estado = "Reserva " + reserva.EstadoReserva;
                            }
                        }
                        if (estado == "")
                        {
                            estado = "Itinerario iniciado";
                        }
                    }
                }
                GestionItinerarioModel itinerarioModel = new GestionItinerarioModel(itinerario.Id,itinerario.Cliente,itinerario.FechaCreacion,estado);
                listaItinerarios.Add(itinerarioModel);
            }

            

            // Agregar un itinerario a la lista

            return listaItinerarios;
        }
        public string CrearItinerario()
        {
            int id = ItinerarioMod.ObtenerUltimoId();
            List<HotelEnt> habitacionesSelec = new List<HotelEnt>();
            List<VueloEnt> pasajesSelec = new List<VueloEnt>();
            ItinerarioEnt nuevoItinerario = new ItinerarioEnt();
            nuevoItinerario.Id = id;
            nuevoItinerario.Cliente = this.NombreCliente;
            nuevoItinerario.FechaCreacion = DateTime.Now;
            nuevoItinerario.HabitacionesSelec = habitacionesSelec;
            nuevoItinerario.PasajesSelec = pasajesSelec;
            ItinerarioMod.AgregarItinerario(nuevoItinerario);
            return null;
        }
        public ItinerarioEnt BuscarItinerario(int itinerarioBuscado)
        {
            return ItinerarioMod.BuscarItinerario(itinerarioBuscado); 
        }
        public int ActivarItinerario(ItinerarioEnt itinerario)
        {
            ItinerarioMod.ItinerarioActivo = itinerario;
            return 0;
        }
        public string ValidarEstadoReserva()
        {
            return ItinerarioMod.ValidarEstadoReserva();
        }
        public string ValidarPagoReserva()
        {
            int res = ReservaMod.ValidarPagoReserva();
            switch (res)
            {
                case 0:
                    return "OK";
                case 1:
                    return "Falta pago";
                case -1:
                    return "No existe reserva";
                case -2:
                    return "Se venció pre-reserva";
                default:
                    return "Error";
            }

        }
        public int GenerarReserva()
        {
            return ReservaMod.GenerarReserva();
        }
        public int EliminarItinerario()
        {
            int idEliminado = ItinerarioMod.EliminarItinerario();
            if (idEliminado != -1)
            {
                ReservaMod.EliminarReserva(idEliminado);
            }
            ItinerarioMod.ItinerarioActivo = null;
            ReservaMod.ReservaDelItinerarioActivo = null;
            return 0;
        }
    }
    }
