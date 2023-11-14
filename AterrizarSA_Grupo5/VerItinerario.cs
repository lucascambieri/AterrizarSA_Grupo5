using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AterrizarSA_Grupo5
{
    public partial class VerItinerario : Form
    {
        VerItinerarioModel model;
        List<VerItinerarioModel> listaHabitacionesSelec;
        List<VerItinerarioModel> listaPasajesSelec;
        public VerItinerario()
        {
            InitializeComponent();
        }

        private void VerItinerario_Load(object sender, EventArgs e)
        {
            model = new VerItinerarioModel();
            ReservaMod.ReservaDelItinerarioActivo = null;
            // Reviso si no existe ningun reserva la creo, sino la cargo en ReservaDelItinierarioActivo
            model.CrearReserva();
            // Cargo itinerario y fecha de inicio en Form
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");
            labelFechaInicioItinerario.Text = ItinerarioMod.ItinerarioActivo.FechaInicio.ToString("dd/MM/yyyy");

            // Cargo habitaciones y pasajes seleccionados del vuelo
            listaHabitacionesSelec = model.ListarHabitacionesSeleccionadas();
            listaPasajesSelec = model.ListarPasajesSeleccionados();
            if (listaHabitacionesSelec != null)
            {
                foreach (var habitacion in listaHabitacionesSelec)
                {
                    ListViewItem listViewItem = new ListViewItem(habitacion.IdHotel.ToString("D5"));
                    listViewItem.SubItems.Add(habitacion.CodHotel);
                    listViewItem.SubItems.Add(habitacion.Nombre);
                    listViewItem.SubItems.Add(habitacion.Ciudad);
                    listViewItem.SubItems.Add(habitacion.Direccion);
                    listViewItem.SubItems.Add(habitacion.IdHabitacion.ToString("D5"));
                    listViewItem.SubItems.Add(habitacion.PrecioNoche.ToString());
                    listViewItem.SubItems.Add(habitacion.CapacidadMaxima.ToString());
                    listViewItem.SubItems.Add(habitacion.CantidadCamasAdultos.ToString());
                    listViewItem.SubItems.Add(habitacion.CantidadCamasMenores.ToString());
                    listViewItem.SubItems.Add(habitacion.CantidadCamasInfantes.ToString());
                    listViewItem.SubItems.Add(habitacion.FechaDesde.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(habitacion.FechaHasta.ToString("dd/MM/yyyy"));
                    listViewHoteleria.Items.Add(listViewItem);
                    listViewHoteleria.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                // Si existe alguna habitación seleccionada, actualizo el total
                if (listaHabitacionesSelec.Count > 0)
                {
                    labelSubTotalHoteles.Text = listaHabitacionesSelec[0].TarifaTotalHotel.ToString();
                }
            }
            if (listaPasajesSelec != null)
            {
                foreach (var pasaje in listaPasajesSelec)
                {
                    ListViewItem listViewItem = new ListViewItem(pasaje.IdVuelo.ToString("D5"));
                    listViewItem.SubItems.Add(pasaje.Origen);
                    listViewItem.SubItems.Add(pasaje.Destino);
                    listViewItem.SubItems.Add(pasaje.Paradas);
                    listViewItem.SubItems.Add(pasaje.FechayHoraPartida.ToString("dd/MM/yyyy HH:mm:ss"));
                    listViewItem.SubItems.Add(pasaje.FechayHoraLlegada.ToString("dd/MM/yyyy HH:mm:ss"));
                    listViewItem.SubItems.Add(pasaje.TiempoViaje);
                    listViewItem.SubItems.Add(pasaje.Aerolinea);
                    listViewItem.SubItems.Add(pasaje.Categoria);
                    listViewItem.SubItems.Add(pasaje.TipoPasajero);
                    listViewItem.SubItems.Add(pasaje.Precio.ToString());
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(pasaje.CantidadElegida.ToString());
                    listViewItem.SubItems.Add(pasaje.IdPasaje.ToString("D5"));
                    listViewAereos.Items.Add(listViewItem);
                    listViewAereos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                // Si existe algún pasaje seleccionado, actualizo el total
                if (listaPasajesSelec.Count > 0)
                {
                    labelSubTotalVuelos.Text = listaPasajesSelec[0].TarifaTotalVuelo.ToString();
                }
            }

        }
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonEditarPasajerosPasajes_Click(object sender, EventArgs e)
        {
            if (listaPasajesSelec.Count > 0)
            {
                if (listViewAereos.SelectedItems.Count == 1)
                {
                    model.IdVuelo = int.Parse(listViewAereos.SelectedItems[0].SubItems[0].Text);
                    model.Origen = listViewAereos.SelectedItems[0].SubItems[1].Text;
                    model.Destino = listViewAereos.SelectedItems[0].SubItems[2].Text;
                    model.Paradas = listViewAereos.SelectedItems[0].SubItems[3].Text;
                    model.FechayHoraPartida = DateTime.Parse(listViewAereos.SelectedItems[0].SubItems[4].Text);
                    model.FechayHoraLlegada = DateTime.Parse(listViewAereos.SelectedItems[0].SubItems[5].Text);
                    model.TiempoViaje = listViewAereos.SelectedItems[0].SubItems[6].Text;
                    model.Aerolinea = listViewAereos.SelectedItems[0].SubItems[7].Text;
                    model.Categoria = listViewAereos.SelectedItems[0].SubItems[8].Text;
                    model.TipoPasajero = listViewAereos.SelectedItems[0].SubItems[9].Text;
                    model.Precio = double.Parse(listViewAereos.SelectedItems[0].SubItems[10].Text);
                    model.IdPasaje = int.Parse(listViewAereos.SelectedItems[0].SubItems[14].Text);
                    if (model.RevisarPasajeroCargado() == 0)
                    {
                        model.ActivarPasajeSeleccionado();
                        NuevoPasajeroVuelo nuevoPasajeroVuelo = new NuevoPasajeroVuelo();
                        nuevoPasajeroVuelo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El pasaje ya tiene un pasajero cargado", "Error al cargar", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Elija un (y solo un) pasaje", "Elija pasajes", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El itinerario no tiene pasajes cargados", "Sin pasajes", MessageBoxButtons.OK);
            }
        }
        private void buttonEditarPasajerosHotel_Click(object sender, EventArgs e)
        {
            if (listaHabitacionesSelec.Count > 0)
            {
                NuevoPasajeroHotel nuevoPasajeroHotel = new NuevoPasajeroHotel();
                nuevoPasajeroHotel.ShowDialog();
            }
            else
            {
                MessageBox.Show("El itinerario no tiene habitaciones cargadas", "Sin habitaciones", MessageBoxButtons.OK);
            }
        }
        private void buttonQuitarPasajero_Click(object sender, EventArgs e)
        {
            if (listaPasajesSelec.Count > 0)
            {
                if (listViewAereos.SelectedItems.Count == 1)
                {
                    model.IdVuelo = int.Parse(listViewAereos.SelectedItems[0].SubItems[0].Text);
                    model.IdPasaje = int.Parse(listViewAereos.SelectedItems[0].SubItems[14].Text);
                    if (model.RevisarPasajeroCargado() != 0)
                    {
                        var result = MessageBox.Show("¿Está seguro que desea eliminar al pasajero?", "Eliminar pasajero", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if(model.QuitarPasajero() == 0)
                            {
                                MessageBox.Show("Pasajero eliminado correctamente", "Pasajero eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("El pasaje no tiene un pasajero cargado", "Error al eliminar", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Elija un (y solo un) pasaje", "Elija pasajes", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El itinerario no tiene pasajes cargados", "Sin pasajes", MessageBoxButtons.OK);
            }
        }
        private void buttonGenerarPreReserva_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuitarPasaje_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuitarPasaje_Click_1(object sender, EventArgs e)
        {
            if (listViewAereos.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewAereos.SelectedItems)
                {
                    listViewAereos.Items.Remove(item);
                }
            }
        }

        private void buttonQuitarHabitacion_Click(object sender, EventArgs e)
        {
            if (listViewHoteleria.SelectedItems.Count > 0)
            {
                // Elimina el elemento seleccionado
                foreach (ListViewItem item in listViewHoteleria.SelectedItems)
                {
                    listViewHoteleria.Items.Remove(item);
                }
            }
        }

        private void buttonQuitarPasajero_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewAereos.Items)
            {
                // Elimina los datos de las columnas 15, 16 y 17
                item.SubItems[15].Text = ""; 
                item.SubItems[16].Text = ""; 
                item.SubItems[17].Text = ""; 
            }
        }

        private void buttonVolverAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
