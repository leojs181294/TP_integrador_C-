using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_integrador_GUI.fac_notebook;
using tp_integrador_GUI.notebook;

namespace tp_integrador_GUI
{
    public partial class fac_proveedor_crear : Form
    {
        public fac_proveedor_crear()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            fac_notebook_crear fac_Notebook = new fac_notebook_crear();
            fac_Notebook.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
