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
    public partial class GestionItinerarios : Form
    {
        public GestionItinerarios()
        {
            InitializeComponent();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerItinerario verItinerario = new VerItinerario();
            verItinerario.Show();
        }
    }
}
