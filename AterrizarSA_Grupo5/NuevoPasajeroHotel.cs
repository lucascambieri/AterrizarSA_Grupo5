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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorColumna1 = textBox3.Text;
            string valorColumna2 = textBox4.Text;
            string valorColumna3 = dateTimePicker1.Value.ToString();

            ListViewItem nuevoItem = new ListViewItem(valorColumna1);
            nuevoItem.SubItems.Add(valorColumna2);
            nuevoItem.SubItems.Add(valorColumna3);

            // Agregar el nuevo elemento a la listView1
            listView1.Items.Add(nuevoItem);

            // Limpiar los controles después de agregar los datos
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
