﻿namespace tp_integrador_GUI
{
    partial class Form1
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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lbpassword = new Label();
            lbuser = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(333, 22);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(333, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 16;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbpassword.Location = new Point(65, 93);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(157, 38);
            lbpassword.TabIndex = 15;
            lbpassword.Text = "passeword";
            // 
            // lbuser
            // 
            lbuser.AutoSize = true;
            lbuser.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbuser.ForeColor = Color.Black;
            lbuser.Location = new Point(65, 22);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(74, 37);
            lbuser.TabIndex = 14;
            lbuser.Text = "User";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(435, 262);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 262);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 300);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(lbpassword);
            Controls.Add(lbuser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lbpassword;
        private Label lbuser;
        private Button btnIngresar;
        private Button btnSalir;
    }
}