using AterrizarSA_Grupo5.Entidades;
using AterrizarSA_Grupo5.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AterrizarSA_Grupo5
{
    public partial class NuevoPasajeroHotel : Form
    {
        NuevoPasajeroHotelModel model;
        //List<HabitacionSelecEnt> listaHabitacionesSelec;
        List<HotelEnt> listaHabitacionesSelec;
        //HabitacionesSelecEnt habitacionSelec;
        HotelEnt habitacionSelec;
        public NuevoPasajeroHotel()
        {
            InitializeComponent();
        }

        private void NuevoPasajeroHotel_Load(object sender, EventArgs e)
        {
            model = new NuevoPasajeroHotelModel();
            // Reviso si existe reserva, si no la creo
            //model.CrearReserva();
            // Cargo itinerario activo + habitaciones
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");
            labelReservaSelec.Text = ReservaMod.ReservaDelItinerarioActivo.IdReserva.ToString("D5");
            listaHabitacionesSelec = model.ListarHabitacionesDelItinerario();
            foreach (var hotel in listaHabitacionesSelec)
            {
                foreach (var habitacion in hotel.Habitaciones)
                {
                    comboBoxHabitaciones.Items.Add(hotel.IdHotel.ToString("D5") + "-" + habitacion.IdHabitacion.ToString("D5"));
                }
            }
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxHabitaciones.Text == "")
            {
                MessageBox.Show("Debe seleccionar una habitación", "Seleccione habitación", MessageBoxButtons.OK);
            }
            else
            {
                // Validar datos básicos
                model.Nombre = textBoxNombre.Text;
                model.Apellido = textBoxApellido.Text;
                model.DNI = textBoxDNI.Text;
                model.FechaNacimiento = dateTimePickerFechaNac.Value.Date;
                string mensaje = model.ValidarDatos();
                if (mensaje == "OK")
                {
                    string valorTipoPasajero;
                    var edad = DateTime.Today.Year - model.FechaNacimiento.Year;
                    switch (edad)
                    {
                        case >= 18:
                            valorTipoPasajero = "Adulto";
                            break;
                        case >= 2:
                            valorTipoPasajero = "Menor";
                            break;
                        case >= 0:
                            valorTipoPasajero = "Infante";
                            break;
                        default:
                            valorTipoPasajero = "Error";
                            break;
                    }
                    // Validad capacidades de la habitacion
                    int disponibilidad = model.ValidarDisponibilidad(valorTipoPasajero);
                    if (disponibilidad == 0)
                    {
                        if (model.AgregarPasajero() == 0)
                        {
                            ListViewItem nuevoItem = new ListViewItem(model.Nombre);
                            nuevoItem.SubItems.Add(model.Apellido);
                            nuevoItem.SubItems.Add(model.DNI);
                            nuevoItem.SubItems.Add(model.FechaNacimiento.ToString("dd/MM/yyyy"));
                            nuevoItem.SubItems.Add(valorTipoPasajero);
                            switch (valorTipoPasajero)
                            {
                                case "Adulto":
                                    model.AdultosAgregados++;
                                    break;
                                case "Menor":
                                    model.MenoresAgregados++;
                                    break;
                                case "Infante":
                                    model.InfantesAgregados++;
                                    break;
                            }
                            model.RestarDisponibilidad(valorTipoPasajero);

                            listViewPasajeros.Items.Add(nuevoItem);
                            listViewPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                            textBoxNombre.Clear();
                            textBoxApellido.Clear();
                            textBoxDNI.Clear();
                            dateTimePickerFechaNac.Value = DateTime.Now.Date;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el pasajero ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay disponibilidad suficiente", "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (listViewPasajeros.SelectedItems.Count == 1)
            {
                var result = MessageBox.Show("¿Está seguro que desea eliminar a: " + listViewPasajeros.SelectedItems[0].Text + "?", "Sale Aplicacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int dniEliminar;

                    dniEliminar = int.Parse(listViewPasajeros.SelectedItems[0].SubItems[2].Text);
                    if (model.QuitarPasajero(dniEliminar) == 0)
                    {
                        model.ActualizarDisponibilidad(listViewPasajeros.SelectedItems[0].SubItems[4].Text);
                        MessageBox.Show("Pasajero eliminado correctamente", "Pasajero eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listViewPasajeros.Items.Remove(listViewPasajeros.SelectedItems[0]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Elija un (y solo un) pasajero", "Elija pasajero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var hotel in listaHabitacionesSelec)
            {
                foreach (var hab in hotel.Habitaciones)
                {
                    if (hab.IdHabitacion.ToString("D5") == comboBoxHabitaciones.Text.Substring(6))
                    {
                        model.IdHotel = hotel.IdHotel;
                        model.CodHotel = hotel.CodHotel;
                        model.NombreHotel = hotel.Nombre;
                        model.Ciudad = hotel.Ciudad;
                        model.Calificacion = hotel.Calificacion;
                        model.Direccion = hotel.Direccion;
                        model.IdHabitacion = hab.IdHabitacion;
                        model.Descripcion = hab.Descripcion;
                        model.CapacidadMaxima = hab.CapacidadMaxima;
                        model.CantidadCamasAdultos = hab.CantidadCamasAdultos;
                        model.CantidadCamasMenores = hab.CantidadCamasMenores;
                        model.CantidadCamasInfantes = hab.CantidadCamasInfantes;
                        model.PrecioNoche = hab.PrecioNoche;
                        model.FechaDesde = hab.Disponibilidad[0].FechaInicioDisp;
                        model.FechaHasta = hab.Disponibilidad[0].FechaFinDisp;
                    }
                }
            }
            listViewPasajeros.Items.Clear();
            List<PasajeroEnt> pasajeros = model.ListarPasajerosPorHabitacion(int.Parse(comboBoxHabitaciones.Text.Substring(6)));
            foreach (var pasajero in pasajeros)
            {
                ListViewItem nuevoItem = new ListViewItem(pasajero.Nombre);
                nuevoItem.SubItems.Add(pasajero.Apellido);
                nuevoItem.SubItems.Add(pasajero.DNI.ToString());
                nuevoItem.SubItems.Add(pasajero.FechaNacimiento.ToString("dd/MM/yyyy"));
                var edad = DateTime.Today.Year - pasajero.FechaNacimiento.Year;
                switch (edad)
                {
                    case >= 18:
                        nuevoItem.SubItems.Add("Adulto");
                        break;
                    case >= 2:
                        nuevoItem.SubItems.Add("Menor");
                        break;
                    case >= 0:
                        nuevoItem.SubItems.Add("Infante");
                        break;
                }
                listViewPasajeros.Items.Add(nuevoItem);
                listViewPasajeros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            int result = model.CargarDisponibilidades();
        }
    }
}
