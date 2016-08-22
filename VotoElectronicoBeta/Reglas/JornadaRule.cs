using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
    class JornadaRule
    {
        public List<Candidato> candidatos;
        public List<Votante> listaVotantes;

        public JornadaRule()
        {
            candidatos = new List<Candidato>();
            listaVotantes = new List<Votante>();
        }

        public void AgregarCandidato(Candidato candidato)
        {
                       candidatos.Add(candidato);
        }


        public List<Votante> CargarVotantes()
        {
           
            listaVotantes.Add(new Votante { NumeroVotante = 001, Nombre = "Julian", Apellido = "Allende", Documento = "00000001", Domicilio = "Los pinos 15", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 002, Nombre = "Ruben", Apellido = "Benegas", Documento = "00000002", Domicilio = "San Martin 145", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 003, Nombre = "Mirna", Apellido = "Carreño", Documento = "000000003", Domicilio = "Siempre Viva S/N", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 004, Nombre = "Aaron", Apellido = "Lacava", Documento = "00000004", Domicilio = "Rojo 123", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 005, Nombre = "Pedro", Apellido = "Cuello", Documento = "00000005", Domicilio = "Azul 456", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 006, Nombre = "Pablo", Apellido = "Bustos", Documento = "00000006", Domicilio = "Amarillo 789", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 007, Nombre = "Agustin", Apellido = "Lopez", Documento = "00000007", Domicilio = "Naranja  321", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 008, Nombre = "Jazmin", Apellido = "Gallardo", Documento = "00000008", Domicilio = "Verde 543", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 009, Nombre = "Rocio", Apellido = "Merlo", Documento = "00000009", Domicilio = "Violeta 987", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 010, Nombre = "Candela", Apellido = "de La Torre", Documento = "00000010", Domicilio = "Negro 666", RealizoVoto = false });
            listaVotantes.Add(new Votante { NumeroVotante = 011, Nombre = "Luz", Apellido = "Hurtado", Documento = "00000011", Domicilio = "En el fondo 221", RealizoVoto = false });

            return listaVotantes;
         }

        public Votante ComprobarVotante(int codigo)
        {
            foreach (Votante vot in listaVotantes)
            {
                if (vot.NumeroVotante != codigo)
                {
                    throw new ApplicationException("El votante no esta en el padron");         
                }
             }
            return null;
         }

        public void Votar()
        {

        }

        public void ImprimirComprobanteDeVoto()
        {

        }

        public string MostrarResultado(string resultado)
        {


            return resultado;
        }

        
    }
}
