using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Covid19_Context;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;

namespace Proyecto.View
{
    public partial class frmProcessDate : Form
    {
        private string NamePlace;
        private DateTime date;
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
            bool verificatonCLB = false;
            for (int i=0; i < clbDiseases.Items.Count; i++)
            {
                if(clbDiseases.GetItemChecked(i) == true)
                {
                    verificatonCLB = true;
                    i += 8;
                }
            }
            bool verification =
                txtDui.Text.Length == 10 &&
                txtNombre.Text.Length > 15 &&
                txtDirection.Text.Length > 10 &&
                txtPhone.Text.Length >= 8 &&
                verificatonCLB == true;

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
                    List<Lugar> places = db.Lugars.ToList();
                    List<Ciudadano> exist = citizens.Where(u => u.Dui == id).ToList();
                    if (exist.Count() > 0)
                    {
                        MessageBox.Show("El ciudadano ya ha sido registrado o ya posee una cita previa", "Covid-19 Vacunación",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (nudAge.Value >= 60 || nudIdentificator.Value != 0 || (clbDiseases.GetItemChecked(6) == false && nudAge.Value >=18))
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

                            for (int i=0; i < clbDiseases.Items.Count; i++)
                            {
                                if (clbDiseases.GetItemChecked(i) == true)
                                {
                                    string value = clbDiseases.Items[i].ToString();
                                    Enfermedad disease = new Enfermedad
                                    {
                                        Enfermedad1 = value,
                                        IdCiudadano = txtDui.Text
                                    };
                                    db.Add(disease);
                                    db.SaveChanges();
                                }
                            }
                            //Añadiendo la cita a la BD
                            Random id_Place = new Random();
                            int aux = id_Place.Next(1, (places.Count + 1));
                            date = RandomDate();
                            Citum NewDate = new Citum
                            {
                                FechaHora = date,
                                IdentificadorCita = 1,
                                //Sabiendo ya el gestor que ingreso debere buscar la cabina en donde esta
                                //de momento hare quemado los datos
                                IdLugar = aux,
                                IdentificadorEmpleado = id_employee,
                                IdCiudadano = id
                            };
                            db.Add(NewDate);
                            db.SaveChanges();

                            //Buscando el nombre del lugar de la cita
                            foreach (var element in places)
                            {
                                if (element.Id == aux)
                                    NamePlace = element.Lugar1;
                            }
                            //recuerda el id de lugar esta quemado
                            string message = string.Format("Datos ingresados exitosamente" +
                                "\nCita realizada: " + date + "\nLugar: " + NamePlace);
                            MessageBox.Show(message, "Covid-19 Vacunacion", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aun no es tu turno del ciudadano, espere atentamente noticias del gobierno ", "Covid-19 Vacunacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            int range = (new DateTime(2022, 12, 31) - start).Days;
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(8,16)).AddMinutes(gen.Next(0,60));
        }

        //Funcion para limpia

        private void Clean()
        {
            txtDui.Text = "";
            txtNombre.Text = "";
            txtDirection.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            nudIdentificator.Value = 0;
            nudAge.Value = 0;
            for(int i = 0; i < clbDiseases.Items.Count; i++)
            {
                clbDiseases.SetItemChecked(i, false);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileS = new FileStream(sfd.FileName, FileMode.Create);
                    Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                    PdfWriter pdf = PdfWriter.GetInstance(doc, fileS);
                    doc.Open();
                    //definimos la fuente que utilizaremos
                    iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8,
                        iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("                                      CITA PARA PROCESO DE VACUNACION COVID-19"));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("          Nombre: " + txtNombre.Text));
                    doc.Add(new Paragraph("          DUI: " + txtDui.Text));
                    doc.Add(new Paragraph("          Fecha y hora: " + date));
                    doc.Add(new Paragraph("          Lugar: " + NamePlace));

                    doc.Close();
                    pdf.Close();
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
