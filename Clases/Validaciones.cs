using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class Validaciones
    {
        public void ValidacionSalir()
        {
            DialogResult Mensaje = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        public bool ValidarSeleccionEmpleado(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidarCalculoPago(TextBox txtpago)
        {
            if (String.IsNullOrWhiteSpace(txtpago.Text))
            {
                MessageBox.Show("Por favor calcule el pago primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
