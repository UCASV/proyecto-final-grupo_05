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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Proyecto.View
{
    public partial class frmFollowDate : Form
    {
        public frmFollowDate()
        {
            InitializeComponent();
        }

        private void frmFollowDate_Load(object sender, EventArgs e)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int id_place = 0;
            string nameplace = "";
            string date_hour = "";

            using (var db = new COVID19_DATABASEContext())
            {
                //se mandan los ciudadanos a una lista
                List<Ciudadano> citizens = db.Ciudadanos.ToList();
                List<Ciudadano> exist = citizens.Where(u => u.Dui == txtDui.Text).ToList();

                //se mandan las citas a una lista
                List<Citum> appointment = db.Cita.ToList();
                List<Citum> have = appointment.Where(u => u.IdCiudadano == txtDui.Text).ToList();


                List<Lugar> site = db.Lugars.ToList();

                //para obtener los datos de la fecha, hora y id lugar de la tabla cita
                foreach (var element in appointment)
                {

                    if (txtDui.Text == element.IdCiudadano)
                    {
                        id_place = element.IdLugar;
                        date_hour = element.FechaHora.ToString("dd/MM/yyyy HH:mm:ss");

                    }
                }


                // para obtener el nombre del lugar de la tabla lugar
                foreach (var element2 in site)
                {
                    if (id_place == element2.Id)
                    {
                        nameplace = element2.Lugar1;
                    }
                }

                string message = string.Format("El ciudadano tiene cita previa. \n" + "Fecha y Hora: " + date_hour + "\nLugar: " + nameplace);

                if (exist.Count() > 0)
                {
                    MessageBox.Show(text: message, caption: "Vacuna Covid-19", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
            }
        }

        private void btnExportFollowDate_Click(object sender, EventArgs e)
        {
            int id_place = 0;
            string nameplace = "";
            string date_hour = "";
            string name = " ";

            using (var db = new COVID19_DATABASEContext())
            {
                //se mandan los ciudadanos a una lista
                List<Ciudadano> citizens = db.Ciudadanos.ToList();
                List<Ciudadano> exist = citizens.Where(u => u.Dui == txtDui.Text).ToList();

                //se mandan las citas a una lista
                List<Citum> appointment = db.Cita.ToList();
                List<Citum> have = appointment.Where(u => u.IdCiudadano == txtDui.Text).ToList();

                //lista de lugar
                List<Lugar> site = db.Lugars.ToList();

                //Para obtener el nombre
                foreach (var search in citizens)
                {
                    if (txtDui.Text == search.Dui)
                    {
                        name = search.Nombre;
                    }
                }


                //para obtener los datos de la fecha, hora y id lugar de la tabla cita
                foreach (var element in appointment)
                {

                    if (txtDui.Text == element.IdCiudadano)
                    {
                        id_place = element.IdLugar;
                        date_hour = element.FechaHora.ToString("dd/MM/yyyy HH:mm:ss");

                    }
                }


                // para obtener el nombre del lugar de la tabla lugar
                foreach (var element2 in site)
                {
                    if (id_place == element2.Id)
                    {
                        nameplace = element2.Lugar1;
                    }
                }
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileS = new FileStream(sfd.FileName, FileMode.Create);
                    Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                    PdfWriter pdf = PdfWriter.GetInstance(doc, fileS);
                    doc.Open();
                    //definimos la fuente que utilizaremos
                    iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8,
                        iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    doc.Add(new Paragraph("                                      CITA PARA VACUNACIÓN COVID-19"));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Paragraph("          Nombre: " + name));
                    doc.Add(new Paragraph("          DUI: " + txtDui.Text));
                    doc.Add(new Paragraph("          Fecha y hora: " + date_hour));
                    doc.Add(new Paragraph("          Lugar: " + nameplace));

                    doc.Close();
                    pdf.Close();
                }
            }
        }
    }
}
