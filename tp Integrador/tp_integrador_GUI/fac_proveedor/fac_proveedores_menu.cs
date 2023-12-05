using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_integrador_GUI
{
    public partial class fac_proveedores_menu : Form
    {
        public fac_proveedores_menu()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            fac_proveedor_crear crear_fac = new fac_proveedor_crear();
            crear_fac.ShowDialog();
        }
    }
}
