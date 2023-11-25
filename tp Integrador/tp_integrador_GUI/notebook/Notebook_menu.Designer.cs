namespace tp_integrador_GUI
{
    partial class notebook_menu
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
            components = new System.ComponentModel.Container();
            btn_crear = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            datos_notebook = new DataGridView();
            proveedorBindingSource = new BindingSource(components);
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btnBuscar = new Button();
            opc_buscar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)datos_notebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.LimeGreen;
            btn_crear.Location = new Point(731, 483);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(133, 43);
            btn_crear.TabIndex = 0;
            btn_crear.Text = "crear nuevo";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 41;
            label1.Text = "Buscar por:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 27);
            textBox1.TabIndex = 43;
            // 
            // datos_notebook
            // 
            datos_notebook.BackgroundColor = Color.White;
            datos_notebook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datos_notebook.Location = new Point(11, 45);
            datos_notebook.Name = "datos_notebook";
            datos_notebook.RowHeadersWidth = 51;
            datos_notebook.RowTemplate.Height = 29;
            datos_notebook.Size = new Size(851, 419);
            datos_notebook.TabIndex = 47;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Yellow;
            btn_modificar.Location = new Point(373, 483);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(133, 43);
            btn_modificar.TabIndex = 48;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Location = new Point(11, 483);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(133, 43);
            btn_eliminar.TabIndex = 49;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(695, 12);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 50;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btn_buscar_Click;
            // 
            // opc_buscar
            // 
            opc_buscar.FormattingEnabled = true;
            opc_buscar.Items.AddRange(new object[] { "Marca", "Ram" });
            opc_buscar.Location = new Point(109, 11);
            opc_buscar.Name = "opc_buscar";
            opc_buscar.Size = new Size(211, 28);
            opc_buscar.TabIndex = 51;
            // 
            // notebook_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 555);
            Controls.Add(opc_buscar);
            Controls.Add(btnBuscar);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(datos_notebook);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_crear);
            Name = "notebook_menu";
            Text = "menu notebook";
            ((System.ComponentModel.ISupportInitialize)datos_notebook).EndInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_crear;
        private Label label1;
        private TextBox textBox1;
        private DataGridView datos_notebook;
        private Button btn_modificar;
        private Button btn_eliminar;
        private BindingSource proveedorBindingSource;
        private Button btnBuscar;
        private ComboBox opc_buscar;
    }
}