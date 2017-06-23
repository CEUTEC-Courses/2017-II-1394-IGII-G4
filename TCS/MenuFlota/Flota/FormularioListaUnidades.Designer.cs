namespace TCS.MenuFlota.Flota
{
    partial class FormularioListaUnidades
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
            this.groupBoxListaUnidades = new System.Windows.Forms.GroupBox();
            this.listViewUnidades = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAgregarUnidad = new System.Windows.Forms.Button();
            this.groupBoxListaUnidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListaUnidades
            // 
            this.groupBoxListaUnidades.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxListaUnidades.Controls.Add(this.listViewUnidades);
            this.groupBoxListaUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListaUnidades.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxListaUnidades.Location = new System.Drawing.Point(8, 8);
            this.groupBoxListaUnidades.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListaUnidades.Name = "groupBoxListaUnidades";
            this.groupBoxListaUnidades.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListaUnidades.Size = new System.Drawing.Size(379, 330);
            this.groupBoxListaUnidades.TabIndex = 5;
            this.groupBoxListaUnidades.TabStop = false;
            this.groupBoxListaUnidades.Text = "Lista de Unidades";
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
            this.listViewUnidades.Size = new System.Drawing.Size(371, 305);
            this.listViewUnidades.TabIndex = 0;
            this.listViewUnidades.UseCompatibleStateImageBehavior = false;
            this.listViewUnidades.View = System.Windows.Forms.View.Details;
            this.listViewUnidades.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUnidades_ItemSelectionChanged);
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
            // buttonAgregarUnidad
            // 
            this.buttonAgregarUnidad.BackColor = System.Drawing.Color.Navy;
            this.buttonAgregarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarUnidad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAgregarUnidad.Location = new System.Drawing.Point(299, 346);
            this.buttonAgregarUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregarUnidad.Name = "buttonAgregarUnidad";
            this.buttonAgregarUnidad.Size = new System.Drawing.Size(88, 41);
            this.buttonAgregarUnidad.TabIndex = 14;
            this.buttonAgregarUnidad.Text = "Agregar ";
            this.buttonAgregarUnidad.UseVisualStyleBackColor = false;
            this.buttonAgregarUnidad.Click += new System.EventHandler(this.buttonAgregarUnidad_Click);
            // 
            // FormularioListaUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(407, 387);
            this.Controls.Add(this.buttonAgregarUnidad);
            this.Controls.Add(this.groupBoxListaUnidades);
            this.Name = "FormularioListaUnidades";
            this.Text = "Lista de Unidades";
            this.Load += new System.EventHandler(this.FormularioListaUnidades_Load);
            this.groupBoxListaUnidades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaUnidades;
        private System.Windows.Forms.ListView listViewUnidades;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnPlaca;
        private System.Windows.Forms.ColumnHeader columnMarca;
        private System.Windows.Forms.ColumnHeader columnModelo;
        private System.Windows.Forms.ColumnHeader columnEstado;
        private System.Windows.Forms.ColumnHeader columnAño;
        private System.Windows.Forms.Button buttonAgregarUnidad;
    }
}