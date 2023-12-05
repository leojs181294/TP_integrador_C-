using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using tp_integrador_GUI.conexion;
using tp_integrador_GUI.notebook;

namespace tp_integrador_GUI
{
    public partial class Notebook_crear : Form
    {
        Notebook notebook = new Notebook();
        public Notebook_crear(Notebook notdatos)
        {
            InitializeComponent();

            notebook = notdatos;
            txt_marca.Text = notebook.Marca;
            txt_modelo.Text = notebook.Modelo;
            txt_sist_op.Text = notebook.Sis_operativo;
            txt_procesador.Text = notebook.Procesador;
            txt_nucleos.Text = notebook.Nucleos.ToString();
            txt_vel_cpu.Text = notebook.Velocidad_procesadora.ToString();
            txt_ram.Text = notebook.Memoria_ram.ToString();
            txt_hdd.Text = notebook.Hdd.ToString();
            txt_ssd.Text = notebook.Ssd.ToString();
            txt_mem_video.Text = notebook.Memoria_video.ToString();
            txt_usb.Text = notebook.Puertos_usb.ToString();
            if (notebook.Red_rj45 == 1)
            {
                txt_red_rj45.Text = "Si";
            }
            else
            {
                txt_red_rj45.Text = "No";
            }
            txt_precio.Text = notebook.Precio_unitario.ToString();
            txt_stock.Text = notebook.Stock.ToString();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Decea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            notebook.Marca = txt_marca.Text;
            notebook.Modelo = txt_modelo.Text;
            notebook.Sis_operativo = txt_sist_op.Text;
            notebook.Procesador = txt_procesador.Text;
            notebook.Nucleos = int.Parse(txt_nucleos.Text);
            notebook.Velocidad_procesadora = float.Parse(txt_vel_cpu.Text);
            notebook.Memoria_ram = int.Parse(txt_ram.Text);
            notebook.Hdd = int.Parse(txt_hdd.Text);
            notebook.Ssd = int.Parse(txt_ssd.Text);
            notebook.Memoria_video = int.Parse(txt_mem_video.Text);
            notebook.Puertos_usb = int.Parse(txt_usb.Text);
            if (txt_red_rj45.Text == "Si")
            {
                notebook.Red_rj45 = 1;
            }
            else
            {
                notebook.Red_rj45 = 0;
            }
            notebook.Precio_unitario = int.Parse(txt_precio.Text);
            notebook.Stock = int.Parse(txt_stock.Text);
            notebook.Stock_valorizado = notebook.Stock * notebook.Precio_unitario;
           

            string sql = "INSERT INTO notebook(marca,modelo,precio_unitario,stock_valorizado,stock,procesador,veloc_cpu,nucleos,mem_video,sis_operativo,hdd,ssd,puertos_usb,red_rj45,memoria_ram)" + " VALUES ('" + notebook.Marca + "','" + notebook.Modelo + "','" + notebook.Precio_unitario + "','" + notebook.Stock_valorizado + "','" + notebook.Stock + "','" + notebook.Procesador + "','" + notebook.Velocidad_procesadora + "','" + notebook.Nucleos + "','" + notebook.Memoria_video + "','" + notebook.Sis_operativo + "','" + notebook.Hdd + "','" + notebook.Ssd + "','" + notebook.Puertos_usb + "','" + notebook.Red_rj45 + "','" + notebook.Memoria_ram + "')";
            MySqlConnection conexionDB = Conexion.Conectar();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                Close();
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

        private void Notebook_crear_Load(object sender, EventArgs e)
        {

        }

        private void txt_sist_op_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
