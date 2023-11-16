namespace AterrizarSA_Grupo5
{
    partial class VerItinerario
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
            label7 = new Label();
            label8 = new Label();
            buttonEditarPasajerosHotel = new Button();
            buttonQuitarHabitacion = new Button();
            label11 = new Label();
            buttonVolverAtras = new Button();
            listViewHoteleria = new ListView();
            idHotel = new ColumnHeader();
            codigo = new ColumnHeader();
            hotel = new ColumnHeader();
            ciudad = new ColumnHeader();
            direccion = new ColumnHeader();
            habitacion = new ColumnHeader();
            tarifa = new ColumnHeader();
            capacidad = new ColumnHeader();
            adultosMax = new ColumnHeader();
            menoresMax = new ColumnHeader();
            infantesMax = new ColumnHeader();
            Desde = new ColumnHeader();
            Hasta = new ColumnHeader();
            groupBox1 = new GroupBox();
            labelSubTotalHoteles = new Label();
            groupBox2 = new GroupBox();
            buttonQuitarPasaje = new Button();
            labelSubTotalVuelos = new Label();
            listViewAereos = new ListView();
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
            impuestos = new ColumnHeader();
            comision = new ColumnHeader();
            disponibilidad = new ColumnHeader();
            idPasaje = new ColumnHeader();
            label6 = new Label();
            buttonQuitarPasajero = new Button();
            buttonEditarPasajerosPasajes = new Button();
            label12 = new Label();
            label20 = new Label();
            panel1 = new Panel();
            labelFechaInicioItinerario = new Label();
            labelItinerarioSelec = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonGenerarPreReserva = new Button();
            idPasajeroPasaje = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero itinerario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(411, 19);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 32);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 17;
            label7.Text = "Servicios Hoteleria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(799, 186);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 21;
            label8.Text = "Subtotal";
            // 
            // buttonEditarPasajerosHotel
            // 
            buttonEditarPasajerosHotel.BackColor = Color.CornflowerBlue;
            buttonEditarPasajerosHotel.FlatAppearance.BorderSize = 0;
            buttonEditarPasajerosHotel.FlatStyle = FlatStyle.Flat;
            buttonEditarPasajerosHotel.ForeColor = Color.White;
            buttonEditarPasajerosHotel.Location = new Point(8, 177);
            buttonEditarPasajerosHotel.Margin = new Padding(3, 4, 3, 4);
            buttonEditarPasajerosHotel.Name = "buttonEditarPasajerosHotel";
            buttonEditarPasajerosHotel.Size = new Size(153, 39);
            buttonEditarPasajerosHotel.TabIndex = 20;
            buttonEditarPasajerosHotel.Text = "Editar pasajeros";
            buttonEditarPasajerosHotel.UseVisualStyleBackColor = false;
            buttonEditarPasajerosHotel.Click += buttonEditarPasajerosHotel_Click;
            // 
            // buttonQuitarHabitacion
            // 
            buttonQuitarHabitacion.BackColor = Color.LightSteelBlue;
            buttonQuitarHabitacion.FlatAppearance.BorderSize = 0;
            buttonQuitarHabitacion.FlatStyle = FlatStyle.Flat;
            buttonQuitarHabitacion.Location = new Point(167, 177);
            buttonQuitarHabitacion.Margin = new Padding(3, 4, 3, 4);
            buttonQuitarHabitacion.Name = "buttonQuitarHabitacion";
            buttonQuitarHabitacion.Size = new Size(153, 39);
            buttonQuitarHabitacion.TabIndex = 19;
            buttonQuitarHabitacion.Text = "Quitar habitación";
            buttonQuitarHabitacion.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(806, 616);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 28;
            label11.Text = "TOTAL:";
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.Location = new Point(806, 666);
            buttonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(153, 39);
            buttonVolverAtras.TabIndex = 30;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // listViewHoteleria
            // 
            listViewHoteleria.Columns.AddRange(new ColumnHeader[] { idHotel, codigo, hotel, ciudad, direccion, habitacion, tarifa, capacidad, adultosMax, menoresMax, infantesMax, Desde, Hasta });
            listViewHoteleria.FullRowSelect = true;
            listViewHoteleria.Location = new Point(8, 53);
            listViewHoteleria.Margin = new Padding(3, 4, 3, 4);
            listViewHoteleria.Name = "listViewHoteleria";
            listViewHoteleria.Size = new Size(929, 116);
            listViewHoteleria.TabIndex = 52;
            listViewHoteleria.UseCompatibleStateImageBehavior = false;
            listViewHoteleria.View = View.Details;
            // 
            // idHotel
            // 
            idHotel.Text = "IdHotel";
            // 
            // codigo
            // 
            codigo.Text = "Código";
            // 
            // hotel
            // 
            hotel.Text = "Hotel";
            // 
            // ciudad
            // 
            ciudad.Text = "Ciudad";
            // 
            // direccion
            // 
            direccion.Text = "Dirección";
            // 
            // habitacion
            // 
            habitacion.Text = "Habitación";
            // 
            // tarifa
            // 
            tarifa.Text = "Tarifa";
            // 
            // capacidad
            // 
            capacidad.Text = "Capacidad";
            // 
            // adultosMax
            // 
            adultosMax.Text = "Adultos máx.";
            // 
            // menoresMax
            // 
            menoresMax.Text = "Menores máx.";
            // 
            // infantesMax
            // 
            infantesMax.Text = "Infantes máx.";
            // 
            // Desde
            // 
            Desde.Text = "Desde";
            // 
            // Hasta
            // 
            Hasta.Text = "Hasta";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(labelSubTotalHoteles);
            groupBox1.Controls.Add(listViewHoteleria);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(buttonQuitarHabitacion);
            groupBox1.Controls.Add(buttonEditarPasajerosHotel);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(16, 345);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(943, 267);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hotelería";
            // 
            // labelSubTotalHoteles
            // 
            labelSubTotalHoteles.AutoSize = true;
            labelSubTotalHoteles.BackColor = Color.LightBlue;
            labelSubTotalHoteles.Location = new Point(857, 186);
            labelSubTotalHoteles.Name = "labelSubTotalHoteles";
            labelSubTotalHoteles.Size = new Size(69, 15);
            labelSubTotalHoteles.TabIndex = 68;
            labelSubTotalHoteles.Text = "SUBTOTAL";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonQuitarPasaje);
            groupBox2.Controls.Add(labelSubTotalVuelos);
            groupBox2.Controls.Add(listViewAereos);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(buttonQuitarPasajero);
            groupBox2.Controls.Add(buttonEditarPasajerosPasajes);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(16, 57);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(943, 267);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vuelos";
            // 
            // buttonQuitarPasaje
            // 
            buttonQuitarPasaje.BackColor = Color.LightSteelBlue;
            buttonQuitarPasaje.FlatAppearance.BorderSize = 0;
            buttonQuitarPasaje.FlatStyle = FlatStyle.Flat;
            buttonQuitarPasaje.Location = new Point(328, 177);
            buttonQuitarPasaje.Margin = new Padding(3, 4, 3, 4);
            buttonQuitarPasaje.Name = "buttonQuitarPasaje";
            buttonQuitarPasaje.Size = new Size(153, 39);
            buttonQuitarPasaje.TabIndex = 68;
            buttonQuitarPasaje.Text = "Quitar pasaje";
            buttonQuitarPasaje.UseVisualStyleBackColor = false;
            buttonQuitarPasaje.Click += buttonQuitarPasaje_Click;
            // 
            // labelSubTotalVuelos
            // 
            labelSubTotalVuelos.AutoSize = true;
            labelSubTotalVuelos.BackColor = Color.LightBlue;
            labelSubTotalVuelos.Location = new Point(857, 189);
            labelSubTotalVuelos.Name = "labelSubTotalVuelos";
            labelSubTotalVuelos.Size = new Size(69, 15);
            labelSubTotalVuelos.TabIndex = 67;
            labelSubTotalVuelos.Text = "SUBTOTAL";
            // 
            // listViewAereos
            // 
            listViewAereos.AllowColumnReorder = true;
            listViewAereos.Columns.AddRange(new ColumnHeader[] { idVuelo, origen, destino, paradas, fechaSalida, fechaLlegada, tiempoVuelo, aerolinea, clase, tipoPasajero, precioBase, impuestos, comision, disponibilidad, idPasaje, idPasajeroPasaje });
            listViewAereos.FullRowSelect = true;
            listViewAereos.Location = new Point(8, 53);
            listViewAereos.Margin = new Padding(3, 4, 3, 4);
            listViewAereos.Name = "listViewAereos";
            listViewAereos.Size = new Size(929, 116);
            listViewAereos.TabIndex = 62;
            listViewAereos.UseCompatibleStateImageBehavior = false;
            listViewAereos.View = View.Details;
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
            precioBase.Text = "Precio base";
            // 
            // impuestos
            // 
            impuestos.Text = "Impuestos";
            // 
            // comision
            // 
            comision.Text = "Comisión";
            // 
            // disponibilidad
            // 
            disponibilidad.Text = "Disponibilidad";
            // 
            // idPasaje
            // 
            idPasaje.Text = "IdPasaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 32);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 17;
            label6.Text = "Servicios Vuelos";
            // 
            // buttonQuitarPasajero
            // 
            buttonQuitarPasajero.BackColor = Color.LightSteelBlue;
            buttonQuitarPasajero.FlatAppearance.BorderSize = 0;
            buttonQuitarPasajero.FlatStyle = FlatStyle.Flat;
            buttonQuitarPasajero.Location = new Point(169, 177);
            buttonQuitarPasajero.Margin = new Padding(3, 4, 3, 4);
            buttonQuitarPasajero.Name = "buttonQuitarPasajero";
            buttonQuitarPasajero.Size = new Size(153, 39);
            buttonQuitarPasajero.TabIndex = 19;
            buttonQuitarPasajero.Text = "Quitar pasajero";
            buttonQuitarPasajero.UseVisualStyleBackColor = false;
            buttonQuitarPasajero.Click += buttonQuitarPasajero_Click;
            // 
            // buttonEditarPasajerosPasajes
            // 
            buttonEditarPasajerosPasajes.BackColor = Color.CornflowerBlue;
            buttonEditarPasajerosPasajes.FlatAppearance.BorderSize = 0;
            buttonEditarPasajerosPasajes.FlatStyle = FlatStyle.Flat;
            buttonEditarPasajerosPasajes.ForeColor = Color.White;
            buttonEditarPasajerosPasajes.Location = new Point(8, 177);
            buttonEditarPasajerosPasajes.Margin = new Padding(3, 4, 3, 4);
            buttonEditarPasajerosPasajes.Name = "buttonEditarPasajerosPasajes";
            buttonEditarPasajerosPasajes.Size = new Size(153, 39);
            buttonEditarPasajerosPasajes.TabIndex = 20;
            buttonEditarPasajerosPasajes.Text = "Editar pasajeros";
            buttonEditarPasajerosPasajes.UseVisualStyleBackColor = false;
            buttonEditarPasajerosPasajes.Click += buttonEditarPasajerosPasajes_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(799, 189);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 21;
            label12.Text = "Subtotal";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.LightBlue;
            label20.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(865, 616);
            label20.Name = "label20";
            label20.Size = new Size(77, 15);
            label20.TabIndex = 77;
            label20.Text = "SUBTOTAL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(labelFechaInicioItinerario);
            panel1.Controls.Add(labelItinerarioSelec);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1557, 53);
            panel1.TabIndex = 73;
            // 
            // labelFechaInicioItinerario
            // 
            labelFechaInicioItinerario.AutoSize = true;
            labelFechaInicioItinerario.Location = new Point(544, 19);
            labelFechaInicioItinerario.Name = "labelFechaInicioItinerario";
            labelFechaInicioItinerario.Size = new Size(121, 15);
            labelFechaInicioItinerario.TabIndex = 74;
            labelFechaInicioItinerario.Text = "NO SELECCIONADO";
            // 
            // labelItinerarioSelec
            // 
            labelItinerarioSelec.AutoSize = true;
            labelItinerarioSelec.Location = new Point(167, 19);
            labelItinerarioSelec.Name = "labelItinerarioSelec";
            labelItinerarioSelec.Size = new Size(121, 15);
            labelItinerarioSelec.TabIndex = 73;
            labelItinerarioSelec.Text = "NO SELECCIONADO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bg_donut_1;
            pictureBox2.Location = new Point(0, 292);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(533, 433);
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.landing_bg_object_2;
            pictureBox3.Location = new Point(1231, -55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(355, 353);
            pictureBox3.TabIndex = 79;
            pictureBox3.TabStop = false;
            // 
            // buttonGenerarPreReserva
            // 
            buttonGenerarPreReserva.BackColor = Color.CornflowerBlue;
            buttonGenerarPreReserva.FlatAppearance.BorderSize = 0;
            buttonGenerarPreReserva.FlatStyle = FlatStyle.Flat;
            buttonGenerarPreReserva.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarPreReserva.ForeColor = Color.White;
            buttonGenerarPreReserva.Location = new Point(24, 666);
            buttonGenerarPreReserva.Margin = new Padding(3, 4, 3, 4);
            buttonGenerarPreReserva.Name = "buttonGenerarPreReserva";
            buttonGenerarPreReserva.Size = new Size(143, 39);
            buttonGenerarPreReserva.TabIndex = 81;
            buttonGenerarPreReserva.Text = "Generar pre-reserva";
            buttonGenerarPreReserva.UseVisualStyleBackColor = false;
            buttonGenerarPreReserva.Click += buttonGenerarPreReserva_Click;
            // 
            // idPasajeroPasaje
            // 
            idPasajeroPasaje.Text = "IdPasajeroPasaje";
            // 
            // VerItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(974, 724);
            Controls.Add(groupBox1);
            Controls.Add(buttonGenerarPreReserva);
            Controls.Add(panel1);
            Controls.Add(label20);
            Controls.Add(groupBox2);
            Controls.Add(buttonVolverAtras);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerItinerario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VerItinerario";
            Load += VerItinerario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button buttonQuitarHabitacion;
        private Label label11;
        private Button button7;
        private ListView listViewHoteleria;
        private ColumnHeader codigo;
        private ColumnHeader hotel;
        private ColumnHeader ciudad;
        private ColumnHeader direccion;
        private ColumnHeader habitacion;
        private ColumnHeader tarifa;
        private ColumnHeader capacidad;
        private ColumnHeader adultosMax;
        private ColumnHeader menoresMax;
        private ColumnHeader infantesMax;
        private ColumnHeader Desde;
        private ColumnHeader Hasta;
        private ColumnHeader idHotel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Button button3;
        private Button button6;
        private Label label12;
        private ListView listViewAereos;
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
        private ColumnHeader impuestos;
        private ColumnHeader comision;
        private ColumnHeader disponibilidad;
        private Label labelSubTotalHoteles;
        private Label labelSubTotalVuelos;
        private Label label20;
        private Panel panel1;
        private Label label22;
        private Label label21;
        private PictureBox pictureBox1;
        private Label label24;
        private Label label23;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button8;
        private ColumnHeader idPasaje;
        private Label itinerarioSelec;
        private Label labelFechaInicioItinerario;
        private Label labelItinerarioSelec;
        private Button buttonEditarPasajerosPasajes;
        private Button buttonQuitarPasajero;
        private Button buttonEditarPasajerosHotel;
        private Button buttonVolverAtras;
        private Button buttonGenerarPreReserva;
        private Button buttonQuitarPasaje;
        private ColumnHeader idPasajeroPasaje;
    }
}