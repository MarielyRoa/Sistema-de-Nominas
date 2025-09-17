using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class EmpleadoAsalariado : EmpleadoBase
    {
        public decimal salarioSemanal { get; set; }

        public override decimal calcularPago()
        {
            return pago = salarioSemanal;
        }

        public override string ObtenerDetalleCalculo()
        {
            return $"Tipo de Empleado Asalariado ~ Recibe un Salario Semanal de: {salarioSemanal:C}";
        }
    }
}
