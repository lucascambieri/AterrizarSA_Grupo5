﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    internal class PasajeEnt
    {
        public int IdPasaje {  get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string TipoPasajero { get; set; }
        public int CantidadDisponible { get; set; }

    }
}
