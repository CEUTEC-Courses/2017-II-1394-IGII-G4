﻿namespace TCS
{
    partial class UsuarioMenu
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
            this.nuevoUsuarioBtn = new System.Windows.Forms.Button();
            this.mostrarUsuarioLV = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrarUsuariosBtn = new System.Windows.Forms.Button();
            this.modificarUsuariosBtn = new System.Windows.Forms.Button();
            this.privilegiosBtn = new System.Windows.Forms.Button();
            this.regresarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardarUsuarioBtn = new System.Windows.Forms.Button();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.privilegioCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuevoUsuarioBtn
            // 
            this.nuevoUsuarioBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.nuevoUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoUsuarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoUsuarioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuevoUsuarioBtn.Location = new System.Drawing.Point(29, 148);
            this.nuevoUsuarioBtn.Name = "nuevoUsuarioBtn";
            this.nuevoUsuarioBtn.Size = new System.Drawing.Size(89, 28);
            this.nuevoUsuarioBtn.TabIndex = 7;
            this.nuevoUsuarioBtn.Text = "Nuevo";
            this.nuevoUsuarioBtn.UseVisualStyleBackColor = false;
            this.nuevoUsuarioBtn.Click += new System.EventHandler(this.nuevoUsuarioBtn_Click);
            // 
            // mostrarUsuarioLV
            // 
            this.mostrarUsuarioLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.columnHeader1,
            this.columnHeader2});
            this.mostrarUsuarioLV.FullRowSelect = true;
            this.mostrarUsuarioLV.LabelWrap = false;
            this.mostrarUsuarioLV.Location = new System.Drawing.Point(267, 12);
            this.mostrarUsuarioLV.Name = "mostrarUsuarioLV";
            this.mostrarUsuarioLV.Size = new System.Drawing.Size(358, 208);
            this.mostrarUsuarioLV.TabIndex = 2;
            this.mostrarUsuarioLV.UseCompatibleStateImageBehavior = false;
            this.mostrarUsuarioLV.View = System.Windows.Forms.View.Details;
            this.mostrarUsuarioLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mostrarUsuarioLV_ItemSelectionChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 162;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contraseña";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id Privilegio";
            this.columnHeader2.Width = 72;
            // 
            // borrarUsuariosBtn
            // 
            this.borrarUsuariosBtn.BackColor = System.Drawing.Color.Firebrick;
            this.borrarUsuariosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarUsuariosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarUsuariosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrarUsuariosBtn.Location = new System.Drawing.Point(634, 43);
            this.borrarUsuariosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.borrarUsuariosBtn.Name = "borrarUsuariosBtn";
            this.borrarUsuariosBtn.Size = new System.Drawing.Size(89, 26);
            this.borrarUsuariosBtn.TabIndex = 3;
            this.borrarUsuariosBtn.Text = "Borrar";
            this.borrarUsuariosBtn.UseVisualStyleBackColor = false;
            this.borrarUsuariosBtn.Click += new System.EventHandler(this.borrarUsuariosBtn_Click);
            // 
            // modificarUsuariosBtn
            // 
            this.modificarUsuariosBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.modificarUsuariosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarUsuariosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuariosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modificarUsuariosBtn.Location = new System.Drawing.Point(634, 12);
            this.modificarUsuariosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarUsuariosBtn.Name = "modificarUsuariosBtn";
            this.modificarUsuariosBtn.Size = new System.Drawing.Size(89, 28);
            this.modificarUsuariosBtn.TabIndex = 11;
            this.modificarUsuariosBtn.Text = "Modificar";
            this.modificarUsuariosBtn.UseVisualStyleBackColor = false;
            this.modificarUsuariosBtn.Click += new System.EventHandler(this.modificarUsuariosBtn_Click);
            // 
            // privilegiosBtn
            // 
            this.privilegiosBtn.BackColor = System.Drawing.Color.Coral;
            this.privilegiosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privilegiosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegiosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.privilegiosBtn.Location = new System.Drawing.Point(634, 72);
            this.privilegiosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.privilegiosBtn.Name = "privilegiosBtn";
            this.privilegiosBtn.Size = new System.Drawing.Size(88, 26);
            this.privilegiosBtn.TabIndex = 12;
            this.privilegiosBtn.Text = "Privilegios";
            this.privilegiosBtn.UseVisualStyleBackColor = false;
            this.privilegiosBtn.Click += new System.EventHandler(this.privilegiosBtn_Click);
            // 
            // regresarBtn
            // 
            this.regresarBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.regresarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regresarBtn.Location = new System.Drawing.Point(634, 192);
            this.regresarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(88, 26);
            this.regresarBtn.TabIndex = 13;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = false;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.guardarUsuarioBtn);
            this.panel1.Controls.Add(this.nuevoUsuarioBtn);
            this.panel1.Controls.Add(this.contrasenaTxt);
            this.panel1.Controls.Add(this.userTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.privilegioCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 208);
            this.panel1.TabIndex = 14;
            // 
            // guardarUsuarioBtn
            // 
            this.guardarUsuarioBtn.BackColor = System.Drawing.Color.Green;
            this.guardarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarUsuarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUsuarioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarUsuarioBtn.Location = new System.Drawing.Point(124, 148);
            this.guardarUsuarioBtn.Name = "guardarUsuarioBtn";
            this.guardarUsuarioBtn.Size = new System.Drawing.Size(86, 28);
            this.guardarUsuarioBtn.TabIndex = 2;
            this.guardarUsuarioBtn.Text = "Guardar";
            this.guardarUsuarioBtn.UseVisualStyleBackColor = false;
            this.guardarUsuarioBtn.Click += new System.EventHandler(this.guardarUsuarioBtn_Click);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTxt.Location = new System.Drawing.Point(84, 68);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(121, 21);
            this.contrasenaTxt.TabIndex = 5;
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(84, 39);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(121, 21);
            this.userTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Privilegio:";
            // 
            // privilegioCmb
            // 
            this.privilegioCmb.FormattingEnabled = true;
            this.privilegioCmb.Location = new System.Drawing.Point(84, 101);
            this.privilegioCmb.Name = "privilegioCmb";
            this.privilegioCmb.Size = new System.Drawing.Size(121, 21);
            this.privilegioCmb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario: ";
            // 
            // UsuarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(731, 229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.privilegiosBtn);
            this.Controls.Add(this.modificarUsuariosBtn);
            this.Controls.Add(this.borrarUsuariosBtn);
            this.Controls.Add(this.mostrarUsuarioLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UsuarioMenu";
            this.Text = "UsuarioMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Button borrarUsuariosBtn;
        private System.Windows.Forms.Button modificarUsuariosBtn;
        private System.Windows.Forms.Button privilegiosBtn;
        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button nuevoUsuarioBtn;
        public System.Windows.Forms.ListView mostrarUsuarioLV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardarUsuarioBtn;
        public System.Windows.Forms.TextBox contrasenaTxt;
        public System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox privilegioCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}