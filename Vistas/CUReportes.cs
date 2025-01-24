using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUsuarios.Vistas
{
    public partial class CUReportes : UserControl
    {
        public CUReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.frmReportes frm = new Reportes.frmReportes();
            frm.Text = "Agregar";
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes.frmReportes frm = new Reportes.frmReportes();
            frm.Text = "Editar";
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
