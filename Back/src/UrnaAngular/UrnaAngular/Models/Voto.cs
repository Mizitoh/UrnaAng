using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaAngular.Models
{
    public class Voto
    {
        public int Id { get; set; }
        public int? CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public int QtdVotos { get; set; }

        public Voto()
        {

        }

        public Voto(int id, int? candidatoId, int qtdVotos)
        {
            Id = id;
            CandidatoId = candidatoId;
            QtdVotos = qtdVotos;
        }
    }
}
