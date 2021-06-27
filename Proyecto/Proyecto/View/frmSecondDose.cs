using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using Proyecto.Covid19_Context;

namespace Proyecto.View
{
    public partial class frmSecondDose : Form
    {
        public frmSecondDose()
        {
            InitializeComponent();
        }

        private void frmSecondDose_Load(object sender, EventArgs e)
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

        private void btnScndDse_Verify_Click(object sender, EventArgs e)
        {
            bool verifcation = txtScndDse_dui.Text.Length == 10;

            //Encontrar si el DUI existe y validar si es su segunda dosis
            // Tambien restringir el maximo de citas agendadas
            using (var db = new COVID19_DATABASEContext())
            {
                List<Citum> cita = db.Cita.ToList();
                List<Citum> identifyCita = cita.Where(c => c.IdentificadorCita == 1).ToList();
                List<Citum> restrict = cita.Where(c => c.IdCiudadano == txtScndDse_dui.Text).ToList();
                List<Ciudadano> citizens = db.Ciudadanos.ToList();
                List<Ciudadano> exist = citizens.Where(u => u.Dui == txtScndDse_dui.Text).ToList();
                if (exist.Count() > 0 && identifyCita.Count() > 0 && restrict.Count() < 2)
                {
                    if (verifcation)
                    {
                        DateTime newDateCitum = Convert.ToDateTime("2020-01-01 13:00");
                        string duivalidatorio = txtScndDse_dui.Text;
                        int idCita;
                        //obtenemos la fecha de la primera cita correspondiente al dui
                        foreach (var element in cita)
                        {
                            if (duivalidatorio == element.IdCiudadano)
                            {
                                newDateCitum = element.FechaHora;
                            }
                        }
                        //agregamos los dias para la proxima cita
                        newDateCitum = newDateCitum.AddDays(45);

                        //randomizador para seleccionar lugar donde sera la proxima cita y el empleado que atiende la cita
                        Random rdm = new Random();
                        int a = rdm.Next(1, 5);
                        int b = rdm.Next(1, 10);


                        
                        Citum unCitum = new Citum();
                        {
                            unCitum.FechaHora = newDateCitum;
                            unCitum.IdentificadorCita = 2;
                            unCitum.IdLugar = a;
                            unCitum.IdentificadorEmpleado = b;
                            unCitum.IdCiudadano = txtScndDse_dui.Text;
                        };

                        db.Add(unCitum);
                        db.SaveChanges();

                        //Mesagge box para mostrar los datos de la proxima cita
                        MessageBox.Show("Su cita para la segunda dosis sera el " + newDateCitum, "Covid-19 Vacunación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El DUI no existe o su segunda dosis ya ha sido agendada", "Covid-19 Vacunación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
    }
}
