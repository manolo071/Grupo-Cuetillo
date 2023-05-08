namespace AgendaCuetillo
{
    partial class frmLogin
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
            pbLogin = new PictureBox();
            btnIniciar = new Button();
            btnSalir = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pbPassword = new PictureBox();
            pbUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // pbLogin
            // 
            pbLogin.Image = Properties.Resources.login1;
            pbLogin.Location = new Point(35, 12);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(164, 159);
            pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin.TabIndex = 0;
            pbLogin.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(35, 275);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(141, 275);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(66, 191);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(66, 232);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 23);
            txtPassword.TabIndex = 4;
            // 
            // pbPassword
            // 
            pbPassword.Image = Properties.Resources.password;
            pbPassword.Location = new Point(35, 232);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(21, 23);
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 6;
            pbPassword.TabStop = false;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.user;
            pbUser.Location = new Point(35, 191);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(21, 23);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 5;
            pbUser.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(242, 320);
            Controls.Add(pbPassword);
            Controls.Add(pbUser);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(pbLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogin;
        private Button btnIniciar;
        private Button btnSalir;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox pbPassword;
        private PictureBox pbUser;
    }
}