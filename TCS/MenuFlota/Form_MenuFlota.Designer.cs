namespace TCS.MenuFlota
{
    partial class Form_MenuFlota
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
            this.AbrirFormularioFlota = new System.Windows.Forms.Button();
            this.AbrirFormularioUnidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbrirFormularioFlota
            // 
            this.AbrirFormularioFlota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirFormularioFlota.Location = new System.Drawing.Point(51, 27);
            this.AbrirFormularioFlota.Name = "AbrirFormularioFlota";
            this.AbrirFormularioFlota.Size = new System.Drawing.Size(98, 44);
            this.AbrirFormularioFlota.TabIndex = 0;
            this.AbrirFormularioFlota.Text = "Flota";
            this.AbrirFormularioFlota.UseVisualStyleBackColor = true;
            this.AbrirFormularioFlota.Click += new System.EventHandler(this.AbrirFormularioFlota_Click);
            // 
            // AbrirFormularioUnidad
            // 
            this.AbrirFormularioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbrirFormularioUnidad.Location = new System.Drawing.Point(51, 88);
            this.AbrirFormularioUnidad.Name = "AbrirFormularioUnidad";
            this.AbrirFormularioUnidad.Size = new System.Drawing.Size(98, 44);
            this.AbrirFormularioUnidad.TabIndex = 1;
            this.AbrirFormularioUnidad.Text = "Unidad";
            this.AbrirFormularioUnidad.UseVisualStyleBackColor = true;
            this.AbrirFormularioUnidad.Click += new System.EventHandler(this.AbrirFormularioUnidad_Click);
            // 
            // Form_MenuFlota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(197, 184);
            this.Controls.Add(this.AbrirFormularioUnidad);
            this.Controls.Add(this.AbrirFormularioFlota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_MenuFlota";
            this.Text = "Menu Flota";
            this.Load += new System.EventHandler(this.MenuFlota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbrirFormularioFlota;
        private System.Windows.Forms.Button AbrirFormularioUnidad;
    }
}