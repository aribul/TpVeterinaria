using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.VeterinariaServices
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }

        public Cliente(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public Cliente()
        {
        }
    }
}
