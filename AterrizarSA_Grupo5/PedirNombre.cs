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
    public partial class PedirNombre : Form
    {
        GestionItinerarioModel model;
        public PedirNombre()
        {
            InitializeComponent();
        }
        private void PedirNombre_Load(object sender, EventArgs e)
        {
            model = new GestionItinerarioModel();
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmarNombre_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxNombre.Text;
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                model.NombreCliente = nombreCliente;
                model.CrearItinerario();
                MessageBox.Show("Itinerario creado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de cliente", "Ingrese nombre", MessageBoxButtons.OK);
            }
        }

    }
}
