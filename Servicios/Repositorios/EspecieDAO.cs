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
    internal class EspecieDAO : DAOConexion
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
                    idEspecie = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    edadMadurez = lector.GetInt32(2),
                    peso = lector.GetDouble(3)

                };

                //Agrega a la lista
                list.Add(nuevaEspecie);
            }

            return list;
        }

        //Insertar nuevo usuario a la base
        public void insert(Especie nEspecie)
        {

            string query = $"insert into animales (idEspecie, nombreEspecie, edadMadurez, pesoPromedio) VALUES ('{nEspecie.idEspecie}', {nEspecie.nombre}, {nEspecie.edadMadurez}, {nEspecie.peso})";

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;
        }



    }
}
