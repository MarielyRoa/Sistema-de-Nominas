namespace Sistema_de_Nominas
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
            btnEmpleados = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.DarkSlateGray;
            btnEmpleados.FlatAppearance.BorderColor = Color.Black;
            btnEmpleados.FlatAppearance.BorderSize = 100;
            btnEmpleados.FlatAppearance.CheckedBackColor = Color.Black;
            btnEmpleados.FlatStyle = FlatStyle.Popup;
            btnEmpleados.Font = new Font("Gadugi", 10.2F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.Image = Properties.Resources.empLogo;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(558, 47);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(173, 66);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "EMPLEADOS";
            btnEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.DarkSlateGray;
            btnReportes.FlatAppearance.BorderColor = Color.Black;
            btnReportes.FlatAppearance.BorderSize = 100;
            btnReportes.FlatAppearance.CheckedBackColor = Color.Black;
            btnReportes.FlatStyle = FlatStyle.Popup;
            btnReportes.Font = new Font("Gadugi", 10.2F, FontStyle.Bold);
            btnReportes.ForeColor = Color.FromArgb(224, 224, 224);
            btnReportes.Image = Properties.Resources.reportelogo;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(558, 171);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(173, 66);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "REPORTES";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSlateGray;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 100;
            btnSalir.FlatAppearance.CheckedBackColor = Color.Black;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Gadugi", 10.2F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(224, 224, 224);
            btnSalir.Image = Properties.Resources.salirlogo;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(558, 294);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 66);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.imgnomina;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnEmpleados);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEmpleados;
        private Button btnReportes;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
