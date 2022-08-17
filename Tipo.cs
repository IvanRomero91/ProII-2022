using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Tipo
    {


        public int IdTipo { get; set; }
        public string tipo { get; set; }

        public Tipo(int idTipo, string tipo)
        {
            IdTipo = idTipo;
            this.tipo = tipo;
        }
    }
}
