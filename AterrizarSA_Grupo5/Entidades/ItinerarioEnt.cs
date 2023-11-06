using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    internal class ItinerarioEnt
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantAdultos { get; set; }
        public int CantMenores { get; set; }
        public int CantInfantes { get; set; }
        public IList<HabitacionesSelec> HabitacionesSelec { get; set; }
        public IList<PasajesSelec> PasajesSelec { get; set; }
        public double TarifaTotal { get; set; }

    }
}
