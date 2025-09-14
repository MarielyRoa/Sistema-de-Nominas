using Microsoft.Data.SqlClient;
using Sistema_de_Nominas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nominas
{
    public partial class FormEmpleados : Form
    {
        int Indice = -1;
        EmpleadoDB empleadodb = new EmpleadoDB();
        Validaciones validar = new Validaciones();
        EmpleadoBase emp = null;
        public FormEmpleados()
        {
            InitializeComponent();
            Indice = -1;
        }

        private void cmbxTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtseguroSocial.Enabled = false;
            txtsalSemanal.Enabled = false;
            txtsueldoHora.Enabled = false;
            txthorasTrabajadas.Enabled = false;
            txtcomision.Enabled = false;
            txtsalarioBase.Enabled = false;
            txtventasBrutas.Enabled = false;
            txtpago.Enabled = false;
            

            switch (cmbxTipoEmpleado.SelectedItem.ToString())
            {
                case "Empleado asalariado":
                    txtnombre.Enabled = true;
                    txtapellido.Enabled = true;
                    txtseguroSocial.Enabled = true;
                    txtsalSemanal.Enabled = true;
                    break;

                case "Empleado por horas":
                    txtapellido.Enabled = true;
                    txtseguroSocial.Enabled = true;
                    txthorasTrabajadas.Enabled = true;
                    txtsueldoHora.Enabled = true;
                    break;

                case "Empleado por comision":
                    txtnombre.Enabled = true;
                    txtapellido.Enabled = true;
                    txtseguroSocial.Enabled = true;
                    txtventasBrutas.Enabled = true;
                    txtcomision.Enabled = true;
                    break;

                case "Empleado asalariado por comision":
                    txtnombre.Enabled = true;
                    txtapellido.Enabled = true;
                    txtseguroSocial.Enabled = true;
                    txtventasBrutas.Enabled = true;
                    txtcomision.Enabled = true;
                    txtsalarioBase.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Seleccione un tipo de empleado");
                    break;
            }
        }

        private void btnCalcularPago_Click(object sender, EventArgs e)
        {
            if (!validar.ValidarSeleccionEmpleado(cmbxTipoEmpleado))
                return;

            try
            {

                decimal pagoCalculado = 0m;

                switch (cmbxTipoEmpleado.SelectedItem.ToString())
                {
                    case "Empleado asalariado":
                        emp = new EmpleadoAsalariado
                        {
                            primerNombre = txtnombre.Text,
                            apellidoPaterno = txtapellido.Text,
                            numeroSeguroSocial = txtseguroSocial.Text,
                            salarioSemanal = decimal.Parse(txtsalSemanal.Text)
                        };
                        pagoCalculado = emp.calcularPago();

                        break;

                    case "Empleado por horas":
                        emp = new EmpleadoPorHoras
                        {
                            apellidoPaterno = txtapellido.Text,
                            numeroSeguroSocial = txtseguroSocial.Text,
                            horasTrabajadas = decimal.Parse(txthorasTrabajadas.Text),
                            sueldoHora = decimal.Parse(txtsueldoHora.Text)
                        };
                        pagoCalculado = emp.calcularPago();
                        break;

                    case "Empleado por comision":
                        emp = new EmpleadoPorComision
                        {
                            primerNombre = txtnombre.Text,
                            apellidoPaterno = txtapellido.Text,
                            numeroSeguroSocial = txtseguroSocial.Text,
                            ventasBrutas = decimal.Parse(txtventasBrutas.Text),
                            tarifaComision = decimal.Parse(txtcomision.Text)
                        };
                        pagoCalculado = emp.calcularPago();
                        break;

                    case "Empleado asalariado por comision":
                        emp = new EmpleadoAsalariadoPorComision
                        {
                            primerNombre = txtnombre.Text,
                            apellidoPaterno = txtapellido.Text,
                            numeroSeguroSocial = txtseguroSocial.Text,
                            ventasBrutas = decimal.Parse(txtventasBrutas.Text),
                            tarifaComision = decimal.Parse(txtcomision.Text),
                            salarioBase = decimal.Parse(txtsalarioBase.Text)
                        };
                        pagoCalculado = emp.calcularPago();
                        break;
                    default:
                        MessageBox.Show("Datos no validos");
                        return;
                }

                txtpago.Text = pagoCalculado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese solo numeros en los campos correspondientes.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var empleados = empleadodb.ObtenerEmpleados();

            if (Indice >= 0)
            {
                btnCalcularPago_Click(sender, e);

                if (Indice < empleados.Count)
                {
                    empleados[Indice] = emp;
                    MessageBox.Show("Datos del empleado Actualizados");
                }
                else
                {
                    MessageBox.Show("Indice fuera de rango");
                    Indice = -1;
                    return;
                }
            }
            else
            {

                foreach (var existe in empleados)
                {
                    if (existe.numeroSeguroSocial == txtseguroSocial.Text)
                    {
                        MessageBox.Show("El numero de seguro social insertado ya existe");
                        return;
                    }
                }
                if (!validar.ValidarCalculoPago(txtpago))
                    return;

                empleadodb.AgregarEmpleado(emp);
                MessageBox.Show("Empleado Registrado");
            }

            txtEmpleado.Clear();
            foreach (var listemp in empleados)
            {
                txtEmpleado.AppendText(listemp.ToString() + Environment.NewLine);
            }

            txtnombre.Clear();
            txtapellido.Clear();
            txtseguroSocial.Clear();
            txtsalSemanal.Clear();
            txtsueldoHora.Clear();
            txthorasTrabajadas.Clear();
            txtventasBrutas.Clear();
            txtcomision.Clear();
            txtsalarioBase.Clear();
            txtpago.Clear();

            Indice = -1;
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {

            String NumSocial = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de seguro social del empleado: ");

            var empleados = empleadodb.ObtenerEmpleados();
            Indice = empleados.FindIndex(emp => emp.numeroSeguroSocial == NumSocial);

            if (Indice == -1)
            {
                MessageBox.Show("No se encontro el empleado");
                return;
            }

            var employee = empleados[Indice];
            txtnombre.Text = employee.primerNombre;
            txtapellido.Text = employee.apellidoPaterno;
            txtseguroSocial.Text = employee.numeroSeguroSocial;
            txtpago.Text = employee.calcularPago().ToString();

            if (employee is EmpleadoAsalariado)
            {
                txtsalSemanal.Text = ((EmpleadoAsalariado)employee).salarioSemanal.ToString();
            }
            else if (employee is EmpleadoPorHoras)
            {
                txthorasTrabajadas.Text = ((EmpleadoPorHoras)employee).horasTrabajadas.ToString();
                txtsueldoHora.Text = ((EmpleadoPorHoras)employee).sueldoHora.ToString();

            }
            else if (employee is EmpleadoPorComision)
            {
                txtventasBrutas.Text = ((EmpleadoPorComision)employee).ventasBrutas.ToString();
                txtcomision.Text = ((EmpleadoPorComision)employee).tarifaComision.ToString();
            }
            else if (employee is EmpleadoAsalariadoPorComision)
            {
                txtventasBrutas.Text = ((EmpleadoAsalariadoPorComision)employee).ventasBrutas.ToString();
                txtcomision.Text = ((EmpleadoAsalariadoPorComision)employee).tarifaComision.ToString();
                txtsalarioBase.Text = ((EmpleadoAsalariadoPorComision)employee).salarioBase.ToString();
            }

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Form1 FormularioMenu = new Form1();
             this.Close();
              FormularioMenu.Show();
         }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validaciones validarSalida = new Validaciones();
            validarSalida.ValidacionSalir();
        }
    }
}


