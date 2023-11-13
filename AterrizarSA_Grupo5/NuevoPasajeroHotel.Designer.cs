namespace AterrizarSA_Grupo5
{
    partial class NuevoPasajeroHotel
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
            groupBox1 = new GroupBox();
            textBoxApellido = new TextBox();
            label9 = new Label();
            dateTimePickerFechaNac = new DateTimePicker();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            buttonAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listViewPasajeros = new ListView();
            nombre = new ColumnHeader();
            apellido = new ColumnHeader();
            dni = new ColumnHeader();
            fechaNacimiento = new ColumnHeader();
            tipoPasajero = new ColumnHeader();
            buttonVolverAtras = new Button();
            buttonQuitar = new Button();
            panel1 = new Panel();
            comboBoxHabitaciones = new ComboBox();
            labelItinerarioSelec = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "N° de itinerario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Hotel y habitación:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBoxApellido);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTimePickerFechaNac);
            groupBox1.Controls.Add(textBoxDNI);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(buttonAgregar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 363);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(507, 163);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva persona:";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(204, 58);
            textBoxApellido.Margin = new Padding(3, 4, 3, 4);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(128, 21);
            textBoxApellido.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 62);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 7;
            label9.Text = "Apellido:";
            // 
            // dateTimePickerFechaNac
            // 
            dateTimePickerFechaNac.Location = new Point(204, 122);
            dateTimePickerFechaNac.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            dateTimePickerFechaNac.Size = new Size(128, 21);
            dateTimePickerFechaNac.TabIndex = 4;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(204, 87);
            textBoxDNI.Margin = new Padding(3, 4, 3, 4);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(128, 21);
            textBoxDNI.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(204, 26);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(128, 21);
            textBoxNombre.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.RoyalBlue;
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(362, 62);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(124, 36);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 125);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 2;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 91);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 30);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // listViewPasajeros
            // 
            listViewPasajeros.Columns.AddRange(new ColumnHeader[] { nombre, apellido, dni, fechaNacimiento, tipoPasajero });
            listViewPasajeros.FullRowSelect = true;
            listViewPasajeros.Location = new Point(28, 126);
            listViewPasajeros.Margin = new Padding(3, 4, 3, 4);
            listViewPasajeros.Name = "listViewPasajeros";
            listViewPasajeros.Size = new Size(959, 216);
            listViewPasajeros.TabIndex = 5;
            listViewPasajeros.UseCompatibleStateImageBehavior = false;
            listViewPasajeros.View = View.Details;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 110;
            // 
            // apellido
            // 
            apellido.Text = "Apellido";
            apellido.Width = 110;
            // 
            // dni
            // 
            dni.Text = "DNI";
            dni.Width = 100;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Text = "Fecha de naciemiento";
            fechaNacimiento.Width = 150;
            // 
            // tipoPasajero
            // 
            tipoPasajero.Text = "Tipo de pasajero";
            tipoPasajero.Width = 110;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.ForeColor = Color.Black;
            buttonVolverAtras.Location = new Point(834, 488);
            buttonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(153, 39);
            buttonVolverAtras.TabIndex = 6;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonQuitar
            // 
            buttonQuitar.BackColor = Color.CornflowerBlue;
            buttonQuitar.FlatAppearance.BorderSize = 0;
            buttonQuitar.FlatStyle = FlatStyle.Flat;
            buttonQuitar.ForeColor = Color.White;
            buttonQuitar.Location = new Point(834, 350);
            buttonQuitar.Margin = new Padding(3, 4, 3, 4);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(153, 34);
            buttonQuitar.TabIndex = 8;
            buttonQuitar.Text = "Quitar";
            buttonQuitar.UseVisualStyleBackColor = false;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(comboBoxHabitaciones);
            panel1.Controls.Add(labelItinerarioSelec);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 94);
            panel1.TabIndex = 9;
            // 
            // comboBoxHabitaciones
            // 
            comboBoxHabitaciones.FormattingEnabled = true;
            comboBoxHabitaciones.Location = new Point(168, 55);
            comboBoxHabitaciones.Name = "comboBoxHabitaciones";
            comboBoxHabitaciones.Size = new Size(121, 23);
            comboBoxHabitaciones.TabIndex = 4;
            comboBoxHabitaciones.SelectedIndexChanged += comboBoxHabitaciones_SelectedIndexChanged;
            // 
            // labelItinerarioSelec
            // 
            labelItinerarioSelec.AutoSize = true;
            labelItinerarioSelec.Location = new Point(168, 24);
            labelItinerarioSelec.Name = "labelItinerarioSelec";
            labelItinerarioSelec.Size = new Size(121, 15);
            labelItinerarioSelec.TabIndex = 2;
            labelItinerarioSelec.Text = "NO SELECCIONADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 104);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 2;
            label6.Text = "Personas:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.landing_bg_object_4;
            pictureBox1.Location = new Point(608, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.landing_bg_object_4;
            pictureBox2.Location = new Point(942, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.landing_bg_object_4;
            pictureBox3.Location = new Point(0, 213);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.landing_bg_object_4;
            pictureBox4.Location = new Point(0, 476);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 50);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.landing_bg_object_4;
            pictureBox5.Location = new Point(974, 413);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 50);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // NuevoPasajeroHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1028, 540);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(buttonQuitar);
            Controls.Add(buttonVolverAtras);
            Controls.Add(listViewPasajeros);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NuevoPasajeroHotel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NuevoPasajeroHotel";
            Load += NuevoPasajeroHotel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView listViewPasajeros;
        private Button buttonVolverAtras;
        private Button buttonGuardar;
        private DateTimePicker dateTimePickerFechaNac;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private ColumnHeader nombre;
        private ColumnHeader dni;
        private ColumnHeader fechaNacimiento;
        private Button buttonQuitar;
        private Panel panel1;
        private Label labelItinerarioSelec;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ColumnHeader apellido;
        private TextBox textBoxApellido;
        private Label label9;
        private ComboBox comboBoxHabitaciones;
        private ColumnHeader tipoPasajero;
    }
}