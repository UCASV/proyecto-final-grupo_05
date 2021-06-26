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
            Vacunacion unVacunacion = new Vacunacion();

            unVacunacion.IdCiudadano = txtVacProcss_dui.Text;
            unVacunacion.FechaHoraEntrada = dTp_VacPrcss_entry.Value;
            unVacunacion.FechaHoraSalida = dTp_VacPrcss_exit.Value;
            unVacunacion.Tiempo = Convert.ToInt32(nUdVacProcss_minute.Value);
            EfectoSecundario efecto = (EfectoSecundario) cmbVacProcss_Effects.SelectedItem;

            //subir datos a la base de datos.
            var db = new COVID19_DATABASEContext();
            db.Add(unVacunacion);
            db.SaveChanges();
        }

       

        /*public void ValidarDui(Vacunacion unVacunacion)
        {
            string dui;
            dui = txtVacProcss_dui.Text;
            Ciudadano unCiudadano = new Ciudadano();
            if (unCiudadano.Dui.Contains(dui))
            {
                unVacunacion.IdCiudadano = txtVacProcss_dui.Text;
            }
            else
            {
                MessageBox.Show("Error DUI no registrado en cita.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

    }

}