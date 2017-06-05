namespace TCS.Rutas
{
    partial class Form_Rutas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listaRutasDisponibles = new System.Windows.Forms.ListBox();
            this.listaPuntosRuta = new System.Windows.Forms.ListBox();
            this.btnLimpiarAgregarRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRutaNueva = new System.Windows.Forms.TextBox();
            this.btnSeleccionarPuntoOrigenNuevaRuta = new System.Windows.Forms.Button();
            this.btnSeleccionarPuntoDestinoRutaNueva = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnModificarDestinoRuta = new System.Windows.Forms.Button();
            this.btnModificarOrigenRuta = new System.Windows.Forms.Button();
            this.txtModificarRutaNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificarRuta = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPuntos = new System.Windows.Forms.Button();
            this.btnBorrarPuntos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombrePunto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarRuta);
            this.groupBox1.Controls.Add(this.btnSeleccionarPuntoDestinoRutaNueva);
            this.groupBox1.Controls.Add(this.btnSeleccionarPuntoOrigenNuevaRuta);
            this.groupBox1.Controls.Add(this.txtNombreRutaNueva);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLimpiarAgregarRuta);
            this.groupBox1.Location = new System.Drawing.Point(14, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Ruta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificarDestinoRuta);
            this.groupBox2.Controls.Add(this.btnModificarOrigenRuta);
            this.groupBox2.Controls.Add(this.txtModificarRutaNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnModificarRuta);
            this.groupBox2.Location = new System.Drawing.Point(13, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Ruta Seleccionada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listaRutasDisponibles);
            this.groupBox3.Location = new System.Drawing.Point(287, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rutas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listaPuntosRuta);
            this.groupBox4.Location = new System.Drawing.Point(493, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 365);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puntos en Ruta Seleccionada";
            // 
            // listaRutasDisponibles
            // 
            this.listaRutasDisponibles.FormattingEnabled = true;
            this.listaRutasDisponibles.Location = new System.Drawing.Point(7, 20);
            this.listaRutasDisponibles.Name = "listaRutasDisponibles";
            this.listaRutasDisponibles.Size = new System.Drawing.Size(187, 329);
            this.listaRutasDisponibles.TabIndex = 0;
            // 
            // listaPuntosRuta
            // 
            this.listaPuntosRuta.FormattingEnabled = true;
            this.listaPuntosRuta.Location = new System.Drawing.Point(7, 20);
            this.listaPuntosRuta.Name = "listaPuntosRuta";
            this.listaPuntosRuta.Size = new System.Drawing.Size(187, 329);
            this.listaPuntosRuta.TabIndex = 0;
            // 
            // btnLimpiarAgregarRuta
            // 
            this.btnLimpiarAgregarRuta.Location = new System.Drawing.Point(178, 98);
            this.btnLimpiarAgregarRuta.Name = "btnLimpiarAgregarRuta";
            this.btnLimpiarAgregarRuta.Size = new System.Drawing.Size(83, 23);
            this.btnLimpiarAgregarRuta.TabIndex = 0;
            this.btnLimpiarAgregarRuta.Text = "Limpiar";
            this.btnLimpiarAgregarRuta.UseVisualStyleBackColor = true;
            this.btnLimpiarAgregarRuta.Click += new System.EventHandler(this.btnLimpiarAgregarRuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Ruta : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punto Origen : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Punto Destino :";
            // 
            // txtNombreRutaNueva
            // 
            this.txtNombreRutaNueva.Location = new System.Drawing.Point(91, 17);
            this.txtNombreRutaNueva.Name = "txtNombreRutaNueva";
            this.txtNombreRutaNueva.Size = new System.Drawing.Size(170, 20);
            this.txtNombreRutaNueva.TabIndex = 4;
            // 
            // btnSeleccionarPuntoOrigenNuevaRuta
            // 
            this.btnSeleccionarPuntoOrigenNuevaRuta.Location = new System.Drawing.Point(90, 41);
            this.btnSeleccionarPuntoOrigenNuevaRuta.Name = "btnSeleccionarPuntoOrigenNuevaRuta";
            this.btnSeleccionarPuntoOrigenNuevaRuta.Size = new System.Drawing.Size(171, 23);
            this.btnSeleccionarPuntoOrigenNuevaRuta.TabIndex = 5;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Text = "Seleccionar Punto";
            this.btnSeleccionarPuntoOrigenNuevaRuta.UseVisualStyleBackColor = true;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Click += new System.EventHandler(this.btnSeleccionarPuntoOrigenNuevaRuta_Click);
            // 
            // btnSeleccionarPuntoDestinoRutaNueva
            // 
            this.btnSeleccionarPuntoDestinoRutaNueva.Location = new System.Drawing.Point(90, 68);
            this.btnSeleccionarPuntoDestinoRutaNueva.Name = "btnSeleccionarPuntoDestinoRutaNueva";
            this.btnSeleccionarPuntoDestinoRutaNueva.Size = new System.Drawing.Size(171, 23);
            this.btnSeleccionarPuntoDestinoRutaNueva.TabIndex = 6;
            this.btnSeleccionarPuntoDestinoRutaNueva.Text = "Seleccionar Punto";
            this.btnSeleccionarPuntoDestinoRutaNueva.UseVisualStyleBackColor = true;
            this.btnSeleccionarPuntoDestinoRutaNueva.Click += new System.EventHandler(this.btnSeleccionarPuntoDestinoRutaNueva_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Location = new System.Drawing.Point(90, 97);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(82, 23);
            this.btnAgregarRuta.TabIndex = 7;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnModificarDestinoRuta
            // 
            this.btnModificarDestinoRuta.Location = new System.Drawing.Point(91, 69);
            this.btnModificarDestinoRuta.Name = "btnModificarDestinoRuta";
            this.btnModificarDestinoRuta.Size = new System.Drawing.Size(171, 23);
            this.btnModificarDestinoRuta.TabIndex = 14;
            this.btnModificarDestinoRuta.Text = "Seleccionar Punto";
            this.btnModificarDestinoRuta.UseVisualStyleBackColor = true;
            this.btnModificarDestinoRuta.Click += new System.EventHandler(this.btnModificarDestinoRuta_Click);
            // 
            // btnModificarOrigenRuta
            // 
            this.btnModificarOrigenRuta.Location = new System.Drawing.Point(91, 42);
            this.btnModificarOrigenRuta.Name = "btnModificarOrigenRuta";
            this.btnModificarOrigenRuta.Size = new System.Drawing.Size(171, 23);
            this.btnModificarOrigenRuta.TabIndex = 13;
            this.btnModificarOrigenRuta.Text = "Seleccionar Punto";
            this.btnModificarOrigenRuta.UseVisualStyleBackColor = true;
            this.btnModificarOrigenRuta.Click += new System.EventHandler(this.btnModificarOrigenRuta_Click);
            // 
            // txtModificarRutaNombre
            // 
            this.txtModificarRutaNombre.Location = new System.Drawing.Point(92, 18);
            this.txtModificarRutaNombre.Name = "txtModificarRutaNombre";
            this.txtModificarRutaNombre.Size = new System.Drawing.Size(170, 20);
            this.txtModificarRutaNombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Punto Destino :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Punto Origen : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre Ruta : ";
            // 
            // btnModificarRuta
            // 
            this.btnModificarRuta.Location = new System.Drawing.Point(179, 99);
            this.btnModificarRuta.Name = "btnModificarRuta";
            this.btnModificarRuta.Size = new System.Drawing.Size(83, 23);
            this.btnModificarRuta.TabIndex = 8;
            this.btnModificarRuta.Text = "Cambiar";
            this.btnModificarRuta.UseVisualStyleBackColor = true;
            this.btnModificarRuta.Click += new System.EventHandler(this.btnModificarRuta_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNombrePunto);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnBorrarPuntos);
            this.groupBox5.Controls.Add(this.btnAgregarPuntos);
            this.groupBox5.Location = new System.Drawing.Point(14, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 84);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puntos";
            // 
            // btnAgregarPuntos
            // 
            this.btnAgregarPuntos.Location = new System.Drawing.Point(174, 55);
            this.btnAgregarPuntos.Name = "btnAgregarPuntos";
            this.btnAgregarPuntos.Size = new System.Drawing.Size(81, 23);
            this.btnAgregarPuntos.TabIndex = 0;
            this.btnAgregarPuntos.Text = "Agregar";
            this.btnAgregarPuntos.UseVisualStyleBackColor = true;
            this.btnAgregarPuntos.Click += new System.EventHandler(this.btnAgregarPuntos_Click);
            // 
            // btnBorrarPuntos
            // 
            this.btnBorrarPuntos.Location = new System.Drawing.Point(91, 55);
            this.btnBorrarPuntos.Name = "btnBorrarPuntos";
            this.btnBorrarPuntos.Size = new System.Drawing.Size(81, 23);
            this.btnBorrarPuntos.TabIndex = 1;
            this.btnBorrarPuntos.Text = "Borrar";
            this.btnBorrarPuntos.UseVisualStyleBackColor = true;
            this.btnBorrarPuntos.Click += new System.EventHandler(this.btnBorrarPuntos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre : ";
            // 
            // txtNombrePunto
            // 
            this.txtNombrePunto.Location = new System.Drawing.Point(90, 26);
            this.txtNombrePunto.Name = "txtNombrePunto";
            this.txtNombrePunto.Size = new System.Drawing.Size(165, 20);
            this.txtNombrePunto.TabIndex = 3;
            // 
            // Form_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Rutas";
            this.Text = "Rutas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Button btnSeleccionarPuntoDestinoRutaNueva;
        private System.Windows.Forms.Button btnSeleccionarPuntoOrigenNuevaRuta;
        private System.Windows.Forms.TextBox txtNombreRutaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarAgregarRuta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificarDestinoRuta;
        private System.Windows.Forms.Button btnModificarOrigenRuta;
        private System.Windows.Forms.TextBox txtModificarRutaNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificarRuta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listaRutasDisponibles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listaPuntosRuta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBorrarPuntos;
        private System.Windows.Forms.Button btnAgregarPuntos;
        private System.Windows.Forms.TextBox txtNombrePunto;
        private System.Windows.Forms.Label label7;
    }
}