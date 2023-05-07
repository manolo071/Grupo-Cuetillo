namespace wea
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarContactoToolStripMenuItem = new ToolStripMenuItem();
            mostrarContactoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            acercaDeAgendaCuetilloToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lblBienvenida = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operacionesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(300, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarContactoToolStripMenuItem, mostrarContactoToolStripMenuItem, salirToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(85, 20);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agregarContactoToolStripMenuItem
            // 
            agregarContactoToolStripMenuItem.Name = "agregarContactoToolStripMenuItem";
            agregarContactoToolStripMenuItem.Size = new Size(168, 22);
            agregarContactoToolStripMenuItem.Text = "Agregar Contacto";
            agregarContactoToolStripMenuItem.Click += agregarContactoToolStripMenuItem_Click;
            // 
            // mostrarContactoToolStripMenuItem
            // 
            mostrarContactoToolStripMenuItem.Name = "mostrarContactoToolStripMenuItem";
            mostrarContactoToolStripMenuItem.Size = new Size(168, 22);
            mostrarContactoToolStripMenuItem.Text = "Mostrar Contacto";
            mostrarContactoToolStripMenuItem.Click += mostrarContactoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(168, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeAgendaCuetilloToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(53, 20);
            acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeAgendaCuetilloToolStripMenuItem
            // 
            acercaDeAgendaCuetilloToolStripMenuItem.Name = "acercaDeAgendaCuetilloToolStripMenuItem";
            acercaDeAgendaCuetilloToolStripMenuItem.Size = new Size(214, 22);
            acercaDeAgendaCuetilloToolStripMenuItem.Text = "Acerca de Agenda Cuetillo";
            acercaDeAgendaCuetilloToolStripMenuItem.Click += acercaDeAgendaCuetilloToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AgendaCuetillo.Properties.Resources._1802667;
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(112, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(66, 15);
            lblBienvenida.TabIndex = 6;
            lblBienvenida.Text = "Bienvenido";
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 330);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Cuetillo 1.0";
            FormClosing += frmAgenda_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem agregarContactoToolStripMenuItem;
        private ToolStripMenuItem mostrarContactoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem acercaDeAgendaCuetilloToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label lblBienvenida;
    }
}