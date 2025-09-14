using Sistema_de_Nominas.Clases;

namespace Sistema_de_Nominas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Validaciones validarSalida = new Validaciones();
            validarSalida.ValidacionSalir();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados FormularioEmpleados = new FormEmpleados();
            this.Hide();
            FormularioEmpleados.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            this.Hide();
            reporte.ShowDialog();
        }
    }
}
