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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.listaPuntos = new System.Windows.Forms.ListBox();
            this.Puntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Puntos
            // 
            this.Puntos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Puntos.Controls.Add(this.btnAceptar);
            this.Puntos.Controls.Add(this.listaPuntos);
            this.Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Puntos.Location = new System.Drawing.Point(13, 13);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(200, 278);
            this.Puntos.TabIndex = 0;
            this.Puntos.TabStop = false;
            this.Puntos.Text = "Puntos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Navy;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(119, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 26);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "OK";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // listaPuntos
            // 
            this.listaPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPuntos.FormattingEnabled = true;
            this.listaPuntos.Location = new System.Drawing.Point(6, 19);
            this.listaPuntos.Name = "listaPuntos";
            this.listaPuntos.Size = new System.Drawing.Size(188, 225);
            this.listaPuntos.TabIndex = 0;
            // 
            // Form_Puntos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(238, 303);
            this.Controls.Add(this.Puntos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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