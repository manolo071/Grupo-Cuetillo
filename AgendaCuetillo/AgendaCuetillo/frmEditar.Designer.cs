namespace AgendaCuetillo
{
    partial class frmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            txtDNI = new TextBox();
            label10 = new Label();
            rbM = new RadioButton();
            rbF = new RadioButton();
            dtNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtAM = new TextBox();
            txtAP = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            btnModificar = new Button();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            dgvContactos = new DataGridView();
            btnCancelar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Enabled = false;
            btnNuevo.Location = new Point(349, 394);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 44;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(353, 42);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(197, 23);
            txtDNI.TabIndex = 43;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 50);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 42;
            label10.Text = "DNI:";
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Enabled = false;
            rbM.Location = new Point(353, 195);
            rbM.Name = "rbM";
            rbM.Size = new Size(80, 19);
            rbM.TabIndex = 41;
            rbM.TabStop = true;
            rbM.Tag = "gen";
            rbM.Text = "Masculino";
            rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Enabled = false;
            rbF.Location = new Point(454, 195);
            rbF.Name = "rbF";
            rbF.Size = new Size(78, 19);
            rbF.TabIndex = 40;
            rbF.TabStop = true;
            rbF.Tag = "Genero";
            rbF.Text = "Femenino";
            rbF.UseVisualStyleBackColor = true;
            // 
            // dtNacimiento
            // 
            dtNacimiento.Enabled = false;
            dtNacimiento.Location = new Point(353, 338);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(200, 23);
            dtNacimiento.TabIndex = 39;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(353, 297);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(353, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 37;
            // 
            // txtAM
            // 
            txtAM.Enabled = false;
            txtAM.Location = new Point(353, 152);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(197, 23);
            txtAM.TabIndex = 36;
            txtAM.KeyPress += txtAM_KeyPress;
            // 
            // txtAP
            // 
            txtAP.Enabled = false;
            txtAP.Location = new Point(353, 116);
            txtAP.Name = "txtAP";
            txtAP.Size = new Size(197, 23);
            txtAP.TabIndex = 35;
            txtAP.KeyPress += txtAP_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 346);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 34;
            label9.Text = "Nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 305);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 33;
            label8.Text = "Direccion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 269);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 32;
            label7.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 230);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 31;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 197);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 30;
            label5.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 160);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 29;
            label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 124);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 28;
            label3.Text = "Apellido Paterno:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(538, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(258, 394);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Guardar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(353, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 23);
            txtTelefono.TabIndex = 25;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(353, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 24;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 84);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 23;
            label1.Text = "Nombre:";
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(16, 468);
            dgvContactos.MultiSelect = false;
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowTemplate.Height = 25;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(772, 356);
            dgvContactos.TabIndex = 45;
            dgvContactos.SelectionChanged += dgvContactos_SelectionChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(444, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(208, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 47;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(353, 9);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 48;
            // 
            // frmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 836);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnCancelar);
            Controls.Add(dgvContactos);
            Controls.Add(btnNuevo);
            Controls.Add(txtDNI);
            Controls.Add(label10);
            Controls.Add(rbM);
            Controls.Add(rbF);
            Controls.Add(dtNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtAM);
            Controls.Add(txtAP);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Contacto";
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private TextBox txtDNI;
        private Label label10;
        private RadioButton rbM;
        private RadioButton rbF;
        private DateTimePicker dtNacimiento;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtAM;
        private TextBox txtAP;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSalir;
        private Button btnModificar;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label label1;
        private DataGridView dgvContactos;
        private Button btnCancelar;
        private Label lblId;
        private TextBox txtId;
    }
}