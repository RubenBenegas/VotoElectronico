using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
    public class PadronRule
    {
        public List<Votante> ObtenerVotantes()
        {
            var lista = new List<Votante>();

             lista.Add(new Votante { NumeroVotante = 001, Nombre = "Julian", Apellido = "Allende", Documento = "00000001", Domicilio = "Los pinos 15" });
            lista.Add(new Votante { NumeroVotante = 002, Nombre = "Ruben", Apellido = "Benegas", Documento = "00000002", Domicilio = "San Martin 145" });
            lista.Add( new Votante { NumeroVotante = 003, Nombre = "Mirna", Apellido = "Carreño", Documento = "000000003", Domicilio = "Siempre Viva S/N" });
            lista.Add(new Votante { NumeroVotante = 004, Nombre = "Aaron", Apellido = "Lacava", Documento = "00000004", Domicilio = "Rojo 123" });
            lista.Add(new Votante { NumeroVotante = 005, Nombre = "Pedro", Apellido = "Cuello", Documento = "00000005", Domicilio = "Azul 456" });
            lista.Add(new Votante { NumeroVotante = 006, Nombre = "Pablo", Apellido = "Bustos", Documento = "00000006", Domicilio = "Amarillo 789" });
            lista.Add(new Votante { NumeroVotante = 007, Nombre = "Agustin", Apellido = "Lopez", Documento = "00000007", Domicilio = "Naranja  321" });
            lista.Add(new Votante { NumeroVotante = 008, Nombre = "Jazmin", Apellido = "Gallardo", Documento = "00000008", Domicilio = "Verde 543" });
            lista.Add(new Votante { NumeroVotante = 009, Nombre = "Rocio", Apellido = "Merlo", Documento = "00000009", Domicilio = "Violeta 987" });
            lista.Add(new Votante { NumeroVotante = 010, Nombre = "Candela", Apellido = "de La Torre", Documento = "00000010", Domicilio = "Negro 666" });

            return lista;

        }

        public void RealizarVoto()
        {

        }
    }
}
