namespace tp_integrador_GUI
{
    partial class u_proveedor
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProv4 = new TextBox();
            txtProv3 = new TextBox();
            txtProv2 = new TextBox();
            boton1 = new Button();
            txtProv1 = new TextBox();
            etiqueta_1 = new Label();
            datos_proveedor.SuspendLayout();
            SuspendLayout();
            // 
            // datos_proveedor
            // 
            datos_proveedor.Controls.Add(label3);
            datos_proveedor.Controls.Add(label2);
            datos_proveedor.Controls.Add(label1);
            datos_proveedor.Controls.Add(txtProv4);
            datos_proveedor.Controls.Add(txtProv3);
            datos_proveedor.Controls.Add(txtProv2);
            datos_proveedor.Controls.Add(boton1);
            datos_proveedor.Controls.Add(txtProv1);
            datos_proveedor.Controls.Add(etiqueta_1);
            datos_proveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datos_proveedor.Location = new Point(14, 16);
            datos_proveedor.Margin = new Padding(3, 4, 3, 4);
            datos_proveedor.Name = "datos_proveedor";
            datos_proveedor.Padding = new Padding(3, 4, 3, 4);
            datos_proveedor.Size = new Size(869, 568);
            datos_proveedor.TabIndex = 1;
            datos_proveedor.TabStop = false;
            datos_proveedor.Text = "Datos del proveedor";
            datos_proveedor.Enter += datos_proveedor_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 187);
            label3.Name = "label3";
            label3.Size = new Size(223, 28);
            label3.TabIndex = 8;
            label3.Text = "Direccion del proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 140);
            label2.Name = "label2";
            label2.Size = new Size(250, 28);
            label2.TabIndex = 7;
            label2.Text = "Nombre de la distribuidora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 93);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 6;
            label1.Text = "Telefono del proveedor";
            label1.Click += label1_Click_1;
            // 
            // txtProv4
            // 
            txtProv4.Location = new Point(278, 183);
            txtProv4.Margin = new Padding(3, 4, 3, 4);
            txtProv4.Name = "txtProv4";
            txtProv4.Size = new Size(544, 34);
            txtProv4.TabIndex = 5;
            // 
            // txtProv3
            // 
            txtProv3.Location = new Point(278, 136);
            txtProv3.Margin = new Padding(3, 4, 3, 4);
            txtProv3.Name = "txtProv3";
            txtProv3.Size = new Size(544, 34);
            txtProv3.TabIndex = 4;
            // 
            // txtProv2
            // 
            txtProv2.Location = new Point(278, 89);
            txtProv2.Margin = new Padding(3, 4, 3, 4);
            txtProv2.Name = "txtProv2";
            txtProv2.Size = new Size(544, 34);
            txtProv2.TabIndex = 3;
            txtProv2.TextChanged += txtProv2_TextChanged;
            // 
            // boton1
            // 
            boton1.FlatStyle = FlatStyle.System;
            boton1.Location = new Point(242, 485);
            boton1.Margin = new Padding(3, 4, 3, 4);
            boton1.Name = "boton1";
            boton1.Size = new Size(397, 39);
            boton1.TabIndex = 2;
            boton1.Text = "Enviar";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // txtProv1
            // 
            txtProv1.Location = new Point(278, 43);
            txtProv1.Margin = new Padding(3, 4, 3, 4);
            txtProv1.Name = "txtProv1";
            txtProv1.Size = new Size(544, 34);
            txtProv1.TabIndex = 1;
            txtProv1.TextChanged += txtProv1_TextChanged;
            // 
            // etiqueta_1
            // 
            etiqueta_1.AutoSize = true;
            etiqueta_1.Location = new Point(7, 47);
            etiqueta_1.Name = "etiqueta_1";
            etiqueta_1.Size = new Size(214, 28);
            etiqueta_1.TabIndex = 0;
            etiqueta_1.Text = "Nombre del proveedor";
            etiqueta_1.Click += label1_Click;
            // 
            // c_proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(datos_proveedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "c_proveedor";
            Text = "Proveedor";
            Load += Form3_Load;
            datos_proveedor.ResumeLayout(false);
            datos_proveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox datos_proveedor;
        private Label etiqueta_1;
        private TextBox txtProv1;
        private Button boton1;
        private TextBox txtProv4;
        private TextBox txtProv3;
        private TextBox txtProv2;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}