﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public class JornadaElectoral: EntidadBase
    {

        public JornadaElectoral()
        {
            VotantesQueVotaron = new List<Votante>();
        }

        public string Nombre { get; set; }

        public string Fecha { get; set; }

        public string HoraComienzo { get; set; }

        public string HoraFin { get; set; }

        public string Organizador { get; set; }

        public List<Votante> VotantesQueVotaron { get; private set; }

                

    }

   
}
