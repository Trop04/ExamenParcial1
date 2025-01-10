namespace ExamenParcial1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            PanelMenu = new Panel();
            PanelPrincipal = new Panel();
            PanelMenu.SuspendLayout();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Green;
            button1.Location = new Point(3, 24);
            button1.Name = "button1";
            button1.Size = new Size(137, 60);
            button1.TabIndex = 0;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Green;
            button2.Location = new Point(285, 24);
            button2.Name = "button2";
            button2.Size = new Size(137, 60);
            button2.TabIndex = 1;
            button2.Text = "Vehículos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Green;
            button3.Location = new Point(560, 24);
            button3.Name = "button3";
            button3.Size = new Size(137, 60);
            button3.TabIndex = 2;
            button3.Text = "Servicios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(171, 203);
            label1.Name = "label1";
            label1.Size = new Size(344, 119);
            label1.TabIndex = 3;
            label1.Text = "Taller Automotriz";
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.Green;
            PanelMenu.Controls.Add(button1);
            PanelMenu.Controls.Add(button2);
            PanelMenu.Controls.Add(button3);
            PanelMenu.Location = new Point(12, 556);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(700, 109);
            PanelMenu.TabIndex = 4;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Location = new Point(12, 12);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(700, 538);
            PanelPrincipal.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 677);
            Controls.Add(PanelPrincipal);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Taller Automotriz";
            PanelMenu.ResumeLayout(false);
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Panel PanelMenu;
        private Panel PanelPrincipal;
    }
}
