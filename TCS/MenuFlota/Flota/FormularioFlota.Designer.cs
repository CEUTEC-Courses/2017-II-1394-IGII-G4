namespace TCS.MenuFlota.Flota
{
    partial class FormularioFlota
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUnidades = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGuardarFlota = new System.Windows.Forms.Button();
            this.ButtonAgregarUnidadEnFlota = new System.Windows.Forms.Button();
            this.groupBoxListaFlotas = new System.Windows.Forms.GroupBox();
            this.listViewFlotas = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDueño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuFlota = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxListaFlotas.SuspendLayout();
            this.contextMenuFlota.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Empresa:";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpresa.Location = new System.Drawing.Point(155, 36);
            this.textBoxEmpresa.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(163, 22);
            this.textBoxEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Dueño:";
            // 
            // textBoxDueño
            // 
            this.textBoxDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDueño.Location = new System.Drawing.Point(138, 68);
            this.textBoxDueño.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDueño.Name = "textBoxDueño";
            this.textBoxDueño.Size = new System.Drawing.Size(163, 22);
            this.textBoxDueño.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(73, 100);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(163, 22);
            this.textBoxCodigo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewUnidades);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unidades";
            // 
            // dataGridViewUnidades
            // 
            this.dataGridViewUnidades.AllowUserToAddRows = false;
            this.dataGridViewUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Placa,
            this.Marca,
            this.Modelo});
            this.dataGridViewUnidades.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewUnidades.Name = "dataGridViewUnidades";
            this.dataGridViewUnidades.ReadOnly = true;
            this.dataGridViewUnidades.Size = new System.Drawing.Size(440, 222);
            this.dataGridViewUnidades.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLimpiar);
            this.groupBox2.Controls.Add(this.buttonGuardarFlota);
            this.groupBox2.Controls.Add(this.ButtonAgregarUnidadEnFlota);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBoxEmpresa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDueño);
            this.groupBox2.Controls.Add(this.textBoxCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 454);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flota";
            // 
            // buttonGuardarFlota
            // 
            this.buttonGuardarFlota.BackColor = System.Drawing.Color.Navy;
            this.buttonGuardarFlota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarFlota.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGuardarFlota.Location = new System.Drawing.Point(269, 404);
            this.buttonGuardarFlota.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarFlota.Name = "buttonGuardarFlota";
            this.buttonGuardarFlota.Size = new System.Drawing.Size(88, 41);
            this.buttonGuardarFlota.TabIndex = 13;
            this.buttonGuardarFlota.Text = "Guardar";
            this.buttonGuardarFlota.UseVisualStyleBackColor = false;
            this.buttonGuardarFlota.Click += new System.EventHandler(this.buttonGuardarFlota_Click);
            // 
            // ButtonAgregarUnidadEnFlota
            // 
            this.ButtonAgregarUnidadEnFlota.BackColor = System.Drawing.Color.SlateGray;
            this.ButtonAgregarUnidadEnFlota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarUnidadEnFlota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarUnidadEnFlota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAgregarUnidadEnFlota.Location = new System.Drawing.Point(286, 100);
            this.ButtonAgregarUnidadEnFlota.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAgregarUnidadEnFlota.Name = "ButtonAgregarUnidadEnFlota";
            this.ButtonAgregarUnidadEnFlota.Size = new System.Drawing.Size(171, 32);
            this.ButtonAgregarUnidadEnFlota.TabIndex = 9;
            this.ButtonAgregarUnidadEnFlota.Text = "Agregar Unidad";
            this.ButtonAgregarUnidadEnFlota.UseVisualStyleBackColor = false;
            this.ButtonAgregarUnidadEnFlota.Click += new System.EventHandler(this.ButtonAgregarUnidadEnFlota_Click);
            // 
            // groupBoxListaFlotas
            // 
            this.groupBoxListaFlotas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxListaFlotas.Controls.Add(this.listViewFlotas);
            this.groupBoxListaFlotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListaFlotas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxListaFlotas.Location = new System.Drawing.Point(530, 23);
            this.groupBoxListaFlotas.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListaFlotas.Name = "groupBoxListaFlotas";
            this.groupBoxListaFlotas.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListaFlotas.Size = new System.Drawing.Size(300, 442);
            this.groupBoxListaFlotas.TabIndex = 10;
            this.groupBoxListaFlotas.TabStop = false;
            this.groupBoxListaFlotas.Text = "Lista de Flotas";
            // 
            // listViewFlotas
            // 
            this.listViewFlotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnEmpresa,
            this.columnDueño,
            this.columnCodigo});
            this.listViewFlotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFlotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFlotas.FullRowSelect = true;
            this.listViewFlotas.GridLines = true;
            this.listViewFlotas.Location = new System.Drawing.Point(4, 21);
            this.listViewFlotas.Name = "listViewFlotas";
            this.listViewFlotas.Size = new System.Drawing.Size(292, 417);
            this.listViewFlotas.TabIndex = 0;
            this.listViewFlotas.UseCompatibleStateImageBehavior = false;
            this.listViewFlotas.View = System.Windows.Forms.View.Details;
            this.listViewFlotas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFlotas_ItemSelectionChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 29;
            // 
            // columnEmpresa
            // 
            this.columnEmpresa.Text = "Empresa";
            this.columnEmpresa.Width = 108;
            // 
            // columnDueño
            // 
            this.columnDueño.Text = "Dueño";
            this.columnDueño.Width = 70;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Codigo";
            this.columnCodigo.Width = 79;
            // 
            // contextMenuFlota
            // 
            this.contextMenuFlota.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuFlota.Name = "contextMenuFlota";
            this.contextMenuFlota.Size = new System.Drawing.Size(127, 48);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimpiar.Location = new System.Drawing.Point(381, 404);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 41);
            this.buttonLimpiar.TabIndex = 15;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // FormularioFlota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.groupBoxListaFlotas);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioFlota";
            this.Text = "Flota";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxListaFlotas.ResumeLayout(false);
            this.contextMenuFlota.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewUnidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonAgregarUnidadEnFlota;
        private System.Windows.Forms.Button buttonGuardarFlota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.GroupBox groupBoxListaFlotas;
        private System.Windows.Forms.ListView listViewFlotas;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnEmpresa;
        private System.Windows.Forms.ColumnHeader columnDueño;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuFlota;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}