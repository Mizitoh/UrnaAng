using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaAngular.Data;
using UrnaAngular.Models;

namespace UrnaAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly DataContext _context;
        public CandidatoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Candidato> Get()
        {
            return _context.Candidatos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Candidato> GetbyId(int id)
        {
            return _context.Candidatos.Where(candidato=> candidato.Id == id);
        }

        [HttpPost]
        public IEnumerable<Candidato> Post()
        {
            return null;
        }

        [HttpPut("{id}")]
        public IEnumerable<Candidato> Put()
        {
            return null;
        }

        [HttpDelete("{id}")]
        public IEnumerable<Candidato> Delete()
        {
            return null;
        }
    }
}
