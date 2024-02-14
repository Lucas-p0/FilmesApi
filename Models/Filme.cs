using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage = "O Id do filme é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O Titulo do filme é obrigatório")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Genero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do Genero não pode exceder 50 caracteres")]

    public string? Genero { get; set; }

    public string? Tipo { get; set; }
    [Required(ErrorMessage = "")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600")]
    public int Duracao { get; set; }
    public int Ano { get; set; }
    public double NotaIMDB { get; set; }
}
