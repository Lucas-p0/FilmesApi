using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDTO
    {

        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public string? Tipo { get; set; }
        public int Duracao { get; set; }
        public int Ano { get; set; }
        public double NotaIMDB { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}