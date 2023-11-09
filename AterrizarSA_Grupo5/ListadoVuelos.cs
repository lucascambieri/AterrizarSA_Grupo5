using AterrizarSA_Grupo5.Entidades;
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
            PasajesSelecEnt pasajeSeleccionado = new PasajesSelecEnt();
            if (listViewPasajes.SelectedItems.Count > 0)
            {
                int i = 0;
                // Recorre los subítems (columnas) de la fila seleccionada
                foreach (ListViewItem.ListViewSubItem subItem in listViewPasajes.SelectedItems[0].SubItems)
                {
                    if (i == 0)
                    {
                        pasajeSeleccionado.IdVuelo = int.Parse(subItem.Text);
                    }
                    if (i == 14)
                    {
                        pasajeSeleccionado.IdPasaje = int.Parse(subItem.Text);
                    }
                    i++;
                }
            }
            int result = model.GuardarPasaje(pasajeSeleccionado);
            if (result == 0)
            {
                MessageBox.Show("Pasaje agregado exitosamente", "Pasaje agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
