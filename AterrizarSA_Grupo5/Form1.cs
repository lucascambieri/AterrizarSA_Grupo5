namespace AterrizarSA_Grupo5
{
    public partial class Form1 : Form
    {
        public Form1()
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
            itinerarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoVuelos vuelos = new ListadoVuelos();
            vuelos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoHoteles hoteles = new ListadoHoteles();
            hoteles.Show();
        }
    }
}