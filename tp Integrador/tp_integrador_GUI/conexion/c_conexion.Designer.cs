namespace tp_integrador_GUI
{
    partial class c_conexion
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
            datos_proveedor = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtConx3 = new TextBox();
            txtConx2 = new TextBox();
            boton1 = new Button();
            txtConx1 = new TextBox();
            etiqueta_1 = new Label();
            datos_proveedor.SuspendLayout();
            SuspendLayout();
            // 
            // datos_proveedor
            // 
            datos_proveedor.Controls.Add(label2);
            datos_proveedor.Controls.Add(label1);
            datos_proveedor.Controls.Add(txtConx3);
            datos_proveedor.Controls.Add(txtConx2);
            datos_proveedor.Controls.Add(boton1);
            datos_proveedor.Controls.Add(txtConx1);
            datos_proveedor.Controls.Add(etiqueta_1);
            datos_proveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datos_proveedor.Location = new Point(12, 12);
            datos_proveedor.Name = "datos_proveedor";
            datos_proveedor.Size = new Size(760, 426);
            datos_proveedor.TabIndex = 1;
            datos_proveedor.TabStop = false;
            datos_proveedor.Text = "Datos del proveedor";
            datos_proveedor.Enter += datos_proveedor_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 6;
            label1.Text = "Nombre del usuario";
            label1.Click += label1_Click_1;
            // 
            // txtConx3
            // 
            txtConx3.Location = new Point(243, 102);
            txtConx3.Name = "txtConx3";
            txtConx3.Size = new Size(476, 29);
            txtConx3.TabIndex = 4;
            // 
            // txtConx2
            // 
            txtConx2.Location = new Point(243, 67);
            txtConx2.Name = "txtConx2";
            txtConx2.Size = new Size(476, 29);
            txtConx2.TabIndex = 3;
            txtConx2.TextChanged += txtProv2_TextChanged;
            // 
            // boton1
            // 
            boton1.FlatStyle = FlatStyle.System;
            boton1.Location = new Point(212, 364);
            boton1.Name = "boton1";
            boton1.Size = new Size(347, 29);
            boton1.TabIndex = 2;
            boton1.Text = "Enviar";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // txtConx1
            // 
            txtConx1.Location = new Point(243, 32);
            txtConx1.Name = "txtConx1";
            txtConx1.Size = new Size(476, 29);
            txtConx1.TabIndex = 1;
            txtConx1.TextChanged += txtProv1_TextChanged;
            // 
            // etiqueta_1
            // 
            etiqueta_1.AutoSize = true;
            etiqueta_1.Location = new Point(6, 35);
            etiqueta_1.Name = "etiqueta_1";
            etiqueta_1.Size = new Size(154, 21);
            etiqueta_1.TabIndex = 0;
            etiqueta_1.Text = "Nombre del servidor";
            etiqueta_1.Click += label1_Click;
            // 
            // c_conexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datos_proveedor);
            Name = "c_conexion";
            Text = "Proveedor";
            Load += Form3_Load;
            datos_proveedor.ResumeLayout(false);
            datos_proveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox datos_proveedor;
        private Label etiqueta_1;
        private TextBox txtConx1;
        private Button boton1;
        private TextBox txtConx3;
        private TextBox txtConx2;
        private Label label2;
        private Label label1;
    }
}