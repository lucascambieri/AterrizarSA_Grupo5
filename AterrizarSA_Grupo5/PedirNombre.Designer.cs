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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonConfirmarNombre = new System.Windows.Forms.Button();
            this.buttonVolverAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AterrizarSA_Grupo5.Properties.Resources.landing_bg_object_2;
            this.pictureBox2.Location = new System.Drawing.Point(-35, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(353, 263);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Por favor, ingrese un nombre para crear el itinerario:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(101, 78);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(217, 27);
            this.textBoxNombre.TabIndex = 75;
            // 
            // buttonConfirmarNombre
            // 
            this.buttonConfirmarNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonConfirmarNombre.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarNombre.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarNombre.Location = new System.Drawing.Point(32, 145);
            this.buttonConfirmarNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfirmarNombre.Name = "buttonConfirmarNombre";
            this.buttonConfirmarNombre.Size = new System.Drawing.Size(130, 52);
            this.buttonConfirmarNombre.TabIndex = 77;
            this.buttonConfirmarNombre.Text = "Confirmar";
            this.buttonConfirmarNombre.UseVisualStyleBackColor = false;
            // 
            // buttonVolverAtras
            // 
            this.buttonVolverAtras.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonVolverAtras.FlatAppearance.BorderSize = 0;
            this.buttonVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVolverAtras.Location = new System.Drawing.Point(256, 145);
            this.buttonVolverAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVolverAtras.Name = "buttonVolverAtras";
            this.buttonVolverAtras.Size = new System.Drawing.Size(130, 51);
            this.buttonVolverAtras.TabIndex = 76;
            this.buttonVolverAtras.Text = "Volver atrás";
            this.buttonVolverAtras.UseVisualStyleBackColor = false;
            // 
            // PedirNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(425, 231);
            this.Controls.Add(this.buttonConfirmarNombre);
            this.Controls.Add(this.buttonVolverAtras);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PedirNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PedirNombre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBoxNombre;
        private Button buttonConfirmarNombre;
        private Button buttonVolverAtras;
    }
}