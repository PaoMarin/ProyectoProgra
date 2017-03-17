using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiempos.View
{
    public partial class frmPrincipal : Form
    {
       
        frmApuesta oFrmApuesta;

        public frmPrincipal()
        {
            InitializeComponent();
        }

       
        private void apuestaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.HandleForm(this.oFrmApuesta))
            {
                this.oFrmApuesta = new frmApuesta();
                oFrmApuesta.MdiParent = this;
                oFrmApuesta.Show();
            }
        }

        private bool HandleForm(Form currentForm)
        {
            if (this.MdiChildren.Contains(currentForm))
            {
                currentForm.WindowState = FormWindowState.Maximized;
                currentForm.Activate();
                return false;
            }
            return true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void apuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
