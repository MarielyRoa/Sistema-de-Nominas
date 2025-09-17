using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        public decimal salarioBase { get; set; }
        public override decimal calcularPago()
        {
            return pago = (ventasBrutas * tarifaComision) + salarioBase + (salarioBase * 0.10m);
        }

        public override string ObtenerDetalleCalculo()
        {

            decimal bono = salarioBase * 0.10m;
            return $"Tipo de Empleado Asalariado por Comisión ~ Recibe un Salario Base de: {salarioBase:C} mas una Comisión de: {base.calcularPago():C} mas un Extra del 10% del Salario Base de: {bono:C}.";
        }


    }
}
