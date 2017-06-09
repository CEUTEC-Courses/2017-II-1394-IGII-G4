namespace TCS.Rutas
{
    partial class Form_Puntos
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
            this.Puntos = new System.Windows.Forms.GroupBox();
            this.listaPuntos = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Puntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Puntos
            // 
            this.Puntos.Controls.Add(this.btnAceptar);
            this.Puntos.Controls.Add(this.listaPuntos);
            this.Puntos.Location = new System.Drawing.Point(13, 13);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(200, 278);
            this.Puntos.TabIndex = 0;
            this.Puntos.TabStop = false;
            this.Puntos.Text = "Puntos";
            // 
            // listaPuntos
            // 
            this.listaPuntos.FormattingEnabled = true;
            this.listaPuntos.Location = new System.Drawing.Point(6, 19);
            this.listaPuntos.Name = "listaPuntos";
            this.listaPuntos.Size = new System.Drawing.Size(188, 225);
            this.listaPuntos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(119, 250);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "OK";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form_Puntos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 303);
            this.Controls.Add(this.Puntos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Puntos";
            this.Text = "Seleccionar Punto";
            this.Puntos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Puntos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox listaPuntos;
    }
}