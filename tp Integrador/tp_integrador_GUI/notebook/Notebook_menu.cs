using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_integrador_GUI;
using tp_integrador_GUI.notebook;
using tp_integrador_GUI.proveedores;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace tp_integrador_GUI
{
    public partial class notebook_menu : Form
    {
        List<Notebook> notebooks = new List<Notebook>();
        public notebook_menu()
        {
            InitializeComponent();
            CargarData(null);
        }

        class CtrNotebook
        {
            public List<object> consulta(string dato)
            {
                MySqlDataReader lector = null;
                List<object> listaconsulta = new List<object>();
                string sql;
                if (dato == null)
                {
                    sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook ORDER BY marca ASC";
                }
                else
                {
                    sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook WHERE marca LIKE '%" + dato + "%' OR marca LIKE '%" + dato + "%' ORDER BY id_notebook DESC";
                }
                try
                {

                    MySqlConnection conexionDB = Conexion.Conectar();
                    conexionDB.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Notebook notebook = new Notebook();
                        notebook.Id_notebook = int.Parse(lector.GetString(0));
                        notebook.Marca = lector.GetString(1);
                        notebook.Modelo = lector.GetString(2);
                        notebook.Sis_operativo = lector.GetString(3);
                        notebook.Procesador = lector.GetString(4);
                        notebook.Nucleos = int.Parse(lector.GetString(5));
                        notebook.Velocidad_procesadora = float.Parse(lector.GetString(6));
                        notebook.Memoria_ram = int.Parse(lector.GetString(7));
                        notebook.Hdd = int.Parse(lector.GetString(8));
                        notebook.Ssd = int.Parse(lector.GetString(9));
                        notebook.Memoria_video = int.Parse(lector.GetString(10));
                        notebook.Puertos_usb = int.Parse(lector.GetString(11));
                        notebook.Red_rj45 = int.Parse(lector.GetString(12));
                        notebook.Precio_unitario = int.Parse(lector.GetString(13));
                        notebook.Stock = int.Parse(lector.GetString(14));
                        notebook.Stock_valorizado = int.Parse(lector.GetString(15));
                        
                        listaconsulta.Add(notebook);
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
            List<Notebook> lista = new List<Notebook>();
            CtrNotebook _CtrNotebook = new CtrNotebook();
            datos_notebook.DataSource = _CtrNotebook.consulta(dato);
        }
        public void EliminarData(int id)
        {

            string sql = "DELETE FROM notebook WHERE id_notebook= '" + id + "'";
            MySqlConnection conexionDB = Conexion.Conectar();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Notebook_crear fnotebook = new Notebook_crear();
            fnotebook.ShowDialog();
            CargarData(null);
        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Este boton es para eliminar brotherrr
            DialogResult confirmacion = MessageBox.Show("Seguro que quiere eliminar este registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(datos_notebook.CurrentRow.Cells[0].Value.ToString());
                menu_proveedores _menu_prov = new menu_proveedores();
                _menu_prov.EliminarData(id);
                CargarData(null);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
