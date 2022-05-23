using teste_mysql_do_zero.Models.Entities;

using teste_mysql_do_zero.Contexts;
using teste_mysql_do_zero.Repositories.Interfaces;
using teste_mysql_do_zero.Models.Dtos;

namespace teste_mysql_do_zero.Repositories
{

    public class AnimeMemoryRepository : IAnimeRepository
    {

        public List<AnimeEntity> getListaDeAnimes()
        {
            List<AnimeEntity> lista = new List<AnimeEntity> {
                new AnimeEntity {
                    Id = 1,
                    NomeAnime = "Dragon Ball",
                    DataCriacao = new DateTime()
                },

                new AnimeEntity {
                    Id = 2,
                    NomeAnime = "Yu Yu Hakusho",
                    DataCriacao = new DateTime()
                },

                new AnimeEntity {
                    Id = 3,
                    NomeAnime = "Naruto",
                    DataCriacao = new DateTime()
                },
            };

            return lista;
        }

        public AnimeEntity? checaSeAnimeJaExiste(string nome)
        {
            return this.getListaDeAnimes().Where(
                row => row.NomeAnime == nome
            ).FirstOrDefault();
        }
    }
}