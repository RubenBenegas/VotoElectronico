﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Votante: EntidadBase
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Documento { get; set; }

        public string Domicilio { get; set; }

       


    }
}
