namespace tp_integrador_GUI
{
    partial class Notebook_crear
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
            groupBox1 = new GroupBox();
            btn_cancelar = new Button();
            txt_precio = new TextBox();
            txt_stock = new TextBox();
            txt_vel_cpu = new TextBox();
            txt_red_rj45 = new ComboBox();
            txt_sist_op = new ComboBox();
            txt_ram = new NumericUpDown();
            txt_ssd = new NumericUpDown();
            txt_mem_video = new NumericUpDown();
            txt_hdd = new NumericUpDown();
            txt_nucleos = new NumericUpDown();
            txt_usb = new NumericUpDown();
            txt_procesador = new TextBox();
            txt_modelo = new TextBox();
            txt_marca = new TextBox();
            btn_guardar = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_ram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_ssd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_mem_video).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_hdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_nucleos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_usb).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_cancelar);
            groupBox1.Controls.Add(txt_precio);
            groupBox1.Controls.Add(txt_stock);
            groupBox1.Controls.Add(txt_vel_cpu);
            groupBox1.Controls.Add(txt_red_rj45);
            groupBox1.Controls.Add(txt_sist_op);
            groupBox1.Controls.Add(txt_ram);
            groupBox1.Controls.Add(txt_ssd);
            groupBox1.Controls.Add(txt_mem_video);
            groupBox1.Controls.Add(txt_hdd);
            groupBox1.Controls.Add(txt_nucleos);
            groupBox1.Controls.Add(txt_usb);
            groupBox1.Controls.Add(txt_procesador);
            groupBox1.Controls.Add(txt_modelo);
            groupBox1.Controls.Add(txt_marca);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 417);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Notebook";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.InactiveBorder;
            btn_cancelar.FlatStyle = FlatStyle.System;
            btn_cancelar.Location = new Point(30, 368);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(180, 29);
            btn_cancelar.TabIndex = 16;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(547, 278);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(211, 27);
            txt_precio.TabIndex = 14;
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(547, 237);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(211, 27);
            txt_stock.TabIndex = 12;
            // 
            // txt_vel_cpu
            // 
            txt_vel_cpu.Location = new Point(164, 184);
            txt_vel_cpu.Name = "txt_vel_cpu";
            txt_vel_cpu.Size = new Size(211, 27);
            txt_vel_cpu.TabIndex = 9;
            // 
            // txt_red_rj45
            // 
            txt_red_rj45.FormattingEnabled = true;
            txt_red_rj45.Items.AddRange(new object[] { "Si", "No" });
            txt_red_rj45.Location = new Point(164, 95);
            txt_red_rj45.Name = "txt_red_rj45";
            txt_red_rj45.Size = new Size(211, 28);
            txt_red_rj45.TabIndex = 5;
            // 
            // txt_sist_op
            // 
            txt_sist_op.FormattingEnabled = true;
            txt_sist_op.Items.AddRange(new object[] { "Windows", "Linux", "MacOS" });
            txt_sist_op.Location = new Point(164, 51);
            txt_sist_op.Name = "txt_sist_op";
            txt_sist_op.Size = new Size(211, 28);
            txt_sist_op.TabIndex = 3;

            // 
            // txt_ram
            // 
            txt_ram.Location = new Point(547, 96);
            txt_ram.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            txt_ram.Name = "txt_ram";
            txt_ram.Size = new Size(211, 27);
            txt_ram.TabIndex = 6;
            txt_ram.ThousandsSeparator = true;
            // 
            // txt_ssd
            // 
            txt_ssd.Location = new Point(547, 138);
            txt_ssd.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txt_ssd.Name = "txt_ssd";
            txt_ssd.Size = new Size(211, 27);
            txt_ssd.TabIndex = 8;
            // 
            // txt_mem_video
            // 
            txt_mem_video.Location = new Point(164, 237);
            txt_mem_video.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            txt_mem_video.Name = "txt_mem_video";
            txt_mem_video.Size = new Size(211, 27);
            txt_mem_video.TabIndex = 11;
            // 
            // txt_hdd
            // 
            txt_hdd.Location = new Point(547, 184);
            txt_hdd.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txt_hdd.Name = "txt_hdd";
            txt_hdd.Size = new Size(211, 27);
            txt_hdd.TabIndex = 10;
            // 
            // txt_nucleos
            // 
            txt_nucleos.Location = new Point(164, 138);
            txt_nucleos.Name = "txt_nucleos";
            txt_nucleos.Size = new Size(211, 27);
            txt_nucleos.TabIndex = 7;
            // 
            // txt_usb
            // 
            txt_usb.Location = new Point(164, 278);
            txt_usb.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txt_usb.Name = "txt_usb";
            txt_usb.Size = new Size(211, 27);
            txt_usb.TabIndex = 13;
            // 
            // txt_procesador
            // 
            txt_procesador.Location = new Point(547, 51);
            txt_procesador.Name = "txt_procesador";
            txt_procesador.Size = new Size(211, 27);
            txt_procesador.TabIndex = 4;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(547, 16);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(211, 27);
            txt_modelo.TabIndex = 2;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(164, 16);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(211, 27);
            txt_marca.TabIndex = 1;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = SystemColors.InactiveBorder;
            btn_guardar.FlatStyle = FlatStyle.System;
            btn_guardar.Location = new Point(578, 368);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(180, 29);
            btn_guardar.TabIndex = 15;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(418, 285);
            label14.Name = "label14";
            label14.Size = new Size(105, 20);
            label14.TabIndex = 13;
            label14.Text = "Precio Unidad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(418, 239);
            label13.Name = "label13";
            label13.Size = new Size(48, 20);
            label13.TabIndex = 12;
            label13.Text = "Stock:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(418, 190);
            label12.Name = "label12";
            label12.Size = new Size(45, 20);
            label12.TabIndex = 11;
            label12.Text = "HDD:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(418, 145);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 10;
            label11.Text = "SSD:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 104);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 9;
            label10.Text = "Entrada red RJ45:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 285);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 8;
            label9.Text = "Puertos USB";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 239);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 7;
            label8.Text = "Memoria Video:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 103);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 6;
            label7.Text = "Ram:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 191);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 5;
            label6.Text = "Velocidad CPU:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Nucleos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 58);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Procesador:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 58);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Sistema Operativo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // Notebook_crear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Notebook_crear";
            Text = "notebook";
            Load += Notebook_crear_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_ram).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_ssd).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_mem_video).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_hdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_nucleos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_usb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btn_guardar;
        private TextBox txt_marca;
        private TextBox txt_procesador;
        private TextBox txt_modelo;
        private NumericUpDown txt_usb;
        private NumericUpDown txt_hdd;
        private NumericUpDown txt_nucleos;
        private NumericUpDown txt_ram;
        private NumericUpDown txt_ssd;
        private NumericUpDown txt_mem_video;
        private ComboBox txt_red_rj45;
        private ComboBox txt_sist_op;
        private TextBox txt_vel_cpu;
        private TextBox txt_precio;
        private TextBox txt_stock;
        private Button btn_cancelar;
    }
}