using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
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
    public partial class ListadoVuelos : Form
    {
        ListadoVuelosModel model;
        public ListadoVuelos()
        {
            InitializeComponent();
        }

        private void ListadoVuelos_Load(object sender, EventArgs e)
        {
            model = new ListadoVuelosModel();

            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");

            List<ListadoVuelosModel> listaPasajes = model.ListarPasajes();

            foreach (var pasaje in listaPasajes)
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
                listViewItem.SubItems.Add(pasaje.CantidadDisponible.ToString());
                listViewItem.SubItems.Add(pasaje.IdPasaje.ToString("D5"));
                listViewPasajes.Items.Add(listViewItem);
            }

        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardarPasaje_Click(object sender, EventArgs e)
        {
            if (listViewPasajes.SelectedItems.Count == 1)
            {
                model.IdVuelo = int.Parse(listViewPasajes.SelectedItems[0].SubItems[0].Text);
                model.Origen = listViewPasajes.SelectedItems[0].SubItems[1].Text;
                model.Destino = listViewPasajes.SelectedItems[0].SubItems[2].Text;
                model.Paradas = listViewPasajes.SelectedItems[0].SubItems[3].Text;
                model.FechayHoraPartida = DateTime.Parse(listViewPasajes.SelectedItems[0].SubItems[4].Text);
                model.FechayHoraLlegada = DateTime.Parse(listViewPasajes.SelectedItems[0].SubItems[5].Text);
                model.TiempoViaje = listViewPasajes.SelectedItems[0].SubItems[6].Text;
                model.Aerolinea = listViewPasajes.SelectedItems[0].SubItems[7].Text;
                model.Categoria = listViewPasajes.SelectedItems[0].SubItems[8].Text;
                model.TipoPasajero = listViewPasajes.SelectedItems[0].SubItems[9].Text;
                model.Precio = double.Parse(listViewPasajes.SelectedItems[0].SubItems[10].Text);
                model.IdPasaje = int.Parse(listViewPasajes.SelectedItems[0].SubItems[14].Text);
            }
            int result = model.GuardarPasaje();
            if (result == 0)
            {
                MessageBox.Show("Pasaje agregado exitosamente", "Pasaje agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
