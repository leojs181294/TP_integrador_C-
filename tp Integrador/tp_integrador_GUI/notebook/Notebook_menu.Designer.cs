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
            check_todo = new CheckBox();
            check_marca = new CheckBox();
            check_ram = new CheckBox();
            datos_notebook = new DataGridView();
            proveedorBindingSource = new BindingSource(components);
            btn_modificar = new Button();
            btn_eliminar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)datos_notebook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proveedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.LimeGreen;
            btn_crear.Location = new Point(640, 362);
            btn_crear.Margin = new Padding(3, 2, 3, 2);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(116, 32);
            btn_crear.TabIndex = 0;
            btn_crear.Text = "crear nuevo";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 41;
            label1.Text = "Buscar por:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(335, 8);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 43;
            // 
            // check_todo
            // 
            check_todo.AutoSize = true;
            check_todo.Location = new Point(88, 10);
            check_todo.Margin = new Padding(3, 2, 3, 2);
            check_todo.Name = "check_todo";
            check_todo.Size = new Size(52, 19);
            check_todo.TabIndex = 44;
            check_todo.Text = "Todo";
            check_todo.UseVisualStyleBackColor = true;
            // 
            // check_marca
            // 
            check_marca.AutoSize = true;
            check_marca.Location = new Point(181, 10);
            check_marca.Margin = new Padding(3, 2, 3, 2);
            check_marca.Name = "check_marca";
            check_marca.Size = new Size(59, 19);
            check_marca.TabIndex = 45;
            check_marca.Text = "Marca";
            check_marca.UseVisualStyleBackColor = true;
            // 
            // check_ram
            // 
            check_ram.AutoSize = true;
            check_ram.Location = new Point(275, 10);
            check_ram.Margin = new Padding(3, 2, 3, 2);
            check_ram.Name = "check_ram";
            check_ram.Size = new Size(52, 19);
            check_ram.TabIndex = 46;
            check_ram.Text = "RAM";
            check_ram.UseVisualStyleBackColor = true;
            // 
            // datos_notebook
            // 
            datos_notebook.AutoGenerateColumns = false;
            datos_notebook.BackgroundColor = Color.White;
            datos_notebook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datos_notebook.DataSource = proveedorBindingSource;
            datos_notebook.Location = new Point(10, 34);
            datos_notebook.Margin = new Padding(3, 2, 3, 2);
            datos_notebook.Name = "datos_notebook";
            datos_notebook.RowHeadersWidth = 51;
            datos_notebook.RowTemplate.Height = 29;
            datos_notebook.Size = new Size(745, 314);
            datos_notebook.TabIndex = 47;
            // 
            // proveedorBindingSource
            // 
            //proveedorBindingSource.DataSource = typeof(proveedor);
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Yellow;
            btn_modificar.Location = new Point(326, 362);
            btn_modificar.Margin = new Padding(3, 2, 3, 2);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(116, 32);
            btn_modificar.TabIndex = 48;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Location = new Point(10, 362);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(116, 32);
            btn_eliminar.TabIndex = 49;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(608, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 50;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Notebook_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 416);
            Controls.Add(button1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(datos_notebook);
            Controls.Add(check_ram);
            Controls.Add(check_marca);
            Controls.Add(check_todo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_crear);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Notebook_menu";
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
        private CheckBox check_todo;
        private CheckBox check_marca;
        private CheckBox check_ram;
        private DataGridView datos_notebook;
        private Button btn_modificar;
        private Button btn_eliminar;
        private BindingSource proveedorBindingSource;
        private Button button1;
    }
}