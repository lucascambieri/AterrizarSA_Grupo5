using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    public class ItinerarioEnt
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantAdultos { get; set; }
        public int CantMenores { get; set; }
        public int CantInfantes { get; set; }
        public List<HotelEnt> HabitacionesSelec { get; set; }
        public List<VueloEnt> PasajesSelec { get; set; }
        public decimal TarifaTotal { get; set; }

    }
}
