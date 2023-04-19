using AgendaCuetillo;
using System.Windows.Forms;

namespace wea
{
    public partial class frmAgreCon : Form
    {
        public List<Contacto> contactos;
        public frmAgreCon(List<Contacto> contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
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
                int Numero = int.Parse(txtNumero.Text);
                Contacto nuevoContacto = new Contacto(Nombre, Numero);
                contactos.Add(nuevoContacto);
                txtNombre.ResetText();
                txtNumero.ResetText();
                MessageBox.Show("Se agrego correctamente","Felicidades");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar correctamente :c", "Error");
            }
        }
    }
}
