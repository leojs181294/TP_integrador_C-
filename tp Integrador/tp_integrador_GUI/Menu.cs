﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_integrador_GUI.proveedores;

namespace tp_integrador_GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            menu_proveedores mproveedor = new menu_proveedores();
            mproveedor.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNoteboock_Click(object sender, EventArgs e)
        {
            notebook_menu fnotebook = new notebook_menu();
            fnotebook.ShowDialog();
        }
    }
}
