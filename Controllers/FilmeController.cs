using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int Id = 0;

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = Id++;
        filmes.Add(filme);
        Console.WriteLine("Codigo do filme: {0}, Titulo do filmes: {1}, Genero do filme: {2}, Duração do filme: {3}, Nota IMDB: {4}", filme.Id, filme.Titulo, filme.Genero, filme.Duracao, filme.NotaIMDB);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }
    [HttpGet("{id}")]
    public Filme? RecuperaFilmesPorId(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}
