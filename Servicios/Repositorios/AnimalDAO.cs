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
                    NombreAnimal = lector.GetString(1),
                    Peso = lector.GetDouble(2),
                    Edad = lector.GetInt32(3), 
                    DniCliente = lector.GetInt32(4),
                    IdEspecie = lector.GetInt32(5),

                };

                //Agrega a la lista
                list.Add(nuevoAnimal);
            }

            return list;
        }

        //Insertar nuevo usuario a la base
        public bool Insert(Animal nAnimal)
        {


            string query = $"insert into animales (nombreAnimal, peso, edad, dnicliente, cspecieID) VALUES ('{nAnimal.NombreAnimal}', {nAnimal.Peso}, {nAnimal.Edad}, {nAnimal.DniCliente}, {nAnimal.IdEspecie})";

            using (IDbConnection conexion = this.prepararConexion())
            {

                IDbCommand comando = conexion.CreateCommand();

                comando.CommandText = query;

                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;

            }

        }

        public double pesoMinimo(int edadMinima, int edadMaxima)
        {
            double pesoMin = 0;
            foreach (Animal animal in this.getAll())
            {
                if (animal.Edad > edadMinima & animal.Edad < edadMaxima)
                {
                    if (pesoMin == 0 || animal.Peso <= pesoMin)
                    {
                        pesoMin = animal.Peso;
                    }
                }
            }
            return pesoMin;
        }

        public double pesoMaximo(int edadMinima, int edadMaxima)
        {
            double pesoMax = 0;
            foreach (Animal animal in this.getAll())
            {
                if (animal.Edad > edadMinima & animal.Edad < edadMaxima)
                {
                    if (pesoMax == 0 || animal.Peso >= pesoMax)
                    {
                        pesoMax = animal.Peso;
                    }
                }
            }
            return pesoMax;
        }

        public double promedioPeso(int edadMinima, int edadMaxima)
        {
            double promedioPeso = 0;
            double pesoTotal = 0;
            int contador = 0;
            foreach (Animal animal in getAll())
            {
                if (animal.Edad > edadMinima & animal.Edad < edadMaxima)
                {
                    contador++;
                    pesoTotal += animal.Peso;
                }
            }
            if (contador > 0)
            {
                return promedioPeso = pesoTotal / contador;
            }
            else
            {
                return promedioPeso;
            }
        }

    }
}
