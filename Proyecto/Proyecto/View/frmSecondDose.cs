using Proyecto.Covid19_Context;
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
    public partial class frmSecondDose : Form
    {
        public string user { get; set; }
        public frmSecondDose(string user4)
        {
            InitializeComponent();
            this.user = user4;
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
                List<Lugar> places = db.Lugars.ToList();
                if (exist.Count() > 0 && identifyCita.Count() > 0 && restrict.Count() < 2)
                {
                    if (verifcation)
                    {
                        DateTime newDateCitum = Convert.ToDateTime("2020-01-01 13:00");
                        string duivalidatorio = txtScndDse_dui.Text;
                        int idCita;
                        int idLugars=0;
                        string NamePlace = "";
                        //obtenemos la fecha de la primera cita correspondiente al dui
                        foreach (var element in cita)
                        {
                            if (duivalidatorio == element.IdCiudadano)
                            {
                                newDateCitum = element.FechaHora;
                                idLugars = element.IdLugar;
                            }
                        }
                        foreach (var element in places)
                        {
                            if (element.Id == idLugars)
                            {
                                NamePlace = element.Lugar1;
                            }
                        }
                        //agregamos los dias para la proxima cita
                        newDateCitum = newDateCitum.AddDays(45);

                        //Obteniendo el identificador del empleado
                        int idEmploye = 0;
                        List<Empleado> employe = db.Empleados.ToList();
                        foreach(var element in employe)
                        {
                            if(element.Usuario == user)
                            {
                                idEmploye = element.Identificador;
                            }
                        }

                        Citum unCitum = new Citum();
                        {
                            unCitum.FechaHora = newDateCitum;
                            unCitum.IdentificadorCita = 2;
                            unCitum.IdLugar = idLugars;
                            unCitum.IdentificadorEmpleado = idEmploye;
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
