using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;



namespace Reglas
{
    class CandidatoRule
    {
        public List<Candidato> _candidatos;
      

        public CandidatoRule()
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
       
        }

        public Candidato ObtenerCandidatoPorCodigo(string codigo)
        {

            foreach (var candidato in _candidatos)
            {
                if (candidato.Codigo == codigo)
                {
                    return candidato;
                }
              }
            return null;
            }

            //for (int i = 0; i < _cantidadCandidatos; i++)
            //{
            //    if (_candidatos[i].Codigo == codigo)
            //    {
            //return _candidatos
            //    }
            //}
            //return null;
        }

    }


