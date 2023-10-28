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

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionItinerarios itinerarios = new GestionItinerarios();
            itinerarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoVuelos vuelos = new ListadoVuelos();
            vuelos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoHoteles hoteles = new ListadoHoteles();
            hoteles.ShowDialog();
        }
    }
}