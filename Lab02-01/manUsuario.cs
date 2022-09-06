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
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string fecNac = txtFecha.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string area = txtArea.Text;
            dgvUsers.Rows.Add(DNI,nombre, telefono, direccion, fecNac, apellido, email,area);

        }
    }
}
