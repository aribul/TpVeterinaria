using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.VeterinariaServices
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public string NombreAnimal { get; set; }
        public double Peso { get; set; }
        public int Edad { get; set; }
        public int DniCliente { get; set; }
        public int IdEspecie { get; set; }

        public Animal(string nombreAnimal, double peso, int edad, int dniCliente, int idEspecie)
        {
            NombreAnimal = nombreAnimal;
            Peso = peso;
            Edad = edad;
            DniCliente = dniCliente;
            IdEspecie = idEspecie;
        }

        public Animal()
        {

        }
    }

}
