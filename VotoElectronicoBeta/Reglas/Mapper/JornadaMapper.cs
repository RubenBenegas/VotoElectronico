using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
    public class JornadaMapper : BaseMapper<JornadaElectoral>
    {

        public JornadaElectoral ObtenerPorNombre(string nombre)
        {
            foreach (var jornada in ObtenerTodas())
            {
                if (jornada.Nombre == nombre)
                {
                    return jornada;
                }

            }

            return null;
        }
    }

}

