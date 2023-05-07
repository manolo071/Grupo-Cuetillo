using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wea;

namespace AgendaCuetillo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Password = txtPassword.Text;
            if (User == "" )
            {
                MessageBox.Show("Se debe ingresar un usuario", "Advertencia");
            }
            else
            {
                if (Password == "")
                {
                    MessageBox.Show("Se debe ingresar una contraseña", "Advertencia");
                }
                else
                {
                    try
                    {
                        cConexion conex = new cConexion();
                        OleDbDataReader lector = conex.Login(User, Password);
                        // Enlazar los datos al DataGridView
                        if (lector.HasRows)
                        {
                            frmAgenda agenda = new frmAgenda();
                            agenda.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Datos Incorrectos o usuario no existe", "Advertencia");
                            txtUser.ResetText();
                            txtPassword.ResetText();
                            txtUser.Focus();
                        }
                        conex.close();
                    }
                    catch (Exception ex) { }
                }
            }            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
