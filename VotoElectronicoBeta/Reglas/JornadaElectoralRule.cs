using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;



namespace Reglas
{
    class JornadaElectoralRule
    {
        public List<Candidato> _candidatos;
        int _cantidadCandidatos;

        public JornadaElectoralRule()
        {
            _candidatos = new List<Candidato>();
        }

        public void AgregarCandidato(Candidato candidato)
        {
            if (ObtenerCandidatoPorCodigo(candidato.Codigo) != null)
            {
                throw new ApplicationException("El candidato con este codigo ya existe");
            }

            _candidatos.Add(candidato);
            _cantidadCandidatos++;
        }

        public Candidato ObtenerCandidatoPorCodigo(string codigo)
        {
            for (int i = 0; i < _cantidadCandidatos; i++)
            {
                if (_candidatos[i].Codigo == codigo)
                {
                    return _candidatos[i];
                }
            }
            return null;
        }

    }

}

