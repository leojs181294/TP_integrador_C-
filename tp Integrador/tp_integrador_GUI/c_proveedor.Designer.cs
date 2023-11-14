namespace tp_integrador_GUI
{
    partial class c_proveedor
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
            boton1 = new Button();
            txtProv1 = new TextBox();
            etiqueta_1 = new Label();
            txtProv2 = new TextBox();
            txtProv3 = new TextBox();
            txtProv4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            datos_proveedor.Location = new Point(12, 12);
            datos_proveedor.Name = "datos_proveedor";
            datos_proveedor.Size = new Size(760, 426);
            datos_proveedor.TabIndex = 1;
            datos_proveedor.TabStop = false;
            datos_proveedor.Text = "Datos del proveedor";
            // 
            // boton1
            // 
            boton1.Location = new Point(212, 364);
            boton1.Name = "boton1";
            boton1.Size = new Size(347, 29);
            boton1.TabIndex = 2;
            boton1.Text = "Enviar";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // txtProv1
            // 
            txtProv1.Location = new Point(212, 32);
            txtProv1.Name = "txtProv1";
            txtProv1.Size = new Size(508, 29);
            txtProv1.TabIndex = 1;
            // 
            // etiqueta_1
            // 
            etiqueta_1.AutoSize = true;
            etiqueta_1.Location = new Point(6, 35);
            etiqueta_1.Name = "etiqueta_1";
            etiqueta_1.Size = new Size(169, 21);
            etiqueta_1.TabIndex = 0;
            etiqueta_1.Text = "Nombre del proveedor";
            etiqueta_1.Click += label1_Click;
            // 
            // txtProv2
            // 
            txtProv2.Location = new Point(212, 67);
            txtProv2.Name = "txtProv2";
            txtProv2.Size = new Size(508, 29);
            txtProv2.TabIndex = 3;
            // 
            // txtProv3
            // 
            txtProv3.Location = new Point(212, 102);
            txtProv3.Name = "txtProv3";
            txtProv3.Size = new Size(508, 29);
            txtProv3.TabIndex = 4;
            // 
            // txtProv4
            // 
            txtProv4.Location = new Point(212, 137);
            txtProv4.Name = "txtProv4";
            txtProv4.Size = new Size(508, 29);
            txtProv4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 6;
            label1.Text = "Telefono del proveedor";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(198, 21);
            label2.TabIndex = 7;
            label2.Text = "Nombre de la distribuidora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 140);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 8;
            label3.Text = "Direccion del proveedor";
            // 
            // c_proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datos_proveedor);
            Name = "c_proveedor";
            Text = "Form3";
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