using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Models
{
    internal class Especie
    {

        public int idEspecie { get; set; }
        public string nombre { get; set; }
        public int edadMadurez { get; set; }
        public double peso { get; set; }


        public Especie(int idEspecie, string nombre, int edadMadurez, double peso)
        {
            this.idEspecie = idEspecie;
            this.nombre = nombre;
            this.edadMadurez = edadMadurez;
            this.peso = peso;

        }

        public Especie() { }
    }
}
