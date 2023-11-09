namespace AterrizarSA_Grupo5
{
    partial class GestionItinerarios
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
            textBox1 = new TextBox();
            textNombreCliente = new TextBox();
            ButtonNuevoItinerario = new Button();
            buttonActivaItinerario = new Button();
            buttonVerItinerario = new Button();
            buttonGenerarReserva = new Button();
            buttonVolverAtras = new Button();
            Eliminar = new Button();
            buttonBuscar = new Button();
            listViewItinerarios = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ItinerarioSeleccionado = new Label();
            buttonAgregarHotel = new Button();
            buttonAgregarVuelo = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonConfirmarReserva = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 17);
            label1.TabIndex = 51;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 31);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 52;
            label2.Text = "Nombre del cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 53;
            // 
            // textNombreCliente
            // 
            textNombreCliente.Location = new Point(369, 28);
            textNombreCliente.Name = "textNombreCliente";
            textNombreCliente.Size = new Size(100, 23);
            textNombreCliente.TabIndex = 54;
            // 
            // ButtonNuevoItinerario
            // 
            ButtonNuevoItinerario.BackColor = Color.CornflowerBlue;
            ButtonNuevoItinerario.FlatAppearance.BorderSize = 0;
            ButtonNuevoItinerario.FlatStyle = FlatStyle.Flat;
            ButtonNuevoItinerario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonNuevoItinerario.ForeColor = Color.White;
            ButtonNuevoItinerario.Location = new Point(62, 332);
            ButtonNuevoItinerario.Name = "ButtonNuevoItinerario";
            ButtonNuevoItinerario.Size = new Size(114, 39);
            ButtonNuevoItinerario.TabIndex = 57;
            ButtonNuevoItinerario.Text = "Crear Nuevo Itinerario";
            ButtonNuevoItinerario.UseVisualStyleBackColor = false;
            ButtonNuevoItinerario.Click += buttonNuevoItinerario_Click;
            // 
            // buttonActivaItinerario
            // 
            buttonActivaItinerario.BackColor = Color.CornflowerBlue;
            buttonActivaItinerario.FlatAppearance.BorderSize = 0;
            buttonActivaItinerario.FlatStyle = FlatStyle.Flat;
            buttonActivaItinerario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActivaItinerario.ForeColor = Color.White;
            buttonActivaItinerario.Location = new Point(222, 332);
            buttonActivaItinerario.Name = "buttonActivaItinerario";
            buttonActivaItinerario.Size = new Size(114, 39);
            buttonActivaItinerario.TabIndex = 58;
            buttonActivaItinerario.Text = "Establecer como activo";
            buttonActivaItinerario.UseVisualStyleBackColor = false;
            buttonActivaItinerario.Click += buttonActivaItinerario_Click_;
            // 
            // buttonVerItinerario
            // 
            buttonVerItinerario.BackColor = Color.CornflowerBlue;
            buttonVerItinerario.FlatAppearance.BorderSize = 0;
            buttonVerItinerario.FlatStyle = FlatStyle.Flat;
            buttonVerItinerario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVerItinerario.ForeColor = Color.White;
            buttonVerItinerario.Location = new Point(393, 332);
            buttonVerItinerario.Name = "buttonVerItinerario";
            buttonVerItinerario.Size = new Size(114, 39);
            buttonVerItinerario.TabIndex = 59;
            buttonVerItinerario.Text = "Ver itinerario y presupuesto";
            buttonVerItinerario.UseVisualStyleBackColor = false;
            buttonVerItinerario.Click += buttonVerItinerario_Click;
            // 
            // buttonGenerarReserva
            // 
            buttonGenerarReserva.BackColor = Color.CornflowerBlue;
            buttonGenerarReserva.FlatAppearance.BorderSize = 0;
            buttonGenerarReserva.FlatStyle = FlatStyle.Flat;
            buttonGenerarReserva.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarReserva.ForeColor = Color.White;
            buttonGenerarReserva.Location = new Point(564, 332);
            buttonGenerarReserva.Name = "buttonGenerarReserva";
            buttonGenerarReserva.Size = new Size(114, 39);
            buttonGenerarReserva.TabIndex = 60;
            buttonGenerarReserva.Text = "Generar pre-reserva";
            buttonGenerarReserva.UseVisualStyleBackColor = false;
            buttonGenerarReserva.Click += buttonGenerarReserva_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolverAtras.Location = new Point(738, 397);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(114, 38);
            buttonVolverAtras.TabIndex = 61;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.CornflowerBlue;
            Eliminar.FlatAppearance.BorderSize = 0;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar.ForeColor = Color.White;
            Eliminar.Location = new Point(735, 332);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(114, 38);
            Eliminar.TabIndex = 62;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click_1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.RoyalBlue;
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(537, 20);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(114, 37);
            buttonBuscar.TabIndex = 63;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // listViewItinerarios
            // 
            listViewItinerarios.Alignment = ListViewAlignment.Left;
            listViewItinerarios.BackColor = Color.White;
            listViewItinerarios.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewItinerarios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listViewItinerarios.FullRowSelect = true;
            listViewItinerarios.Location = new Point(27, 140);
            listViewItinerarios.Margin = new Padding(3, 2, 3, 2);
            listViewItinerarios.Name = "listViewItinerarios";
            listViewItinerarios.Size = new Size(849, 169);
            listViewItinerarios.TabIndex = 64;
            listViewItinerarios.UseCompatibleStateImageBehavior = false;
            listViewItinerarios.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Número de itinerario";
            columnHeader1.Width = 212;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre del cliente";
            columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Creado";
            columnHeader3.Width = 212;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado del itinerario";
            columnHeader4.Width = 212;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNombreCliente);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(27, 50);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(668, 73);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar itinerario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(19, 11);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 64;
            label4.Text = "N° de itinerario:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_of_a_baggage_and_a_compass_for_a_travel_compa;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(746, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 106);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(ItinerarioSeleccionado);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 34);
            panel1.TabIndex = 64;
            // 
            // ItinerarioSeleccionado
            // 
            ItinerarioSeleccionado.AutoSize = true;
            ItinerarioSeleccionado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItinerarioSeleccionado.Location = new Point(131, 11);
            ItinerarioSeleccionado.Name = "ItinerarioSeleccionado";
            ItinerarioSeleccionado.Size = new Size(121, 15);
            ItinerarioSeleccionado.TabIndex = 65;
            ItinerarioSeleccionado.Text = "NO SELECCIONADO";
            // 
            // buttonAgregarHotel
            // 
            buttonAgregarHotel.BackColor = Color.RoyalBlue;
            buttonAgregarHotel.FlatAppearance.BorderSize = 0;
            buttonAgregarHotel.FlatStyle = FlatStyle.Flat;
            buttonAgregarHotel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarHotel.ForeColor = Color.White;
            buttonAgregarHotel.Location = new Point(62, 397);
            buttonAgregarHotel.Name = "buttonAgregarHotel";
            buttonAgregarHotel.Size = new Size(114, 38);
            buttonAgregarHotel.TabIndex = 68;
            buttonAgregarHotel.Text = "Agregar Hotel";
            buttonAgregarHotel.UseVisualStyleBackColor = false;
            buttonAgregarHotel.Click += buttonAgregarHabitacion_Click;
            // 
            // buttonAgregarVuelo
            // 
            buttonAgregarVuelo.BackColor = Color.RoyalBlue;
            buttonAgregarVuelo.FlatAppearance.BorderSize = 0;
            buttonAgregarVuelo.FlatStyle = FlatStyle.Flat;
            buttonAgregarVuelo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarVuelo.ForeColor = Color.White;
            buttonAgregarVuelo.Location = new Point(222, 397);
            buttonAgregarVuelo.Name = "buttonAgregarVuelo";
            buttonAgregarVuelo.Size = new Size(114, 38);
            buttonAgregarVuelo.TabIndex = 69;
            buttonAgregarVuelo.Text = "Agregar Vuelo";
            buttonAgregarVuelo.UseVisualStyleBackColor = false;
            buttonAgregarVuelo.Click += buttonAgregarVuelo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.landing_bg_object_2;
            pictureBox2.Location = new Point(15, 184);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(372, 302);
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.landing_bg_object_2;
            pictureBox3.Location = new Point(466, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(372, 302);
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // buttonConfirmarReserva
            // 
            buttonConfirmarReserva.BackColor = Color.RoyalBlue;
            buttonConfirmarReserva.FlatAppearance.BorderSize = 0;
            buttonConfirmarReserva.FlatStyle = FlatStyle.Flat;
            buttonConfirmarReserva.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirmarReserva.ForeColor = Color.White;
            buttonConfirmarReserva.Location = new Point(393, 396);
            buttonConfirmarReserva.Name = "buttonConfirmarReserva";
            buttonConfirmarReserva.Size = new Size(114, 39);
            buttonConfirmarReserva.TabIndex = 72;
            buttonConfirmarReserva.Text = "Confirmar reserva";
            buttonConfirmarReserva.UseVisualStyleBackColor = false;
            buttonConfirmarReserva.Click += buttonConfirmarReserva_Click;
            // 
            // GestionItinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 458);
            Controls.Add(buttonConfirmarReserva);
            Controls.Add(buttonAgregarVuelo);
            Controls.Add(buttonAgregarHotel);
            Controls.Add(listViewItinerarios);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(Eliminar);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonGenerarReserva);
            Controls.Add(buttonVerItinerario);
            Controls.Add(buttonActivaItinerario);
            Controls.Add(ButtonNuevoItinerario);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GestionItinerarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de Itinerarios";
            Load += GestionItinerarios_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textNombreCliente;
        private Button ButtonNuevoItinerario;
        private Button buttonActivaItinerario;
        private Button buttonVerItinerario;
        private Button buttonGenerarReserva;
        private Button buttonVolverAtras;
        private Button Eliminar;
        private Button buttonBuscar;
        private ListView listViewItinerarios;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label ItinerarioSeleccionado;
        private Button buttonAgregarHotel;
        private Button buttonAgregarVuelo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonConfirmarReserva;
    }
}