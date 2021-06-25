using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Covid19_Context;
using System.Windows.Forms;

namespace Proyecto.View
{
    public partial class frmProcessDate : Form
    {
        public frmProcessDate()
        {
            InitializeComponent();
        }

        private void frmProcessDate_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //varible para hacer respectivas validaciones
            bool verification =
                txtDui.Text.Length == 10 &&
                txtNombre.Text.Length > 15 &&
                txtDirection.Text.Length > 10 &&
                txtPhone.Text.Length >= 8;

            if (verification)
            {
                //Creando y guardadno los datos de un ciudadano
                string id = txtDui.Text;
                string name = txtNombre.Text;
                string direction = txtDirection.Text;
                string phone = txtPhone.Text;
                string @email = txtEmail.Text;
                int identificator = (int)nudIdentificator.Value;
                //Se necesita el id del gestor de alguna manera
                //momentaneamente sera id del trabajador 1 *Dato quemado*
                int id_employee = 1;
                using (var db = new COVID19_DATABASEContext())
                {
                    List<Ciudadano> citizens = db.Ciudadanos.ToList();
                    List<Ciudadano> exist = citizens.Where(u => u.Dui == id).ToList();
                    if (exist.Count() > 0)
                    {
                        MessageBox.Show("El ciudadano ya ha sido registrado o ya posee una cita previa", "Covid-19 Vacunación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Añadiendolos datos del ciudadno a la BD
                        Ciudadano people = new Ciudadano
                        {
                            Dui = id,
                            Nombre = name,
                            Direccion = direction,
                            Telefono = phone,
                            Email = @email,
                            NumeroIdentificador = identificator,
                            IdentificadorEmpleado = id_employee
                        };
                        db.Add(people);
                        db.SaveChanges();

                        //Añadiendo la cita a la BD
                        DateTime date = RandomDate();
                        Citum NewDate = new Citum
                        {
                            FechaHora = date,
                            IdentificadorCita = 1,
                            //Sabiendo ya el gestor que ingreso debere buscar la cabina en donde esta
                            //de momento hare quemado los datos
                            IdLugar = 1,
                            IdentificadorEmpleado = id_employee,
                            IdCiudadano = id
                        };
                        db.Add(NewDate);
                        db.SaveChanges();

                        //recuerda el id de lugar esta quemado
                        string place = "Hospital El Salvador";
                        string message = string.Format("Datos ingresados exitosamente" +
                            "\nCita realizada: " + date + "\nLugar: " + place);
                        MessageBox.Show(message, "Covid-19 Vacunacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Clean();
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos, revise las entradas de los datos", "Covid-19 Vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Funcion para generar la cita
        private Random gen = new Random();
        DateTime RandomDate()
        {
            //DateTime aux = new DateTime(2022, 12, 31)
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                DateTime.Today.Hour, DateTime.Today.Minute, DateTime.Today.Millisecond);
            int range = (new DateTime(2022, 12, 31) - start).Days;
            return start.AddDays(gen.Next(range));
        }

        //Funcion para limpiar
        private void Clean()
        {
            txtDui.Text = "";
            txtNombre.Text = "";
            txtDirection.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            nudIdentificator.Value = 0;
        }
    }
}
