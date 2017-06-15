namespace TCS.UsuariosClases
{
    partial class PrivilegiosForm
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
            this.regresarBtn = new System.Windows.Forms.Button();
            this.modificarPrivilegiosBtn = new System.Windows.Forms.Button();
            this.borrarPrivilegiosBtn = new System.Windows.Forms.Button();
            this.mostrarPrivilegiosLV = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardarUsuarioBtn = new System.Windows.Forms.Button();
            this.privilegioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regresarBtn
            // 
            this.regresarBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.regresarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regresarBtn.Location = new System.Drawing.Point(420, 77);
            this.regresarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(88, 26);
            this.regresarBtn.TabIndex = 19;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = false;
            // 
            // modificarPrivilegiosBtn
            // 
            this.modificarPrivilegiosBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modificarPrivilegiosBtn.Enabled = false;
            this.modificarPrivilegiosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarPrivilegiosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarPrivilegiosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modificarPrivilegiosBtn.Location = new System.Drawing.Point(419, 17);
            this.modificarPrivilegiosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modificarPrivilegiosBtn.Name = "modificarPrivilegiosBtn";
            this.modificarPrivilegiosBtn.Size = new System.Drawing.Size(89, 26);
            this.modificarPrivilegiosBtn.TabIndex = 17;
            this.modificarPrivilegiosBtn.Text = "Modificar";
            this.modificarPrivilegiosBtn.UseVisualStyleBackColor = false;
            // 
            // borrarPrivilegiosBtn
            // 
            this.borrarPrivilegiosBtn.BackColor = System.Drawing.Color.Firebrick;
            this.borrarPrivilegiosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarPrivilegiosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarPrivilegiosBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrarPrivilegiosBtn.Location = new System.Drawing.Point(419, 47);
            this.borrarPrivilegiosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.borrarPrivilegiosBtn.Name = "borrarPrivilegiosBtn";
            this.borrarPrivilegiosBtn.Size = new System.Drawing.Size(89, 26);
            this.borrarPrivilegiosBtn.TabIndex = 16;
            this.borrarPrivilegiosBtn.Text = "Borrar";
            this.borrarPrivilegiosBtn.UseVisualStyleBackColor = false;
            // 
            // mostrarPrivilegiosLV
            // 
            this.mostrarPrivilegiosLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre});
            this.mostrarPrivilegiosLV.Location = new System.Drawing.Point(243, 16);
            this.mostrarPrivilegiosLV.Name = "mostrarPrivilegiosLV";
            this.mostrarPrivilegiosLV.Size = new System.Drawing.Size(166, 128);
            this.mostrarPrivilegiosLV.TabIndex = 15;
            this.mostrarPrivilegiosLV.UseCompatibleStateImageBehavior = false;
            this.mostrarPrivilegiosLV.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Lista";
            this.Nombre.Width = 162;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.guardarUsuarioBtn);
            this.panel1.Controls.Add(this.privilegioTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 128);
            this.panel1.TabIndex = 14;
            // 
            // guardarUsuarioBtn
            // 
            this.guardarUsuarioBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.guardarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarUsuarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUsuarioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarUsuarioBtn.Location = new System.Drawing.Point(72, 84);
            this.guardarUsuarioBtn.Name = "guardarUsuarioBtn";
            this.guardarUsuarioBtn.Size = new System.Drawing.Size(77, 29);
            this.guardarUsuarioBtn.TabIndex = 2;
            this.guardarUsuarioBtn.Text = "Agregar";
            this.guardarUsuarioBtn.UseVisualStyleBackColor = false;
            // 
            // privilegioTxt
            // 
            this.privilegioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegioTxt.Location = new System.Drawing.Point(84, 39);
            this.privilegioTxt.Name = "privilegioTxt";
            this.privilegioTxt.Size = new System.Drawing.Size(121, 21);
            this.privilegioTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Privilegio: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Privilegios";
            // 
            // PrivilegiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 156);
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.modificarPrivilegiosBtn);
            this.Controls.Add(this.borrarPrivilegiosBtn);
            this.Controls.Add(this.mostrarPrivilegiosLV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PrivilegiosForm";
            this.Text = "PrivilegiosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regresarBtn;
        private System.Windows.Forms.Button modificarPrivilegiosBtn;
        private System.Windows.Forms.Button borrarPrivilegiosBtn;
        private System.Windows.Forms.ListView mostrarPrivilegiosLV;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardarUsuarioBtn;
        private System.Windows.Forms.TextBox privilegioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}