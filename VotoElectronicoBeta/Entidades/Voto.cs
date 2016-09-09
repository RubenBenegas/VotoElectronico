using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Voto: EntidadBase
    {

        public string Mesa { get; set; }
            
        public Candidato CandidatoAQuienSeVoto { get; set; }

    }
}
