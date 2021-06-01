using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaAngular.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string NomePresidente { get; set; }
        public string NomeVice { get; set; }
        public string Partido { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Legenda { get; set; }        
        public IEnumerable<Voto> Votos { get; set; }

        public Candidato()
        {

        }

        public Candidato(int id, string nomePresidente, string nomeVice, string partido, DateTime dataCadastro, int legenda)
        {
            Id = id;
            NomePresidente = nomePresidente;
            NomeVice = nomeVice;
            Partido = partido;
            DataCadastro = dataCadastro;
            Legenda = legenda;
        }
    }
}
