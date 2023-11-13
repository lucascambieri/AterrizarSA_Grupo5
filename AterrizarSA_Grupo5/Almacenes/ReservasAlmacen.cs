using AterrizarSA_Grupo5.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5.Almacenes
{
    internal static class ReservasAlmacen
    {
        public static List<ReservaEnt> Reservas;

        static ReservasAlmacen()
        {
            var reservasJson = File.ReadAllText("C:\\Users\\stefa\\Desktop\\Facultad\\CAI\\AterrizarSA_Grupo5\\AterrizarSA_Grupo5\\Almacenes\\Reservas.json");
            Reservas = JsonConvert.DeserializeObject<List<ReservaEnt>>(reservasJson);
        }

        public static void Grabar()
        {
            var reservasJson = JsonConvert.SerializeObject(Reservas);
            File.WriteAllText("C:\\Users\\stefa\\Desktop\\Facultad\\CAI\\AterrizarSA_Grupo5\\AterrizarSA_Grupo5\\Almacenes\\Reservas.json", reservasJson);

            Reservas = null;
        }

    }
}
