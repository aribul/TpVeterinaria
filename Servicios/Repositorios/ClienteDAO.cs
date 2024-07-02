using Servicios.Models;
using Servicios.VeterinariaServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Repositorios
{
    public class ClienteDAO : DAOConexion
    {

        public List<Cliente> getAll()
        {

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            //crea query
            comando.CommandText = "select * from clientes";

            //ejecuta la query
            IDataReader lector = comando.ExecuteReader();

            //Lista de usuarios
            List<Cliente> list = new List<Cliente>();

            //Se recorre la lista
            while (lector.Read())
            {
                //crea usuario por cada fila
                Cliente nuevoCliente = new Cliente()
                {
                    Dni = lector.GetString(0),
                    Nombre = lector.GetString(1)

                };

                //Agrega a la lista
                list.Add(nuevoCliente);
            }

            return list;
        }


        public bool Insert(Cliente clienteNuevo)
        {


            string query = $"insert into usuario (dni, nombre) values ( '{clienteNuevo.Dni}' , '{clienteNuevo.Nombre}')";

            using (IDbConnection conexion = this.prepararConexion())
            {

                IDbCommand comando = conexion.CreateCommand();

                comando.CommandText = query;

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;

            }

        }
    }
}
