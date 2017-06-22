namespace TCS.UsuariosClases
{
    partial class NuevoUsuarioForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardarUsuarioBtn = new System.Windows.Forms.Button();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.privilegioCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.guardarUsuarioBtn);
            this.panel1.Controls.Add(this.contrasenaTxt);
            this.panel1.Controls.Add(this.userTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.privilegioCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 208);
            this.panel1.TabIndex = 2;
            // 
            // guardarUsuarioBtn
            // 
            this.guardarUsuarioBtn.BackColor = System.Drawing.Color.Green;
            this.guardarUsuarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarUsuarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarUsuarioBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardarUsuarioBtn.Location = new System.Drawing.Point(84, 145);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Usuario";
            // 
            // NuevoUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "NuevoUsuarioForm";
            this.Text = "NuevoUsuarioForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardarUsuarioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox contrasenaTxt;
        public System.Windows.Forms.TextBox userTxt;
        public System.Windows.Forms.ComboBox privilegioCmb;
    }
}