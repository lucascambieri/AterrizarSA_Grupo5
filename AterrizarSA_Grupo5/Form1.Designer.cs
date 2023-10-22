namespace AterrizarSA_Grupo5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Itinerario n°: NO SELECCIONADO");
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una de las opciones:";
            // 
            // button1
            // 
            button1.Location = new Point(51, 83);
            button1.Name = "button1";
            button1.Size = new Size(154, 62);
            button1.TabIndex = 1;
            button1.Text = "Consultar / Agregar hotel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(51, 163);
            button2.Name = "button2";
            button2.Size = new Size(154, 62);
            button2.TabIndex = 2;
            button2.Text = "Consultar / Agregar vuelo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(51, 252);
            button3.Name = "button3";
            button3.Size = new Size(154, 62);
            button3.TabIndex = 3;
            button3.Text = "Gestión de itinerarios";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(90, 351);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LabelWrap = false;
            listView1.Location = new Point(26, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(208, 27);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 429);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listView1;
    }
}