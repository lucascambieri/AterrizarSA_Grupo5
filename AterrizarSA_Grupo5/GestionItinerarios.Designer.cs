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
            ListViewItem listViewItem2 = new ListViewItem("Itinerario n°: NO SELECCIONADO");
            listView2 = new ListView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Eliminar = new Button();
            SuspendLayout();
            // 
            // listView2
            // 
            listView2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView2.LabelWrap = false;
            listView2.Location = new Point(385, 32);
            listView2.Name = "listView2";
            listView2.Size = new Size(190, 27);
            listView2.TabIndex = 50;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 101);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 51;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 101);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 52;
            label2.Text = "Nombre del cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(550, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 144);
            label3.Name = "label3";
            label3.Size = new Size(538, 15);
            label3.TabIndex = 55;
            label3.Text = "Numero de itinerario                 ||              Nombre del cliente            ||               Inicio del itinerario          ||";
            // 
            // listView1
            // 
            listView1.Location = new Point(72, 172);
            listView1.Name = "listView1";
            listView1.Size = new Size(768, 97);
            listView1.TabIndex = 56;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(72, 317);
            button1.Name = "button1";
            button1.Size = new Size(114, 39);
            button1.TabIndex = 57;
            button1.Text = "Crear Nuevo Itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(235, 317);
            button2.Name = "button2";
            button2.Size = new Size(114, 39);
            button2.TabIndex = 58;
            button2.Text = "Establecer como activo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(403, 317);
            button3.Name = "button3";
            button3.Size = new Size(114, 39);
            button3.TabIndex = 59;
            button3.Text = "Ver itinerario y presupuesto";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(558, 317);
            button4.Name = "button4";
            button4.Size = new Size(114, 39);
            button4.TabIndex = 60;
            button4.Text = "Generar pre-reserva";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(870, 395);
            button5.Name = "button5";
            button5.Size = new Size(114, 38);
            button5.TabIndex = 61;
            button5.Text = "Volver atrás";
            button5.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(726, 317);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(114, 38);
            Eliminar.TabIndex = 62;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            // 
            // GestionItinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 458);
            Controls.Add(Eliminar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Name = "GestionItinerarios";
            Text = "GestionItinerarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button Eliminar;
    }
}