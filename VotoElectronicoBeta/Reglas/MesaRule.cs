using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Reglas
{
    public class MesaRule
    {

        private List<Votante> _votantes;
        private int _cantidadVotantes;

        public MesaRule()
        {
            _votantes = new List<Votante>();
        }


        public Votante ObtenerVotantePorDni(string dni)
        {

            for (int i = 0; i < _cantidadVotantes; i++)
            {
                if (_votantes[i].Documento == dni)
                {
                    return _votantes[i];
                }
            }
            return null;

           

        }



        public void ObtieneVotos()
        {


        }

        public void EntregaComprobanteDeVoto()
        {

        }

    }
}
