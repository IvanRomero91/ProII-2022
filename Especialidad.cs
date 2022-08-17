using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Especialidad
    {

        public int iIdEspecialidad { get; set; }
        public string especialidad { get; set; }

        public Especialidad(int iIdEspecialidad, string especialidad)
        {
            this.iIdEspecialidad = iIdEspecialidad;
            this.especialidad = especialidad;
        }

    }
}
