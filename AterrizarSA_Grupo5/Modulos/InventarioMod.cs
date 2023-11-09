using AterrizarSA_Grupo5.Almacenes;
using AterrizarSA_Grupo5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Modulos
{
    internal class InventarioMod
    {
        public static List<HotelEnt> ListarHoteles()
        {
            return InventarioAlmacen.Hoteles;
        }
        public static List<VueloEnt> ListarVuelos()
        {
            return InventarioAlmacen.Vuelos;
        }
        public static HotelEnt BuscarInformacionHotel(int idHotelBuscado)
        {
            foreach (HotelEnt hotel in InventarioAlmacen.Hoteles)
            {
                if(hotel.IdHotel == idHotelBuscado)
                {
                    return hotel;
                }
            }
            return null;
        }
        public static VueloEnt BuscarInformacionVuelo(int idVueloBuscado)
        {
            foreach (VueloEnt vuelo in InventarioAlmacen.Vuelos)
            {
                if (vuelo.IdVuelo == idVueloBuscado)
                {
                    return vuelo;
                }
            }
            return null;
        }

    }
}
