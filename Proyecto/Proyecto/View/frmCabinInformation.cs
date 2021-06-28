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
    public partial class frmCabinInformation : Form
    {
        public frmCabinInformation()
        {
            InitializeComponent();
        }

        private void frmCabinInformation_Load(object sender, EventArgs e)
        {
            LoadTheme();
            InformationCabin();
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

        private void InformationCabin()
        {
            using (var context = new COVID19_DATABASEContext())
            {
                var newDS = context.Cabinas.ToList();
                var jobs = context.Empleados.ToList();
                string boss = "";
                dgvInformation.Rows.Clear();
                foreach (var element in newDS)
                {
                    foreach(var people in jobs)
                    {
                        if (element.Id == people.IdCabina && people.IdTipo == 2)
                            boss = people.Nombre;
                    }
                    List<Empleado>emp  = element.Empleados.ToList();
                    dgvInformation.Rows.Add(
                            element.Id,
                            element.Direccion,
                            element.Telefono,
                            element.Email,
                            boss
                                );
                }                
            }
        }
    }
}
