using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Veterinario:Persona
    {
        public Veterinario(string nombre, string apellido, string sexo, string direccion,
                            string email, DateTime fechaAlta, DateTime fechaBaja,
                            int idVeterinario, Especialidad especialidad)

            : base(nombre,apellido,sexo,direccion,email,fechaAlta,fechaBaja)
        {
            IdVeterinario = idVeterinario;
            Especialidad = especialidad;
        }

        public int IdVeterinario { get; set; }
        public Especialidad Especialidad { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public string Sexo { get; set; }
        //public string Direccion { get; set; }
        //public string Email { get; set; }
        //public DateTime FechaAlta { get; set; }
        //public DateTime FechaBaja { get; set; }

    }
}
