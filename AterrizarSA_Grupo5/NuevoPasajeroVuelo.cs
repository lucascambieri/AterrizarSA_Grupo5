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
    public partial class NuevoPasajeroVuelo : Form
    {
        NuevoPasajeroVueloModel model;
        public NuevoPasajeroVuelo()
        {
            InitializeComponent();
        }
        private void NuevoPasajeroVuelo_Load(object sender, EventArgs e)
        {
            model = new NuevoPasajeroVueloModel();
            //model.CrearReserva();
            // Cargo itinerario activo + pasaje
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");
            labelReservaSelec.Text = ReservaMod.ReservaDelItinerarioActivo.IdReserva.ToString("D5");
            labelVueloyPasaje.Text = ReservaMod.VueloSeleccionado.VueloPasaje.IdVuelo.ToString("D5") + "-" + ReservaMod.VueloSeleccionado.VueloPasaje.Pasajes[0].IdPasaje.ToString("D5");
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
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
                // Validar pasajero cargado == del pasaje
                int disponibilidad = model.ValidarDisponibilidad(valorTipoPasajero);
                if (disponibilidad == 0)
                {
                    if (model.AgregarPasajero() == 0)
                    {
                        MessageBox.Show("Pasajero agregado exitosamente", "Pasajero agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
}
