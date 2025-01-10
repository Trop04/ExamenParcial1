namespace ExamenParcial1.Formularios
{
    partial class FrmServicios
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
            numericUpDownCosto = new NumericUpDown();
            labelCosto = new Label();
            labelDescripcion = new Label();
            textBoxDescripcion = new TextBox();
            comboBoxVehiculoID = new ComboBox();
            buttonAceptar = new Button();
            labelVehiculoID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownCosto);
            panel1.Controls.Add(labelCosto);
            panel1.Controls.Add(labelDescripcion);
            panel1.Controls.Add(textBoxDescripcion);
            panel1.Controls.Add(comboBoxVehiculoID);
            panel1.Controls.Add(buttonAceptar);
            panel1.Controls.Add(labelVehiculoID);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 365);
            panel1.TabIndex = 16;
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.DecimalPlaces = 2;
            numericUpDownCosto.Location = new Point(276, 133);
            numericUpDownCosto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(90, 23);
            numericUpDownCosto.TabIndex = 22;
            // 
            // labelCosto
            // 
            labelCosto.AutoSize = true;
            labelCosto.Location = new Point(38, 133);
            labelCosto.Name = "labelCosto";
            labelCosto.Size = new Size(38, 15);
            labelCosto.TabIndex = 21;
            labelCosto.Text = "Costo";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(38, 98);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(69, 15);
            labelDescripcion.TabIndex = 17;
            labelDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(114, 95);
            textBoxDescripcion.MaxLength = 500;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(252, 23);
            textBoxDescripcion.TabIndex = 16;
            // 
            // comboBoxVehiculoID
            // 
            comboBoxVehiculoID.FormattingEnabled = true;
            comboBoxVehiculoID.Location = new Point(114, 57);
            comboBoxVehiculoID.Name = "comboBoxVehiculoID";
            comboBoxVehiculoID.Size = new Size(252, 23);
            comboBoxVehiculoID.TabIndex = 15;
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
            // labelVehiculoID
            // 
            labelVehiculoID.AutoSize = true;
            labelVehiculoID.Location = new Point(38, 60);
            labelVehiculoID.Name = "labelVehiculoID";
            labelVehiculoID.Size = new Size(52, 15);
            labelVehiculoID.TabIndex = 14;
            labelVehiculoID.Text = "Vehiculo";
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 389);
            Controls.Add(panel1);
            Name = "FrmServicios";
            Text = "FrmServicios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDownCosto;
        private Label labelCosto;
        private Label labelDescripcion;
        private TextBox textBoxDescripcion;
        private ComboBox comboBoxVehiculoID;
        private Button buttonAceptar;
        private Label labelVehiculoID;
    }
}