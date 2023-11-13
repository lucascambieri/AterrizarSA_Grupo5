namespace AterrizarSA_Grupo5
{
    partial class NuevoPasajeroVuelo
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
            buttonGuardar = new Button();
            buttonVolverAtras = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            labelVueloyPasaje = new Label();
            labelItinerarioSelec = new Label();
            label6 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.CornflowerBlue;
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(46, 354);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(132, 40);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.ForeColor = Color.Black;
            buttonVolverAtras.Location = new Point(283, 354);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(131, 40);
            buttonVolverAtras.TabIndex = 1;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 105);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Agregar pasajero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 141);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 179);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 217);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 255);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 6;
            label5.Text = "Fecha de nacimiento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 21);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 21);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 21);
            textBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 21);
            dateTimePicker1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(labelVueloyPasaje);
            panel1.Controls.Add(labelItinerarioSelec);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 83);
            panel1.TabIndex = 18;
            // 
            // labelVueloyPasaje
            // 
            labelVueloyPasaje.AutoSize = true;
            labelVueloyPasaje.Location = new Point(151, 50);
            labelVueloyPasaje.Name = "labelVueloyPasaje";
            labelVueloyPasaje.Size = new Size(121, 15);
            labelVueloyPasaje.TabIndex = 7;
            labelVueloyPasaje.Text = "NO SELECCIONADO";
            // 
            // labelItinerarioSelec
            // 
            labelItinerarioSelec.AutoSize = true;
            labelItinerarioSelec.Location = new Point(151, 16);
            labelItinerarioSelec.Name = "labelItinerarioSelec";
            labelItinerarioSelec.Size = new Size(121, 15);
            labelItinerarioSelec.TabIndex = 6;
            labelItinerarioSelec.Text = "NO SELECCIONADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(17, 50);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 5;
            label6.Text = "Vuelo y pasaje:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(17, 16);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 4;
            label9.Text = "N° de itinerario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg_donut;
            pictureBox1.Location = new Point(89, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 298);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // NuevoPasajeroVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(469, 417);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonVolverAtras);
            Controls.Add(buttonGuardar);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NuevoPasajeroVuelo";
            Text = "NuevoPasajero";
            Load += NuevoPasajeroVuelo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardar;
        private Button buttonVolverAtras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label labelVueloyPasaje;
        private Label labelItinerarioSelec;
        private Label label6;
        private Label label9;
        private PictureBox pictureBox1;
    }
}