namespace wea
{
    partial class frmAgregar
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtAP = new TextBox();
            txtAM = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            dtNacimiento = new DateTimePicker();
            rbF = new RadioButton();
            rbM = new RadioButton();
            txtDNI = new TextBox();
            label10 = new Label();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 51);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 194);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 23);
            txtTelefono.TabIndex = 6;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(65, 366);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(247, 366);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 124);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 159);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 194);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 233);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "E-mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 269);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 11;
            label8.Text = "Direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 310);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 12;
            label9.Text = "Nacimiento:";
            // 
            // txtAP
            // 
            txtAP.Location = new Point(160, 88);
            txtAP.Name = "txtAP";
            txtAP.Size = new Size(197, 23);
            txtAP.TabIndex = 2;
            // 
            // txtAM
            // 
            txtAM.Location = new Point(160, 124);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(197, 23);
            txtAM.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 269);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 8;
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(160, 310);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(200, 23);
            dtNacimiento.TabIndex = 9;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Location = new Point(261, 167);
            rbF.Name = "rbF";
            rbF.Size = new Size(78, 19);
            rbF.TabIndex = 5;
            rbF.TabStop = true;
            rbF.Tag = "Genero";
            rbF.Text = "Femenino";
            rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Location = new Point(160, 167);
            rbM.Name = "rbM";
            rbM.Size = new Size(80, 19);
            rbM.TabIndex = 4;
            rbM.TabStop = true;
            rbM.Tag = "gen";
            rbM.Text = "Masculino";
            rbM.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(160, 14);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(197, 23);
            txtDNI.TabIndex = 0;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 17);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 20;
            label10.Text = "DNI:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(156, 366);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 397);
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
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Contacto";
            FormClosing += frmAgregar_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnSalir;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtAP;
        private TextBox txtAM;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private DateTimePicker dtNacimiento;
        private RadioButton rbF;
        private RadioButton rbM;
        private TextBox txtDNI;
        private Label label10;
        private Button btnNuevo;
    }
}