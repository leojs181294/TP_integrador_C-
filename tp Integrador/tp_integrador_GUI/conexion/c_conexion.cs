using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_integrador_GUI.conexion;
using tp_integrador_GUI.proveedores;

namespace tp_integrador_GUI
{
    public partial class c_conexion : Form
    {
        public c_conexion()
        {
            InitializeComponent();

            using (StreamWriter w = File.AppendText("conexion.config")) ;
            string camino = "./conexion.config";
            string[] file = File.ReadAllLines(camino);
            txtConx1.Text = file[0];
            txtConx2.Text = file[2];
            txtConx3.Text = file[3];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            string[] file = { };

            file[0] = txtConx1.Text;
            file[1] = txtConx2.Text;
            file[2] = txtConx3.Text;



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtProv1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProv2_TextChanged(object sender, EventArgs e)
        {

        }

        private void datos_proveedor_Enter(object sender, EventArgs e)
        {

        }
    }
}
