using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Entidades;

namespace Reglas
{
    public class JornadaRule
    {
        private List<JornadaElectoral> listaJornadas;
        private List<Candidato> listaCandidatos;
        private List<Votante> listaVotantes;

        public JornadaRule()
        {
            listaJornadas = new List<JornadaElectoral>();
            listaCandidatos = new List<Candidato>();
            listaVotantes = new List<Votante>();
        }

        public void AgregarJornada(JornadaElectoral jornadaNueva)
        {
            listaJornadas.Add(jornadaNueva);

          
            var jm = new JornadaMapper();
            jm.Grabar(jornadaNueva);

        }

        public void AgregarCandidato(Candidato candidatoNuevo)
        {
            var obt = new CandidatoMapper();
            var candidatos = obt.ObtenerTodas();
            listaCandidatos.Add(candidatoNuevo);
            
           

            var grab = new CandidatoMapper();
            grab.Grabar(candidatoNuevo);
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

        public void Votar(Candidato candidatoVoto, string mesa, Votante votanteQueVoto, JornadaElectoral jornada)
        {
            var nuevoVoto = new Voto();
            nuevoVoto.RegistroVoto = candidatoVoto;
            nuevoVoto.Mesa = mesa;
            //instanciar mapper de voto y grabar

            var vm = new VotoMapper();
            vm.Grabar(nuevoVoto);

            //jornada.VotantesQueVotaron.Add(votanteQueVoto);

        }


        public List<ResultadoJornada> ObtenerResultado(Candidato candidato)
        {

            var resultado = new List<ResultadoJornada>();

            var vm = new VotoMapper();
            var votos = (List<Voto>)vm.ObtenerTodas();

            foreach (var voto in votos)
            {
                var rp = new ResultadoJornada();

                if (rp.Candidato.Equals(candidato))
                {
                    rp.Candidato = candidato;
                    

                    foreach (var candidatoR in votos)
                    {
                        rp.CantidadDeVotos = rp.CantidadDeVotos++;
                        
                    }

                    resultado.Add(rp);
                }               
            }
          

            var rm = new ResultadoMapper();
            rm.Grabar(resultado);

            return resultado;


        }

    }
}



