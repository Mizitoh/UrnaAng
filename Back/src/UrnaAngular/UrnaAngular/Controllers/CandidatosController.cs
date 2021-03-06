using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaAngular.Data;
using UrnaAngular.Data.Repositories;
using UrnaAngular.Models;

namespace UrnaAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatosController : ControllerBase
    {
        private readonly IRepository _repository;
        public CandidatosController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repository.GetAllCandidatosAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
        }

        [HttpGet("{candidatoId}")]
        public async Task<IActionResult> GetCandidatoAsyncById(int candidatoId)
        {
            try
            {
                var result = await _repository.GetCandidatoAsyncById(candidatoId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Candidato cd)
        {
            try
            {
                _repository.Add(cd);
                if(await _repository.SaveChangesAsync())
                { return Ok(cd); }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
            return BadRequest("Erro não esperado, você que lute!");
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
