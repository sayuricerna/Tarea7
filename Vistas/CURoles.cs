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
    public partial class CURoles : UserControl
    {
        public CURoles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roles.frmRoles frmRoles = new Roles.frmRoles();
            frmRoles.Text = "AGREGAR";
            frmRoles.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Roles.frmRoles frmRoles = new Roles.frmRoles();
            frmRoles.Text = "EDITAR";
            frmRoles.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
