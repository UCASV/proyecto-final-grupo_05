using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto.Covid19_Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.View
{
    public partial class frmEmployeeInformation : Form
    {
        public string user { get; set; }
        public frmEmployeeInformation(string user5)
        {
            InitializeComponent();
            this.user = user5;
        }

        private void frmEmployeeInformation_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ViewInformation();
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

        //Funcion para mostrar la informacion de empleados en el DataGridView
        private void ViewInformation()
        {
            using (var context = new COVID19_DATABASEContext())
            {
                //Llamando a la BD
                var newDS = context.Empleados.ToList();
                var jobs = context.Tipos.ToList();
                //Obteniendo el id de la cabina del empleado
                int idCabin = 0;
                foreach (var element in newDS)
                {
                    if (element.Usuario == user)
                    {
                        idCabin = element.IdCabina;
                    }
                }

                //Imprimiendo y rellenando la DataGridView
                string job = "";
                dgvEmployeed.Rows.Clear();
                foreach (var element in newDS)
                {
                    if (element.IdCabina == idCabin)
                    {
                        foreach (var element2 in jobs)
                        {
                            if (element2.Id == element.IdTipo)
                            {
                                job = element2.Tipo1;
                            }
                        }
                        dgvEmployeed.Rows.Add(
                            element.Identificador,
                            element.Nombre,
                            element.Email,
                            element.Direccion,
                            job
                            );
                    }
                }
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            var db = new COVID19_DATABASEContext();
            var dataSource = db.Empleados.ToList();
            
            using (SaveFileDialog sfd2 = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {

                if (sfd2.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileS = new FileStream(sfd2.FileName, FileMode.Create);
                    Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                    PdfWriter pdf = PdfWriter.GetInstance(doc, fileS);
                    doc.Open();

                    iTextSharp.text.Font Title = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14,
                        iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10,
                        iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10,
                        iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                    iTextSharp.text.Paragraph text = new iTextSharp.text.Paragraph("INFORMACIÓN DE EMPLEADOS", Title);
                    text.Alignment = Element.ALIGN_CENTER;
                    doc.Add(text);
                    doc.Add(Chunk.NEWLINE);

                    //definiendo las columnas
                    PdfPTable tableEmployed = new PdfPTable(4);
                    tableEmployed.WidthPercentage = 100;

                    PdfPCell id = new PdfPCell(new Phrase("ID", fuente2));
                    id.BorderWidth = 1;
                    id.BorderWidthBottom = 0.75f;

                    PdfPCell name = new PdfPCell(new Phrase("Nombre", fuente2));
                    name.BorderWidth = 1;
                    name.BorderWidthBottom = 0.75f;

                    PdfPCell email = new PdfPCell(new Paragraph("Correo", fuente2));
                    email.BorderWidth = 1;
                    email.BorderWidthBottom = 0.75f;

                    PdfPCell direction = new PdfPCell(new Paragraph("Dirección", fuente2));
                    direction.BorderWidth = 1;
                    direction.BorderWidthBottom = 0.75f;

                    tableEmployed.AddCell(id);
                    tableEmployed.AddCell(name);
                    tableEmployed.AddCell(email);
                    tableEmployed.AddCell(direction);

                    //agregamos aqui los valores del data
                    foreach (var elementi in dataSource)
                    {
                        id = new PdfPCell(new Phrase(elementi.Identificador.ToString(), fuente));
                        id.BorderWidth = 1;

                        name = new PdfPCell((new Phrase(elementi.Nombre, fuente)));
                        name.BorderWidth = 1;

                        email = new PdfPCell(new Phrase(elementi.Email, fuente));
                        email.BorderWidth = 1;

                        direction = new PdfPCell(new Phrase(elementi.Direccion, fuente));
                        direction.BorderWidth = 1;

                        tableEmployed.AddCell(id);
                        tableEmployed.AddCell(name);
                        tableEmployed.AddCell(email);
                        tableEmployed.AddCell(direction);
                    }

                    doc.Add(tableEmployed);
                    doc.Close();
                    pdf.Close();

                    MessageBox.Show("Archivo Exportado exitosamente", "Clinica UCA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
