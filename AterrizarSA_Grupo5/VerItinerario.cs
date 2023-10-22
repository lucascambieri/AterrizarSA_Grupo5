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
    public partial class VerItinerario : Form
    {
        public VerItinerario()
        {
            InitializeComponent();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerItinerario_Load(object sender, EventArgs e)
        {
            listView3.View = View.Details;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
