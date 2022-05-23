using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_mysql_do_zero.Models.Entities
{
    public class AnimeEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? NomeAnime { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
