using System.Diagnostics.Contracts;

namespace wea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgreCon Agregar = new frmAgreCon();
            Agregar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar Agregar = new frmMostrar();
            Agregar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}