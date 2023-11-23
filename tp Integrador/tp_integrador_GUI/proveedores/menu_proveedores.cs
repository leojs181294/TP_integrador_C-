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

namespace tp_integrador_GUI.proveedores
{
    public partial class menu_proveedores : Form
    {
        public menu_proveedores()
        {
            InitializeComponent();
            CargarData(null);
        }

        public static DataGridViewRow selectedrow;
        class CtrProveedores
        {
            public List<object> consulta(string dato)
            {
                MySqlDataReader lector = null;
                List<object> listaconsulta = new List<object>();
                string sql;

                if (dato == null)
                {
                    sql = "SELECT id_proveedor, nombre_proveedor, cel_prov, nom_distribuidora, direccion_prov FROM proveedor ORDER BY nombre_proveedor ASC";
                }
                else
                {
                    sql = "SELECT id_proveedor, nombre_proveedor, cel_prov, nom_distribuidora, direccion_prov FROM proveedor WHERE nombre_proveedor LIKE '%" + dato + "%' OR nom_distribuidora LIKE '%" + dato + "%' ORDER BY nombre_proveedor ASC";
                }
                try
                {

                    MySqlConnection conexionDB = Conexion.Conectar();
                    conexionDB.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        //distintas formas de traer el dato, elijan la que les guste, o el indice o el nombre de la tabla...
                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = int.Parse(lector.GetString(0));
                        _proveedor.Nombre = lector.GetString(1);
                        _proveedor.Num_cel = int.Parse(lector.GetString(2));
                        _proveedor.Nom_dist = lector.GetString(3);
                        _proveedor.Direccion = lector.GetString("direccion_prov");
                        listaconsulta.Add(_proveedor);
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return listaconsulta;
            }

        }
        private void CargarData(string dato)
        {
            List<Proveedor> lista = new List<Proveedor>();
            CtrProveedores _CtrProveedores = new CtrProveedores();
            dataGridProv.DataSource = _CtrProveedores.consulta(dato);
        }
        public void EliminarData(int id)
        {

            string sql = "DELETE FROM proveedor WHERE id_proveedor= '"+id +"'";
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
        private void dataGridProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1prov_Click(object sender, EventArgs e)
        {
            c_proveedor c_prov = new c_proveedor();
            c_prov.ShowDialog();
            CargarData(null);
        }
        public void button2prov_Click(object sender, EventArgs e)
        {

            /*Proveedor _pasedatos = new Proveedor();
            _pasedatos.Id = int.Parse(dataGridProv.CurrentRow.Cells[0].Value.ToString());
            _pasedatos.Nombre = dataGridProv.CurrentRow.Cells[1].Value.ToString(); 
            _pasedatos.Num_cel = int.Parse(dataGridProv.CurrentRow.Cells[2].Value.ToString());
            _pasedatos.Nom_dist = dataGridProv.CurrentRow.Cells[3].Value.ToString();
            _pasedatos.Direccion = dataGridProv.CurrentRow.Cells[4].Value.ToString();*/
            Proveedor_modificar _pasedatos = new Proveedor_modificar();
            _pasedatos.Id = int.Parse(dataGridProv.CurrentRow.Cells[0].Value.ToString());
            _pasedatos.Nombre = dataGridProv.CurrentRow.Cells[1].Value.ToString();
            _pasedatos.Num_cel = int.Parse(dataGridProv.CurrentRow.Cells[2].Value.ToString());
            _pasedatos.nom_dist = dataGridProv.CurrentRow.Cells[3].Value.ToString();
            _pasedatos.direccion = dataGridProv.CurrentRow.Cells[4].Value.ToString();
            u_proveedor u_prov = new u_proveedor(_pasedatos);
            u_prov.ShowDialog();
            CargarData(null);
        }

        private void button3prov_Click(object sender, EventArgs e)
        {
            //Este boton es para eliminar brotherrr
            DialogResult confirmacion = MessageBox.Show("Seguro que quiere eliminar este registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if(confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(dataGridProv.CurrentRow.Cells[0].Value.ToString());
                menu_proveedores _menu_prov = new menu_proveedores();
                _menu_prov.EliminarData(id);
                CargarData(null);
            }
        }
    }
}
