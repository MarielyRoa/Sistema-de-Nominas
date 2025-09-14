using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public abstract class EmpleadoBase
    {
        public string primerNombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string numeroSeguroSocial { get; set; }
        public decimal pago { get; set; }

        public abstract decimal calcularPago();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("═══════════════════════════════════════════════════════════");
            sb.AppendLine($"    📄 RECIBO DE PAGO - {primerNombre} {apellidoPaterno}");
            sb.AppendLine("═══════════════════════════════════════════════════════════");
            sb.AppendLine($"    🆔 Seguro Social: {numeroSeguroSocial}");
            sb.AppendLine($"    💵 MONTO TOTAL: {calcularPago():C}");
            sb.AppendLine("───────────────────────────────────────────────────────────");
            sb.AppendLine("     📊 DETALLES DEL CALCULO DE PAGO:");
            sb.AppendLine($"    {ObtenerDetalleCalculo()}");
            sb.AppendLine("═══════════════════════════════════════════════════════════");
            sb.AppendLine();

            return sb.ToString();
        }

        public abstract string ObtenerDetalleCalculo();

    }

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

