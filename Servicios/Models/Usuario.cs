using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string usuario {get; set;}
        public string contrasenia { get; set;}

        public Usuario()
        {
        }

        public Usuario(string contrasenia, string usuario )
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

        
    }
}
