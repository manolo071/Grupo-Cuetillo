using AgendaCuetillo;
using System.Diagnostics.Contracts;

namespace wea
{

    public partial class Form1 : Form
    {
        private List<cContacto> contactos = new List<cContacto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar(contactos);

            Agregar.ShowDialog();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar Agregar = new frmMostrar(contactos);
            Agregar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            cConexion objeto = new cConexion();
            objeto.conexionBD();
        }
    }
}