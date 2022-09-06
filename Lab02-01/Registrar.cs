using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab02_01.frmLogin;
namespace Lab02_01
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConPassword.Text;
            if (password == confirmPassword)
            {

                //List<Usuario> users = new List<Usuario>();

                Constante.users.Add(new Usuario { name = usuario, password = password });
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                Form form = new FormErr();
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
