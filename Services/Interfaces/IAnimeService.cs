using teste_mysql_do_zero.Models.Dtos;

namespace teste_mysql_do_zero.Services.Interfaces
{
    public interface IAnimeService
    {
        public List<AnimeDto> getListaDeAnimes();

        public bool cadastrarAnime(AnimeDto objAnimeDto);


    }
}