﻿namespace wea
{
    partial class frmMostrar
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
            Salir = new Button();
            dgvContactos = new DataGridView();
            cbFiltro = new ComboBox();
            txtFiltro = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscador";
            // 
            // Salir
            // 
            Salir.Location = new Point(430, 307);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 2;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(12, 69);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowTemplate.Height = 25;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(938, 205);
            dgvContactos.TabIndex = 3;
            // 
            // cbFiltro
            // 
            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.IntegralHeight = false;
            cbFiltro.Items.AddRange(new object[] { "DNI", "Nombre", "Ape Paterno", "Ape Materno", "Genero", "Telefono", "Email", "Direccion" });
            cbFiltro.Location = new Point(126, 30);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(121, 23);
            cbFiltro.TabIndex = 4;
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(287, 30);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(240, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            txtFiltro.KeyPress += txtFiltro_KeyPress;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(552, 33);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 342);
            Controls.Add(btnLimpiar);
            Controls.Add(txtFiltro);
            Controls.Add(cbFiltro);
            Controls.Add(dgvContactos);
            Controls.Add(Salir);
            Controls.Add(label1);
            Name = "frmMostrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button Salir;
        private DataGridView dgvContactos;
        private ComboBox cbFiltro;
        private TextBox txtFiltro;
        private Button btnLimpiar;
    }
}