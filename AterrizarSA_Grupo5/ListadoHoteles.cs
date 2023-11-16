using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AterrizarSA_Grupo5
{
    public partial class ListadoHoteles : Form
    {
        ListadoHotelesModel model;
        List<ListadoHotelesModel> listaHabitaciones;
        public ListadoHoteles()
        {
            InitializeComponent();
        }

        private void ListadoHoteles_Load(object sender, EventArgs e)
        {
            model = new ListadoHotelesModel();
            // cargo itininerario activo 
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");

            comboBoxAdultos.SelectedIndex = 0;
            comboBoxMenores.SelectedIndex = 0;
            comboBoxInfantes.SelectedIndex = 0;

            listaHabitaciones = model.ListarHabitaciones();

            foreach (var habitacion in listaHabitaciones)
            {
                //Origen y destino
                if (!comboBoxDestino.Items.Contains(habitacion.Ciudad))
                {
                    comboBoxDestino.Items.Add(habitacion.Ciudad);
                }
                /*
                ListViewItem listViewItem = new ListViewItem(habitacion.IdHotel.ToString());
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
                listViewItem.SubItems.Add(habitacion.FechaInicioDisp.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(habitacion.FechaFinDisp.ToString("dd/MM/yyyy"));
                listViewHabitaciones.Items.Add(listViewItem);*/
            }
            listViewHabitaciones.Enabled = false;
            buttonGuardarHabitacion.Enabled = false;
        }
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonGuardarHabitacion_Click(object sender, EventArgs e)
        {
            if (listViewHabitaciones.SelectedItems.Count == 1)
            {
                model.IdHotel = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[0].Text);
                model.CodHotel = listViewHabitaciones.SelectedItems[0].SubItems[1].Text;
                model.Nombre = listViewHabitaciones.SelectedItems[0].SubItems[2].Text;
                model.Ciudad = listViewHabitaciones.SelectedItems[0].SubItems[3].Text;
                model.Direccion = listViewHabitaciones.SelectedItems[0].SubItems[4].Text;
                model.IdHabitacion = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[5].Text);
                model.PrecioNoche = double.Parse(listViewHabitaciones.SelectedItems[0].SubItems[6].Text);
                model.CapacidadMaxima = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[7].Text);
                model.CantidadCamasAdultos = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[8].Text);
                model.CantidadCamasMenores = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[9].Text);
                model.CantidadCamasInfantes = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[10].Text);
                model.FechaInicioDisp = dTPickerIn.Value.Date;
                model.FechaFinDisp = dTPickerOut.Value.Date;
                model.CantidadAdultosSelec = int.Parse(comboBoxAdultos.Text);
                model.CantidadMenoresSelec = int.Parse(comboBoxMenores.Text);
                model.CantidadInfantesSelec = int.Parse(comboBoxInfantes.Text);
                int result = model.Guardarhabitacion();
                switch (result)
                {
                    case 0:
                        MessageBox.Show("Habitación agregada exitosamente", "Habitacion agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case -1:
                        MessageBox.Show("Error al agregar la habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case -2:
                        MessageBox.Show("La habitación seleccionada ya existe en el itinerario", "Ya existe habitación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        private void buttonBuscarHabitacion_Click(object sender, EventArgs e)
        {
            string buscaValida = model.ValidarDatosBusqueda(comboBoxAdultos.Text, comboBoxMenores.Text, comboBoxInfantes.Text, DateTime.Parse(dTPickerIn.Text), DateTime.Parse(dTPickerOut.Text), comboBoxDestino.Text);
            if (buscaValida != "OK")
            {
                MessageBox.Show(buscaValida);
                listViewHabitaciones.Enabled = false;
                buttonGuardarHabitacion.Enabled = false;
            }
            else
            {
                int capacidadTotal = int.Parse(comboBoxAdultos.Text) + int.Parse(comboBoxMenores.Text) + int.Parse(comboBoxInfantes.Text);
                listViewHabitaciones.Items.Clear();
                foreach (var habitacion in listaHabitaciones)
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
                    listViewItem.SubItems.Add(habitacion.FechaInicioDisp.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(habitacion.FechaFinDisp.ToString("dd/MM/yyyy"));
                    List<int> habitacionesAgregadas = new List<int>();
                    if (habitacion.Ciudad == comboBoxDestino.Text && habitacion.FechaInicioDisp.Date <= DateTime.Parse(dTPickerIn.Text).Date && habitacion.FechaFinDisp.Date >= DateTime.Parse(dTPickerOut.Text).Date)
                    {
                        if (habitacion.CapacidadMaxima >= capacidadTotal)
                        {
                            if (int.Parse(comboBoxAdultos.Text) > 0 && habitacion.CantidadCamasAdultos >= (int.Parse(comboBoxAdultos.Text) / 2))
                            {
                                if (!habitacionesAgregadas.Contains(habitacion.IdHabitacion))
                                {
                                    //Habitaciones
                                    listViewHabitaciones.Items.Add(listViewItem);
                                    habitacionesAgregadas.Add(habitacion.IdHabitacion);
                                }
                            }
                            if (int.Parse(comboBoxMenores.Text) > 0 && habitacion.CantidadCamasMenores >= int.Parse(comboBoxMenores.Text))
                            {
                                if (!habitacionesAgregadas.Contains(habitacion.IdHabitacion))
                                {
                                    //Habitaciones
                                    listViewHabitaciones.Items.Add(listViewItem);
                                    habitacionesAgregadas.Add(habitacion.IdHabitacion);
                                }
                            }
                            if (int.Parse(comboBoxInfantes.Text) > 0 && habitacion.CantidadCamasInfantes >= int.Parse(comboBoxInfantes.Text))
                            {
                                if (!habitacionesAgregadas.Contains(habitacion.IdHabitacion))
                                {
                                    //Habitaciones
                                    listViewHabitaciones.Items.Add(listViewItem);
                                    habitacionesAgregadas.Add(habitacion.IdHabitacion);
                                }
                            }
                        }
                    }
                    listViewHabitaciones.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                if (listViewHabitaciones.Items.Count > 0)
                {
                    listViewHabitaciones.Enabled = true;
                    buttonGuardarHabitacion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay pasajes para los datos buscados");
                }
            }
        }
    }
}
