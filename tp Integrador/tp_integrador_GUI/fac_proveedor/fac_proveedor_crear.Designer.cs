namespace tp_integrador_GUI
{
    partial class fac_proveedor_crear
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
            btn_cancelar = new Button();
            btn_guardar = new Button();
            txt_N_fac = new TextBox();
            label1 = new Label();
            dataGrid_fac_notebook = new DataGridView();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_fac_notebook).BeginInit();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.InactiveBorder;
            btn_cancelar.FlatStyle = FlatStyle.System;
            btn_cancelar.Location = new Point(56, 457);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(180, 29);
            btn_cancelar.TabIndex = 18;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = SystemColors.InactiveBorder;
            btn_guardar.FlatStyle = FlatStyle.System;
            btn_guardar.Location = new Point(604, 457);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(180, 29);
            btn_guardar.TabIndex = 17;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_N_fac
            // 
            txt_N_fac.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_N_fac.Location = new Point(308, 0);
            txt_N_fac.Name = "txt_N_fac";
            txt_N_fac.Size = new Size(317, 30);
            txt_N_fac.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(274, 24);
            label1.TabIndex = 54;
            label1.Text = "Ingrese Numero de Factura:";
            // 
            // dataGrid_fac_notebook
            // 
            dataGrid_fac_notebook.BackgroundColor = Color.White;
            dataGrid_fac_notebook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_fac_notebook.Location = new Point(12, 36);
            dataGrid_fac_notebook.Name = "dataGrid_fac_notebook";
            dataGrid_fac_notebook.RowHeadersWidth = 51;
            dataGrid_fac_notebook.RowTemplate.Height = 29;
            dataGrid_fac_notebook.Size = new Size(662, 359);
            dataGrid_fac_notebook.TabIndex = 56;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(128, 255, 128);
            btn_agregar.Location = new Point(716, 48);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(83, 96);
            btn_agregar.TabIndex = 57;
            btn_agregar.Text = "Agregar al carrito";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar.Location = new Point(716, 263);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(83, 96);
            btn_eliminar.TabIndex = 58;
            btn_eliminar.Text = "Eliminar del carrito";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // fac_proveedor_crear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 498);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(dataGrid_fac_notebook);
            Controls.Add(txt_N_fac);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_guardar);
            Name = "fac_proveedor_crear";
            Text = "Factura proveedor";
            ((System.ComponentModel.ISupportInitialize)dataGrid_fac_notebook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_guardar;
        private TextBox txt_N_fac;
        private Label label1;
        private DataGridView dataGrid_fac_notebook;
        private Button btn_agregar;
        private Button btn_eliminar;
    }
}