namespace tp_integrador_GUI
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
            txtUser.Location = new Point(291, 16);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(110, 23);
            txtUser.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 78);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 16;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbpassword.Location = new Point(57, 70);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(126, 30);
            lbpassword.TabIndex = 15;
            lbpassword.Text = "passeword";
            // 
            // lbuser
            // 
            lbuser.AutoSize = true;
            lbuser.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbuser.ForeColor = Color.Black;
            lbuser.Location = new Point(57, 16);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(62, 26);
            lbuser.TabIndex = 14;
            lbuser.Text = "User";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(381, 196);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(82, 22);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(10, 196);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 225);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(lbpassword);
            Controls.Add(lbuser);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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