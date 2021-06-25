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
    public partial class frmVaccinationProcess : Form
    {
        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dTp_VacPrcss_entry.Format = DateTimePickerFormat.Custom;
            dTp_VacPrcss_entry.CustomFormat = "yyyy/MM/dd hh:mm";
            dTp_VacPrcss_exit.Format = DateTimePickerFormat.Custom;
            dTp_VacPrcss_exit.CustomFormat = "yyyy/MM/dd hh:mm";
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

        private void btnVacProcss_DatetimeEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnVacProcss_DatetimeExit_Click(object sender, EventArgs e)
        {

        }

        private void btnVacProcss_RegistrEffect_Click(object sender, EventArgs e)
        {

        }

    }
}