﻿using System;
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
    public partial class GestionItinerarios : Form
    {
        public GestionItinerarios()
        {
            InitializeComponent();
        }

        private int codigoUnico = 1;

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
    }
}
