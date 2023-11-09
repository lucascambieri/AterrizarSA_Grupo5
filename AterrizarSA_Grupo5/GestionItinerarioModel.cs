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
                string estado;
                if (ItinerarioMod.ItinerarioActivo == null)
                {
                    estado = "";
                }
                else
                {
                    if (itinerario.Id == ItinerarioMod.ItinerarioActivo.Id) 
                    {
                        estado = "Activo";
                    }
                    else 
                    {
                        estado = ""; 
                    }
                }
                GestionItinerarioModel itinerarioModel = new GestionItinerarioModel(itinerario.Id,itinerario.Cliente,itinerario.FechaCreacion,estado);
                listaItinerarios.Add(itinerarioModel);
            }

            

            // Agregar un itinerario a la lista

            return listaItinerarios;
        }

        public string CrearItinerario(int id, string nombreCliente, DateTime fecha)
        {
            List<HabitacionesSelecEnt> habitacionesSelec = new List<HabitacionesSelecEnt>();
            List<PasajesSelecEnt> pasajesSelec = new List<PasajesSelecEnt>();
            ItinerarioEnt nuevoItinerario = new ItinerarioEnt();
            nuevoItinerario.Id = id;
            nuevoItinerario.Cliente = nombreCliente;
            nuevoItinerario.FechaCreacion = fecha;
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

    }
    }
