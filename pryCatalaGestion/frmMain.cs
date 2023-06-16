using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCatalaGestion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
            Controls.Add(txtContrasena);
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena= txtContrasena.Text;
            frmBienvenida bienvenida = new frmBienvenida();
            if (usuario == "Admin" && contrasena == "Admin")
            {
                this.Hide();
                bienvenida.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
               
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
