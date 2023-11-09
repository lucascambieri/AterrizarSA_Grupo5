using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AterrizarSA_Grupo5
{
    public partial class VerItinerario : Form
    {
        VerItinerarioModel model;
        public VerItinerario()
        {
            InitializeComponent();
        }

        private void VerItinerario_Load(object sender, EventArgs e)
        {
            model = new VerItinerarioModel();

            List<VerItinerarioModel> listaHabitacionesSelec = VerItinerarioModel.ListarHabitacionesSeleccionadas();
            List<VerItinerarioModel> listaPasajesSelec = VerItinerarioModel.ListarPasajesSeleccionados();

            foreach (var habitacion in listaHabitacionesSelec)
            {
                ListViewItem listViewItem = new ListViewItem(habitacion.IdHotel.ToString("D5"));
                listViewItem.SubItems.Add(habitacion.CodHotel);
                listViewItem.SubItems.Add(habitacion.Nombre);
                listViewItem.SubItems.Add(habitacion.Ciudad);
                listViewItem.SubItems.Add(habitacion.Direccion);
                listViewItem.SubItems.Add(habitacion.IdHabitacion.ToString("D5"));
                listViewItem.SubItems.Add(habitacion.PrecioNoche.ToString());
                listViewItem.SubItems.Add(habitacion.CapacidadMaxima.ToString());
                listViewItem.SubItems.Add(habitacion.CantidadCamasAdultos.ToString());
                listViewItem.SubItems.Add(habitacion.CantidadCamasMenores.ToString());
                listViewItem.SubItems.Add(habitacion.CantidadCamasInfantes.ToString());
                listViewItem.SubItems.Add(habitacion.FechaDesde.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(habitacion.FechaHasta.ToString("dd/MM/yyyy"));
                listViewHoteleria.Items.Add(listViewItem);
            }
            foreach (var pasaje in listaPasajesSelec)
            {
                ListViewItem listViewItem = new ListViewItem(pasaje.IdVuelo.ToString("D5"));
                listViewItem.SubItems.Add(pasaje.Origen);
                listViewItem.SubItems.Add(pasaje.Destino);
                listViewItem.SubItems.Add(pasaje.Paradas);
                listViewItem.SubItems.Add(pasaje.FechayHoraPartida.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewItem.SubItems.Add(pasaje.FechayHoraLlegada.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewItem.SubItems.Add(pasaje.TiempoViaje);
                listViewItem.SubItems.Add(pasaje.Aerolinea);
                listViewItem.SubItems.Add(pasaje.Categoria);
                listViewItem.SubItems.Add(pasaje.TipoPasajero);
                listViewItem.SubItems.Add(pasaje.Precio.ToString());
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(pasaje.CantidadElegida.ToString());
                listViewItem.SubItems.Add(pasaje.IdPasaje.ToString("D5"));
                listViewAereos.Items.Add(listViewItem);
            }
            if(listaHabitacionesSelec.Count > 0)
            {
                labelSubTotalHoteles.Text = listaHabitacionesSelec[0].TarifaTotalHotel.ToString();
            }
            if(listaPasajesSelec.Count > 0)
            {
                labelSubTotalVuelos.Text = listaPasajesSelec[0].TarifaTotalVuelo.ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NuevoPasajeroVuelo nuevoPasajeroVuelo = new NuevoPasajeroVuelo();
            nuevoPasajeroVuelo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoPasajeroHotel nuevoPasajeroHotel = new NuevoPasajeroHotel();
            nuevoPasajeroHotel.Show();
        }

    }
}
