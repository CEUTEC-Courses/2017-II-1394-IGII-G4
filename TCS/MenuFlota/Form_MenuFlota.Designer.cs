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
            this.AbrirFormularioFlota.Location = new System.Drawing.Point(80, 41);
            this.AbrirFormularioFlota.Name = "AbrirFormularioFlota";
            this.AbrirFormularioFlota.Size = new System.Drawing.Size(75, 23);
            this.AbrirFormularioFlota.TabIndex = 0;
            this.AbrirFormularioFlota.Text = "Flota";
            this.AbrirFormularioFlota.UseVisualStyleBackColor = true;
            // 
            // AbrirFormularioUnidad
            // 
            this.AbrirFormularioUnidad.Location = new System.Drawing.Point(80, 87);
            this.AbrirFormularioUnidad.Name = "AbrirFormularioUnidad";
            this.AbrirFormularioUnidad.Size = new System.Drawing.Size(75, 23);
            this.AbrirFormularioUnidad.TabIndex = 1;
            this.AbrirFormularioUnidad.Text = "Unidad";
            this.AbrirFormularioUnidad.UseVisualStyleBackColor = true;
            // 
            // MenuFlota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 258);
            this.Controls.Add(this.AbrirFormularioUnidad);
            this.Controls.Add(this.AbrirFormularioFlota);
            this.Name = "MenuFlota";
            this.Text = "MenuFlota";
            this.Load += new System.EventHandler(this.MenuFlota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbrirFormularioFlota;
        private System.Windows.Forms.Button AbrirFormularioUnidad;
    }
}