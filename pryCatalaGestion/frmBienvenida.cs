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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            this.Hide();
            registrar.ShowDialog();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar();
            this.Hide();
            mostrar.ShowDialog();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
