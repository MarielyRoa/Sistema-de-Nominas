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
}

