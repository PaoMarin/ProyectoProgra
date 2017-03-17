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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmLogin oFrmLogin = new frmLogin();
            oFrmLogin.Show();
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmPrincipal oFrmPrincipal = new frmPrincipal();
            oFrmPrincipal.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
