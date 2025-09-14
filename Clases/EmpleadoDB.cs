using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Nominas.Clases
{
    public class EmpleadoDB
    {
        private static List<EmpleadoBase> listaEmpleados = new List<EmpleadoBase>();

        public void AgregarEmpleado(EmpleadoBase emp)
        {
            listaEmpleados.Add(emp); 
        }
        public List<EmpleadoBase> ObtenerEmpleados()
        {
            return listaEmpleados;
        }


    }
}
