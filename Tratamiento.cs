using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Tratamiento
    {

        public int IdTto { get; set; }
        public int IdMascota { get; set; }
        public double Importe { get; set; }
        //public DetalleTto Detalle { get; set; }
        public List<DetalleTto> Detalles { get; set; }

    }
}
