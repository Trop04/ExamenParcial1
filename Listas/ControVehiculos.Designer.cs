﻿namespace ExamenParcial1.Listas
{
    partial class ControVehiculos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            listBoxVehiculos = new ListBox();
            panel1 = new Panel();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonAñadir = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxVehiculos);
            panel2.Location = new Point(301, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 475);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(122, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 6;
            label1.Text = "Vehiculos";
            // 
            // listBoxVehiculos
            // 
            listBoxVehiculos.FormattingEnabled = true;
            listBoxVehiculos.HorizontalScrollbar = true;
            listBoxVehiculos.ItemHeight = 15;
            listBoxVehiculos.Location = new Point(3, 75);
            listBoxVehiculos.Name = "listBoxVehiculos";
            listBoxVehiculos.Size = new Size(373, 394);
            listBoxVehiculos.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(buttonAñadir);
            panel1.Location = new Point(20, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 475);
            panel1.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(98, 247);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(98, 218);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Location = new Point(98, 189);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(75, 23);
            buttonAñadir.TabIndex = 0;
            buttonAñadir.Text = "Añadir";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // ControVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ControVehiculos";
            Size = new Size(700, 538);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ListBox listBoxVehiculos;
        private Panel panel1;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonAñadir;
        private Label label1;
    }
}
