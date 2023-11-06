using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    internal class InventarioEnt
    {
        public List<HotelEnt> Hoteles {  get; set; }
        public List<VueloEnt> Vuelos { get; set; }
    }
}
