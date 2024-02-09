namespace FilmesAPI.Models;

public class Filme
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Genero { get; set; }
    public string? Tipo { get; set; }
    public int Duracao { get; set; }
    public int Ano { get; set; }
    public double NotaIMDB { get; set; }
}
