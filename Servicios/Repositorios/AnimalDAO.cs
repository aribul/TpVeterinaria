using Servicios.VeterinariaServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Repositorios
{
    public class AnimalDAO : DAOConexion
    {
        public List<Animal> getAll()
        {

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            //crea query
            comando.CommandText = "select * from clientes";

            //ejecuta la query
            IDataReader lector = comando.ExecuteReader();

            //Lista de usuarios
            List<Animal> list = new List<Animal>();

            //Se recorre la lista
            while (lector.Read())
            {
                //crea usuario por cada fila
                Animal nuevoAnimal = new Animal()
                {
                    nombreAnimal = lector.GetString(1),
                    peso = lector.GetDouble(2),
                    edad = lector.GetInt32(3), 
                    dniCliente = lector.GetInt32(4),
                    idEspecie = lector.GetInt32(5),

                };

                //Agrega a la lista
                list.Add(nuevoAnimal);
            }

            return list;
        }

        //Insertar nuevo usuario a la base
        public void insert(Animal aNuevo)
        {

            string query = $"insert into animales (nombreAnimal, peso, edad, dnicliente, cspecieID) VALUES ('{aNuevo.nombreAnimal}', {aNuevo.peso}, {aNuevo.edad}, {aNuevo.dniCliente}, {aNuevo.idEspecie})";

            IDbConnection conexion = this.prepararConexion();

            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;
        }

    }
}
