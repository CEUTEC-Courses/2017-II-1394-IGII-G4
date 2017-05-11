namespace TCS
{
    partial class Form_Principal
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
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnFlota = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(9, 10);
            this.btnViajes.Margin = new System.Windows.Forms.Padding(2);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(159, 172);
            this.btnViajes.TabIndex = 0;
            this.btnViajes.Text = "Control de Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Location = new System.Drawing.Point(9, 187);
            this.btnRutas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(159, 172);
            this.btnRutas.TabIndex = 1;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(172, 10);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(159, 172);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Control de Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Location = new System.Drawing.Point(172, 187);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(159, 172);
            this.btnMantenimiento.TabIndex = 3;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnFlota
            // 
            this.btnFlota.Location = new System.Drawing.Point(336, 10);
            this.btnFlota.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlota.Name = "btnFlota";
            this.btnFlota.Size = new System.Drawing.Size(159, 172);
            this.btnFlota.TabIndex = 4;
            this.btnFlota.Text = "Flota";
            this.btnFlota.UseVisualStyleBackColor = true;
            this.btnFlota.Click += new System.EventHandler(this.btnFlota_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(336, 187);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 172);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFlota);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnRutas);
            this.Controls.Add(this.btnViajes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Principal";
            this.Text = "Sistema TCS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnFlota;
        private System.Windows.Forms.Button btnSalir;
    }
}

