﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JornadaElectoral: EntidadBase
    {
        public JornadaElectoral()
        {

        }

        public int NroDeJornada { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public string HoraComienzo { get; set; }

        public string HoraFin { get; set; }

        public string LugarDondeSeRealiza { get; set; }

        public string Organizador { get; set; }

        public List<Candidato> Candidatos { get;  set; }

        public List<Votante> VotantesQueVotaron { get; private set; }

        public List<Voto> Votos { get; set; }

        

    }
}
