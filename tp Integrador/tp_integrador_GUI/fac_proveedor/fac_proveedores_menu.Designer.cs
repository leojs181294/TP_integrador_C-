namespace tp_integrador_GUI
{
    partial class fac_proveedores_menu
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
            opc_buscar = new ComboBox();
            btnBuscar = new Button();
            dataGrid_fac_proveedor = new DataGridView();
            txt_buscar_dato = new TextBox();
            label1 = new Label();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_crear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_fac_proveedor).BeginInit();
            SuspendLayout();
            // 
            // opc_buscar
            // 
            opc_buscar.FormattingEnabled = true;
            opc_buscar.Items.AddRange(new object[] { "id proveedor", "Fecha", "numero factura" });
            opc_buscar.Location = new Point(110, 10);
            opc_buscar.Name = "opc_buscar";
            opc_buscar.Size = new Size(211, 28);
            opc_buscar.TabIndex = 56;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(696, 11);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 55;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGrid_fac_proveedor
            // 
            dataGrid_fac_proveedor.BackgroundColor = Color.White;
            dataGrid_fac_proveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_fac_proveedor.Location = new Point(12, 44);
            dataGrid_fac_proveedor.Name = "dataGrid_fac_proveedor";
            dataGrid_fac_proveedor.RowHeadersWidth = 51;
            dataGrid_fac_proveedor.RowTemplate.Height = 29;
            dataGrid_fac_proveedor.Size = new Size(851, 419);
            dataGrid_fac_proveedor.TabIndex = 54;
            // 
            // txt_buscar_dato
            // 
            txt_buscar_dato.Location = new Point(337, 10);
            txt_buscar_dato.Name = "txt_buscar_dato";
            txt_buscar_dato.Size = new Size(304, 27);
            txt_buscar_dato.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 52;
            label1.Text = "Buscar por:";
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Location = new Point(12, 484);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(133, 43);
            btn_eliminar.TabIndex = 59;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Yellow;
            btn_modificar.Location = new Point(374, 484);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(133, 43);
            btn_modificar.TabIndex = 58;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.LimeGreen;
            btn_crear.Location = new Point(732, 484);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(133, 43);
            btn_crear.TabIndex = 57;
            btn_crear.Text = "crear nuevo";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // fac_proveedores_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 546);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_crear);
            Controls.Add(opc_buscar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGrid_fac_proveedor);
            Controls.Add(txt_buscar_dato);
            Controls.Add(label1);
            Name = "fac_proveedores_menu";
            Text = "Menu Facturas Proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGrid_fac_proveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox opc_buscar;
        private Button btnBuscar;
        private DataGridView dataGrid_fac_proveedor;
        private TextBox txt_buscar_dato;
        private Label label1;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_crear;
    }
}