﻿namespace TCS.Login
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usuariosLoginTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contraseñaLogin = new System.Windows.Forms.TextBox();
            this.EntrarLoginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 63);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trucking Control System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-1, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 43);
            this.panel3.TabIndex = 2;
            // 
            // usuariosLoginTxt
            // 
            this.usuariosLoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosLoginTxt.Location = new System.Drawing.Point(103, 93);
            this.usuariosLoginTxt.Multiline = true;
            this.usuariosLoginTxt.Name = "usuariosLoginTxt";
            this.usuariosLoginTxt.Size = new System.Drawing.Size(127, 25);
            this.usuariosLoginTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña: ";
            // 
            // contraseñaLogin
            // 
            this.contraseñaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaLogin.Location = new System.Drawing.Point(103, 133);
            this.contraseñaLogin.Multiline = true;
            this.contraseñaLogin.Name = "contraseñaLogin";
            this.contraseñaLogin.Size = new System.Drawing.Size(127, 25);
            this.contraseñaLogin.TabIndex = 7;
            // 
            // EntrarLoginBtn
            // 
            this.EntrarLoginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EntrarLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EntrarLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EntrarLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarLoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EntrarLoginBtn.Location = new System.Drawing.Point(91, 182);
            this.EntrarLoginBtn.Name = "EntrarLoginBtn";
            this.EntrarLoginBtn.Size = new System.Drawing.Size(74, 34);
            this.EntrarLoginBtn.TabIndex = 8;
            this.EntrarLoginBtn.Text = "Ingresar";
            this.EntrarLoginBtn.UseVisualStyleBackColor = false;
            this.EntrarLoginBtn.Click += new System.EventHandler(this.EntrarLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.EntrarLoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(246, 288);
            this.Controls.Add(this.EntrarLoginBtn);
            this.Controls.Add(this.contraseñaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariosLoginTxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usuariosLoginTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraseñaLogin;
        private System.Windows.Forms.Button EntrarLoginBtn;
        private System.Windows.Forms.Label label3;
    }
}