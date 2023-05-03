using AgendaCuetillo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wea
{
    public partial class frmMostrar : Form
    {
        private List<cContacto> contactos;

        public frmMostrar(List<cContacto> cont)
        {
            InitializeComponent();
            this.contactos = cont;
            cbFiltro.SelectedIndex = 0;
            CargarContactos();
            CargarDatos(0, "", "");
        }

        private void CargarContactos()
        {
            dgvContactos.AutoGenerateColumns = false;
            dgvContactos.Columns.Add("DNI", "DNI");
            dgvContactos.Columns.Add("Nombre", "Nombre");
            dgvContactos.Columns.Add("ApellPaterno", "ApellPaterno");
            dgvContactos.Columns.Add("ApellMaterno", "ApellMaterno");
            dgvContactos.Columns.Add("Genero", "Genero");
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns.Add("Email", "Email");
            dgvContactos.Columns.Add("Direccion", "Direccion");
            dgvContactos.Columns.Add("Nacimiento", "Nacimiento");
            dgvContactos.Columns["DNI"].DataPropertyName = "DNI";
            dgvContactos.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvContactos.Columns["ApellPaterno"].DataPropertyName = "ApellPaterno";
            dgvContactos.Columns["ApellMaterno"].DataPropertyName = "ApellMaterno";
            dgvContactos.Columns["Genero"].DataPropertyName = "Genero";
            dgvContactos.Columns["Telefono"].DataPropertyName = "Telefono";
            dgvContactos.Columns["Email"].DataPropertyName = "Email";
            dgvContactos.Columns["Direccion"].DataPropertyName = "Direccion";
            dgvContactos.Columns["Nacimiento"].DataPropertyName = "Nacimiento";
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void clear()
        {
            dgvContactos.Rows.Clear();
        }
        private void CargarDatos(int f, string colum, string para)
        {

            cConexion conex = new cConexion();
            clear();
            OleDbDataReader reader = conex.RecuperarDatos(f, colum, para);
            // Enlazar los datos al DataGridView
            while (reader.Read())
            {
                dgvContactos.Rows.Add(reader["DNI"], reader["Nombre"], reader["ApellidoPaterno"], reader["ApellidoMaterno"], reader["Genero"], reader["Telefono"], reader["Email"], reader["Direccion"], reader["Nacimiento"]);
            }
            conex.close();
            // dgvContactos.DataSource = contactos;
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            int filtro = cbFiltro.SelectedIndex;
            string a = txtFiltro.Text.ToUpper();
            try
            {
                if (a != "")
                {
                    switch (filtro)
                    {
                        case 0:
                            {
                                CargarDatos(1, "DNI", a);
                            }
                            break;
                        case 1:
                            {
                                CargarDatos(1, "Nombre", a);
                            }
                            break;
                        case 2:
                            {
                                CargarDatos(1, "ApellidoPaterno", a);
                            }
                            break;
                        case 3:
                            {
                                CargarDatos(1, "ApellidoMaterno", a);
                            }
                            break;
                        case 4:
                            {
                                CargarDatos(1, "Genero", a);
                            }
                            break;
                        case 5:
                            {

                                CargarDatos(1, "Telefono", a);
                            }
                            break;
                        case 6:
                            {
                                CargarDatos(1, "Email", a);
                            }
                            break;
                        case 7:
                            {
                                CargarDatos(1, "Direccion", a);
                            }
                            break;
                    }
                }
                else
                {
                    dgvContactos.DataSource = null;
                    CargarDatos(0, "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo buscar correctamente :c", "Error");
                CargarDatos(0, "", "");

            }

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.ResetText();
        }
    }
}
