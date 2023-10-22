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

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoHoteles hotel = new ListadoHoteles();
            hotel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoVuelos vuelo = new ListadoVuelos();
            vuelo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionItinerarios itinerario = new GestionItinerarios();
            itinerario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}