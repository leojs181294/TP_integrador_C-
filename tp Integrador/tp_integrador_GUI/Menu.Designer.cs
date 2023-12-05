namespace tp_integrador_GUI
{
    partial class Menu
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
            btnProveedor = new Button();
            btn_fac_proveedor = new Button();
            btnNoteboock = new Button();
            btnVenta = new Button();
            boton_salida = new Button();
            SuspendLayout();
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(14, 51);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(226, 96);
            btnProveedor.TabIndex = 0;
            btnProveedor.Text = "proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btn_fac_proveedor
            // 
            btn_fac_proveedor.Location = new Point(14, 175);
            btn_fac_proveedor.Name = "btn_fac_proveedor";
            btn_fac_proveedor.Size = new Size(226, 96);
            btn_fac_proveedor.TabIndex = 1;
            btn_fac_proveedor.Text = "Factura Proveedor";
            btn_fac_proveedor.UseVisualStyleBackColor = true;
            btn_fac_proveedor.Click += btn_fac_proveedor_Click;
            // 
            // btnNoteboock
            // 
            btnNoteboock.Location = new Point(14, 305);
            btnNoteboock.Name = "btnNoteboock";
            btnNoteboock.Size = new Size(226, 96);
            btnNoteboock.TabIndex = 2;
            btnNoteboock.Text = "Noteboock";
            btnNoteboock.UseVisualStyleBackColor = true;
            btnNoteboock.Click += btnNoteboock_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(14, 428);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(226, 96);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // boton_salida
            // 
            boton_salida.Location = new Point(14, 571);
            boton_salida.Name = "boton_salida";
            boton_salida.Size = new Size(226, 96);
            boton_salida.TabIndex = 5;
            boton_salida.Text = "salir";
            boton_salida.UseVisualStyleBackColor = true;
            boton_salida.Click += boton_salida_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 732);
            Controls.Add(boton_salida);
            Controls.Add(btnVenta);
            Controls.Add(btnNoteboock);
            Controls.Add(btn_fac_proveedor);
            Controls.Add(btnProveedor);
            Name = "Menu";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProveedor;
        private Button btn_fac_proveedor;
        private Button btnNoteboock;
        private Button btnVenta;
        private Button boton_salida;
    }
}