using AgendaCuetillo;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace wea
{
    public partial class frmAgregar : Form
    {
        public List<cContacto> contactos;
        public frmAgregar(List<cContacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
            rbM.Select();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                if (MessageBox.Show("Los datos de su nuevo contacto se perderan, esta seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
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
                contactos.Add(nuevoContacto);
                cConexion conex = new cConexion();
                conex.IngresarDatos(nuevoContacto);
                MessageBox.Show("Se agrego correctamente", "Felicidades");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                MessageBox.Show("No se pudo agregar correctamente :c", "Error");
            }
        }

        private void frmAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verificar())
            {
                if (MessageBox.Show("Los datos de su nuevo contacto se perderan, esta seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Boolean verificar()
        {
            if (txtDNI.Text != "" || txtNombre.Text != "" || txtAP.Text != "" || txtAM.Text != "" || txtTelefono.Text != "" || txtEmail.Text != "" || txtDireccion.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
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
    }
}
