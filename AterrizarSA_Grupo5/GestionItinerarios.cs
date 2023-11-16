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
            ActualizarListaItinerarios();
        }
        private void buttonNuevoItinerario_Click(object sender, EventArgs e)
        {
            PedirNombre pedirNombre = new PedirNombre();
            pedirNombre.ShowDialog();
            ActualizarListaItinerarios();
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
                    // Copiar el valor al textBox para mostra el Itinerario seleccionado
                    ItinerarioSeleccionado.Text = valorColumna1;
                    ActualizarListaItinerarios();
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
                MessageBox.Show("Debe activar un itinerario primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string estado = model.ValidarEstadoReserva();
                if (estado == "Pre-reservada" || estado == "Confirmada")
                {
                    MessageBox.Show("El itinerario ya tiene una reserva realizada.\nNo puede modificarse más", "Reserva hecha", MessageBoxButtons.OK);
                }
                else
                {
                    ListadoHoteles listadoHoteles = new ListadoHoteles();
                    listadoHoteles.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe activar un itinerario primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonAgregarVuelo_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                string estado = model.ValidarEstadoReserva();
                if (estado == "Pre-reservada" || estado == "Confirmada")
                {
                    MessageBox.Show("El itinerario ya tiene una reserva realizada.\nNo puede modificarse más", "Reserva hecha", MessageBoxButtons.OK);
                }
                else
                {
                    ListadoVuelos listadoVuelos = new ListadoVuelos();
                    listadoVuelos.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe activar un itinerario primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (ItinerarioMod.ItinerarioActivo != null)
            {
                string estado = model.ValidarEstadoReserva();
                if (estado == "Confirmada")
                {
                    MessageBox.Show("El itinerario ya tiene una reserva realizada.\nNo puede modificarse más", "Reserva hecha", MessageBoxButtons.OK);
                }
                else
                {
                    string res = model.ValidarPagoReserva();
                    if(res == "OK")
                    {
                        if(model.GenerarReserva() == 0)
                        {
                            MessageBox.Show("La reserva se confirmó exitosamente", "Reserva confirmada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Error al confirmar reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe activar un itinerario primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizarListaItinerarios()
        {
            listViewItinerarios.Items.Clear();
            listaItinerarios = model.ListarItinerarios();
            foreach (var itinerario in listaItinerarios)
            {
                ListViewItem listViewItem = new ListViewItem(itinerario.NumeroItinerario.ToString("D5"));
                listViewItem.SubItems.Add(itinerario.NombreCliente);
                listViewItem.SubItems.Add(itinerario.FechaCreado.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(itinerario.EstadoItinerario);
                listViewItinerarios.Items.Add(listViewItem);
                listViewItinerarios.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
