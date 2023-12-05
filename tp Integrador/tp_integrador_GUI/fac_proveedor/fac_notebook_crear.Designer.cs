namespace tp_integrador_GUI
{
    partial class fac_notebook_crear
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
            label1 = new Label();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            txt_id_notebook = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_precio_unitario = new TextBox();
            txt_cantidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 42);
            label1.Name = "label1";
            label1.Size = new Size(137, 24);
            label1.TabIndex = 0;
            label1.Text = "Id Notebook :";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = SystemColors.InactiveBorder;
            btn_guardar.FlatStyle = FlatStyle.System;
            btn_guardar.Location = new Point(608, 409);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(180, 29);
            btn_guardar.TabIndex = 52;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.InactiveBorder;
            btn_cancelar.FlatStyle = FlatStyle.System;
            btn_cancelar.Location = new Point(12, 409);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(180, 29);
            btn_cancelar.TabIndex = 51;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_id_notebook
            // 
            txt_id_notebook.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id_notebook.Location = new Point(338, 39);
            txt_id_notebook.Name = "txt_id_notebook";
            txt_id_notebook.Size = new Size(190, 30);
            txt_id_notebook.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 144);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 56;
            label2.Text = "Cantidad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 261);
            label3.Name = "label3";
            label3.Size = new Size(187, 24);
            label3.TabIndex = 57;
            label3.Text = "Precio por Unidad:";
            // 
            // txt_precio_unitario
            // 
            txt_precio_unitario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precio_unitario.Location = new Point(338, 258);
            txt_precio_unitario.Name = "txt_precio_unitario";
            txt_precio_unitario.Size = new Size(190, 30);
            txt_precio_unitario.TabIndex = 58;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cantidad.Location = new Point(338, 138);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(190, 30);
            txt_cantidad.TabIndex = 59;
            // 
            // fac_notebook_crear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_cantidad);
            Controls.Add(txt_precio_unitario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_id_notebook);
            Controls.Add(btn_guardar);
            Controls.Add(btn_cancelar);
            Controls.Add(label1);
            Name = "fac_notebook_crear";
            Text = "factura notebook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_guardar;
        private Button btn_cancelar;
        private TextBox txt_id_notebook;
        private Label label2;
        private Label label3;
        private TextBox txt_precio_unitario;
        private TextBox txt_cantidad;
    }
}