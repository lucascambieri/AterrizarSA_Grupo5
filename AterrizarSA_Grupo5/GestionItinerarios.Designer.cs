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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Eliminar = new Button();
            button6 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            button7 = new Button();
            button8 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button9 = new Button();
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
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(222, 332);
            button2.Name = "button2";
            button2.Size = new Size(114, 39);
            button2.TabIndex = 58;
            button2.Text = "Establecer como activo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(393, 332);
            button3.Name = "button3";
            button3.Size = new Size(114, 39);
            button3.TabIndex = 59;
            button3.Text = "Ver itinerario y presupuesto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(564, 332);
            button4.Name = "button4";
            button4.Size = new Size(114, 39);
            button4.TabIndex = 60;
            button4.Text = "Generar pre-reserva";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(738, 397);
            button5.Name = "button5";
            button5.Size = new Size(114, 38);
            button5.TabIndex = 61;
            button5.Text = "Volver atrás";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
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
            // button6
            // 
            button6.BackColor = Color.RoyalBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(537, 20);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(114, 37);
            button6.TabIndex = 63;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(27, 140);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(849, 169);
            listView1.TabIndex = 64;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            groupBox1.Controls.Add(button6);
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 34);
            panel1.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 11);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 65;
            label3.Text = "NO SELECCIONADO";
            // 
            // button7
            // 
            button7.BackColor = Color.RoyalBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(62, 397);
            button7.Name = "button7";
            button7.Size = new Size(114, 38);
            button7.TabIndex = 68;
            button7.Text = "Agregar Hotel";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.RoyalBlue;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(222, 397);
            button8.Name = "button8";
            button8.Size = new Size(114, 38);
            button8.TabIndex = 69;
            button8.Text = "Agregar Vuelo";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
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
            // button9
            // 
            button9.BackColor = Color.RoyalBlue;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(393, 396);
            button9.Name = "button9";
            button9.Size = new Size(114, 39);
            button9.TabIndex = 72;
            button9.Text = "Confirmar reserva";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // GestionItinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 458);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(Eliminar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(ButtonNuevoItinerario);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GestionItinerarios";
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button Eliminar;
        private Button button6;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button9;
    }
}