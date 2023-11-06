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
            foreach (var itinerario in listaHabitaciones)
            {
                ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D5"));
                listViewItem.SubItems.Add(itinerario.NombreCliente);
                listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                listViewHabitaciones.Items.Add(listViewItem);
            }
        }
    }
}
