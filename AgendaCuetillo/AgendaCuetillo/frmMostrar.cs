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


            // Agregar los contactos al DataGridView
            dgvContactos.DataSource = contactos;
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
