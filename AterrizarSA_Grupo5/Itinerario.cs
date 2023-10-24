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

        

    }

    

}
