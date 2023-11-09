using AterrizarSA_Grupo5.Entidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AterrizarSA_Grupo5
{
    public partial class GestionItinerarios : Form
    {
        GestionItinerarioModel model;
        List<GestionItinerarioModel> listaItinerarios;
        public GestionItinerarios()
        {
            InitializeComponent();
        }

        private void GestionItinerarios_Load_1(object sender, EventArgs e)
        {
            model = new GestionItinerarioModel();
            listaItinerarios = model.ListarItinerarios();
            foreach (var itinerario in listaItinerarios)
            {
                ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D5"));
                listViewItem.SubItems.Add(itinerario.NombreCliente);
                listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                listViewItinerarios.Items.Add(listViewItem);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonNuevoItinerario_Click(object sender, EventArgs e)
        {
            string nombreCliente = textNombreCliente.Text;
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                int codigoUnico = listaItinerarios[listaItinerarios.Count - 1].NumeroItinerario++;
                codigoUnico++;

                // Generar un código único de cuatro dígitos
                string codigo = codigoUnico.ToString("D5");

                // Obtener la fecha actual
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");

                // Crea el itinerario
                if (model.CrearItinerario(codigoUnico, nombreCliente, DateTime.Now) == null)
                {
                    // Crear una nueva fila
                    ListViewItem nuevaFila = new ListViewItem(codigo);
                    nuevaFila.SubItems.Add(nombreCliente); // Columna vacía
                    nuevaFila.SubItems.Add(fecha);
                    nuevaFila.SubItems.Add("Itinerario creado");

                    // Agregar la nueva fila a listView1
                    listViewItinerarios.Items.Add(nuevaFila);

                    // Incrementar el contador de códigos únicos para el próximo elemento
                    codigoUnico++;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de cliente", "Ingrese nombre", MessageBoxButtons.OK);
            }
        }

        private void buttonActivaItinerario_Click_(object sender, EventArgs e)
        {
            if (listViewItinerarios.SelectedItems.Count > 0)
            {
                // Obtener el valor de columnHeader1 del elemento seleccionado
                string valorColumna1 = listViewItinerarios.SelectedItems[0].SubItems[0].Text;
                // Actualizo valor en el model
                ItinerarioEnt itinerarioBuscado;
                itinerarioBuscado = model.BuscarItinerario(int.Parse(valorColumna1));
                int result = model.ActivarItinerario(itinerarioBuscado);
                if (result == 0)
                {
                    foreach (ListViewItem item in listViewItinerarios.Items)
                    {
                        if (item.SubItems[3].Text == "Activo")
                        {
                            // Cambiar el estado del elemento activo anterior a "Itinerario creado"
                            item.SubItems[3].Text = "Itinerario creado";
                        }
                    }
                    // Copiar el valor al textBox para mostra el Itinerario seleccionado
                    ItinerarioSeleccionado.Text = valorColumna1;
                    ListViewItem selectedItem = listViewItinerarios.SelectedItems[0];
                    selectedItem.SubItems[3].Text = "Activo";
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento en la lista antes de cambiar el estado.");
            }
        }

        private void buttonVerItinerario_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                VerItinerario verItinerario = new VerItinerario();
                verItinerario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar un itinerario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGenerarReserva_Click(object sender, EventArgs e)
        {
            if (listViewItinerarios.SelectedItems.Count > 0)
            {
                // Verificar si se ha seleccionado un elemento
                ListViewItem selectedItem = listViewItinerarios.SelectedItems[0]; // Obtener el elemento seleccionado

                // Modificar la ColumnHeader4 (indice 3) del elemento seleccionado
                selectedItem.SubItems[3].Text = "Pre-Reservado";

                MessageBox.Show("Revisar y agregar los pasajeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VerItinerario verItinerario = new VerItinerario();
                verItinerario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un elemento en la lista antes de cambiar el estado.");
            }
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en listView1
            if (listViewItinerarios.SelectedItems.Count > 0)
            {
                // Obtén el elemento seleccionado
                ListViewItem itemSeleccionado = listViewItinerarios.SelectedItems[0];

                // Verifica si el texto de columnHeader1 del elemento seleccionado coincide con el texto actual de label1
                if (ItinerarioSeleccionado.Text == itemSeleccionado.SubItems[0].Text)
                {
                    ItinerarioSeleccionado.Text = "NO SELECCIONADO";
                }

                // Eliminar el elemento seleccionado
                listViewItinerarios.Items.Remove(itemSeleccionado);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (listViewItinerarios.Items.Count == 1)
                {
                    listViewItinerarios.Items.Clear();

                    foreach (var itinerario in listaItinerarios)
                    {
                        ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D4"));
                        listViewItem.SubItems.Add(itinerario.NombreCliente);
                        listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                        listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                        listViewItinerarios.Items.Add(listViewItem);
                    }

                }


            }

            string buscarNumeroItinerario = textBox1.Text;


            foreach (ListViewItem item in listViewItinerarios.Items)
            {
                string columnaItinerario = item.SubItems[0].Text;
                if (columnaItinerario == buscarNumeroItinerario)
                {
                    listViewItinerarios.Items.Clear();
                    string[] infoFila = new string[item.SubItems.Count];
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        infoFila[i] = item.SubItems[i].Text;
                    }

                    listViewItinerarios.Items.Add(new ListViewItem(infoFila));
                }
            }
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarHabitacion_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                ListadoHoteles listadoHoteles = new ListadoHoteles();
                listadoHoteles.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar un itinerario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAgregarVuelo_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                ListadoVuelos listadoVuelos = new ListadoVuelos();
                listadoVuelos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar un itinerario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (listViewItinerarios.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewItinerarios.SelectedItems[0];
                selectedItem.SubItems[3].Text = "Confirmado";
            }
            else
            {
                MessageBox.Show("Selecciona un itinerario en la lista antes de cambiar el estado.");
            }
        }

    }
}
