using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    public class PasajeEnt
    {
        public int IdPasaje {  get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string TipoPasajero { get; set; }
        public int CantidadDisponible { get; set; }

    }
}
