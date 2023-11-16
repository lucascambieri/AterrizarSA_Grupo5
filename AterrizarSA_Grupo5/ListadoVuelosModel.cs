using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AterrizarSA_Grupo5
{
    internal class ListadoVuelosModel
    {
        public int IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Paradas { get; set; }
        public DateTime FechayHoraPartida { get; set; }
        public DateTime FechayHoraLlegada { get; set; }
        public string TiempoViaje { get; set; }
        public string Aerolinea { get; set; }
        public int IdPasaje { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string TipoPasajero { get; set; }
        public int CantidadDisponible { get; set; }
        public ListadoVuelosModel(int idVuelo, string origen, string destino, string paradas, DateTime fechaPartida, DateTime fechaLlegada, string timepoViaje, string aerolinea, int idPasaje, string categoria, double precio, string tipoPasajero, int cantidadDisponible)
        {
            this.IdVuelo = idVuelo;
            this.Origen = origen;
            this.Destino = destino;
            this.Paradas = paradas;
            this.FechayHoraPartida = fechaPartida;
            this.FechayHoraLlegada = fechaLlegada;
            this.TiempoViaje = timepoViaje;
            this.Aerolinea = aerolinea;
            this.IdPasaje = idPasaje;
            this.Categoria = categoria;
            this.Precio = precio;
            this.TipoPasajero = tipoPasajero;
            this.CantidadDisponible = cantidadDisponible;
        }

        public ListadoVuelosModel()
        {

        }
        public List<ListadoVuelosModel> ListarPasajes()
        {
            List<ListadoVuelosModel> listaVuelos = new List<ListadoVuelosModel>();
            foreach (var vuelo in InventarioMod.ListarVuelos())
            {
                foreach (var pasaje in vuelo.Pasajes)
                {
                    ListadoVuelosModel vueloModel = new ListadoVuelosModel(vuelo.IdVuelo, vuelo.Origen, vuelo.Destino, vuelo.Paradas, vuelo.FechayHoraPartida, vuelo.FechayHoraLlegada, vuelo.TiempoViaje, vuelo.Aerolinea, pasaje.IdPasaje, pasaje.Categoria, pasaje.Precio, pasaje.TipoPasajero, pasaje.CantidadDisponible);
                    listaVuelos.Add(vueloModel);
                }
            }

            return listaVuelos;
        }

        public int GuardarPasaje()
        {
            // Valido si la fecha elegida es menor a la que tiene el itinerario, la guardo.
            if (this.FechayHoraPartida < ItinerarioMod.ItinerarioActivo.FechaInicio || ItinerarioMod.ItinerarioActivo.FechaInicio.Date == DateTime.Parse("0001-01-01"))
            {
                ItinerarioMod.ItinerarioActivo.FechaInicio = this.FechayHoraPartida;
            }
            VueloEnt vueloSeleccionado = new VueloEnt();
            PasajeEnt pasajeSeleccionado = new PasajeEnt();
            vueloSeleccionado.IdVuelo = this.IdVuelo;
            vueloSeleccionado.Aerolinea = this.Aerolinea;
            vueloSeleccionado.Origen = this.Origen;
            vueloSeleccionado.Destino = this.Destino;
            vueloSeleccionado.Paradas = this.Paradas;
            vueloSeleccionado.TiempoViaje = this.TiempoViaje;
            vueloSeleccionado.FechayHoraPartida = this.FechayHoraPartida;
            vueloSeleccionado.FechayHoraLlegada = this.FechayHoraLlegada;
            pasajeSeleccionado.IdPasaje = this.IdPasaje;
            pasajeSeleccionado.Categoria = this.Categoria;
            pasajeSeleccionado.Precio = this.Precio;
            pasajeSeleccionado.TipoPasajero = this.TipoPasajero;
            List<PasajeEnt> listaPasajeSeleccionado = new List<PasajeEnt>() { pasajeSeleccionado };
            vueloSeleccionado.Pasajes = listaPasajeSeleccionado;
            if(this.CantidadDisponible > 0)
            {
                return ItinerarioMod.AgregarPasaje(vueloSeleccionado);
            }
            else
            {
                return -1;
            }
        }
        public string ValidarDatosBusqueda(string cantAdultos, string cantMenores, string cantInfantes, DateTime fechaIda, DateTime fechaVuelta, string origen, string destino)
        {
            if (cantAdultos == "0" && cantMenores == "0" && cantInfantes == "0")
            {
                return "Seleccione al menos un pasajero";
            }
            if (cantInfantes != "0" && cantAdultos == "0")
            {
                return "Los infantes deben viajar con un adulto";
            }
            if (fechaVuelta < fechaIda)
            {
                return "La fecha de vuelta no puede ser inferior a la de partida";
            }
            if (fechaIda.Date < DateTime.Today)
            {
                return "La fecha de ida no puede ser anterior a hoy";
            }
                if (origen == "" || destino == "")
            {
                return "Seleccione origen y destino buscados";
            }

            return "OK";
        }
    }
}
