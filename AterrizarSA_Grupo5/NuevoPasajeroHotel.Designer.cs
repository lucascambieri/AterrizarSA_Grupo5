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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "N° de itinerario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 56);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Hotel y habitación";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 56);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(628, 23);
            textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(22, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 136);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva persona:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 49);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(278, 36);
            button1.Name = "button1";
            button1.Size = new Size(96, 47);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 80);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 2;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 52);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 1;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 25);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre y apellido:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(22, 105);
            listView1.Name = "listView1";
            listView1.Size = new Size(747, 181);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre y apellido";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "DNI";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de naciemiento";
            columnHeader3.Width = 200;
            // 
            // button2
            // 
            button2.Location = new Point(518, 362);
            button2.Name = "button2";
            button2.Size = new Size(119, 40);
            button2.TabIndex = 6;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(650, 363);
            button3.Name = "button3";
            button3.Size = new Size(119, 39);
            button3.TabIndex = 7;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // NuevoPasajeroHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NuevoPasajeroHotel";
            Text = "NuevoPasajeroHotel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView listView1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}