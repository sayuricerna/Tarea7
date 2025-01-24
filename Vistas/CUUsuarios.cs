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
    public partial class CUUsuarios : UserControl
    {
        public CUUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios.frmUsuarios frm = new Usuarios.frmUsuarios();
            frm.Text = "Agregar";
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios.frmUsuarios frm = new Usuarios.frmUsuarios();
            frm.Text = "EDITAR";
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
