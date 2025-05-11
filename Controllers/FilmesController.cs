using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CineTurbo.Data;
using CineTurbo.Models; // Necessário para acessar o modelo Filme

namespace CineTurbo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FilmesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddFilme([FromBody] Filme filme)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _appDbContext.FilmesDB.Add(filme);
            await _appDbContext.SaveChangesAsync();

            return Created("Filme criado com sucesso!", filme);
        }

        // // GET: api/filmes
        // [HttpGet]
        // public ActionResult<IEnumerable<Filme>> GetTodosFilmes()
        // {
        //     var filmes = _appDbContext.FilmesDB.ToList();
        //     return Ok(filmes);
        // }

        [HttpGet]
        public ActionResult<IEnumerable<Filme>> GetFilmes([FromQuery] string? genero)
        {
            var query = _appDbContext.FilmesDB.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genero))
            {
                query = query.Where(s => s.Genero.Trim().ToLower() == genero.Trim().ToLower());


            }

            return Ok(query.ToList());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Filme>> GetFilme(int id)
        {
            var filme = await _appDbContext.FilmesDB.FindAsync(id);

            if (filme == null) {
                return NotFound("Filme não encontrado!");
            }

            return Ok(filme);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFilme(int id, [FromBody] Filme filmeAtualizado)
        {
            var filmeExistente = await _appDbContext.FilmesDB.FindAsync(id);

            if (filmeExistente == null) {
                return NotFound("Filme não encontrado!");
            }

            _appDbContext.Entry(filmeExistente).CurrentValues.SetValues(filmeAtualizado);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, filmeAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFilme(int id)
        {
            var filme = await _appDbContext.FilmesDB.FindAsync(id);

            if (filme == null) {
                return NotFound("Filme não encontrado!");
            }

            _appDbContext.Remove(filme);

            await _appDbContext.SaveChangesAsync();

            return Ok("Filme deletado");
        }
    }
}
