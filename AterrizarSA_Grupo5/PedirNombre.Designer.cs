namespace AterrizarSA_Grupo5
{
    partial class PedirNombre
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBoxNombre = new TextBox();
            buttonConfirmarNombre = new Button();
            buttonVolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.landing_bg_object_2;
            pictureBox2.Location = new Point(-9, -19);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(372, 302);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 74;
            label1.Text = "Por favor, ingrese un nombre para crear el itinerario";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(87, 78);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(190, 23);
            textBoxNombre.TabIndex = 75;
            // 
            // buttonConfirmarNombre
            // 
            buttonConfirmarNombre.BackColor = Color.RoyalBlue;
            buttonConfirmarNombre.FlatAppearance.BorderSize = 0;
            buttonConfirmarNombre.FlatStyle = FlatStyle.Flat;
            buttonConfirmarNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirmarNombre.ForeColor = Color.White;
            buttonConfirmarNombre.Location = new Point(47, 129);
            buttonConfirmarNombre.Name = "buttonConfirmarNombre";
            buttonConfirmarNombre.Size = new Size(114, 39);
            buttonConfirmarNombre.TabIndex = 77;
            buttonConfirmarNombre.Text = "Confirmar";
            buttonConfirmarNombre.UseVisualStyleBackColor = false;
            buttonConfirmarNombre.Click += buttonConfirmarNombre_Click;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.BackColor = Color.LightSteelBlue;
            buttonVolverAtras.FlatAppearance.BorderSize = 0;
            buttonVolverAtras.FlatStyle = FlatStyle.Flat;
            buttonVolverAtras.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolverAtras.Location = new Point(225, 130);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(114, 38);
            buttonVolverAtras.TabIndex = 76;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // PedirNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(372, 194);
            Controls.Add(buttonConfirmarNombre);
            Controls.Add(buttonVolverAtras);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "PedirNombre";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PedirNombre";
            Load += PedirNombre_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBoxNombre;
        private Button buttonConfirmarNombre;
        private Button buttonVolverAtras;
    }
}