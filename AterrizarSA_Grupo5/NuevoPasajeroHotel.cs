using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AterrizarSA_Grupo5
{
    public partial class NuevoPasajeroHotel : Form
    {
        public NuevoPasajeroHotel()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string valorColumna1 = textBox3.Text;
            string valorColumna2 = textBox4.Text;
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;  // Obtiene solo la fecha (día, mes y año)

            ListViewItem nuevoItem = new ListViewItem(valorColumna1);
            nuevoItem.SubItems.Add(valorColumna2);
            nuevoItem.SubItems.Add(fechaSeleccionada.ToString("dd/MM/yyyy"));

            listView1.Items.Add(nuevoItem);

            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
