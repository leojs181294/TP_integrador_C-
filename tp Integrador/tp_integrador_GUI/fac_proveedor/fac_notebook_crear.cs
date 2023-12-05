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
using tp_integrador_GUI.fac_notebook;
using tp_integrador_GUI.proveedores;


namespace tp_integrador_GUI
{
    public partial class fac_notebook_crear : Form
    {
        public fac_notebook_crear()
        {
            InitializeComponent();
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
            Fac_notebook fac_Notebook = new Fac_notebook();
            fac_Notebook.id_notebook = int.Parse(txt_id_notebook.Text);
            fac_Notebook.cantidad = int.Parse(txt_cantidad.Text);
            fac_Notebook.precio_costo = float.Parse(txt_precio_unitario.Text);
            string sql = "INSERT INTO fact_notebook(cantidad, id_notebook, precio_costo, precio_total) VALUES ('" + fac_Notebook.cantidad + "', '" + fac_Notebook.id_notebook + "',  '" + fac_Notebook.precio_costo + "', '" + fac_Notebook.getprecio_total + "')";
            MySqlConnection conexionDB = Conexion.Conectar();
            conexionDB.Open();

            //ver como cambiar stock de notebook y verificar id_notebook

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
