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
            button4 = new Button();
            button5 = new Button();
            label10 = new Label();
            label11 = new Label();
            button7 = new Button();
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
            listView2 = new ListView();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label3 = new Label();
            labelSubTotalHoteles = new Label();
            label4 = new Label();
            label18 = new Label();
            button1 = new Button();
            label19 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label9 = new Label();
            label16 = new Label();
            labelSubTotalVuelos = new Label();
            label17 = new Label();
            listView9 = new ListView();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
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
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            button6 = new Button();
            label12 = new Label();
            label13 = new Label();
            label20 = new Label();
            panel1 = new Panel();
            label24 = new Label();
            label23 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button8 = new Button();
            idPasaje = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            label8.Location = new Point(558, 186);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 21;
            label8.Text = "Subtotal";
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(8, 176);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(153, 39);
            button4.TabIndex = 20;
            button4.Text = "Editar pasajeros";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(169, 176);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(153, 39);
            button5.TabIndex = 19;
            button5.Text = "Quitar";
            button5.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(766, 32);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 23;
            label10.Text = "Servicios Extra";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1320, 625);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 28;
            label11.Text = "TOTAL:";
            // 
            // button7
            // 
            button7.BackColor = Color.LightSteelBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1344, 672);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(153, 39);
            button7.TabIndex = 30;
            button7.Text = "Volver atrás";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_2;
            // 
            // listViewHoteleria
            // 
            listViewHoteleria.Columns.AddRange(new ColumnHeader[] { idHotel, codigo, hotel, ciudad, direccion, habitacion, tarifa, capacidad, adultosMax, menoresMax, infantesMax, Desde, Hasta });
            listViewHoteleria.FullRowSelect = true;
            listViewHoteleria.Location = new Point(8, 53);
            listViewHoteleria.Margin = new Padding(3, 4, 3, 4);
            listViewHoteleria.Name = "listViewHoteleria";
            listViewHoteleria.Size = new Size(715, 116);
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
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader30, columnHeader31, columnHeader32, columnHeader33 });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(766, 53);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(715, 116);
            listView2.TabIndex = 53;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Código";
            columnHeader30.Width = 100;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Descripción";
            columnHeader31.Width = 300;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Tarifa";
            columnHeader32.Width = 100;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "¿Por pasajero?";
            columnHeader33.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelSubTotalHoteles);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(listViewHoteleria);
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(16, 345);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1510, 267);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hotelería";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1375, 220);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 76;
            label3.Text = "SUBTOTAL";
            // 
            // labelSubTotalHoteles
            // 
            labelSubTotalHoteles.AutoSize = true;
            labelSubTotalHoteles.BackColor = Color.LightBlue;
            labelSubTotalHoteles.Location = new Point(626, 186);
            labelSubTotalHoteles.Name = "labelSubTotalHoteles";
            labelSubTotalHoteles.Size = new Size(69, 15);
            labelSubTotalHoteles.TabIndex = 68;
            labelSubTotalHoteles.Text = "SUBTOTAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1245, 220);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 75;
            label4.Text = "Total Hotelería:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.LightBlue;
            label18.Location = new Point(1383, 182);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 74;
            label18.Text = "SUBTOTAL";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(766, 176);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 39);
            button1.TabIndex = 56;
            button1.Text = "Quitar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1315, 182);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 73;
            label19.Text = "Subtotal";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(labelSubTotalVuelos);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(listView9);
            groupBox2.Controls.Add(listViewAereos);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(16, 57);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1510, 267);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vuelos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1375, 224);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 72;
            label5.Text = "SUBTOTAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1262, 224);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 71;
            label9.Text = "Total Vuelos:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.LightBlue;
            label16.Location = new Point(1383, 186);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 70;
            label16.Text = "SUBTOTAL";
            // 
            // labelSubTotalVuelos
            // 
            labelSubTotalVuelos.AutoSize = true;
            labelSubTotalVuelos.BackColor = Color.LightBlue;
            labelSubTotalVuelos.Location = new Point(626, 189);
            labelSubTotalVuelos.Name = "labelSubTotalVuelos";
            labelSubTotalVuelos.Size = new Size(69, 15);
            labelSubTotalVuelos.TabIndex = 67;
            labelSubTotalVuelos.Text = "SUBTOTAL";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1315, 186);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 69;
            label17.Text = "Subtotal";
            // 
            // listView9
            // 
            listView9.Columns.AddRange(new ColumnHeader[] { columnHeader26, columnHeader27, columnHeader28 });
            listView9.FullRowSelect = true;
            listView9.Location = new Point(766, 53);
            listView9.Margin = new Padding(3, 4, 3, 4);
            listView9.Name = "listView9";
            listView9.Size = new Size(715, 116);
            listView9.TabIndex = 63;
            listView9.UseCompatibleStateImageBehavior = false;
            listView9.View = View.Details;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Código";
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Descripción";
            columnHeader27.Width = 400;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Tarifa";
            columnHeader28.Width = 100;
            // 
            // listViewAereos
            // 
            listViewAereos.AllowColumnReorder = true;
            listViewAereos.Columns.AddRange(new ColumnHeader[] { idVuelo, origen, destino, paradas, fechaSalida, fechaLlegada, tiempoVuelo, aerolinea, clase, tipoPasajero, precioBase, impuestos, comision, disponibilidad, idPasaje });
            listViewAereos.FullRowSelect = true;
            listViewAereos.Location = new Point(8, 53);
            listViewAereos.Margin = new Padding(3, 4, 3, 4);
            listViewAereos.Name = "listViewAereos";
            listViewAereos.Size = new Size(715, 116);
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
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(766, 176);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(153, 39);
            button2.TabIndex = 56;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = false;
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
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(169, 176);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(153, 39);
            button3.TabIndex = 19;
            button3.Text = "Quitar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(8, 176);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(153, 39);
            button6.TabIndex = 20;
            button6.Text = "Editar pasajeros";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(558, 189);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 21;
            label12.Text = "Subtotal";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(766, 32);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 23;
            label13.Text = "Servicios Extra";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.LightBlue;
            label20.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(1391, 625);
            label20.Name = "label20";
            label20.Size = new Size(77, 15);
            label20.TabIndex = 77;
            label20.Text = "SUBTOTAL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1557, 53);
            panel1.TabIndex = 73;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(544, 19);
            label24.Name = "label24";
            label24.Size = new Size(121, 15);
            label24.TabIndex = 74;
            label24.Text = "NO SELECCIONADO";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(167, 19);
            label23.Name = "label23";
            label23.Size = new Size(121, 15);
            label23.TabIndex = 73;
            label23.Text = "NO SELECCIONADO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bg_donut_1;
            pictureBox2.Location = new Point(0, 312);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(428, 433);
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
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.landing_bg_object_2;
            pictureBox4.Location = new Point(895, 392);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(355, 353);
            pictureBox4.TabIndex = 80;
            pictureBox4.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.CornflowerBlue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(24, 659);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(130, 52);
            button8.TabIndex = 81;
            button8.Text = "Generar pre-reserva";
            button8.UseVisualStyleBackColor = false;
            // 
            // idPasaje
            // 
            idPasaje.Text = "IdPasaje";
            // 
            // VerItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1550, 724);
            Controls.Add(button8);
            Controls.Add(panel1);
            Controls.Add(label20);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button7);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button button5;
        private Label label10;
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
        private ListView listView2;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label6;
        private Button button3;
        private Button button6;
        private Label label12;
        private Label label13;
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
        private ListView listView9;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private Label label3;
        private Label labelSubTotalHoteles;
        private Label label4;
        private Label label18;
        private Label label19;
        private Label label5;
        private Label label9;
        private Label label16;
        private Label labelSubTotalVuelos;
        private Label label17;
        private Label label20;
        private Panel panel1;
        private Label label22;
        private Label label21;
        private PictureBox pictureBox1;
        private Label label24;
        private Label label23;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button8;
        private ColumnHeader idPasaje;
    }
}