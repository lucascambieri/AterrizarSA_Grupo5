using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades.Secundarias
{
    public class HotelHabitacionEnt
    {
        public int IdHotel {  get; set; }
        public int IdHabitacion { get; set; }
        public DateTime FechaChekIn { get; set; }
        public DateTime FechaChekOut { get; set; }
        public HotelEnt HotelEntidad { get; set; }
    }
}
