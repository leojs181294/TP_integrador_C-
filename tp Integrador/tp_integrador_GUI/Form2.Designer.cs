namespace tp_integrador_GUI
{
    partial class Form2
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
            SuspendLayout();
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(34, 49);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(226, 96);
            btnProveedor.TabIndex = 0;
            btnProveedor.Text = "proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btn_fac_proveedor
            // 
            btn_fac_proveedor.Location = new Point(34, 175);
            btn_fac_proveedor.Name = "btn_fac_proveedor";
            btn_fac_proveedor.Size = new Size(226, 96);
            btn_fac_proveedor.TabIndex = 1;
            btn_fac_proveedor.Text = "Factura Proveedor";
            btn_fac_proveedor.UseVisualStyleBackColor = true;
            // 
            // btnNoteboock
            // 
            btnNoteboock.Location = new Point(34, 305);
            btnNoteboock.Name = "btnNoteboock";
            btnNoteboock.Size = new Size(226, 96);
            btnNoteboock.TabIndex = 2;
            btnNoteboock.Text = "Noteboock";
            btnNoteboock.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(34, 429);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(226, 96);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Nombre_Proveedor, Celular, Nombre_Distribuidora, Direccion });
            listView1.Location = new Point(589, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(490, 557);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 732);
            Controls.Add(listView1);
            Controls.Add(btnVenta);
            Controls.Add(btnNoteboock);
            Controls.Add(btn_fac_proveedor);
            Controls.Add(btnProveedor);
            Name = "Form2";
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
    }
}