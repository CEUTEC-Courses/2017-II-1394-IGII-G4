namespace TCS.MenuFlota.Unidad
{
    partial class FormularioUnidad
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
            this.panelCrearUnidad = new System.Windows.Forms.Panel();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonGuardarUnidad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.añoUnidad = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEstadoUnidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModeloUnidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMarcaUnidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlacaUnidad = new System.Windows.Forms.TextBox();
            this.groupBoxListaUnidades = new System.Windows.Forms.GroupBox();
            this.listViewUnidades = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuUnidad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCrearUnidad.SuspendLayout();
            this.groupBoxListaUnidades.SuspendLayout();
            this.contextMenuUnidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCrearUnidad
            // 
            this.panelCrearUnidad.Controls.Add(this.buttonLimpiar);
            this.panelCrearUnidad.Controls.Add(this.buttonActualizar);
            this.panelCrearUnidad.Controls.Add(this.buttonGuardarUnidad);
            this.panelCrearUnidad.Controls.Add(this.label6);
            this.panelCrearUnidad.Controls.Add(this.añoUnidad);
            this.panelCrearUnidad.Controls.Add(this.label5);
            this.panelCrearUnidad.Controls.Add(this.comboBoxEstadoUnidad);
            this.panelCrearUnidad.Controls.Add(this.label4);
            this.panelCrearUnidad.Controls.Add(this.label3);
            this.panelCrearUnidad.Controls.Add(this.textBoxModeloUnidad);
            this.panelCrearUnidad.Controls.Add(this.label2);
            this.panelCrearUnidad.Controls.Add(this.textBoxMarcaUnidad);
            this.panelCrearUnidad.Controls.Add(this.label1);
            this.panelCrearUnidad.Controls.Add(this.textBoxPlacaUnidad);
            this.panelCrearUnidad.Location = new System.Drawing.Point(14, 14);
            this.panelCrearUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.panelCrearUnidad.Name = "panelCrearUnidad";
            this.panelCrearUnidad.Size = new System.Drawing.Size(311, 329);
            this.panelCrearUnidad.TabIndex = 1;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimpiar.Location = new System.Drawing.Point(209, 280);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(88, 26);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Green;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonActualizar.Location = new System.Drawing.Point(113, 280);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(88, 26);
            this.buttonActualizar.TabIndex = 13;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonGuardarUnidad
            // 
            this.buttonGuardarUnidad.BackColor = System.Drawing.Color.Navy;
            this.buttonGuardarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarUnidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGuardarUnidad.Location = new System.Drawing.Point(17, 280);
            this.buttonGuardarUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarUnidad.Name = "buttonGuardarUnidad";
            this.buttonGuardarUnidad.Size = new System.Drawing.Size(88, 26);
            this.buttonGuardarUnidad.TabIndex = 12;
            this.buttonGuardarUnidad.Text = "Guardar";
            this.buttonGuardarUnidad.UseVisualStyleBackColor = false;
            this.buttonGuardarUnidad.Click += new System.EventHandler(this.buttonGuardarUnidad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "CREAR UNIDAD";
            // 
            // añoUnidad
            // 
            this.añoUnidad.CustomFormat = "yyyy";
            this.añoUnidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.añoUnidad.Location = new System.Drawing.Point(59, 232);
            this.añoUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.añoUnidad.Name = "añoUnidad";
            this.añoUnidad.Size = new System.Drawing.Size(73, 21);
            this.añoUnidad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año:";
            // 
            // comboBoxEstadoUnidad
            // 
            this.comboBoxEstadoUnidad.FormattingEnabled = true;
            this.comboBoxEstadoUnidad.Location = new System.Drawing.Point(74, 179);
            this.comboBoxEstadoUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEstadoUnidad.Name = "comboBoxEstadoUnidad";
            this.comboBoxEstadoUnidad.Size = new System.Drawing.Size(140, 23);
            this.comboBoxEstadoUnidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo:";
            // 
            // textBoxModeloUnidad
            // 
            this.textBoxModeloUnidad.Location = new System.Drawing.Point(74, 133);
            this.textBoxModeloUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModeloUnidad.Name = "textBoxModeloUnidad";
            this.textBoxModeloUnidad.Size = new System.Drawing.Size(140, 21);
            this.textBoxModeloUnidad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // textBoxMarcaUnidad
            // 
            this.textBoxMarcaUnidad.Location = new System.Drawing.Point(74, 87);
            this.textBoxMarcaUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarcaUnidad.Name = "textBoxMarcaUnidad";
            this.textBoxMarcaUnidad.Size = new System.Drawing.Size(140, 21);
            this.textBoxMarcaUnidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // textBoxPlacaUnidad
            // 
            this.textBoxPlacaUnidad.Location = new System.Drawing.Point(74, 41);
            this.textBoxPlacaUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlacaUnidad.Name = "textBoxPlacaUnidad";
            this.textBoxPlacaUnidad.Size = new System.Drawing.Size(140, 21);
            this.textBoxPlacaUnidad.TabIndex = 0;
            // 
            // groupBoxListaUnidades
            // 
            this.groupBoxListaUnidades.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxListaUnidades.Controls.Add(this.listViewUnidades);
            this.groupBoxListaUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListaUnidades.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxListaUnidades.Location = new System.Drawing.Point(340, 13);
            this.groupBoxListaUnidades.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListaUnidades.Name = "groupBoxListaUnidades";
            this.groupBoxListaUnidades.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListaUnidades.Size = new System.Drawing.Size(386, 330);
            this.groupBoxListaUnidades.TabIndex = 4;
            this.groupBoxListaUnidades.TabStop = false;
            this.groupBoxListaUnidades.Text = "Lista de Unidades";
//            this.groupBoxListaUnidades.Enter += new System.EventHandler(this.groupBoxListaUnidades_Enter);
            // 
            // listViewUnidades
            // 
            this.listViewUnidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnPlaca,
            this.columnMarca,
            this.columnModelo,
            this.columnEstado,
            this.columnAño});
            this.listViewUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUnidades.FullRowSelect = true;
            this.listViewUnidades.GridLines = true;
            this.listViewUnidades.Location = new System.Drawing.Point(4, 21);
            this.listViewUnidades.Name = "listViewUnidades";
            this.listViewUnidades.Size = new System.Drawing.Size(378, 305);
            this.listViewUnidades.TabIndex = 0;
            this.listViewUnidades.UseCompatibleStateImageBehavior = false;
            this.listViewUnidades.View = System.Windows.Forms.View.Details;
            this.listViewUnidades.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUnidades_ItemSelectionChanged);
