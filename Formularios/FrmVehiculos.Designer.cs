namespace ExamenParcial1.Formularios
{
    partial class FrmVehiculos
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
            labelClienteID = new Label();
            buttonAceptar = new Button();
            panel1 = new Panel();
            numericUpDownAnio = new NumericUpDown();
            labelAnio = new Label();
            labelModelo = new Label();
            textBoxModelo = new TextBox();
            labelMarca = new Label();
            textBoxMarca = new TextBox();
            comboBoxClienteID = new ComboBox();
            labelPlaca = new Label();
            textBoxPlaca = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).BeginInit();
            SuspendLayout();
            // 
            // labelClienteID
            // 
            labelClienteID.AutoSize = true;
            labelClienteID.Location = new Point(38, 60);
            labelClienteID.Name = "labelClienteID";
            labelClienteID.Size = new Size(44, 15);
            labelClienteID.TabIndex = 14;
            labelClienteID.Text = "Cliente";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(160, 321);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 13;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPlaca);
            panel1.Controls.Add(textBoxPlaca);
            panel1.Controls.Add(numericUpDownAnio);
            panel1.Controls.Add(labelAnio);
            panel1.Controls.Add(labelModelo);
            panel1.Controls.Add(textBoxModelo);
            panel1.Controls.Add(labelMarca);
            panel1.Controls.Add(textBoxMarca);
            panel1.Controls.Add(comboBoxClienteID);
            panel1.Controls.Add(buttonAceptar);
            panel1.Controls.Add(labelClienteID);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 365);
            panel1.TabIndex = 15;
            // 
            // numericUpDownAnio
            // 
            numericUpDownAnio.Location = new Point(276, 171);
            numericUpDownAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownAnio.Name = "numericUpDownAnio";
            numericUpDownAnio.Size = new Size(90, 23);
            numericUpDownAnio.TabIndex = 22;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Location = new Point(38, 179);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(29, 15);
            labelAnio.TabIndex = 21;
            labelAnio.Text = "Año";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(38, 138);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(48, 15);
            labelModelo.TabIndex = 19;
            labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(114, 135);
            textBoxModelo.MaxLength = 50;
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(252, 23);
            textBoxModelo.TabIndex = 18;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(38, 98);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(40, 15);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(114, 95);
            textBoxMarca.MaxLength = 50;
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(252, 23);
            textBoxMarca.TabIndex = 16;
            // 
            // comboBoxClienteID
            // 
            comboBoxClienteID.FormattingEnabled = true;
            comboBoxClienteID.Location = new Point(114, 57);
            comboBoxClienteID.Name = "comboBoxClienteID";
            comboBoxClienteID.Size = new Size(252, 23);
            comboBoxClienteID.TabIndex = 15;
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(38, 212);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(35, 15);
            labelPlaca.TabIndex = 24;
            labelPlaca.Text = "Placa";
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(238, 209);
            textBoxPlaca.MaxLength = 20;
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(128, 23);
            textBoxPlaca.TabIndex = 23;
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 389);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmVehiculos";
            Text = "FrmVehiculos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelClienteID;
        private Button buttonAceptar;
        private Panel panel1;
        private ComboBox comboBoxClienteID;
        private Label labelAnio;
        private Label labelModelo;
        private TextBox textBoxModelo;
        private Label labelMarca;
        private TextBox textBoxMarca;
        private NumericUpDown numericUpDownAnio;
        private Label labelPlaca;
        private TextBox textBoxPlaca;
    }
}