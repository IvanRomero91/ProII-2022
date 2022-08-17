using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Persona
    {


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }


        public Persona(string nombre, string apellido, string sexo, string direccion, string email, DateTime fechaAlta, DateTime fechaBaja)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Direccion = direccion;
            Email = email;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }
    }
}
