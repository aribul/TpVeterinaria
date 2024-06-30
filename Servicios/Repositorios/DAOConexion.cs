using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Repositorios
{
    public class DAOConexion
    {

        //private const string CONEXION_URL = "server=;Database=;Integrated Security=true";
        protected IDbConnection prepararConexion()
        {
            string connectionString = "server=ATAWAY-AR368;database=veterinaria;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
