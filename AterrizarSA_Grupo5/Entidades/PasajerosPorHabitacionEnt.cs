using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    public class PasajerosPorHabitacionEnt
    {
        public HotelEnt HotelHabitacion { get; set; }
        public List<PasajeroEnt> Pasajeros { get; set; }
    }
}
