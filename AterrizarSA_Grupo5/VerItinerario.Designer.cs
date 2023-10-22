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
            listView1 = new ListView();
            listView2 = new ListView();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            listView5 = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            button2 = new Button();
            label5 = new Label();
            listView4 = new ListView();
            button3 = new Button();
            listView6 = new ListView();
            label6 = new Label();
            label7 = new Label();
            listView7 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            listView8 = new ListView();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            listView9 = new ListView();
            label9 = new Label();
            button6 = new Button();
            listView10 = new ListView();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            label10 = new Label();
            listView11 = new ListView();
            label11 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero itinerario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 36);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio:";
            // 
            // listView1
            // 
            listView1.Location = new Point(137, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 19);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(443, 32);
            listView2.Name = "listView2";
            listView2.Size = new Size(121, 19);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 103);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Servicios Aereos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 103);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Servicios Extra";
            // 
            // button1
            // 
            button1.Location = new Point(27, 233);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 8;
            button1.Text = "Quitar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            listView5.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader16, columnHeader15, columnHeader17, columnHeader18 });
            listView5.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView5.Location = new Point(27, 133);
            listView5.Name = "listView5";
            listView5.Size = new Size(557, 81);
            listView5.TabIndex = 9;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Aerolínea";
            columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Origen";
            columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Destino";
            columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Salida";
            columnHeader13.Width = 70;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Arribo";
            columnHeader14.Width = 70;
            // 
            // columnHeader16
            // 
            columnHeader16.DisplayIndex = 5;
            columnHeader16.Text = "Tiempo de vuelo";
            columnHeader16.Width = 90;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Tarifa";
            columnHeader17.Width = 90;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView3.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.Location = new Point(625, 133);
            listView3.Name = "listView3";
            listView3.Size = new Size(557, 81);
            listView3.TabIndex = 10;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tarifa";
            columnHeader3.Width = 90;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 7;
            columnHeader9.Text = "Código";
            columnHeader9.Width = 90;
            // 
            // columnHeader15
            // 
            columnHeader15.DisplayIndex = 8;
            columnHeader15.Text = "Clase";
            columnHeader15.Width = 90;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Tipo de pasajero";
            columnHeader18.Width = 90;
            // 
            // button2
            // 
            button2.Location = new Point(166, 233);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 11;
            button2.Text = "Editar pasajeros";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 241);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Subtotal";
            // 
            // listView4
            // 
            listView4.Location = new Point(463, 237);
            listView4.Name = "listView4";
            listView4.Size = new Size(121, 19);
            listView4.TabIndex = 13;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(625, 233);
            button3.Name = "button3";
            button3.Size = new Size(119, 23);
            button3.TabIndex = 14;
            button3.Text = "Quitar";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView6
            // 
            listView6.Location = new Point(1061, 237);
            listView6.Name = "listView6";
            listView6.Size = new Size(121, 19);
            listView6.TabIndex = 16;
            listView6.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(989, 241);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "Subtotal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 321);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 17;
            label7.Text = "Servicios Hoteleria";
            // 
            // listView7
            // 
            listView7.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader19, columnHeader6, columnHeader7, columnHeader8, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25 });
            listView7.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView7.Location = new Point(27, 360);
            listView7.Name = "listView7";
            listView7.Size = new Size(557, 81);
            listView7.TabIndex = 18;
            listView7.UseCompatibleStateImageBehavior = false;
            listView7.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Código";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nombre hotel";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Código ciudad";
            columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Dirección";
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Calificación";
            columnHeader8.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Nombre Habitación";
            columnHeader19.Width = 90;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Tarifa";
            columnHeader20.Width = 90;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Capacidad";
            columnHeader21.Width = 90;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "A/M/I";
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Desde";
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Hasta";
            // 
            // listView8
            // 
            listView8.Location = new Point(463, 469);
            listView8.Name = "listView8";
            listView8.Size = new Size(121, 19);
            listView8.TabIndex = 22;
            listView8.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 473);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 21;
            label8.Text = "Subtotal";
            // 
            // button4
            // 
            button4.Location = new Point(166, 464);
            button4.Name = "button4";
            button4.Size = new Size(119, 23);
            button4.TabIndex = 20;
            button4.Text = "Editar pasajeros";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(27, 464);
            button5.Name = "button5";
            button5.Size = new Size(119, 23);
            button5.TabIndex = 19;
            button5.Text = "Quitar";
            button5.UseVisualStyleBackColor = true;
            // 
            // listView9
            // 
            listView9.Location = new Point(1061, 469);
            listView9.Name = "listView9";
            listView9.Size = new Size(121, 19);
            listView9.TabIndex = 27;
            listView9.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(989, 473);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 26;
            label9.Text = "Subtotal";
            // 
            // button6
            // 
            button6.Location = new Point(625, 460);
            button6.Name = "button6";
            button6.Size = new Size(119, 23);
            button6.TabIndex = 25;
            button6.Text = "Quitar";
            button6.UseVisualStyleBackColor = true;
            // 
            // listView10
            // 
            listView10.Columns.AddRange(new ColumnHeader[] { columnHeader26, columnHeader27, columnHeader28 });
            listView10.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView10.Location = new Point(625, 360);
            listView10.Name = "listView10";
            listView10.Size = new Size(557, 81);
            listView10.TabIndex = 24;
            listView10.UseCompatibleStateImageBehavior = false;
            listView10.View = View.Details;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Código";
            columnHeader26.Width = 90;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Descripción";
            columnHeader27.Width = 90;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Tarifa";
            columnHeader28.Width = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(625, 330);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 23;
            label10.Text = "Servicios Extra";
            // 
            // listView11
            // 
            listView11.Location = new Point(1061, 550);
            listView11.Name = "listView11";
            listView11.Size = new Size(121, 19);
            listView11.TabIndex = 29;
            listView11.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1001, 554);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 28;
            label11.Text = "TOTAL";
            // 
            // button7
            // 
            button7.Location = new Point(1061, 591);
            button7.Name = "button7";
            button7.Size = new Size(119, 23);
            button7.TabIndex = 30;
            button7.Text = "Volver atrás";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // VerItinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 621);
            Controls.Add(button7);
            Controls.Add(listView11);
            Controls.Add(label11);
            Controls.Add(listView9);
            Controls.Add(label9);
            Controls.Add(button6);
            Controls.Add(listView10);
            Controls.Add(label10);
            Controls.Add(listView8);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(listView7);
            Controls.Add(label7);
            Controls.Add(listView6);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(listView4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(listView3);
            Controls.Add(listView5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VerItinerario";
            Text = "VerItinerario";
            Load += VerItinerario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private ListView listView2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ListView listView5;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader18;
        private Button button2;
        private Label label5;
        private ListView listView4;
        private Button button3;
        private ListView listView6;
        private Label label6;
        private Label label7;
        private ListView listView7;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ListView listView8;
        private Label label8;
        private Button button4;
        private Button button5;
        private ListView listView9;
        private Label label9;
        private Button button6;
        private ListView listView10;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private Label label10;
        private ListView listView11;
        private Label label11;
        private Button button7;
    }
}