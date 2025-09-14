namespace Sistema_de_Nominas
{
    partial class Reportes
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
            txtReporte = new TextBox();
            btnreport = new Button();
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 70);
            label1.Name = "label1";
            label1.Size = new Size(347, 36);
            label1.TabIndex = 1;
            label1.Text = "REPORTES SEMANALES";
            // 
            // txtReporte
            // 
            txtReporte.Location = new Point(35, 149);
            txtReporte.Multiline = true;
            txtReporte.Name = "txtReporte";
            txtReporte.ScrollBars = ScrollBars.Both;
            txtReporte.Size = new Size(823, 376);
            txtReporte.TabIndex = 59;
            // 
            // btnreport
            // 
            btnreport.BackColor = Color.DarkSlateGray;
            btnreport.FlatStyle = FlatStyle.Popup;
            btnreport.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            btnreport.ForeColor = Color.FromArgb(224, 224, 224);
            btnreport.Image = Properties.Resources.reportelogo;
            btnreport.ImageAlign = ContentAlignment.MiddleLeft;
            btnreport.Location = new Point(693, 50);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(165, 67);
            btnreport.TabIndex = 60;
            btnreport.Text = "Imprimir Reporte";
            btnreport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
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
            menuStrip1.Size = new Size(935, 28);
            menuStrip1.TabIndex = 61;
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
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(935, 555);
            Controls.Add(menuStrip1);
            Controls.Add(btnreport);
            Controls.Add(txtReporte);
            Controls.Add(label1);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtReporte;
        private Button btnreport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}