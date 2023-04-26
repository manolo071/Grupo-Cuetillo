namespace wea
{
    partial class frmAgreCon
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
            btnCancelar = new Button();
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(157, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 23);
            txtTelefono.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(72, 339);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(221, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 167);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 206);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "E-mail:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 242);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 11;
            label8.Text = "Direccion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 283);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 12;
            label9.Text = "Nacimiento:";
            // 
            // txtAP
            // 
            txtAP.Location = new Point(157, 61);
            txtAP.Name = "txtAP";
            txtAP.Size = new Size(197, 23);
            txtAP.TabIndex = 13;
            // 
            // txtAM
            // 
            txtAM.Location = new Point(157, 97);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(197, 23);
            txtAM.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(157, 242);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 16;
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(157, 283);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(200, 23);
            dtNacimiento.TabIndex = 17;
            // 
            // rbF
            // 
            rbF.AutoSize = true;
            rbF.Location = new Point(258, 140);
            rbF.Name = "rbF";
            rbF.Size = new Size(78, 19);
            rbF.TabIndex = 18;
            rbF.TabStop = true;
            rbF.Tag = "Genero";
            rbF.Text = "Femenino";
            rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Location = new Point(157, 140);
            rbM.Name = "rbM";
            rbM.Size = new Size(80, 19);
            rbM.TabIndex = 19;
            rbM.TabStop = true;
            rbM.Tag = "gen";
            rbM.Text = "Masculino";
            rbM.UseVisualStyleBackColor = true;
            // 
            // frmAgreCon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 397);
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
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmAgreCon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Contacto";
            Load += frmAgreCon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnCancelar;
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
    }
}