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
            this.btnBorrarRuta = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.btnSeleccionarPuntoDestinoRutaNueva = new System.Windows.Forms.Button();
            this.btnSeleccionarPuntoOrigenNuevaRuta = new System.Windows.Forms.Button();
            this.txtNombreRutaNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarRuta = new System.Windows.Forms.Button();
            this.btnLimpiarAgregarRuta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listaRutasDisponibles = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPuntoARuta = new System.Windows.Forms.Button();
            this.btnBorrarPuntoDeRuta = new System.Windows.Forms.Button();
            this.listaPuntosRuta = new System.Windows.Forms.ListBox();
            this.btnAgregarPuntos = new System.Windows.Forms.Button();
            this.btnBorrarPuntos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombrePunto = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnModificarPunto = new System.Windows.Forms.Button();
            this.btnLimpiarPunto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnBorrarRuta);
            this.groupBox1.Controls.Add(this.btnAgregarRuta);
            this.groupBox1.Controls.Add(this.btnSeleccionarPuntoDestinoRutaNueva);
            this.groupBox1.Controls.Add(this.btnSeleccionarPuntoOrigenNuevaRuta);
            this.groupBox1.Controls.Add(this.txtNombreRutaNueva);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModificarRuta);
            this.groupBox1.Controls.Add(this.btnLimpiarAgregarRuta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(14, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutas";
            // 
            // btnBorrarRuta
            // 
            this.btnBorrarRuta.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarRuta.Location = new System.Drawing.Point(178, 153);
            this.btnBorrarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarRuta.Name = "btnBorrarRuta";
            this.btnBorrarRuta.Size = new System.Drawing.Size(81, 26);
            this.btnBorrarRuta.TabIndex = 9;
            this.btnBorrarRuta.Text = "Borrar";
            this.btnBorrarRuta.UseVisualStyleBackColor = false;
            this.btnBorrarRuta.Click += new System.EventHandler(this.btnBorrarRuta_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarRuta.Location = new System.Drawing.Point(5, 123);
            this.btnAgregarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(82, 26);
            this.btnAgregarRuta.TabIndex = 7;
            this.btnAgregarRuta.Text = "Agregar";
            this.btnAgregarRuta.UseVisualStyleBackColor = false;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnSeleccionarPuntoDestinoRutaNueva
            // 
            this.btnSeleccionarPuntoDestinoRutaNueva.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSeleccionarPuntoDestinoRutaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPuntoDestinoRutaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarPuntoDestinoRutaNueva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarPuntoDestinoRutaNueva.Location = new System.Drawing.Point(90, 68);
            this.btnSeleccionarPuntoDestinoRutaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarPuntoDestinoRutaNueva.Name = "btnSeleccionarPuntoDestinoRutaNueva";
            this.btnSeleccionarPuntoDestinoRutaNueva.Size = new System.Drawing.Size(171, 26);
            this.btnSeleccionarPuntoDestinoRutaNueva.TabIndex = 6;
            this.btnSeleccionarPuntoDestinoRutaNueva.Text = "Seleccionar Punto";
            this.btnSeleccionarPuntoDestinoRutaNueva.UseVisualStyleBackColor = false;
            this.btnSeleccionarPuntoDestinoRutaNueva.Click += new System.EventHandler(this.btnSeleccionarPuntoDestinoRutaNueva_Click);
            // 
            // btnSeleccionarPuntoOrigenNuevaRuta
            // 
            this.btnSeleccionarPuntoOrigenNuevaRuta.BackColor = System.Drawing.Color.SlateGray;
            this.btnSeleccionarPuntoOrigenNuevaRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarPuntoOrigenNuevaRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Location = new System.Drawing.Point(90, 41);
            this.btnSeleccionarPuntoOrigenNuevaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarPuntoOrigenNuevaRuta.Name = "btnSeleccionarPuntoOrigenNuevaRuta";
            this.btnSeleccionarPuntoOrigenNuevaRuta.Size = new System.Drawing.Size(171, 26);
            this.btnSeleccionarPuntoOrigenNuevaRuta.TabIndex = 5;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Text = "Seleccionar Punto";
            this.btnSeleccionarPuntoOrigenNuevaRuta.UseVisualStyleBackColor = false;
            this.btnSeleccionarPuntoOrigenNuevaRuta.Click += new System.EventHandler(this.btnSeleccionarPuntoOrigenNuevaRuta_Click);
            // 
            // txtNombreRutaNueva
            // 
            this.txtNombreRutaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRutaNueva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreRutaNueva.Location = new System.Drawing.Point(91, 17);
            this.txtNombreRutaNueva.Name = "txtNombreRutaNueva";
            this.txtNombreRutaNueva.Size = new System.Drawing.Size(170, 20);
            this.txtNombreRutaNueva.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Punto Destino :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Punto Origen : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Ruta : ";
            // 
            // btnModificarRuta
            // 
            this.btnModificarRuta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificarRuta.Enabled = false;
            this.btnModificarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarRuta.Location = new System.Drawing.Point(91, 123);
            this.btnModificarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarRuta.Name = "btnModificarRuta";
            this.btnModificarRuta.Size = new System.Drawing.Size(83, 26);
            this.btnModificarRuta.TabIndex = 8;
            this.btnModificarRuta.Text = "Modificar";
            this.btnModificarRuta.UseVisualStyleBackColor = false;
            this.btnModificarRuta.Click += new System.EventHandler(this.btnModificarRuta_Click);
            // 
            // btnLimpiarAgregarRuta
            // 
            this.btnLimpiarAgregarRuta.BackColor = System.Drawing.Color.Coral;
            this.btnLimpiarAgregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarAgregarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarAgregarRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarAgregarRuta.Location = new System.Drawing.Point(178, 123);
            this.btnLimpiarAgregarRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarAgregarRuta.Name = "btnLimpiarAgregarRuta";
            this.btnLimpiarAgregarRuta.Size = new System.Drawing.Size(82, 26);
            this.btnLimpiarAgregarRuta.TabIndex = 0;
            this.btnLimpiarAgregarRuta.Text = "Limpiar";
            this.btnLimpiarAgregarRuta.UseVisualStyleBackColor = false;
            this.btnLimpiarAgregarRuta.Click += new System.EventHandler(this.btnLimpiarAgregarRuta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.listaRutasDisponibles);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(287, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rutas";
            // 
            // listaRutasDisponibles
            // 
            this.listaRutasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaRutasDisponibles.FormattingEnabled = true;
            this.listaRutasDisponibles.Location = new System.Drawing.Point(7, 20);
            this.listaRutasDisponibles.Name = "listaRutasDisponibles";
            this.listaRutasDisponibles.Size = new System.Drawing.Size(187, 329);
            this.listaRutasDisponibles.TabIndex = 0;
            this.listaRutasDisponibles.SelectedIndexChanged += new System.EventHandler(this.listaRutasDisponibles_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.btnAgregarPuntoARuta);
            this.groupBox4.Controls.Add(this.btnBorrarPuntoDeRuta);
            this.groupBox4.Controls.Add(this.listaPuntosRuta);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(493, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 365);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puntos en Ruta Seleccionada";
            // 
            // btnAgregarPuntoARuta
            // 
            this.btnAgregarPuntoARuta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarPuntoARuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPuntoARuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntoARuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPuntoARuta.Location = new System.Drawing.Point(28, 334);
            this.btnAgregarPuntoARuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPuntoARuta.Name = "btnAgregarPuntoARuta";
            this.btnAgregarPuntoARuta.Size = new System.Drawing.Size(81, 26);
            this.btnAgregarPuntoARuta.TabIndex = 3;
            this.btnAgregarPuntoARuta.Text = "Agregar";
            this.btnAgregarPuntoARuta.UseVisualStyleBackColor = false;
            this.btnAgregarPuntoARuta.Click += new System.EventHandler(this.btnAgregarPuntoARuta_Click);
            // 
            // btnBorrarPuntoDeRuta
            // 
            this.btnBorrarPuntoDeRuta.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarPuntoDeRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPuntoDeRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPuntoDeRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarPuntoDeRuta.Location = new System.Drawing.Point(113, 334);
            this.btnBorrarPuntoDeRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarPuntoDeRuta.Name = "btnBorrarPuntoDeRuta";
            this.btnBorrarPuntoDeRuta.Size = new System.Drawing.Size(81, 26);
            this.btnBorrarPuntoDeRuta.TabIndex = 2;
            this.btnBorrarPuntoDeRuta.Text = "Borrar";
            this.btnBorrarPuntoDeRuta.UseVisualStyleBackColor = false;
            this.btnBorrarPuntoDeRuta.Click += new System.EventHandler(this.btnBorrarPuntoDeRuta_Click);
            // 
            // listaPuntosRuta
            // 
            this.listaPuntosRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPuntosRuta.FormattingEnabled = true;
            this.listaPuntosRuta.Location = new System.Drawing.Point(7, 20);
            this.listaPuntosRuta.Name = "listaPuntosRuta";
            this.listaPuntosRuta.Size = new System.Drawing.Size(187, 303);
            this.listaPuntosRuta.TabIndex = 0;
            this.listaPuntosRuta.SelectedIndexChanged += new System.EventHandler(this.listaPuntosRuta_SelectedIndexChanged);
            // 
            // btnAgregarPuntos
            // 
            this.btnAgregarPuntos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPuntos.Location = new System.Drawing.Point(7, 51);
            this.btnAgregarPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPuntos.Name = "btnAgregarPuntos";
            this.btnAgregarPuntos.Size = new System.Drawing.Size(81, 26);
            this.btnAgregarPuntos.TabIndex = 0;
            this.btnAgregarPuntos.Text = "Agregar";
            this.btnAgregarPuntos.UseVisualStyleBackColor = false;
            this.btnAgregarPuntos.Click += new System.EventHandler(this.btnAgregarPuntos_Click);
            // 
            // btnBorrarPuntos
            // 
            this.btnBorrarPuntos.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPuntos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrarPuntos.Location = new System.Drawing.Point(178, 81);
            this.btnBorrarPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarPuntos.Name = "btnBorrarPuntos";
            this.btnBorrarPuntos.Size = new System.Drawing.Size(81, 26);
            this.btnBorrarPuntos.TabIndex = 1;
            this.btnBorrarPuntos.Text = "Borrar";
            this.btnBorrarPuntos.UseVisualStyleBackColor = false;
            this.btnBorrarPuntos.Click += new System.EventHandler(this.btnBorrarPuntos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre : ";
            // 
            // txtNombrePunto
            // 
            this.txtNombrePunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombrePunto.Location = new System.Drawing.Point(90, 26);
            this.txtNombrePunto.Name = "txtNombrePunto";
            this.txtNombrePunto.Size = new System.Drawing.Size(165, 20);
            this.txtNombrePunto.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.btnModificarPunto);
            this.groupBox5.Controls.Add(this.btnLimpiarPunto);
            this.groupBox5.Controls.Add(this.txtNombrePunto);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnBorrarPuntos);
            this.groupBox5.Controls.Add(this.btnAgregarPuntos);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(14, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 177);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puntos";
            // 
            // btnModificarPunto
            // 
            this.btnModificarPunto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificarPunto.Enabled = false;
            this.btnModificarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarPunto.Location = new System.Drawing.Point(91, 51);
            this.btnModificarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarPunto.Name = "btnModificarPunto";
            this.btnModificarPunto.Size = new System.Drawing.Size(83, 26);
            this.btnModificarPunto.TabIndex = 10;
            this.btnModificarPunto.Text = "Modificar";
            this.btnModificarPunto.UseVisualStyleBackColor = false;
            this.btnModificarPunto.Click += new System.EventHandler(this.btnModificarPunto_Click);
            // 
            // btnLimpiarPunto
            // 
            this.btnLimpiarPunto.BackColor = System.Drawing.Color.Coral;
            this.btnLimpiarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarPunto.Location = new System.Drawing.Point(177, 51);
            this.btnLimpiarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarPunto.Name = "btnLimpiarPunto";
            this.btnLimpiarPunto.Size = new System.Drawing.Size(82, 26);
            this.btnLimpiarPunto.TabIndex = 9;
            this.btnLimpiarPunto.Text = "Limpiar";
            this.btnLimpiarPunto.UseVisualStyleBackColor = false;
            this.btnLimpiarPunto.Click += new System.EventHandler(this.btnLimpiarPunto_Click);
            // 
            // Form_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(706, 390);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Rutas";
            this.Text = "Rutas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnModificarRuta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listaRutasDisponibles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listaPuntosRuta;
        private System.Windows.Forms.Button btnBorrarRuta;
        private System.Windows.Forms.Button btnAgregarPuntos;
        private System.Windows.Forms.Button btnBorrarPuntos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombrePunto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnModificarPunto;
        private System.Windows.Forms.Button btnLimpiarPunto;
        private System.Windows.Forms.Button btnAgregarPuntoARuta;
        private System.Windows.Forms.Button btnBorrarPuntoDeRuta;
    }
}