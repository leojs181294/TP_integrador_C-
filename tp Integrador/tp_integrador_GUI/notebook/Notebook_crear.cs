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
using tp_integrador_GUI.notebook;

namespace tp_integrador_GUI
{
    public partial class Notebook_crear : Form
    {
        public Notebook_crear()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            string marca = txt_marca.Text;
            string modelo = txt_modelo.Text;
            string sist_operativo = txt_sist_op.Text;
            string procesador = txt_procesador.Text;
            int nucleos = int.Parse(txt_nucleos.Text);
            float velocidad_procesadora = float.Parse(txt_vel_cpu.Text);
            int memoria_ram = int.Parse(txt_ram.Text);
            int hdd = int.Parse(txt_hdd.Text);
            int ssd = int.Parse(txt_ssd.Text);
            int memoria_video = int.Parse(txt_mem_video.Text);
            int puertos_usb = int.Parse(txt_usb.Text);
            int red_rj45;
            if (txt_red_rj45.Text == "Si")
            {
                red_rj45 = 1;
            }
            else
            {
                red_rj45 = 0;
            }
            long precio_unitario = int.Parse(txt_precio.Text);
            int stock = int.Parse(txt_stock.Text);
            long stock_valorizado = stock * precio_unitario;

            notebook.SetMarca(marca);
            notebook.SetModelo(modelo);
            notebook.Setsist_operativo(sist_operativo);
            notebook.SetProcesador(procesador);
            notebook.SetNucleos(nucleos);
            notebook.Setvelocidad_procesadora(velocidad_procesadora);
            notebook.Setmemoria_ram(memoria_ram);
            notebook.Sethdd(hdd);
            notebook.Setssd(ssd);
            notebook.Setmemoria_video(memoria_video);
            notebook.Setpuertos_usb(puertos_usb);
            notebook.Setred_rj45(red_rj45);
            notebook.Setprecio_unitario(precio_unitario);
            notebook.Setstock(stock);
            notebook.Setstock_valorizado(stock_valorizado);

            string sql = "INSERT INTO notebook(marca, modelo, precio_unitario, stock_valorizado, stock, procesador, veloc_cpu, nucleos, mem_video, sis_operativo, hdd, ssd, puertos_usb, red_rj45)" + " VALUES ('" + marca + "', '" + modelo + "',  '" + precio_unitario + "', '" + stock_valorizado + "', '" + stock + "', '" + procesador + "', '" + velocidad_procesadora + "', '" + nucleos + "', '" + memoria_video + "', '" + sist_operativo + "', '" + hdd + "', '" + ssd + "', '" + puertos_usb + "', '" + red_rj45 + "')";
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
    }
}
