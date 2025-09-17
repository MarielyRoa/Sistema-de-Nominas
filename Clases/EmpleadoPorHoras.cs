using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class EmpleadoPorHoras : EmpleadoBase
    {
        public decimal sueldoHora { get; set; }
        public decimal horasTrabajadas { get; set; }

        public override decimal calcularPago()
        {
            if (horasTrabajadas <= 40)
            {
                return pago = sueldoHora * horasTrabajadas;
            }
            else
            {
                return pago = (sueldoHora * 40) + (sueldoHora * 1.5m * (horasTrabajadas - 40));
            }
        }
        public override string ObtenerDetalleCalculo()
        {
            if (horasTrabajadas <= 40)
            {
                return $"Tipo de Empleado que trabaja por Horas ~ Recibe un: Sueldo por Hora de: {sueldoHora:C} x {horasTrabajadas} horas trabajadas.";
            }
            else
            {
                decimal pagoExtra = sueldoHora * 1.5m * (horasTrabajadas - 40);
                return $"Tipo de Empleado que trabaja por Horas() ~ Recibe un Sueldo por Hora de: {sueldoHora:C} la hora x 40 horas trabajadas + un pago extra de {pagoExtra:C} por {horasTrabajadas - 40} horas extra.";
            }
        }
    }
}
