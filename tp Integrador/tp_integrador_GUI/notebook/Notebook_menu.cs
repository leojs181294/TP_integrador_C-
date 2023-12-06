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
using tp_integrador_GUI.conexion;
using tp_integrador_GUI.notebook;

using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace tp_integrador_GUI
{
    public partial class notebook_menu : Form
    {
        List<Notebook> notebooks = new List<Notebook>();
        public notebook_menu()
        {
            InitializeComponent();
            CargarData();
        }

        class CtrNotebook
        {
            public List<object> consulta(TextBox data, ComboBox opc_buscar)
            {
                MySqlDataReader lector = null;
                List<object> listaconsulta = new List<object>();
                string opc = opc_buscar.Text;
                string sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook ORDER BY id_notebook ASC";

                switch (opc)
                {
                    case "Todo":
                        {
                            sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook ORDER BY id_notebook ASC";
                            break;
                        }
                    case "Marca":
                        {
                            string dato = data.Text;
                            sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook WHERE marca LIKE '%" + dato + "%' ORDER BY marca ASC";
                            break;

                        }
                    case "Ram":
                        {
                            int dato = int.Parse(data.Text);
                            sql = "SELECT id_notebook, marca, modelo, sis_operativo, procesador, nucleos, veloc_cpu, memoria_ram, hdd, ssd, mem_video, puertos_usb, red_rj45, precio_unitario, stock, stock_valorizado FROM notebook WHERE memoria_ram LIKE '%" + dato + "%' ORDER BY memoria_ram ASC";
                            break;
                        }
                    default:
                        {
                            break;
                        }
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
        private void CargarData()
        {
            List<Notebook> lista = new List<Notebook>();
            CtrNotebook _CtrNotebook = new CtrNotebook();
            dataGrid_notebook.DataSource = _CtrNotebook.consulta(txt_buscar_dato, opc_buscar);
        }
        public void EliminarData(int id)
        {
            string sql = "DELETE FROM not_vacia WHERE id_notebook= '" + id + "'";
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

            Notebook not_vacia = new Notebook();
            not_vacia.Id_notebook = 0;
            not_vacia.Marca = "";
            not_vacia.Modelo = "";
            not_vacia.Sis_operativo = "";
            not_vacia.Procesador = "";
            not_vacia.Nucleos = 0;
            not_vacia.Velocidad_procesadora =0;
            not_vacia.Memoria_ram =0;
            not_vacia.Hdd = 0;
            not_vacia.Ssd = 0;
            not_vacia.Memoria_video = 0;
            not_vacia.Puertos_usb = 0;
            not_vacia.Red_rj45 = 0;
            not_vacia.Precio_unitario = 0;
            not_vacia.Stock = 0;
            not_vacia.Stock_valorizado = 0;
            Notebook_crear fnotebook = new Notebook_crear(not_vacia);
            fnotebook.ShowDialog();
            CargarData();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CargarData();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Este boton es para eliminar brotherrr
            DialogResult confirmacion = MessageBox.Show("Seguro que quiere eliminar este registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(dataGrid_notebook.CurrentRow.Cells[0].Value.ToString());
                notebook_menu _menu_not = new notebook_menu();
                _menu_not.EliminarData(id);
                CargarData();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Notebook notdatos = new Notebook();
            notdatos.Id_notebook = int.Parse(dataGrid_notebook.CurrentRow.Cells[0].Value.ToString());
            notdatos.Marca = dataGrid_notebook.CurrentRow.Cells[1].Value.ToString();
            notdatos.Modelo = dataGrid_notebook.CurrentRow.Cells[2].Value.ToString();
            notdatos.Sis_operativo = dataGrid_notebook.CurrentRow.Cells[3].Value.ToString();
            notdatos.Procesador = dataGrid_notebook.CurrentRow.Cells[4].Value.ToString();
            notdatos.Nucleos = int.Parse(dataGrid_notebook.CurrentRow.Cells[5].Value.ToString());
            notdatos.Velocidad_procesadora = float.Parse(dataGrid_notebook.CurrentRow.Cells[6].Value.ToString());
            notdatos.Memoria_ram = int.Parse(dataGrid_notebook.CurrentRow.Cells[7].Value.ToString());
            notdatos.Hdd = int.Parse(dataGrid_notebook.CurrentRow.Cells[8].Value.ToString());
            notdatos.Ssd = int.Parse(dataGrid_notebook.CurrentRow.Cells[9].Value.ToString());
            notdatos.Memoria_video = int.Parse(dataGrid_notebook.CurrentRow.Cells[10].Value.ToString());
            notdatos.Puertos_usb = int.Parse(dataGrid_notebook.CurrentRow.Cells[11].Value.ToString());
            notdatos.Red_rj45 = int.Parse(dataGrid_notebook.CurrentRow.Cells[12].Value.ToString());
            notdatos.Precio_unitario = long.Parse(dataGrid_notebook.CurrentRow.Cells[13].Value.ToString());
            notdatos.Stock = int.Parse(dataGrid_notebook.CurrentRow.Cells[14].Value.ToString());
            Notebook_crear u_not = new Notebook_crear(notdatos);
            u_not.ShowDialog();
            CargarData();
        }

        private void notebook_menu_Load(object sender, EventArgs e)
        {

        }
    }
}