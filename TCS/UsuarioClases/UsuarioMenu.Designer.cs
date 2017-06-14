namespace TCS
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardarUsuarioBtn = new System.Windows.Forms.Button();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.privilegioCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostrarUsuarioLV = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.guardarUsuarioBtn);
            this.panel1.Controls.Add(this.contrasenaTxt);
            this.panel1.Controls.Add(this.userTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.privilegioCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 243);
            this.panel1.TabIndex = 1;
            // 
            // guardarUsuarioBtn
            // 
            this.guardarUsuarioBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guardarUsuarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUsuarioBtn.Location = new System.Drawing.Point(73, 151);
            this.guardarUsuarioBtn.Name = "guardarUsuarioBtn";
            this.guardarUsuarioBtn.Size = new System.Drawing.Size(77, 40);
            this.guardarUsuarioBtn.TabIndex = 2;
            this.guardarUsuarioBtn.Text = "Guardar";
            this.guardarUsuarioBtn.UseVisualStyleBackColor = false;
            this.guardarUsuarioBtn.Click += new System.EventHandler(this.guardarUsuarioBtn_Click);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTxt.Location = new System.Drawing.Point(90, 68);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Size = new System.Drawing.Size(121, 21);
            this.contrasenaTxt.TabIndex = 5;
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(90, 39);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(121, 21);
            this.userTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Privilegio:";
            // 
            // privilegioCmb
            // 
            this.privilegioCmb.FormattingEnabled = true;
            this.privilegioCmb.Location = new System.Drawing.Point(90, 101);
            this.privilegioCmb.Name = "privilegioCmb";
            this.privilegioCmb.Size = new System.Drawing.Size(121, 21);
            this.privilegioCmb.TabIndex = 2;
            this.privilegioCmb.SelectedIndexChanged += new System.EventHandler(this.privilegioCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario: ";
            // 
            // mostrarUsuarioLV
            // 
            this.mostrarUsuarioLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre});
            this.mostrarUsuarioLV.Location = new System.Drawing.Point(258, 12);
            this.mostrarUsuarioLV.Name = "mostrarUsuarioLV";
            this.mostrarUsuarioLV.Size = new System.Drawing.Size(148, 193);
            this.mostrarUsuarioLV.TabIndex = 2;
            this.mostrarUsuarioLV.UseCompatibleStateImageBehavior = false;
            this.mostrarUsuarioLV.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // UsuarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 273);
            this.Controls.Add(this.mostrarUsuarioLV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UsuarioMenu";
            this.Text = "UsuarioMenu";
            this.Load += new System.EventHandler(this.UsuarioMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardarUsuarioBtn;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox privilegioCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView mostrarUsuarioLV;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Id;
    }
}