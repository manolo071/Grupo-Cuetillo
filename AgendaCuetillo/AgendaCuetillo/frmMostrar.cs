using AgendaCuetillo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Contacto> contactos;

        public frmMostrar(List<Contacto> cont)
        {
            InitializeComponent();
            this.contactos = cont;
            cbFiltro.SelectedIndex = 0;
            CargarContactos();
            CargarDatos();
        }

        private void CargarContactos()
        {
            dgvContactos.AutoGenerateColumns = false;
            dgvContactos.Columns.Add("Nombre", "Nombre");
            dgvContactos.Columns.Add("ApellPaterno", "ApellPaterno");
            dgvContactos.Columns.Add("ApellMaterno", "ApellMaterno");
            dgvContactos.Columns.Add("Genero", "Genero");
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns.Add("Email", "Email");
            dgvContactos.Columns.Add("Direccion", "Direccion");
            dgvContactos.Columns.Add("Nacimiento", "Nacimiento");
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
        private void CargarDatos()
        {
            dgvContactos.DataSource = contactos;
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
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.Nombre.Contains(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 1:
                            {
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.ApellPaterno.Contains(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 2:
                            {
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.ApellMaterno.Contains(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 3:
                            {
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.Genero == (a[0])).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 4:
                            {

                                List<Contacto> contactosFiltrados = contactos.Where(c => c.Telefono == int.Parse(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 5:
                            {
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.Email.Contains(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                        case 6:
                            {
                                List<Contacto> contactosFiltrados = contactos.Where(c => c.Direccion.Contains(a)).ToList();
                                dgvContactos.DataSource = contactosFiltrados;
                            }
                            break;
                    }
                }
                else
                {
                    CargarDatos();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se pudo buscar correctamente :c", "Error");
                CargarDatos();
            }
            
        }
    }
}
