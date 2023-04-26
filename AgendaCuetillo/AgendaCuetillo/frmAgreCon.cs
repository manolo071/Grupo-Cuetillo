using AgendaCuetillo;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace wea
{
    public partial class frmAgreCon : Form
    {
        public List<Contacto> contactos;
        public frmAgreCon(List<Contacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
            rbM.Select();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre =  txtNombre.Text.ToUpper();
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

                Contacto nuevoContacto = new Contacto(Nombre, ApellPaterno, ApellMaterno, Genero, Telefono, Email, Direccion, Nacimiento);
                contactos.Add(nuevoContacto);
                txtNombre.ResetText();
                txtTelefono.ResetText();
                MessageBox.Show("Se agrego correctamente", "Felicidades");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar correctamente :c", "Error");
            }
        }

        private void frmAgreCon_Load(object sender, EventArgs e)
        {

        }

    }
}
