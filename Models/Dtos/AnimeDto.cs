using System;
using System.Collections.Generic;
using System.Text;

namespace teste_mysql_do_zero.Models.Dtos
{
    public class AnimeDto
    {
        public int Id { get; set; }
        public string? NomeAnime { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
