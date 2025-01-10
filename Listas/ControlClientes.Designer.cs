namespace ExamenParcial1.Formularios
{
    partial class ControlClientes
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
            listBoxClientes = new ListBox();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonAñadir = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.HorizontalScrollbar = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(3, 75);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(373, 394);
            listBoxClientes.TabIndex = 0;
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
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxClientes);
            panel2.Location = new Point(301, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 475);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(buttonAñadir);
            panel1.Location = new Point(20, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 475);
            panel1.TabIndex = 2;
            // 
            // ControlClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ControlClientes";
            Size = new Size(700, 538);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxClientes;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonAñadir;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}
