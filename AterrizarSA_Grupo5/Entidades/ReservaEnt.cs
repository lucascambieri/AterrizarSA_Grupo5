using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    public class ReservaEnt
    {
        public int IdReserva {  get; set; }
        public int IdItinerario { get; set; }
        public DateTime FechaPreReserva { get; set; }
        public List<PasajerosPorHabitacionEnt> PasajeroPorHabitacion { get; set; }
        public List<PasajerosPorPasajeEnt> PasajeroPorPasaje { get; set; }
        public string EstadoPago { get; set; }
        public string EstadoReserva { get; set; }
    }
}
