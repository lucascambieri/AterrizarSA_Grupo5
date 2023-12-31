﻿using AterrizarSA_Grupo5.Entidades;
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
    public partial class ListadoHoteles : Form
    {
        ListadoHotelesModel model;
        public ListadoHoteles()
        {
            InitializeComponent();
        }

        private void ListadoHoteles_Load(object sender, EventArgs e)
        {
            model = new ListadoHotelesModel();
            // cargo itininerario activo 
            labelItinerarioSelec.Text = ItinerarioMod.ItinerarioActivo.Id.ToString("D5");

            List<ListadoHotelesModel> listaHabitaciones = model.ListarHabitaciones();

            foreach (var habitacion in listaHabitaciones)
            {
                ListViewItem listViewItem = new ListViewItem(habitacion.IdHotel.ToString());
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
                listViewItem.SubItems.Add(habitacion.FechaInicioDisp.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(habitacion.FechaFinDisp.ToString("dd/MM/yyyy"));
                listViewHabitaciones.Items.Add(listViewItem);
            }
        }
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonGuardarHabitacion_Click(object sender, EventArgs e)
        {
            if (listViewHabitaciones.SelectedItems.Count == 1)
            {
                model.IdHotel = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[0].Text);
                model.CodHotel = listViewHabitaciones.SelectedItems[0].SubItems[1].Text;
                model.Nombre = listViewHabitaciones.SelectedItems[0].SubItems[2].Text;
                model.Ciudad = listViewHabitaciones.SelectedItems[0].SubItems[3].Text;
                model.Direccion = listViewHabitaciones.SelectedItems[0].SubItems[4].Text;
                model.IdHabitacion = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[5].Text);
                model.PrecioNoche = double.Parse(listViewHabitaciones.SelectedItems[0].SubItems[6].Text);
                model.CapacidadMaxima = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[7].Text);
                model.CantidadCamasAdultos = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[8].Text);
                model.CantidadCamasMenores = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[9].Text);
                model.CantidadCamasInfantes = int.Parse(listViewHabitaciones.SelectedItems[0].SubItems[10].Text);
                model.FechaInicioDisp = dTPickerIn.Value.Date;
                model.FechaFinDisp = dTPickerOut.Value.Date;
                int result = model.Guardarhabitacion();
                if (result == 0)
                {
                    MessageBox.Show("Habitación agregada exitosamente", "Habitacion agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
