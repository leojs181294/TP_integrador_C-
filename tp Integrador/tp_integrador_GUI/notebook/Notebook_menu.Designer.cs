namespace tp_integrador_GUI
{
    partial class Notebook_menu
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
            btn_crear = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            check_todo = new CheckBox();
            check_marca = new CheckBox();
            check_ram = new CheckBox();
            datos_notebook = new DataGridView();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)datos_notebook).BeginInit();
            SuspendLayout();
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.LimeGreen;
            btn_crear.Location = new Point(731, 482);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(132, 43);
            btn_crear.TabIndex = 0;
            btn_crear.Text = "crear nuevo";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 41;
            label1.Text = "Buscar por:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(383, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 27);
            textBox1.TabIndex = 43;
            // 
            // check_todo
            // 
            check_todo.AutoSize = true;
            check_todo.Location = new Point(100, 14);
            check_todo.Name = "check_todo";
            check_todo.Size = new Size(65, 24);
            check_todo.TabIndex = 44;
            check_todo.Text = "Todo";
            check_todo.UseVisualStyleBackColor = true;
            // 
            // check_marca
            // 
            check_marca.AutoSize = true;
            check_marca.Location = new Point(207, 14);
            check_marca.Name = "check_marca";
            check_marca.Size = new Size(72, 24);
            check_marca.TabIndex = 45;
            check_marca.Text = "Marca";
            check_marca.UseVisualStyleBackColor = true;
            // 
            // check_ram
            // 
            check_ram.AutoSize = true;
            check_ram.Location = new Point(314, 14);
            check_ram.Name = "check_ram";
            check_ram.Size = new Size(63, 24);
            check_ram.TabIndex = 46;
            check_ram.Text = "RAM";
            check_ram.UseVisualStyleBackColor = true;
            // 
            // datos_notebook
            // 
            datos_notebook.BackgroundColor = Color.White;
            datos_notebook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datos_notebook.Location = new Point(12, 45);
            datos_notebook.Name = "datos_notebook";
            datos_notebook.RowHeadersWidth = 51;
            datos_notebook.RowTemplate.Height = 29;
            datos_notebook.Size = new Size(851, 418);
            datos_notebook.TabIndex = 47;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.Yellow;
            btn_modificar.Location = new Point(372, 482);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(132, 43);
            btn_modificar.TabIndex = 48;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.Red;
            btn_eliminar.Location = new Point(12, 482);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(132, 43);
            btn_eliminar.TabIndex = 49;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Notebook_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 554);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(datos_notebook);
            Controls.Add(check_ram);
            Controls.Add(check_marca);
            Controls.Add(check_todo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btn_crear);
            Name = "Notebook_menu";
            Text = "menu notebook";
            ((System.ComponentModel.ISupportInitialize)datos_notebook).EndInit();
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
    }
}