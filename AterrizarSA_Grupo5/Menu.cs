using AterrizarSA_Grupo5.Modulos;

namespace AterrizarSA_Grupo5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGestionItinerario_Click(object sender, EventArgs e)
        {
            GestionItinerarios itinerarios = new GestionItinerarios();
            itinerarios.ShowDialog();
        }

        private void buttonAgregarVuelo_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                ListadoVuelos vuelos = new ListadoVuelos();
                vuelos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe tener un itinerario activo","Falta activar itinerario",MessageBoxButtons.OK);
            }
        }

        private void buttonAgregarHotel_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                ListadoHoteles hoteles = new ListadoHoteles();
                hoteles.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe tener un itinerario activo", "Falta activar itinerario", MessageBoxButtons.OK);
            }

        }
    }
}