using teste_mysql_do_zero.Models.Dtos;
using teste_mysql_do_zero.Models.Entities;

namespace teste_mysql_do_zero.Repositories.Interfaces
{
    public interface IAnimeRepository
    {
        public List<AnimeEntity> getListaDeAnimes();
        public AnimeEntity? checaSeAnimeJaExiste(string nome);
    }
}