using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class EmpleadoPorComision : EmpleadoBase
    {
        public decimal ventasBrutas { get; set; }
        public decimal tarifaComision { get; set; }
        public override decimal calcularPago()
        {
            return pago = ventasBrutas * tarifaComision;
        }

        public override string ObtenerDetalleCalculo()
        {
            return $"Tipo de Empleado por Comisión ~ Recibe un Pago en base a su: Tarifa de Comisión de: {tarifaComision:P} x ventas brutas de {ventasBrutas:C}.";
        }
    }
}
