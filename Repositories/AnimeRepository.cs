using teste_mysql_do_zero.Models.Entities;

using teste_mysql_do_zero.Contexts;
using teste_mysql_do_zero.Repositories.Interfaces;

namespace teste_mysql_do_zero.Repositories
{

    public class AnimeRepository : IAnimeRepository
    {
        private readonly BancoAnimeContext _context;
        public AnimeRepository(BancoAnimeContext context)
        {
            _context = context;
        }

        public List<AnimeEntity> getListaDeAnimes()
        {
            return _context.Animes.ToList();
        }

        public AnimeEntity? checaSeAnimeJaExiste(string nome)
        {
            return this.getListaDeAnimes().Where(
                row => row.NomeAnime == nome
            ).FirstOrDefault();
        }
    }
}