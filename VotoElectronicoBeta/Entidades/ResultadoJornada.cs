using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResultadoJornada: EntidadBase
    {
        public Candidato Candidato { get; set; }

        public int CantidadDeVotos { get; set; }
    }
}
