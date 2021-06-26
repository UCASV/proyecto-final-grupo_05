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
using Proyecto.Covid19_Context;
using Microsoft.Data.SqlClient;

namespace Proyecto
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        //cadena de conexion
        SqlConnection connection = new SqlConnection("server=LAPTOP-C1BFNSLL\\SQLEXPRESS;database=COVID19_DATABASE; INTEGRATED SECURITY=true");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open(); //iniciando la conexion
            SqlCommand employee = new SqlCommand("SELECT usuario,contrasenia FROM EMPLEADO WHERE usuario= @vusuario AND contrasenia= @vcontrasenia", connection);

            //dandole valor a los parametros
            employee.Parameters.AddWithValue("@vusuario", txtUser.Text); // recibe nombre y valor, parametro usuario
            employee.Parameters.AddWithValue("@vcontrasenia", txtPassword.Text); // parametro contraseña

            //obtener resultado
            SqlDataReader outcome = employee.ExecuteReader();

            //enviar datos a la base de datos 
            if (outcome.Read() == true)
            {
                connection.Close(); //cerrando la conexion
                frmMainMenu main = new frmMainMenu();
                main.Show();
                //this.Hide();

            }
            else if (outcome.Read() == false)
            {
                MessageBox.Show("¡El usuario no existe!", "Vacunacion Covid-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Hide();
            }
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
