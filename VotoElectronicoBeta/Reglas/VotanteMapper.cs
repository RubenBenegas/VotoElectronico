using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
   public class VotanteMapper: BaseMapper<Votante>
    {
        public Votante ObtenerPorDocumento(string documento)
        {


            //ObtenerTodas().FirstOrDefault(v => v.Documento == documento);

            foreach (var votante in ObtenerTodas())
            {
                if (votante.Documento == documento)
                {
                    return votante;
                }
            }

            return null;


        }
    }
}
