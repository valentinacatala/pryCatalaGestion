using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCatalaGestion
{
    public partial class frmRegistrar : Form
    {
        frmMostrar ventanaMostrar = new frmMostrar();
        string[] vectorActividad = new string[5];
        string[] vectorRegistroActvidad = new string[5];
        readonly int indiceRegistro = 0;
        int indiceFilaRegistro;

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
                    if (optSi.Checked==true)
                    {
                        
                    }
                    else
                    {

                    }

                    if (chkDebate.Checked)
                    {

                    }
                    if (chkInvestigacion.Checked)
                    {

                    }
                    if (chkNotasReunion.Checked)
                    {

                    }
                    if (chkRepositorio.Checked)
                    {

                    }

                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");

                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 0] = dtpFecha.Value.ToString();
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 1] = lstTipoActividad.Text;
                        ventanaMostrar.matrizTareas[indiceFilaRegistro, 2] = txtDetalle.Text;

                        indiceFilaRegistro++;
                        if (indiceFilaRegistro == ventanaMostrar.matrizTareas.GetLength(0))
                        {
                            cmdRegistrar.Enabled = false;
                        }

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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmBienvenida bienvenida = new frmBienvenida();
            this.Hide();
            bienvenida.ShowDialog();
        }

        private void cmdVerRegistro_Click(object sender, EventArgs e)
        {

        }

        private void cmdVerRegistro_Click_1(object sender, EventArgs e)
        {
            ventanaMostrar.ShowDialog();
            this.Hide();
            
        }
    }
}
