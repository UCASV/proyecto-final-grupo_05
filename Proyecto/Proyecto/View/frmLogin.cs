using Microsoft.Data.SqlClient;
using Proyecto.Covid19_Context;
using Proyecto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //cadena de conexion
        SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=COVID19_DATABASE;Trusted_Connection=True;");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open(); //iniciando la conexion
            SqlCommand employee = new SqlCommand("SELECT usuario,contrasenia FROM EMPLEADO WHERE usuario= @vusuario AND contrasenia= @vcontrasenia", connection);

            //dandole valor a los parametros
            employee.Parameters.AddWithValue("@vusuario", txtUser.Text); // recibe nombre y valor, parametro usuario
            employee.Parameters.AddWithValue("@vcontrasenia", txtPassword.Text); // parametro contraseña

            //obtener resultado
            SqlDataReader outcome = employee.ExecuteReader();

            string user = txtUser.Text;
            //enviar datos a la base de datos 
            if (outcome.Read() == true)
            {
                //Añadiendo la fecha y hora a la ingreso el gestor
                using (var db = new COVID19_DATABASEContext())
                {
                    List<Empleado> employe = db.Empleados.ToList();

                    //Obteniendo id cabina del gestor 
                    int idCabin = 0;
                    int idEmploye = 0;
                    foreach (var element in employe)
                    {
                        if (element.Usuario == user)
                        {
                            idCabin = element.IdCabina;
                            idEmploye = element.Identificador;
                        }
                    }

                    //Guardadno el registro
                    Historial historial = new Historial
                    {
                        FechaHora = DateTime.Now,
                        IdCabina = idCabin
                    };

                    db.Add(historial);
                    db.SaveChanges();

                    //Obteniendo ID tabla HISTORIAL 
                    List<Historial> register = db.Historials.ToList();
                    int idHistorial = 0;
                    foreach(var element in register)
                    {
                        if (element.IdCabina == idCabin)
                            idHistorial = element.Id;
                    }
                    //Rellenando datos tabla EMPLEADOXHISTORIAL
                    Empleadoxhistorial EmpxHist = new Empleadoxhistorial
                    {
                        IdEmpleado = idEmploye,
                        IdHistorial = idHistorial
                    };
                    db.Add(EmpxHist);
                    db.SaveChanges();
                }
                connection.Close(); //cerrando la conexion
                frmMainMenu main = new frmMainMenu(user);
                main.Show();
                this.Hide();
            }
            else if (outcome.Read() == false)
            {
                connection.Close();
                MessageBox.Show("¡El usuario no existe!", "Vacunacion Covid-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
