using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Covid19_Context;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

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
            var db = new COVID19_DATABASEContext();
            cmbVacProcss_Effects.DataSource = db.EfectoSecundarios.ToList();
            cmbVacProcss_Effects.DisplayMember = "EfectoSecundario1";
            cmbVacProcss_Effects.ValueMember = "Id";
            cmbVacProcss_Effects.SelectedIndex = 9;

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

        private void btnVacProcss_RegistrData_Click(object sender, EventArgs e)
        {
            bool verifcation = txtVacProcss_dui.Text.Length == 10;

            EfectoSecundario efecto = (EfectoSecundario)cmbVacProcss_Effects.SelectedItem;

            //Encontrar si el DUI existe
            using (var db = new COVID19_DATABASEContext())
            {
                List<EfectoSecundario> EfectSecundarys = db.EfectoSecundarios.ToList();
                List<Ciudadano> citizens = db.Ciudadanos.ToList();
                List<Ciudadano> exist = citizens.Where(u => u.Dui == txtVacProcss_dui.Text).ToList();
                List<Vacunacion> vacunations = db.Vacunacions.ToList();
                List<Vacunacion> existVac = vacunations.Where(u => u.IdCiudadano == txtVacProcss_dui.Text).ToList();
                if (exist.Count() > 0 && existVac.Count() < 2)
                {
                    if (verifcation)
                    {
                        //Obteniendo ID de la tabla efecto secundario
                        int idEfect = 0;

                        switch (cmbVacProcss_Effects.SelectedIndex)
                        {
                            case 0:
                                idEfect = 1; 
                                break;
                            case 1:
                                idEfect = 2;
                                break;
                            case 2:
                                idEfect = 3;
                                break;
                            case 3:
                                idEfect = 4;
                                break;
                            case 4:
                                idEfect = 5;
                                break;
                            case 5:
                                idEfect = 6;
                                break;
                            case 6:
                                idEfect = 7;
                                break;
                            case 7:
                                idEfect = 8;
                                break;
                            case 8:
                                idEfect = 9;
                                break;
                            case 9:
                                idEfect = 10;
                                break;

                        }

                        Vacunacion vacinnation = new Vacunacion
                        {
                            FechaHoraEntrada = dTp_VacPrcss_entry.Value,
                            FechaHoraSalida = dTp_VacPrcss_exit.Value,
                            Tiempo = Convert.ToInt32(nUdVacProcss_minute.Value),
                            IdCiudadano = txtVacProcss_dui.Text,
                            IdEfectoSecundario = idEfect
                        };

                        db.Add(vacinnation);
                        db.SaveChanges();

                        MessageBox.Show("Datos registrados", "Covid-19 Vacunación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Inválidos, verifique el ingreso de los datos", "Covid-19 Vacunación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El DUI no existe o ya termino el proceso de vacunacion", "Covid-19 Vacunación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtVacProcss_dui.Text = "";
            dTp_VacPrcss_entry.Value = DateTime.Today;
            dTp_VacPrcss_exit.Value = DateTime.Today;
            nUdVacProcss_minute.Value = 0;
            cmbVacProcss_Effects.SelectedIndex = 9;
        }
    }

}