using Proyecto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Hide();
        }
        //probando el merge
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
