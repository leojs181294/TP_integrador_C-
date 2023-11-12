namespace tp_integrador_GUI
{
    partial class Form3
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
            txtProv = new TextBox();
            etiqueta_1 = new Label();
            datos_proveedor.SuspendLayout();
            SuspendLayout();
            // 
            // datos_proveedor
            // 
            datos_proveedor.Controls.Add(boton1);
            datos_proveedor.Controls.Add(txtProv);
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
            boton1.Location = new Point(384, 32);
            boton1.Name = "boton1";
            boton1.Size = new Size(81, 29);
            boton1.TabIndex = 2;
            boton1.Text = "Enviar";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // txtProv
            // 
            txtProv.Location = new Point(181, 32);
            txtProv.Name = "txtProv";
            txtProv.Size = new Size(197, 29);
            txtProv.TabIndex = 1;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datos_proveedor);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            datos_proveedor.ResumeLayout(false);
            datos_proveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox datos_proveedor;
        private Label etiqueta_1;
        private TextBox txtProv;
        private Button boton1;
    }
}