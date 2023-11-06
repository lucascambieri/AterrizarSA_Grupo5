using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Entidades
{
    internal class VueloEnt
    {
        public int IdVuelo { get; set; }
        public string Aerolinea { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Paradas { get; set; }
        public string TiempoViaje { get; set; }
        public DateTime FechayHoraPartida { get; set; }
        public DateTime FechayHoraLlegada { get; set; }
        public List<PasajeEnt> Pasajes { get; set; }
    }
}
