using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.VeterinariaServices
{
    public class Animal
    {
        public int idAnimal { get; set; }
        public string nombreAnimal { get; set; }
        public double peso { get; set; }
        public int edad { get; set; }
        public int dniCliente { get; set; }
        public int idEspecie { get; set; }

        public Animal(int idAnimal, string nombreAnimal, double peso, int edad, int dniCliente, int idEspecie)
        {
            this.nombreAnimal = nombreAnimal;
            this.peso = peso;
            this.edad = edad;
            this.dniCliente = dniCliente;
            this.idEspecie = idEspecie;
        }

        public Animal()
        {
        }
    }

}
