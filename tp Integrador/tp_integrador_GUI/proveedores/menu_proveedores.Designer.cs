namespace tp_integrador_GUI.proveedores
{
    partial class menu_proveedores
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
            dataGridProv = new DataGridView();
            button1prov = new Button();
            button2prov = new Button();
            button3prov = new Button();
            button4prov = new Button();
            textBox1prov = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridProv).BeginInit();
            SuspendLayout();
            // 
            // dataGridProv
            // 
            dataGridProv.BackgroundColor = Color.White;
            dataGridProv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProv.Location = new Point(14, 101);
            dataGridProv.Margin = new Padding(3, 4, 3, 4);
            dataGridProv.Name = "dataGridProv";
            dataGridProv.RowHeadersWidth = 51;
            dataGridProv.RowTemplate.Height = 25;
            dataGridProv.Size = new Size(887, 439);
            dataGridProv.TabIndex = 0;
            dataGridProv.CellContentClick += dataGridProv_CellContentClick;
            // 
            // button1prov
            // 
            button1prov.Location = new Point(49, 548);
            button1prov.Margin = new Padding(3, 4, 3, 4);
            button1prov.Name = "button1prov";
            button1prov.Size = new Size(149, 41);
            button1prov.TabIndex = 1;
            button1prov.Text = "Crear";
            button1prov.UseVisualStyleBackColor = true;
            button1prov.Click += button1prov_Click;
            // 
            // button2prov
            // 
            button2prov.Location = new Point(384, 548);
            button2prov.Margin = new Padding(3, 4, 3, 4);
            button2prov.Name = "button2prov";
            button2prov.Size = new Size(149, 41);
            button2prov.TabIndex = 2;
            button2prov.Text = "Modificar";
            button2prov.UseVisualStyleBackColor = true;
            button2prov.Click += button2prov_Click;
            // 
            // button3prov
            // 
            button3prov.Location = new Point(717, 548);
            button3prov.Margin = new Padding(3, 4, 3, 4);
            button3prov.Name = "button3prov";
            button3prov.Size = new Size(149, 41);
            button3prov.TabIndex = 3;
            button3prov.Text = "Eliminar";
            button3prov.UseVisualStyleBackColor = true;
            button3prov.Click += button3prov_Click;
            // 
            // button4prov
            // 
            button4prov.Location = new Point(688, 29);
            button4prov.Margin = new Padding(3, 4, 3, 4);
            button4prov.Name = "button4prov";
            button4prov.Size = new Size(86, 31);
            button4prov.TabIndex = 5;
            button4prov.Text = "Buscar";
            button4prov.UseVisualStyleBackColor = true;
            // 
            // textBox1prov
            // 
            textBox1prov.Location = new Point(539, 29);
            textBox1prov.Margin = new Padding(3, 4, 3, 4);
            textBox1prov.Name = "textBox1prov";
            textBox1prov.Size = new Size(141, 27);
            textBox1prov.TabIndex = 6;
            // 
            // menu_proveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1prov);
            Controls.Add(button4prov);
            Controls.Add(button3prov);
            Controls.Add(button2prov);
            Controls.Add(button1prov);
            Controls.Add(dataGridProv);
            Margin = new Padding(3, 4, 3, 4);
            Name = "menu_proveedores";
            Text = "Menu de proveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProv;
        private Button button1prov;
        private Button button2prov;
        private Button button3prov;
        private Button button4prov;
        private TextBox textBox1prov;
    }
}