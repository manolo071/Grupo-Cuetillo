﻿namespace wea
{
    partial class Form1
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
            label1 = new Label();
            btnAgregar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la Agenda:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(74, 92);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Contacto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(72, 145);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(132, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Contacto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(72, 200);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(74, 242);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(132, 23);
            btnConectar.TabIndex = 4;
            btnConectar.Text = "Conectar DB";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 291);
            Controls.Add(btnConectar);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnMostrar;
        private Button btnSalir;
        private Button btnConectar;
    }
}