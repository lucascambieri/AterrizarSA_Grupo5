using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AterrizarSA_Grupo5
{
    public partial class GestionItinerarios : Form
    {
        public GestionItinerarios()
        {
            InitializeComponent();
        }


        // Crea la lista de itinerarios
        List<Itinerario> listaItinerarios = Itinerario.CrearItinerario();
             

        // Agrega la lista de itinerarios en el ListView
        private void GestionItinerarios_Load(object sender, EventArgs e)
        {
                   foreach (var itinerario in listaItinerarios)
            {
                ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D4"));
                listViewItem.SubItems.Add(itinerario.NombreCliente);
                listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                listView1.Items.Add(listViewItem);
            }
        }



        private void Eliminar_Click(object sender, EventArgs e)
        {
            {
                // Verificar si se ha seleccionado un elemento en listView1
                if (listView1.SelectedItems.Count > 0)
                {
                    // Eliminar el elemento seleccionado
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int codigoUnico = listaItinerarios[3].NumeroItinerario++;
                codigoUnico++;

                // Generar un código único de cuatro dígitos
                string codigo = codigoUnico.ToString("D4");

                // Obtener la fecha actual
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");

                // Crear una nueva fila
                ListViewItem nuevaFila = new ListViewItem(codigo);
                nuevaFila.SubItems.Add(""); // Columna vacía
                nuevaFila.SubItems.Add(fecha);
                nuevaFila.SubItems.Add("Itinerario creado");

                // Agregar la nueva fila a listView1
                listView1.Items.Add(nuevaFila);

                // Incrementar el contador de códigos únicos para el próximo elemento
                codigoUnico++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtener el valor de columnHeader1 del elemento seleccionado
                string valorColumna1 = listView1.SelectedItems[0].SubItems[0].Text;

                // Copiar el valor al textBox3
                textBox3.Text = valorColumna1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Buscar número de itinerario
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (listView1.Items.Count == 1)
                {
                    listView1.Items.Clear();

                    foreach (var itinerario in listaItinerarios)
                    {
                        ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D4"));
                        listViewItem.SubItems.Add(itinerario.NombreCliente);
                        listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                        listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                        listView1.Items.Add(listViewItem);
                    }

                }
                    
                
            }
            
            string buscarNumeroItinerario = textBox1.Text;


            foreach (ListViewItem item in listView1.Items)
            {
                string columnaItinerario = item.SubItems[0].Text;
                if (columnaItinerario == buscarNumeroItinerario)
                {
                    listView1.Items.Clear();
                    string[] infoFila = new string[item.SubItems.Count];
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        infoFila[i] = item.SubItems[i].Text;
                    }

                    listView1.Items.Add(new ListViewItem(infoFila));
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
