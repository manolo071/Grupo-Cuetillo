using AgendaCuetillo;
using System.Diagnostics.Contracts;

namespace wea
{

    public partial class Form1 : Form
    {
        private List<Contacto> contactos = new List<Contacto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgreCon Agregar = new frmAgreCon(contactos);
            
            Agregar.ShowDialog();
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar Agregar = new frmMostrar(contactos);
            Agregar.ShowDialog();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}