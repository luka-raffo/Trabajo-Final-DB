using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Odontologo
    {
        
        public int dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String especialidad { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }
        public String fechaNac { get; set; }
        public String sexo { get; set; }


        public Odontologo()
        {
        }

        public Odontologo(int dni, string nombre, string apellido, string especialidad, string telefono, string direccion, string fechaNac, string sexo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
        }

       
    }
}
