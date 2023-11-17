namespace AterrizarSA_Grupo5
{
    partial class ListadoVuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxOrigen = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            dTPickerVuelta = new DateTimePicker();
            dTPickerIda = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            comboBoxInfantes = new ComboBox();
            comboBoxMenores = new ComboBox();
            comboBoxAdultos = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxDestino = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            buttonGuardarPasaje = new Button();
            buttonVolverAtras = new Button();
            buttonBuscarPasajes = new Button();
            listViewPasajes = new ListView();
            idVuelo = new ColumnHeader();
            origen = new ColumnHeader();
            destino = new ColumnHeader();
            paradas = new ColumnHeader();
            fechaSalida = new ColumnHeader();
            fechaLlegada = new ColumnHeader();
            tiempoVuelo = new ColumnHeader();
            aerolinea = new ColumnHeader();
            clase = new ColumnHeader();
            tipoPasajero = new ColumnHeader();
            precioBase = new ColumnHeader();
            disponibilidad = new ColumnHeader();
            idPasaje = new ColumnHeader();
            label16 = new Label();
            groupBoxBusqueda = new GroupBox();
            comboBoxCategorias = new ComboBox();
            label17 = new Label();
            panel1 = new Panel();
            labelItinerarioSelec = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBoxVuelos = new GroupBox();
            groupBoxBusqueda.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(409, 68);
            comboBoxOrigen.Margin = new Padding(3, 4, 3, 4);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(165, 23);
            comboBoxOrigen.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(409, 49);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 32;
            label10.Text = "Ciudad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 22);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 30;
            label8.Text = "Seleccione el origen:";
            // 
            // dTPickerVuelta
            // 
            dTPickerVuelta.Location = new Point(47, 234);
            dTPickerVuelta.Margin = new Padding(3, 4, 3, 4);
            dTPickerVuelta.Name = "dTPickerVuelta";
            dTPickerVuelta.Size = new Size(259, 21);
            dTPickerVuelta.TabIndex = 29;
            // 
            // dTPickerIda
            // 
            dTPickerIda.Location = new Point(47, 173);
            dTPickerIda.Margin = new Padding(3, 4, 3, 4);
            dTPickerIda.Name = "dTPickerIda";
            dTPickerIda.Size = new Size(259, 21);
            dTPickerIda.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 212);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 27;
            label7.Text = "Fecha vuelta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 152);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 26;
            label6.Text = "Fecha ida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 127);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 25;
            label3.Text = "Seleccione las fechas:";
            // 
            // comboBoxInfantes
            // 
            comboBoxInfantes.FormattingEnabled = true;
            comboBoxInfantes.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxInfantes.Location = new Point(276, 68);
            comboBoxInfantes.Margin = new Padding(3, 4, 3, 4);
            comboBoxInfantes.Name = "comboBoxInfantes";
            comboBoxInfantes.Size = new Size(49, 23);
            comboBoxInfantes.TabIndex = 24;
            // 
            // comboBoxMenores
            // 
            comboBoxMenores.FormattingEnabled = true;
            comboBoxMenores.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxMenores.Location = new Point(163, 68);
            comboBoxMenores.Margin = new Padding(3, 4, 3, 4);
            comboBoxMenores.Name = "comboBoxMenores";
            comboBoxMenores.Size = new Size(49, 23);
            comboBoxMenores.TabIndex = 23;
            // 
            // comboBoxAdultos
            // 
            comboBoxAdultos.FormattingEnabled = true;
            comboBoxAdultos.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxAdultos.Location = new Point(51, 68);
            comboBoxAdultos.Margin = new Padding(3, 4, 3, 4);
            comboBoxAdultos.Name = "comboBoxAdultos";
            comboBoxAdultos.Size = new Size(49, 23);
            comboBoxAdultos.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 49);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 21;
            label5.Text = "Infantes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 49);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 20;
            label4.Text = "Menores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 19;
            label2.Text = "Adultos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 18;
            label1.Text = "Disponibilidad para:";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(636, 68);
            comboBoxDestino.Margin = new Padding(3, 4, 3, 4);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(165, 23);
            comboBoxDestino.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(636, 49);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 37;
            label11.Text = "Ciudad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(636, 22);
            label13.Name = "label13";
            label13.Size = new Size(127, 15);
            label13.TabIndex = 35;
            label13.Text = "Seleccione el destino:";
            // 
            // buttonGuardarPasaje
            // 
            buttonGuardarPasaje.BackColor = Color.CornflowerBlue;
            buttonGuardarPasaje.FlatAppearance.BorderSize = 0;
            buttonGuardarPasaje.FlatStyle = FlatStyle.Flat;
            buttonGuardarPasaje.ForeColor = Color.White;
            buttonGuardarPasaje.Location = new Point(1039, 483);
            buttonGuardarPasaje.Margin = new Padding(3, 4, 3, 4);
            buttonGuardarPasaje.Name = "buttonGuardarPasaje";
            buttonGuardarPasaje.Size = new Size(152, 51);
            buttonGuardarPasaje.TabIndex = 44;
            buttonGuardarPasaje.Text = "Guardar selección";
            buttonGuardarPasaje.UseVisualStyleBackColor = false;
            buttonGuardarPasaje.Click += buttonGuardarPasaje_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.ForeColor = Color.Black;
            buttonVolverAtras.Location = new Point(1039, 551);
            buttonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(152, 51);
            buttonVolverAtras.TabIndex = 46;
            buttonVolverAtras.Text = "Volver al menú";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonBuscarPasajes
            // 
            buttonBuscarPasajes.BackColor = Color.RoyalBlue;
            buttonBuscarPasajes.FlatAppearance.BorderSize = 0;
            buttonBuscarPasajes.FlatStyle = FlatStyle.Flat;
            buttonBuscarPasajes.ForeColor = Color.White;
            buttonBuscarPasajes.Location = new Point(1023, 225);
            buttonBuscarPasajes.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarPasajes.Name = "buttonBuscarPasajes";
            buttonBuscarPasajes.Size = new Size(152, 42);
            buttonBuscarPasajes.TabIndex = 47;
            buttonBuscarPasajes.Text = "BUSCAR";
            buttonBuscarPasajes.UseVisualStyleBackColor = false;
            buttonBuscarPasajes.Click += buttonBuscarPasajes_Click;
            // 
            // listViewPasajes
            // 
            listViewPasajes.AllowColumnReorder = true;
            listViewPasajes.Columns.AddRange(new ColumnHeader[] { idVuelo, origen, destino, paradas, fechaSalida, fechaLlegada, tiempoVuelo, aerolinea, clase, tipoPasajero, precioBase, disponibilidad, idPasaje });
            listViewPasajes.FullRowSelect = true;
            listViewPasajes.Location = new Point(35, 377);
            listViewPasajes.Margin = new Padding(3, 4, 3, 4);
            listViewPasajes.Name = "listViewPasajes";
            listViewPasajes.Size = new Size(1156, 98);
            listViewPasajes.TabIndex = 49;
            listViewPasajes.UseCompatibleStateImageBehavior = false;
            listViewPasajes.View = View.Details;
            // 
            // idVuelo
            // 
            idVuelo.Text = "IdVuelo";
            // 
            // origen
            // 
            origen.Text = "Origen";
            // 
            // destino
            // 
            destino.Text = "Destino";
            // 
            // paradas
            // 
            paradas.Text = "Paradas";
            // 
            // fechaSalida
            // 
            fechaSalida.Text = "Fecha salida";
            // 
            // fechaLlegada
            // 
            fechaLlegada.Text = "Fecha llegada";
            // 
            // tiempoVuelo
            // 
            tiempoVuelo.Text = "Tiempo de vuelo";
            // 
            // aerolinea
            // 
            aerolinea.Text = "Aerolinea";
            // 
            // clase
            // 
            clase.Text = "Clase";
            // 
            // tipoPasajero
            // 
            tipoPasajero.Text = "Tipo de pasajero";
            // 
            // precioBase
            // 
            precioBase.Text = "Precio";
            // 
            // disponibilidad
            // 
            disponibilidad.Text = "Disponibilidad";
            // 
            // idPasaje
            // 
            idPasaje.Text = "IdPasaje";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(14, 15);
            label16.Name = "label16";
            label16.Size = new Size(109, 15);
            label16.TabIndex = 51;
            label16.Text = "N° de itinerario:";
            // 
            // groupBoxBusqueda
            // 
            groupBoxBusqueda.BackColor = Color.White;
            groupBoxBusqueda.Controls.Add(comboBoxCategorias);
            groupBoxBusqueda.Controls.Add(label17);
            groupBoxBusqueda.Controls.Add(label1);
            groupBoxBusqueda.Controls.Add(comboBoxInfantes);
            groupBoxBusqueda.Controls.Add(label2);
            groupBoxBusqueda.Controls.Add(label4);
            groupBoxBusqueda.Controls.Add(label5);
            groupBoxBusqueda.Controls.Add(buttonBuscarPasajes);
            groupBoxBusqueda.Controls.Add(comboBoxAdultos);
            groupBoxBusqueda.Controls.Add(comboBoxMenores);
            groupBoxBusqueda.Controls.Add(label3);
            groupBoxBusqueda.Controls.Add(dTPickerIda);
            groupBoxBusqueda.Controls.Add(comboBoxDestino);
            groupBoxBusqueda.Controls.Add(label6);
            groupBoxBusqueda.Controls.Add(label11);
            groupBoxBusqueda.Controls.Add(comboBoxOrigen);
            groupBoxBusqueda.Controls.Add(label8);
            groupBoxBusqueda.Controls.Add(label10);
            groupBoxBusqueda.Controls.Add(dTPickerVuelta);
            groupBoxBusqueda.Controls.Add(label7);
            groupBoxBusqueda.Controls.Add(label13);
            groupBoxBusqueda.Location = new Point(16, 55);
            groupBoxBusqueda.Margin = new Padding(3, 4, 3, 4);
            groupBoxBusqueda.Name = "groupBoxBusqueda";
            groupBoxBusqueda.Padding = new Padding(3, 4, 3, 4);
            groupBoxBusqueda.Size = new Size(1182, 282);
            groupBoxBusqueda.TabIndex = 53;
            groupBoxBusqueda.TabStop = false;
            groupBoxBusqueda.Text = "Buscar vuelo:";
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(409, 146);
            comboBoxCategorias.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(142, 23);
            comboBoxCategorias.TabIndex = 49;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(409, 127);
            label17.Name = "label17";
            label17.Size = new Size(116, 15);
            label17.TabIndex = 48;
            label17.Text = "Seleccione la clase:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(labelItinerarioSelec);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 50);
            panel1.TabIndex = 54;
            // 
            // labelItinerarioSelec
            // 
            labelItinerarioSelec.AutoSize = true;
            labelItinerarioSelec.Location = new Point(146, 15);
            labelItinerarioSelec.Name = "labelItinerarioSelec";
            labelItinerarioSelec.Size = new Size(121, 15);
            labelItinerarioSelec.TabIndex = 50;
            labelItinerarioSelec.Text = "NO SELECCIONADO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.landing_bg_object_2;
            pictureBox1.Location = new Point(-2, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 349);
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bg_donut;
            pictureBox3.Location = new Point(792, 228);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(515, 392);
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // groupBoxVuelos
            // 
            groupBoxVuelos.BackColor = Color.White;
            groupBoxVuelos.Location = new Point(17, 344);
            groupBoxVuelos.Name = "groupBoxVuelos";
            groupBoxVuelos.Size = new Size(1181, 202);
            groupBoxVuelos.TabIndex = 57;
            groupBoxVuelos.TabStop = false;
            groupBoxVuelos.Text = "Seleccion de vuelos:";
            // 
            // ListadoVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1216, 610);
            Controls.Add(buttonGuardarPasaje);
            Controls.Add(listViewPasajes);
            Controls.Add(groupBoxVuelos);
            Controls.Add(panel1);
            Controls.Add(groupBoxBusqueda);
            Controls.Add(buttonVolverAtras);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListadoVuelos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListadoVuelos";
            TransparencyKey = Color.Red;
            Load += ListadoVuelos_Load;
            groupBoxBusqueda.ResumeLayout(false);
            groupBoxBusqueda.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxOrigen;
        private Label label10;
        private Label label8;
        private DateTimePicker dTPickerVuelta;
        private DateTimePicker dTPickerIda;
        private Label label7;
        private Label label6;
        private Label label3;
        private ComboBox comboBoxInfantes;
        private ComboBox comboBoxMenores;
        private ComboBox comboBoxAdultos;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxDestino;
        private Label label11;
        private Label label13;
        private Button buttonGuardarPasaje;
        private Button buttonVolverAtras;
        private Button buttonBuscarPasajes;
        private ListView listViewPasajes;
        private ColumnHeader idVuelo;
        private ColumnHeader origen;
        private ColumnHeader destino;
        private ColumnHeader paradas;
        private ColumnHeader fechaSalida;
        private ColumnHeader fechaLlegada;
        private ColumnHeader tiempoVuelo;
        private ColumnHeader aerolinea;
        private ColumnHeader clase;
        private ColumnHeader tipoPasajero;
        private ColumnHeader precioBase;
        private ColumnHeader disponibilidad;
        private Label label16;
        private GroupBox groupBoxBusqueda;
        private ComboBox comboBoxCategorias;
        private Label label17;
        private Panel panel1;
        private Label labelItinerarioSelec;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private ColumnHeader idPasaje;
        private GroupBox groupBoxVuelos;
    }
}