using System;
using System.Collections.Generic;
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
        
    }
}
