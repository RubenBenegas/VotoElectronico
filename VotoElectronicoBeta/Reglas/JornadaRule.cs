using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
   public class JornadaRule
    {
        public List<Candidato> candidatos;
        public List<Votante> listaVotantes;

        int acumuladorVotos = 0;
        
        public JornadaRule()
        {
            candidatos = new List<Candidato>();
            listaVotantes = new List<Votante>();
        }

        public void AgregarCandidato(Candidato candidato)
        {
            candidatos.Add(candidato);
        }

     

        public List<Votante> CargarVotantes(List<Votante> listaVotantes)
        {

            var g = new VotanteMapper();
            var votantes = g.ObtenerTodas().ToList<Votante>();

            if (votantes.Count == 0)
            {
                listaVotantes.Add(new Votante { Nombre = "Julian", Apellido = "Allende", Documento = "00000001", Domicilio = "Los pinos 15" });
                listaVotantes.Add(new Votante { Nombre = "Ruben", Apellido = "Benegas", Documento = "00000002", Domicilio = "San Martin 145" });
                listaVotantes.Add(new Votante { Nombre = "Mirna", Apellido = "Carreño", Documento = "000000003", Domicilio = "Siempre Viva S/N" });
                listaVotantes.Add(new Votante { Nombre = "Aaron", Apellido = "Lacava", Documento = "00000004", Domicilio = "Rojo 123" });
                listaVotantes.Add(new Votante { Nombre = "Pedro", Apellido = "Cuello", Documento = "00000005", Domicilio = "Azul 456" });
                listaVotantes.Add(new Votante { Nombre = "Pablo", Apellido = "Bustos", Documento = "00000006", Domicilio = "Amarillo 789" });
                listaVotantes.Add(new Votante { Nombre = "Agustin", Apellido = "Lopez", Documento = "00000007", Domicilio = "Naranja  321" });
                listaVotantes.Add(new Votante { Nombre = "Jazmin", Apellido = "Gallardo", Documento = "00000008", Domicilio = "Verde 543" });
                listaVotantes.Add(new Votante { Nombre = "Rocio", Apellido = "Merlo", Documento = "00000009", Domicilio = "Violeta 987" });
                listaVotantes.Add(new Votante { Nombre = "Candela", Apellido = "de La Torre", Documento = "00000010", Domicilio = "Negro 666" });
                listaVotantes.Add(new Votante { Nombre = "Luz", Apellido = "Hurtado", Documento = "00000011", Domicilio = "En el fondo 221" });

                g.Grabar(listaVotantes);
            }
            return listaVotantes;
            
         }

        public Votante ComprobarVotante(string numeroDocumento)
        {

            var cv = new VotanteMapper();
            var votante = cv.ObtenerPorDocumento(numeroDocumento);


            return votante;
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
