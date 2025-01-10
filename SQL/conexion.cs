using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1.SQL
{
    public class conexion //test de conexion
    {
        private readonly string varconexion =
            "Server=localhost;Database=examen;uid=sa;pwd=123";
        public SqlConnection obtenerConexion() {
            return new SqlConnection(varconexion);
        }
    }
}
