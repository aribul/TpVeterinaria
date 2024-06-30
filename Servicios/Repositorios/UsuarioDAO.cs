using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Models;

namespace Servicios.Repositorios
{
    public class UsuarioDAO : DAOConexion
    {

        public List<Usuario> getAll()
        {

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            //crea query
            comando.CommandText = "select * from usuarios";

            //ejecuta la query
            IDataReader lector = comando.ExecuteReader();

            //Lista de usuarios
            List<Usuario> list = new List<Usuario>();

            //Se recorre la lista
            while (lector.Read())
            {
                //crea usuario por cada fila
                Usuario nuevoUsuario = new Usuario()
                {
                    idUsuario = lector.GetInt32(0),
                    usuario = lector.GetString(1),
                    contrasenia = lector.GetString(2)

                };

                //Agrega a la lista
                list.Add(nuevoUsuario);
            }

            return list;
        }

        //Insertar nuevo usuario a la base
        public void insert(Usuario usuarioNuevo)
        {

            string query = $"insert into usuario (NombreUsuario, Clave) values ( '{usuarioNuevo.usuario}' , '{usuarioNuevo.contrasenia}')";

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;
        }


        //Actualiza usuarios
        // public void update(long id, string nombreUusuario, string clave)
        // {

        //string query = $"update Usuarios set NombreUsuario = '{nombreUusuario}', Clave = '{clave}' where IdUsuario = {id};"; /*and AND Estado = 'Activo'; ?*/

        //IDbConnection conexion = this.prepararConexion();

        //IDbCommand comando = conexion.CreateCommand();

        //comando.CommandText = query;

        //int filasActualizadas = comando.ExecuteNonQuery();

        //return filasActualizadas;

        // }


    }
}