//            this.listViewUnidades.SelectedIndexChanged += new System.EventHandler(this.listViewUnidades_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 40;
            // 
            // columnPlaca
            // 
            this.columnPlaca.Text = "Placa";
            // 
            // columnMarca
            // 
            this.columnMarca.Text = "Marca";
            this.columnMarca.Width = 70;
            // 
            // columnModelo
            // 
            this.columnModelo.Text = "Modelo";
            this.columnModelo.Width = 69;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 68;
            // 
            // columnAño
            // 
            this.columnAño.Text = "Año";
            this.columnAño.Width = 200;
            // 
            // contextMenuUnidad
            // 
            this.contextMenuUnidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuUnidad.Name = "contextMenuUnidad";
            this.contextMenuUnidad.Size = new System.Drawing.Size(127, 48);
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
            // FormularioUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 388);
            this.Controls.Add(this.groupBoxListaUnidades);
            this.Controls.Add(this.panelCrearUnidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioUnidad";
            this.Text = "Unidad";
           
            this.panelCrearUnidad.ResumeLayout(false);
            this.panelCrearUnidad.PerformLayout();
            this.groupBoxListaUnidades.ResumeLayout(false);
            this.contextMenuUnidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearUnidad;
        private System.Windows.Forms.Button buttonGuardarUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker añoUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEstadoUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModeloUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMarcaUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlacaUnidad;
        private System.Windows.Forms.GroupBox groupBoxListaUnidades;
        private System.Windows.Forms.ListView listViewUnidades;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnPlaca;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnModelo;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.ColumnHeader columnAño;
        private System.Windows.Forms.ContextMenuStrip contextMenuUnidad;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonActualizar;
    }
}