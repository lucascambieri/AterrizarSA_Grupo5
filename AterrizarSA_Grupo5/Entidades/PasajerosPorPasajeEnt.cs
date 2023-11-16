using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    public class PasajerosPorPasajeEnt
    {
        public int IdPasajeroPasaje {  get; set; }
        public VueloEnt VueloPasaje { get; set; }
        public PasajeroEnt Pasajero { get; set; }
    }
}
