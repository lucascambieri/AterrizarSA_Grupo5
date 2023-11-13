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

namespace AterrizarSA_Grupo5
{
    public partial class NuevoPasajeroVuelo : Form
    {
        public NuevoPasajeroVuelo()
        {
            InitializeComponent();
        }
        private void NuevoPasajeroVuelo_Load(object sender, EventArgs e)
        {
            // Cargo itinerario activo + pasaje
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");
            labelVueloyPasaje.Text = "000";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
