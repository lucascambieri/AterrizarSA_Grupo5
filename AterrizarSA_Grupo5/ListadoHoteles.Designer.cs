namespace AterrizarSA_Grupo5
{
    partial class ListadoHoteles
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxAdultos = new ComboBox();
            comboBoxMenores = new ComboBox();
            comboBoxInfantes = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            dTPickerIn = new DateTimePicker();
            dTPickerOut = new DateTimePicker();
            label8 = new Label();
            label10 = new Label();
            comboBoxDestino = new ComboBox();
            buttonBuscarHabitacion = new Button();
            label11 = new Label();
            buttonGuardarHabitacion = new Button();
            buttonVolverAtras = new Button();
            listViewHabitaciones = new ListView();
            idHotel = new ColumnHeader();
            codigoHotel = new ColumnHeader();
            hotel = new ColumnHeader();
            ciudad = new ColumnHeader();
            direccion = new ColumnHeader();
            idHabitacion = new ColumnHeader();
            tarifa = new ColumnHeader();
            capacidad = new ColumnHeader();
            camasAdultos = new ColumnHeader();
            camasMenores = new ColumnHeader();
            camasInfantes = new ColumnHeader();
            desde = new ColumnHeader();
            hasta = new ColumnHeader();
            label16 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            labelItinerarioSelec = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 58);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Habitaciones para:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Adultos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(626, 76);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Menores:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(716, 76);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Infantes:";
            // 
            // comboBoxAdultos
            // 
            comboBoxAdultos.BackColor = Color.White;
            comboBoxAdultos.FormattingEnabled = true;
            comboBoxAdultos.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxAdultos.Location = new Point(548, 94);
            comboBoxAdultos.Name = "comboBoxAdultos";
            comboBoxAdultos.Size = new Size(39, 23);
            comboBoxAdultos.TabIndex = 5;
            // 
            // comboBoxMenores
            // 
            comboBoxMenores.FormattingEnabled = true;
            comboBoxMenores.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxMenores.Location = new Point(637, 94);
            comboBoxMenores.Name = "comboBoxMenores";
            comboBoxMenores.Size = new Size(39, 23);
            comboBoxMenores.TabIndex = 6;
            // 
            // comboBoxInfantes
            // 
            comboBoxInfantes.FormattingEnabled = true;
            comboBoxInfantes.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBoxInfantes.Location = new Point(725, 94);
            comboBoxInfantes.Name = "comboBoxInfantes";
            comboBoxInfantes.Size = new Size(39, 23);
            comboBoxInfantes.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 23);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 8;
            label3.Text = "Seleccione las fechas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 41);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Check-In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 95);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 10;
            label7.Text = "Check-Out";
            // 
            // dTPickerIn
            // 
            dTPickerIn.Location = new Point(259, 59);
            dTPickerIn.Name = "dTPickerIn";
            dTPickerIn.Size = new Size(203, 21);
            dTPickerIn.TabIndex = 11;
            // 
            // dTPickerOut
            // 
            dTPickerOut.Location = new Point(259, 113);
            dTPickerOut.Name = "dTPickerOut";
            dTPickerOut.Size = new Size(203, 21);
            dTPickerOut.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 23);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 13;
            label8.Text = "Seleccione el destino:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 41);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 15;
            label10.Text = "Ciudad:";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(18, 59);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(129, 23);
            comboBoxDestino.TabIndex = 17;
            // 
            // buttonBuscarHabitacion
            // 
            buttonBuscarHabitacion.BackColor = Color.RoyalBlue;
            buttonBuscarHabitacion.FlatAppearance.BorderSize = 0;
            buttonBuscarHabitacion.FlatStyle = FlatStyle.Flat;
            buttonBuscarHabitacion.ForeColor = Color.White;
            buttonBuscarHabitacion.Location = new Point(863, 68);
            buttonBuscarHabitacion.Name = "buttonBuscarHabitacion";
            buttonBuscarHabitacion.Size = new Size(123, 42);
            buttonBuscarHabitacion.TabIndex = 18;
            buttonBuscarHabitacion.Text = "BUSCAR";
            buttonBuscarHabitacion.UseVisualStyleBackColor = false;
            buttonBuscarHabitacion.Click += buttonBuscarHabitacion_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(27, 232);
            label11.Name = "label11";
            label11.Size = new Size(154, 15);
            label11.TabIndex = 19;
            label11.Text = "Seleccion de habitaciones:";
            // 
            // buttonGuardarHabitacion
            // 
            buttonGuardarHabitacion.BackColor = Color.CornflowerBlue;
            buttonGuardarHabitacion.FlatAppearance.BorderSize = 0;
            buttonGuardarHabitacion.FlatStyle = FlatStyle.Flat;
            buttonGuardarHabitacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarHabitacion.ForeColor = Color.White;
            buttonGuardarHabitacion.Location = new Point(914, 353);
            buttonGuardarHabitacion.Name = "buttonGuardarHabitacion";
            buttonGuardarHabitacion.Size = new Size(133, 38);
            buttonGuardarHabitacion.TabIndex = 23;
            buttonGuardarHabitacion.Text = "Guardar selección";
            buttonGuardarHabitacion.UseVisualStyleBackColor = false;
            buttonGuardarHabitacion.Click += buttonGuardarHabitacion_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolverAtras.ForeColor = Color.Black;
            buttonVolverAtras.Location = new Point(914, 419);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(133, 38);
            buttonVolverAtras.TabIndex = 25;
            buttonVolverAtras.Text = "Volver al menú";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // listViewHabitaciones
            // 
            listViewHabitaciones.BackColor = Color.White;
            listViewHabitaciones.Columns.AddRange(new ColumnHeader[] { idHotel, codigoHotel, hotel, ciudad, direccion, idHabitacion, tarifa, capacidad, camasAdultos, camasMenores, camasInfantes, desde, hasta });
            listViewHabitaciones.FullRowSelect = true;
            listViewHabitaciones.Location = new Point(27, 250);
            listViewHabitaciones.Name = "listViewHabitaciones";
            listViewHabitaciones.Size = new Size(1020, 97);
            listViewHabitaciones.TabIndex = 51;
            listViewHabitaciones.UseCompatibleStateImageBehavior = false;
            listViewHabitaciones.View = View.Details;
            // 
            // idHotel
            // 
            idHotel.Text = "IdHotel";
            // 
            // codigoHotel
            // 
            codigoHotel.Text = "Código";
            // 
            // hotel
            // 
            hotel.Text = "Hotel";
            // 
            // ciudad
            // 
            ciudad.Text = "Ciudad";
            ciudad.Width = 97;
            // 
            // direccion
            // 
            direccion.Text = "Dirección";
            direccion.Width = 65;
            // 
            // idHabitacion
            // 
            idHabitacion.Text = "Habitación";
            idHabitacion.Width = 70;
            // 
            // tarifa
            // 
            tarifa.Text = "Tarifa";
            tarifa.Width = 70;
            // 
            // capacidad
            // 
            capacidad.Text = "Capacidad";
            capacidad.Width = 70;
            // 
            // camasAdultos
            // 
            camasAdultos.Text = "Camas adultos";
            camasAdultos.Width = 95;
            // 
            // camasMenores
            // 
            camasMenores.Text = "Camas menores";
            camasMenores.Width = 98;
            // 
            // camasInfantes
            // 
            camasInfantes.Text = "Camas infantes";
            camasInfantes.Width = 98;
            // 
            // desde
            // 
            desde.Text = "Desde";
            desde.Width = 88;
            // 
            // hasta
            // 
            hasta.Text = "Hasta";
            hasta.Width = 88;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(11, 8);
            label16.Name = "label16";
            label16.Size = new Size(109, 15);
            label16.TabIndex = 53;
            label16.Text = "N° de itinerario:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxAdultos);
            groupBox1.Controls.Add(comboBoxMenores);
            groupBox1.Controls.Add(comboBoxInfantes);
            groupBox1.Controls.Add(buttonBuscarHabitacion);
            groupBox1.Controls.Add(dTPickerIn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxDestino);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dTPickerOut);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1035, 176);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar hotel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg_donut_1;
            pictureBox1.Location = new Point(-1, 150);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 330);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(labelItinerarioSelec);
            panel1.Controls.Add(label16);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 31);
            panel1.TabIndex = 57;
            // 
            // labelItinerarioSelec
            // 
            labelItinerarioSelec.AutoSize = true;
            labelItinerarioSelec.Location = new Point(127, 8);
            labelItinerarioSelec.Name = "labelItinerarioSelec";
            labelItinerarioSelec.Size = new Size(114, 15);
            labelItinerarioSelec.TabIndex = 19;
            labelItinerarioSelec.Text = "NO SELECCIONADO";
            // 
            // ListadoHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1080, 473);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(listViewHabitaciones);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonGuardarHabitacion);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ListadoHoteles";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListadoHoteles";
            Load += ListadoHoteles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxAdultos;
        private ComboBox comboBoxMenores;
        private ComboBox comboBoxInfantes;
        private Label label3;
        private Label label6;
        private Label label7;
        private DateTimePicker dTPickerIn;
        private DateTimePicker dTPickerOut;
        private Label label8;
        private Label label10;
        private ComboBox comboBoxDestino;
        private Button buttonBuscarHabitacion;
        private Label label11;
        private Button buttonGuardarHabitacion;
        private Button buttonVolverAtras;
        private ListView listViewHabitaciones;
        private ColumnHeader idHotel;
        private ColumnHeader codigoHotel;
        private ColumnHeader hotel;
        private ColumnHeader ciudad;
        private ColumnHeader direccion;
        private ColumnHeader idHabitacion;
        private ColumnHeader tarifa;
        private ColumnHeader capacidad;
        private ColumnHeader camasAdultos;
        private ColumnHeader camasMenores;
        private ColumnHeader camasInfantes;
        private ColumnHeader desde;
        private ColumnHeader hasta;
        private Label label16;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelItinerarioSelec;
    }
}