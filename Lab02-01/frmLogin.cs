using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //List<Usuario> users = new List<Usuario>();
            Constante.users.Add(new Usuario { name = "ronald", password = "tecsup"});
            Constante.users.Add(new Usuario { name = "admin", password = "tecsup" });
            Constante.users.Add(new Usuario { name = "sara", password = "tecsup" });
            string userInput = txtUsuario.Text;
            string passwordInput = txtPassword.Text;
            
            for (int i = 0; i < Constante.users.Count; i++)
            {
                Usuario usuario = Constante.users[i];
                if(usuario.name == userInput & usuario.password == passwordInput)
                {
                    
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }   
            }
            //Form form = new FormErr();
            //form.ShowDialog();




        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }
    }
}
