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
using tp_integrador_GUI.proveedores;

namespace tp_integrador_GUI
{
    public partial class c_proveedor : Form
    {
        Proveedor _info = new Proveedor();
        public c_proveedor(Proveedor info)
        {
            InitializeComponent();
            _info = info;
            txtProv1.Text = _info.Nombre;
            txtProv2.Text = _info.Num_cel.ToString();
            txtProv3.Text = _info.nom_dist;
            txtProv4.Text = _info.direccion;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Proveedor _proveedor = new Proveedor();

            _proveedor.Nombre = txtProv1.Text;
            _proveedor.Num_cel = int.Parse(txtProv2.Text);
            _proveedor.Nom_dist = txtProv3.Text;
            _proveedor.Direccion = txtProv4.Text;
            string sql;

            if (_info.id == 0)
            {
                sql = "INSERT INTO proveedor(nombre_proveedor, cel_prov, nom_distribuidora, direccion_prov) VALUES ('" + _proveedor.Nombre + "', '" + _proveedor.Num_cel + "',  '" + _proveedor.Nom_dist + "', '" + _proveedor.Direccion + "')";
            }
            else
            {
                sql = "UPDATE proveedor SET nombre_proveedor='" + _proveedor.Nombre + "'" + ", cel_prov='" + _proveedor.Num_cel + "', nom_distribuidora='" + _proveedor.Nom_dist + "', direccion_prov='" + _proveedor.Direccion + "' WHERE id_proveedor='" + _info.Id + "'";
            }
            MySqlConnection conexionDB = Conexion.Conectar();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al guardar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
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
