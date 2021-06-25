using Proyecto.Extras;
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
    public partial class frmMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        public frmMainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
        }

        //metodo para cambiar de colores aleatoriamente la interfaz 
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitle.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecundaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMainMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Metodo para desplegaar los formularios hijos.
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(childForm);
            this.pnlPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProcessDate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProcessDate(),sender);
            lblTitle.Text = "Procesar Cita";
            lblTitle.Location = new Point(300,12);
            this.Show();
        }

        private void btnfollowDate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmFollowDate(), sender);
            lblTitle.Text = "Seguimiento de Cita";
            lblTitle.Location = new Point(240, 12);
            this.Show();
        }

        private void btnVaccinationProcess_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmVaccinationProcess(), sender);
            lblTitle.Text = "Proceso de Vacunación";
            lblTitle.Location = new Point(220, 12);
            this.Show();
        }

        private void btnSecondDose_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSecondDose(), sender);
            lblTitle.Text = "Cita de Segunda Dosis";
            lblTitle.Location = new Point(220, 12);
            this.Show();
        }

        private void btnEmployeesInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmployeeInformation(), sender);
            lblTitle.Text = "Información de Empleados";
            lblTitle.Location = new Point(180, 12);
            this.Show();
        }

        private void btnCabinInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCabinInformation(), sender);
            lblTitle.Text = "Información de Cabina";
            lblTitle.Location = new Point(210, 12);
            this.Show();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            lblTitle.Location = new Point(350, 12);
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnClose.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnExitSesion_Click(object sender, EventArgs e)
        {
            frmLogin window = new frmLogin();
            window.Show();
            this.Hide();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
