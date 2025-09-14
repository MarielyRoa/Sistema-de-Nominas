using Sistema_de_Nominas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nominas
{
    public partial class Reportes : Form
    {
        EmpleadoDB empleadodb = new EmpleadoDB();
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
           var empleados = empleadodb.ObtenerEmpleados();
            if (empleados.Count == 0)
            {
               MessageBox.Show("No hay empleados registrados");
                return;
            }

            txtReporte.Clear();

            foreach (var reporte in empleados)
            {
                txtReporte.AppendText(reporte.ToString() + Environment.NewLine);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validaciones validarSalida = new Validaciones();
            validarSalida.ValidacionSalir();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormularioMenu = new Form1();
            this.Close();
            FormularioMenu.Show();
        }
    }
}

