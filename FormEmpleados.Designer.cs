namespace Sistema_de_Nominas
{
    partial class FormEmpleados
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
            btnActualizar = new Button();
            txtpago = new TextBox();
            label11 = new Label();
            btnCalcularPago = new Button();
            btnGuardar = new Button();
            txthorasTrabajadas = new TextBox();
            txtsalarioBase = new TextBox();
            txtcomision = new TextBox();
            txtventasBrutas = new TextBox();
            txtsueldoHora = new TextBox();
            txtsalSemanal = new TextBox();
            txtseguroSocial = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            cmbxTipoEmpleado = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label12 = new Label();
            txtEmpleado = new TextBox();
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 96);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkSlateGray;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.FromArgb(224, 224, 224);
            btnActualizar.Image = Properties.Resources.actualizarlogo;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(848, 584);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(172, 61);
            btnActualizar.TabIndex = 54;
            btnActualizar.Text = "Actualizar Datos";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtpago
            // 
            txtpago.BackColor = Color.Yellow;
            txtpago.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpago.Location = new Point(661, 304);
            txtpago.Name = "txtpago";
            txtpago.Size = new Size(125, 28);
            txtpago.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label11.Location = new Point(508, 307);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 52;
            label11.Text = "Pago Calculado: ";
            // 
            // btnCalcularPago
            // 
            btnCalcularPago.BackColor = Color.DarkSlateGray;
            btnCalcularPago.FlatStyle = FlatStyle.Popup;
            btnCalcularPago.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            btnCalcularPago.ForeColor = Color.FromArgb(224, 224, 224);
            btnCalcularPago.Image = Properties.Resources.pagosLogo;
            btnCalcularPago.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcularPago.Location = new Point(848, 358);
            btnCalcularPago.Name = "btnCalcularPago";
            btnCalcularPago.RightToLeft = RightToLeft.No;
            btnCalcularPago.Size = new Size(172, 62);
            btnCalcularPago.TabIndex = 51;
            btnCalcularPago.Text = "Calcular Pago";
            btnCalcularPago.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcularPago.UseVisualStyleBackColor = false;
            btnCalcularPago.Click += btnCalcularPago_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSlateGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(224, 224, 224);
            btnGuardar.Image = Properties.Resources.guardarlogo;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(848, 471);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 62);
            btnGuardar.TabIndex = 50;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txthorasTrabajadas
            // 
            txthorasTrabajadas.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txthorasTrabajadas.Location = new Point(693, 238);
            txthorasTrabajadas.Name = "txthorasTrabajadas";
            txthorasTrabajadas.Size = new Size(61, 28);
            txthorasTrabajadas.TabIndex = 49;
            // 
            // txtsalarioBase
            // 
            txtsalarioBase.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtsalarioBase.Location = new Point(693, 190);
            txtsalarioBase.Name = "txtsalarioBase";
            txtsalarioBase.Size = new Size(125, 28);
            txtsalarioBase.TabIndex = 48;
            // 
            // txtcomision
            // 
            txtcomision.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtcomision.Location = new Point(693, 148);
            txtcomision.Name = "txtcomision";
            txtcomision.Size = new Size(93, 28);
            txtcomision.TabIndex = 47;
            // 
            // txtventasBrutas
            // 
            txtventasBrutas.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtventasBrutas.Location = new Point(693, 104);
            txtventasBrutas.Name = "txtventasBrutas";
            txtventasBrutas.Size = new Size(125, 28);
            txtventasBrutas.TabIndex = 46;
            // 
            // txtsueldoHora
            // 
            txtsueldoHora.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtsueldoHora.Location = new Point(236, 279);
            txtsueldoHora.Name = "txtsueldoHora";
            txtsueldoHora.Size = new Size(82, 28);
            txtsueldoHora.TabIndex = 45;
            // 
            // txtsalSemanal
            // 
            txtsalSemanal.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtsalSemanal.Location = new Point(236, 234);
            txtsalSemanal.Name = "txtsalSemanal";
            txtsalSemanal.Size = new Size(82, 28);
            txtsalSemanal.TabIndex = 44;
            // 
            // txtseguroSocial
            // 
            txtseguroSocial.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtseguroSocial.Location = new Point(236, 190);
            txtseguroSocial.Name = "txtseguroSocial";
            txtseguroSocial.Size = new Size(216, 28);
            txtseguroSocial.TabIndex = 43;
            // 
            // txtapellido
            // 
            txtapellido.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtapellido.Location = new Point(236, 148);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(216, 28);
            txtapellido.TabIndex = 42;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            txtnombre.Location = new Point(236, 104);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(216, 28);
            txtnombre.TabIndex = 41;
            // 
            // cmbxTipoEmpleado
            // 
            cmbxTipoEmpleado.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            cmbxTipoEmpleado.FormattingEnabled = true;
            cmbxTipoEmpleado.Items.AddRange(new object[] { "Empleado asalariado", "Empleado por horas", "Empleado por comision", "Empleado asalariado por comision" });
            cmbxTipoEmpleado.Location = new Point(562, 48);
            cmbxTipoEmpleado.Name = "cmbxTipoEmpleado";
            cmbxTipoEmpleado.Size = new Size(316, 28);
            cmbxTipoEmpleado.TabIndex = 40;
            cmbxTipoEmpleado.SelectedIndexChanged += cmbxTipoEmpleado_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label10.Location = new Point(385, 56);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 39;
            label10.Text = "Tipo de empleado: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label9.Location = new Point(508, 197);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 38;
            label9.Text = "Salario Base: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label8.Location = new Point(508, 155);
            label8.Name = "label8";
            label8.Size = new Size(177, 20);
            label8.TabIndex = 37;
            label8.Text = "Tarifa de Comision: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label7.Location = new Point(508, 111);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 36;
            label7.Text = "Ventas brutas: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label6.Location = new Point(508, 241);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 35;
            label6.Text = "Horas Trabajadas: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label5.Location = new Point(16, 281);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 34;
            label5.Text = "Sueldo por hora: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label4.Location = new Point(16, 236);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 33;
            label4.Text = "Salario semanal: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label3.Location = new Point(15, 192);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 32;
            label3.Text = "Numero de seguro social: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label2.Location = new Point(16, 150);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 31;
            label2.Text = "Apellido Paterno: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            label12.Location = new Point(16, 106);
            label12.Name = "label12";
            label12.Size = new Size(147, 20);
            label12.TabIndex = 30;
            label12.Text = "Primer Nombre: ";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(16, 338);
            txtEmpleado.Multiline = true;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.ScrollBars = ScrollBars.Both;
            txtEmpleado.Size = new Size(817, 359);
            txtEmpleado.TabIndex = 57;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Yellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1051, 28);
            menuStrip1.TabIndex = 58;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.Image = Properties.Resources.menulgo;
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(163, 24);
            principalToolStripMenuItem.Text = "Menu Principal";
            principalToolStripMenuItem.Click += principalToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = Properties.Resources.salirlogo;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(79, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1051, 707);
            Controls.Add(txtEmpleado);
            Controls.Add(btnActualizar);
            Controls.Add(txtpago);
            Controls.Add(label11);
            Controls.Add(btnCalcularPago);
            Controls.Add(btnGuardar);
            Controls.Add(txthorasTrabajadas);
            Controls.Add(txtsalarioBase);
            Controls.Add(txtcomision);
            Controls.Add(txtventasBrutas);
            Controls.Add(txtsueldoHora);
            Controls.Add(txtsalSemanal);
            Controls.Add(txtseguroSocial);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(cmbxTipoEmpleado);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnActualizar;
        private TextBox txtpago;
        private Label label11;
        private Button btnCalcularPago;
        private Button btnGuardar;
        private TextBox txthorasTrabajadas;
        private TextBox txtsalarioBase;
        private TextBox txtcomision;
        private TextBox txtventasBrutas;
        private TextBox txtsueldoHora;
        private TextBox txtsalSemanal;
        private TextBox txtseguroSocial;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private ComboBox cmbxTipoEmpleado;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label12;
        private TextBox txtEmpleado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}