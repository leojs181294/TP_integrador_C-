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
            listView1 = new ListView();
            ID = new ColumnHeader();
            Nombre_Proveedor = new ColumnHeader();
            Celular = new ColumnHeader();
            Nombre_Distribuidora = new ColumnHeader();
            Direccion = new ColumnHeader();
            boton_salida = new Button();
            SuspendLayout();
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(12, 38);
            btnProveedor.Margin = new Padding(3, 2, 3, 2);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(198, 72);
            btnProveedor.TabIndex = 0;
            btnProveedor.Text = "proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btn_fac_proveedor
            // 
            btn_fac_proveedor.Location = new Point(12, 131);
            btn_fac_proveedor.Margin = new Padding(3, 2, 3, 2);
            btn_fac_proveedor.Name = "btn_fac_proveedor";
            btn_fac_proveedor.Size = new Size(198, 72);
            btn_fac_proveedor.TabIndex = 1;
            btn_fac_proveedor.Text = "Factura Proveedor";
            btn_fac_proveedor.UseVisualStyleBackColor = true;
            // 
            // btnNoteboock
            // 
            btnNoteboock.Location = new Point(12, 229);
            btnNoteboock.Margin = new Padding(3, 2, 3, 2);
            btnNoteboock.Name = "btnNoteboock";
            btnNoteboock.Size = new Size(198, 72);
            btnNoteboock.TabIndex = 2;
            btnNoteboock.Text = "Noteboock";
            btnNoteboock.UseVisualStyleBackColor = true;
            btnNoteboock.Click += btnNoteboock_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(12, 321);
            btnVenta.Margin = new Padding(3, 2, 3, 2);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(198, 72);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Nombre_Proveedor, Celular, Nombre_Distribuidora, Direccion });
            listView1.Location = new Point(259, 11);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(909, 459);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // boton_salida
            // 
            boton_salida.Location = new Point(12, 428);
            boton_salida.Margin = new Padding(3, 2, 3, 2);
            boton_salida.Name = "boton_salida";
            boton_salida.Size = new Size(198, 72);
            boton_salida.TabIndex = 5;
            boton_salida.Text = "salir";
            boton_salida.UseVisualStyleBackColor = true;
            boton_salida.Click += boton_salida_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 549);
            Controls.Add(boton_salida);
            Controls.Add(listView1);
            Controls.Add(btnVenta);
            Controls.Add(btnNoteboock);
            Controls.Add(btn_fac_proveedor);
            Controls.Add(btnProveedor);
            Margin = new Padding(3, 2, 3, 2);
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
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Nombre_Proveedor;
        private ColumnHeader Celular;
        private ColumnHeader Nombre_Distribuidora;
        private ColumnHeader Direccion;
        private Button boton_salida;
    }
}