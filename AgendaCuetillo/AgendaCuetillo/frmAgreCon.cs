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
                string Nombre = txtNombre.Text;
                string ApellPaterno = txtAP.Text;
                string ApellMaterno = txtAM.Text;
                char Genero = 'm';
                if (rbF.IsDisposed)
                {
                    Genero = 'f';
                }
                if (rbM.IsDisposed)
                {
                    Genero = 'm';
                }
                int Telefono = int.Parse(txtTelefono.Text);
                string Email = txtEmail.Text;
                string Direccion = txtDireccion.Text;
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
