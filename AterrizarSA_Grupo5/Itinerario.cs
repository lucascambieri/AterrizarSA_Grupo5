using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5
{
    public class Itinerario
    {
        public int NumeroItinerario { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaCreado { get; set; }
        public string EstadoItinerario { get; set; }

        public Itinerario(int numero, string nombre, DateTime fecha, string estado)
        {
            NumeroItinerario = numero;
            NombreCliente = nombre;
            FechaCreado = fecha;
            EstadoItinerario = estado;
        }

        public Itinerario()
        {

        }

        public static List<Itinerario> CrearItinerario()
        {
            List<Itinerario> listaItinerarios = new List<Itinerario>();

            Itinerario itinerario1 = new Itinerario(1, "Carlos Gomez", DateTime.Now, "Itinerario creado");
            Itinerario itinerario2 = new Itinerario(2, "German Puentes", DateTime.Now, "Pre-reservado");
            Itinerario itinerario3 = new Itinerario(3, "Lucía Pérez", DateTime.Now, "Pre-reservado");
            Itinerario itinerario4 = new Itinerario(4, "Julieta Pacheco", DateTime.Now, "Confirmado");


            listaItinerarios.Add(itinerario1);
            listaItinerarios.Add(itinerario2);
            listaItinerarios.Add(itinerario3);
            listaItinerarios.Add(itinerario4);

            // Agregar un itinerario a la lista

            return listaItinerarios;
        }
    }
    }
