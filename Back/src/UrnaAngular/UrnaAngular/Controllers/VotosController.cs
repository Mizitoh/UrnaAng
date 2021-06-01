using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaAngular.Data;
using UrnaAngular.Data.Repositories;
using UrnaAngular.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrnaAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotosController : ControllerBase
    {
        private readonly IRepository _repository;
        public VotosController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repository.GetAllVotosAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
        }

        [HttpGet("{legenda}")]
        public async Task<IActionResult> GetVotosByLegendaAsync(int legenda)
        {
            try
            {
                var result = await _repository.GetVotosByLegendaAsync(legenda);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Voto vt)
        {
            try
            {
                _repository.Add(vt);
                if (await _repository.SaveChangesAsync())
                { return Ok(vt); }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
                throw;
            }
            return BadRequest("Erro não esperado, você que lute!");
        }
    }
}
