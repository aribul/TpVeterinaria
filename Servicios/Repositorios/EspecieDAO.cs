using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Repositorios
{
    public class EspecieDAO : DAOConexion
    {
        public List<Especie> getAll()
        {

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            //crea query
            comando.CommandText = "select * from especies";

            //ejecuta la query
            IDataReader lector = comando.ExecuteReader();

            //Lista de usuarios
            List<Especie> list = new List<Especie>();

            //Se recorre la lista
            while (lector.Read())
            {
                //crea usuario por cada fila
                Especie nuevaEspecie = new Especie()
                {
                    IdEspecie = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    EdadMadurez = lector.GetInt32(2),
                    Peso = lector.GetDouble(3)

                };

                //Agrega a la lista
                list.Add(nuevaEspecie);
            }

            return list;
        }

        //Insertar nuevo usuario a la base
        public bool Insert(Especie nEspecie)
        {

            
            string query = $"insert into animales (idEspecie, nombreEspecie, edadMadurez, pesoPromedio) VALUES ('{nEspecie.IdEspecie}', {nEspecie.Nombre}, {nEspecie.EdadMadurez}, {nEspecie.Peso})";
            
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
