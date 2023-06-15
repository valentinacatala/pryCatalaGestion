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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void lblTipoActividad_Click(object sender, EventArgs e)
        {

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstTipoActividad.SelectedIndex != -1)
                {
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");
                    }
                    else
                    {
                        MessageBox.Show("Falta completar el detalle", "Cargar Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo de actividad", "Cargar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstTipoActividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar una fecha actual o posterior a la de hoy", "Cargar fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();

            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
