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
        List<ListadoVuelosModel> listaPasajes;
        public ListadoVuelos()
        {
            InitializeComponent();
        }

        private void ListadoVuelos_Load(object sender, EventArgs e)
        {
            model = new ListadoVuelosModel();

            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");

            // Cargo datos basicos para la busqueda
            /*for (int i = 0; i <= 20; i++)
            {
                comboBoxAdultos.Items.Add(i);
                comboBoxMenores.Items.Add(i);
                comboBoxInfantes.Items.Add(i);
            }*/
            comboBoxAdultos.SelectedIndex = 0;
            comboBoxMenores.SelectedIndex = 0;
            comboBoxInfantes.SelectedIndex = 0;

            listaPasajes = model.ListarPasajes();
            foreach (var pasaje in listaPasajes)
            {
                //Origen y destino
                if (!comboBoxOrigen.Items.Contains(pasaje.Origen))
                {
                    comboBoxOrigen.Items.Add(pasaje.Origen);
                }
                if (!comboBoxDestino.Items.Contains(pasaje.Destino))
                {
                    comboBoxDestino.Items.Add(pasaje.Destino);
                }
                //Categorias
                if (!comboBoxCategorias.Items.Contains(pasaje.Categoria))
                {
                    comboBoxCategorias.Items.Add(pasaje.Categoria);
                }

                // Pasajes completos
                /*ListViewItem listViewItem = new ListViewItem(pasaje.IdVuelo.ToString("D5"));
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
                listViewPasajes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);*/
            }
            listViewPasajes.Enabled = false;
            buttonGuardarPasaje.Enabled = false;
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
                model.Precio = decimal.Parse(listViewPasajes.SelectedItems[0].SubItems[10].Text);
                model.CantidadDisponible = int.Parse(listViewPasajes.SelectedItems[0].SubItems[11].Text);
                model.IdPasaje = int.Parse(listViewPasajes.SelectedItems[0].SubItems[12].Text);
            }
            int result = model.GuardarPasaje();
            if (result == 0)
            {
                listViewPasajes.SelectedItems[0].SubItems[11].Text = (model.CantidadDisponible - 1).ToString();
                MessageBox.Show("Pasaje agregado exitosamente", "Pasaje agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonBuscarPasajes_Click(object sender, EventArgs e)
        {
            string buscaValida = model.ValidarDatosBusqueda(comboBoxAdultos.Text, comboBoxMenores.Text, comboBoxInfantes.Text, DateTime.Parse(dTPickerIda.Text), DateTime.Parse(dTPickerVuelta.Text), comboBoxOrigen.Text, comboBoxDestino.Text);
            if (buscaValida != "OK")
            {
                MessageBox.Show(buscaValida);
                listViewPasajes.Enabled = false;
                buttonGuardarPasaje.Enabled = false;
            }
            else
            {
                listViewPasajes.Items.Clear();
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
                    listViewItem.SubItems.Add(pasaje.CantidadDisponible.ToString());
                    listViewItem.SubItems.Add(pasaje.IdPasaje.ToString("D5"));
                    if(pasaje.Categoria == comboBoxCategorias.Text || comboBoxCategorias.Text == "")
                    {
                        // Ida
                        if ((pasaje.Origen == comboBoxOrigen.Text && pasaje.Destino == comboBoxDestino.Text) && pasaje.FechayHoraPartida.Date == DateTime.Parse(dTPickerIda.Text).Date)
                        {
                            if (pasaje.TipoPasajero == "Adulto")
                            {
                                if (int.Parse(comboBoxAdultos.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxAdultos.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                            if (pasaje.TipoPasajero == "Menor")
                            {
                                if (int.Parse(comboBoxMenores.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxMenores.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                            if (pasaje.TipoPasajero == "Infante")
                            {
                                if (int.Parse(comboBoxInfantes.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxInfantes.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                        }
                        //Vuelta
                        if ((pasaje.Origen == comboBoxDestino.Text && pasaje.Destino == comboBoxOrigen.Text) && pasaje.FechayHoraPartida.Date == DateTime.Parse(dTPickerVuelta.Text).Date)
                        {
                            if (pasaje.TipoPasajero == "Adulto")
                            {
                                if (int.Parse(comboBoxAdultos.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxAdultos.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                            if (pasaje.TipoPasajero == "Menor")
                            {
                                if (int.Parse(comboBoxMenores.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxMenores.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                            if (pasaje.TipoPasajero == "Infante")
                            {
                                if (int.Parse(comboBoxInfantes.Text) > 0 && pasaje.CantidadDisponible >= int.Parse(comboBoxInfantes.Text))
                                {
                                    // Pasajes completos
                                    listViewPasajes.Items.Add(listViewItem);
                                }
                            }
                        }
                    }
                }
                listViewPasajes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                if (listViewPasajes.Items.Count > 0)
                {
                    listViewPasajes.Enabled = true;
                    buttonGuardarPasaje.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay pasajes para los datos buscados");
                }
            }
        }
    }
}
