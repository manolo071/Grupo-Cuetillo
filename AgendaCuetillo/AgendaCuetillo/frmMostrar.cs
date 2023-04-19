using AgendaCuetillo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvContactos.Columns["Telefono"].DataPropertyName = "Telefono";

            // Agregar los contactos al DataGridView
            dgvContactos.DataSource = contactos;
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
