using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CineTurbo.Data;
using CineTurbo.Models;
using CineMaisTurbo.Models; // Necessário para acessar o modelo Serie

namespace CineTurbo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeriesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public SeriesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddSerie([FromBody] Serie serie)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _appDbContext.SeriesDB.Add(serie);
            await _appDbContext.SaveChangesAsync();

            return Created("Serie criado com sucesso!", serie);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Serie>> GetSeries([FromQuery] string? genero)
        {
            var query = _appDbContext.SeriesDB.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genero))
            {
                query = query.Where(s => s.Genero.Trim().ToLower() == genero.Trim().ToLower());
            }

            return Ok(query.ToList());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Serie>> GetSerie(int id)
        {
            var serie = await _appDbContext.SeriesDB.FindAsync(id);

            if (serie == null) {
                return NotFound("Serie não encontrado!");
            }

            return Ok(serie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSerie(int id, [FromBody] Serie serieAtualizado)
        {
            var serieExistente = await _appDbContext.SeriesDB.FindAsync(id);

            if (serieExistente == null) {
                return NotFound("Serie não encontrado!");
            }

            _appDbContext.Entry(serieExistente).CurrentValues.SetValues(serieAtualizado);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, serieAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSerie(int id)
        {
            var serie = await _appDbContext.SeriesDB.FindAsync(id);

            if (serie == null) {
                return NotFound("Serie não encontrado!");
            }

            _appDbContext.Remove(serie);

            await _appDbContext.SaveChangesAsync();

            return Ok("Serie deletado");
        }
    }
}
