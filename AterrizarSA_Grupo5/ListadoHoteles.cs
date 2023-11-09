using AterrizarSA_Grupo5.Entidades;
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
        public ListadoHoteles()
        {
            InitializeComponent();
        }

        //List<ListadoHotelesModel> listaHabitaciones = ListadoHotelesModel.ListarHabitaciones();

        private void ListadoHoteles_Load(object sender, EventArgs e)
        {
            model = new ListadoHotelesModel();

            List<ListadoHotelesModel> listaHabitaciones = model.ListarHabitaciones();

            foreach (var habitacion in listaHabitaciones)
            {
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
                listViewHabitaciones.Items.Add(listViewItem);
            }
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardarHabitacion_Click(object sender, EventArgs e)
        {
            HabitacionesSelecEnt habitacionSeleccionada = new HabitacionesSelecEnt();
            if (listViewHabitaciones.SelectedItems.Count > 0)
            {
                int i = 0;
                // Recorre los subítems (columnas) de la fila seleccionada
                foreach (ListViewItem.ListViewSubItem subItem in listViewHabitaciones.SelectedItems[0].SubItems)
                {
                    if (i == 0)
                    {
                        habitacionSeleccionada.IdHotel = int.Parse(subItem.Text);
                    }
                    if (i == 5)
                    {
                        habitacionSeleccionada.IdHab = int.Parse(subItem.Text);
                    }
                    habitacionSeleccionada.FechaDesde = dTPickerIn.Value;
                    habitacionSeleccionada.FechaHasta = dTPickerOut.Value;
                    i++;
                }

            }
            int result = model.GuardarHabitacion(habitacionSeleccionada);
            if (result == 0)
            {
                MessageBox.Show("Habitación agregada exitosamente", "Habitacion agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
