using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public String nombre { get; set; }
        public String contrasenia { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }

        public Usuario(int id, string nombre, string contrasenia)
        {
            Id = id;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }
    }
}
