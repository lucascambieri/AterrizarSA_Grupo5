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
        public ListadoHoteles()
        {
            InitializeComponent();
        }

        List<ListadoHotelesModel> listaHabitaciones = ListadoHotelesModel.ListarHabitaciones();


        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoHoteles_Load(object sender, EventArgs e)
        {
            foreach (var habitacion in listaHabitaciones)
            {
                //ListViewItem listViewItem = new ListViewItem(habitacion.NumeroItinerario.ToString("D5"));
                //listViewItem.SubItems.Add(habitacion.NombreCliente);
                //listViewItem.SubItems.Add(habitacion.FechaCreado.ToString("dd/MM/yyyy"));
                //listViewItem.SubItems.Add(habitacion.EstadoItinerario);
                //listViewHabitaciones.Items.Add(listViewItem);
                MessageBox.Show("OK");
            }
        }
    }
}
