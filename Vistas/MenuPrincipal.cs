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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUUsuarios frmUsuarios = new CUUsuarios();
            pnlGeneral.Controls.Clear();
            frmUsuarios.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(frmUsuarios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUReportes frm = new CUReportes();
            pnlGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CURoles frm = new CURoles();
            pnlGeneral.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(frm);
        }

        private void pnlGeneral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
