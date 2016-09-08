using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Candidato: EntidadBase
    {
        public string Nombre {get; set;}

        public string Apellido { get; set; }

        public string Partido { get; set; }

        public string Slogan { get; set; }

    }
}
