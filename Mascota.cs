using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Mascota
    {

        public int IdMascota { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }
        public Tipo Tipo { get; set; }
        public string Sexo { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }

    }
}
