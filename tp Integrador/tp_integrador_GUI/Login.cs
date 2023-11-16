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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string User, Password;
            User = txtUser.Text.Trim();
            Password = txtPassword.Text.Trim();

            if (User == "Admin" && Password == "1234" || User == "user1" && Password == "1234")
            {
                MessageBox.Show("Bienvenidos al sistema");

                this.Hide();
                Menu frm = new Menu();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Acceso denegado!!", "Error en User o Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Decea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}