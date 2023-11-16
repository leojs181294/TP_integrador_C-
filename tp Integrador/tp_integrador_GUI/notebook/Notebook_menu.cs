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

namespace tp_integrador_GUI
{
    public partial class Notebook_menu : Form
    {
        List<Notebook> notebooks = new List<Notebook>();
        public Notebook_menu()
        {
            InitializeComponent();
        }
        private void btn_crear_Click(object sender, EventArgs e)
        {
            Notebook_crear fnotebook = new Notebook_crear();
            fnotebook.ShowDialog();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Notebook_crear fnotebook = new Notebook_crear();
            fnotebook.ShowDialog();
        }
    }
}
