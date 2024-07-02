using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Models
{
    public class Especie
    {
        public int IdEspecie { get; set; }
        public string Nombre { get; set; }
        public double EdadMadurez { get; set; }
        public double Peso { get; set; }


        public Especie(string nombre, int edadMadurez, double peso)
        {
            Nombre = nombre;
            EdadMadurez = edadMadurez;
            Peso = peso;

        }

        public Especie()
        {

        }


    }
}
