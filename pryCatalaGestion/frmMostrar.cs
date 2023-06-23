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
    public partial class frmMostrar : Form
    {
        public string[,] matrizTareas = new string[5, 5];
        int indiceFilaRegistro, indiceColumna;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            indiceFilaRegistro = 0;
            indiceColumna = 0;

            while (indiceFilaRegistro < matrizTareas.GetLength(0))
            {
                dgvMostrar.Rows.Add(matrizTareas[indiceFilaRegistro, 0],
                    matrizTareas[indiceFilaRegistro, 1], matrizTareas[indiceFilaRegistro, 2],
                    matrizTareas[indiceFilaRegistro, 3], matrizTareas[indiceFilaRegistro, 4]);
                indiceFilaRegistro++;
            }

        }
    }
}
