using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPeraltaRoureIEFI2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevo frmNuevo = new frmNuevo();
            frmNuevo.ShowDialog();


        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
