using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.View
{
    public partial class frmEmployeeInformation : Form
    {
        public frmEmployeeInformation()
        {
            InitializeComponent();
        }

        private void frmEmployeeInformation_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        //Metodo para cambiar de colores los botones
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Extras.ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Extras.ThemeColor.SecundaryColor;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Covid19_Context.COVID19_DATABASEContext())
            {
                var newDS = context.Empleados.ToList();
                dataGridView1.DataSource = newDS;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
