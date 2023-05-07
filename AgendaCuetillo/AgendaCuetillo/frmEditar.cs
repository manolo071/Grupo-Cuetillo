using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendaCuetillo
{

    public partial class frmEditar : Form
    {
        cConexion conex = new cConexion();
        public frmEditar()
        {
            InitializeComponent();
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
        private void CargarDatos(int f, string colum, string para)
        {            
            clear();
            OleDbDataReader reader = conex.RecuperarDatos(f, colum, para);
            // Enlazar los datos al DataGridView
            if (reader.Read())
            {
                dgvContactos.Rows.Add(reader["DNI"], reader["Nombre"], reader["ApellidoPaterno"], reader["ApellidoMaterno"], reader["Genero"], reader["Telefono"], reader["Email"], reader["Direccion"], reader["Nacimiento"]);
            }
            conex.close();
            // dgvContactos.DataSource = contactos;
        }
        private void Limpiar()
        {
            txtDNI.ResetText();
            txtNombre.ResetText();
            txtAP.ResetText();
            txtAM.ResetText();
            txtTelefono.ResetText();
            txtEmail.ResetText();
            txtDireccion.ResetText();
            txtDNI.Focus();
        }
        private void clear()
        {
            dgvContactos.Rows.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int DNI = int.Parse(txtDNI.Text);
                string Nombre = txtNombre.Text.ToUpper();
                string ApellPaterno = txtAP.Text.ToUpper();
                string ApellMaterno = txtAM.Text.ToUpper();
                char Genero = 'M';
                if (rbF.Checked)
                {
                    Genero = 'F';
                }
                if (rbM.Checked)
                {
                    Genero = 'M';
                }
                int Telefono = int.Parse(txtTelefono.Text);
                string Email = txtEmail.Text.ToUpper();
                string Direccion = txtDireccion.Text.ToUpper();
                DateTime Nacimiento = dtNacimiento.Value.Date;

                cContacto nuevoContacto = new cContacto(DNI, Nombre, ApellPaterno, ApellMaterno, Genero, Telefono, Email, Direccion, Nacimiento);
                clear();
                //int i = dgvContactos.CurrentRow.Index;
                int i = 1;
                conex.ModificarDatos(nuevoContacto,i+3);
                MessageBox.Show("Se actualizo correctamente", "Felicidades");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                MessageBox.Show("No se pudo agregar correctamente :c", "Error");
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Habilitar();
                txtDNI.Text = (dgvContactos.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dgvContactos.CurrentRow.Cells[1].Value.ToString();
                txtAP.Text = dgvContactos.CurrentRow.Cells[2].Value.ToString();
                txtAM.Text = dgvContactos.CurrentRow.Cells[3].Value.ToString();
                char Genero = char.Parse(dgvContactos.CurrentRow.Cells[4].Value.ToString());
                if (Genero == 'M')
                {
                    rbM.Select();
                }
                else
                {
                    rbF.Select();
                }
                txtTelefono.Text = dgvContactos.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvContactos.CurrentRow.Cells[6].Value.ToString();
                txtDireccion.Text = dgvContactos.CurrentRow.Cells[7].Value.ToString();
                dtNacimiento.Value = DateTime.Parse(dgvContactos.CurrentRow.Cells[8].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiene que seleccionar un contacto valido", "Advertencia");
            }

        }

        private void Habilitar()
        {
            txtNombre.Enabled = true;
            txtAP.Enabled = true;
            txtAM.Enabled = true;
            txtDNI.Enabled = true;
            rbF.Enabled = true;
            rbM.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtDireccion.Enabled = true;
            dtNacimiento.Enabled = true;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
        }

        private void Deshabilitar()
        {
            txtNombre.Enabled = false;
            txtAP.Enabled = false;
            txtAM.Enabled = false;
            txtDNI.Enabled = false;
            rbF.Enabled = false;
            rbM.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            dtNacimiento.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
        }
    }
}
