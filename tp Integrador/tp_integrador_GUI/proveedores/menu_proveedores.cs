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
        class CtrProveedores : Conexion
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
        private void dataGridProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
