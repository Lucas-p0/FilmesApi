using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    // private static List<Filme> filmes = new List<Filme>();
    // private static int Id = 0;
    private FilmeContext _context;
    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDTO filmeDTO)
    {
        // filme.Id = Id++;
        // filmes.Add(filme);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        //Validação em
        // Console.WriteLine("Codigo do filme: {0}, Titulo do filmes: {1}, Genero do filme: {2}, Duração do filme: {3}, Nota IMDB: {4}", filme.Id, filme.Titulo, filme.Genero, filme.Duracao, filme.NotaIMDB);
        return CreatedAtAction(nameof(RecuperaFilmesPorId),
            new { id = filme.Id },
            filme);
    }
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 30)
    {
        return _context.Filmes.Skip(skip).Take(take);
    }
    [HttpGet("{id}")]
    public IActionResult RecuperaFilmesPorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
