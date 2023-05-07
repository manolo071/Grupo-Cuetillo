using AgendaCuetillo;
using System.Diagnostics.Contracts;

namespace wea
{

    public partial class frmAgenda : Form
    {
        private List<cContacto> contactos = new List<cContacto>();
        public frmAgenda(string User)
        {
            InitializeComponent();
            lblBienvenida.Text += " " + User;
        }
        private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar(contactos);

            Agregar.Show();
        }

        private void mostrarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar Agregar = new frmMostrar(contactos);
            Agregar.Show();
        }

        private void acercaDeAgendaCuetilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGENDA CUETILLO\n\nAgenda Cuetillo version 1.0 64 bits\n\nCuetilloDevs:\n\n\t*Jimy Moises Mamani Diaz\n\t*Juan Manuel Huayta Mayta\n\t*Roy Ademir Farfan Ordoñez\n\t*Andre Josias Sequeiros Carcagno", "Acerca de Agenda Cuetillo");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrar();
        }

        private void cerrar()
        {
            Environment.Exit(1);
        }
    }
}