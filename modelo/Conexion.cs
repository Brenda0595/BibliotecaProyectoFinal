using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaProyecto.modelo
{
    public class Conexion
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Server=ESCOBAR;DataBase= BibliotecaProyecto;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection;
        }

        public SqlConnection CerrarConexion()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
            return sqlConnection;
        }
    }
}
