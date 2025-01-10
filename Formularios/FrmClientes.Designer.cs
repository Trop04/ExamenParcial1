namespace ExamenParcial1.Formularios
{
    partial class FrmClientes
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
            panel1 = new Panel();
            labelDirecc = new Label();
            labelEmail = new Label();
            labelTelefono = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            buttonAceptar = new Button();
            textBoxDirecc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelDirecc);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelTelefono);
            panel1.Controls.Add(labelApellido);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(buttonAceptar);
            panel1.Controls.Add(textBoxDirecc);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxTelefono);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(textBoxNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 365);
            panel1.TabIndex = 0;
            // 
            // labelDirecc
            // 
            labelDirecc.AutoSize = true;
            labelDirecc.Location = new Point(41, 220);
            labelDirecc.Name = "labelDirecc";
            labelDirecc.Size = new Size(57, 15);
            labelDirecc.TabIndex = 15;
            labelDirecc.Text = "Dirección";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(41, 182);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(41, 144);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(53, 15);
            labelTelefono.TabIndex = 13;
            labelTelefono.Text = "Teléfono";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(41, 104);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 12;
            labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(41, 63);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(178, 307);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 10;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // textBoxDirecc
            // 
            textBoxDirecc.Location = new Point(107, 220);
            textBoxDirecc.MaxLength = 200;
            textBoxDirecc.Name = "textBoxDirecc";
            textBoxDirecc.Size = new Size(232, 23);
            textBoxDirecc.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(107, 182);
            textBoxEmail.MaxLength = 100;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(232, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(107, 144);
            textBoxTelefono.MaxLength = 15;
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(232, 23);
            textBoxTelefono.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(107, 104);
            textBoxApellido.MaxLength = 100;
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(232, 23);
            textBoxApellido.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(107, 63);
            textBoxNombre.MaxLength = 100;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(232, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 389);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmClientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxDirecc;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefono;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Button buttonAceptar;
        private Label labelDirecc;
        private Label labelEmail;
        private Label labelTelefono;
        private Label labelApellido;
        private Label labelNombre;
    }
}