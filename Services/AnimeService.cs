using teste_mysql_do_zero.Models.Dtos;

using teste_mysql_do_zero.Services.Interfaces;
using teste_mysql_do_zero.Repositories;
using teste_mysql_do_zero.Repositories.Interfaces;
using teste_mysql_do_zero.Models.Entities;

using teste_mysql_do_zero.Contexts;

namespace teste_mysql_do_zero.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _objAnimeRepository;

        public AnimeService(IAnimeRepository objAnimeRepository)
        {
            _objAnimeRepository = objAnimeRepository;
        }

        public List<AnimeDto> getListaDeAnimes()
        {
            // AnimeRepository objAnimeRepository = new AnimeRepository(_BancoAnimeContext);
            List<AnimeEntity> objListaEntity = _objAnimeRepository.getListaDeAnimes();

            List<AnimeDto> objListaDto = objListaEntity.Select(
                x => new AnimeDto() {
                    Id = x.Id,
                    NomeAnime = x.NomeAnime,
                    DataCriacao = x.DataCriacao
                }
            ).ToList();

            return objListaDto;
        }

        public bool cadastrarAnime(AnimeDto objAnimeDto)
        {
            bool sn_operacao_ok = false;

            AnimeEntity? objAnimeEntity = _objAnimeRepository.checaSeAnimeJaExiste(
                objAnimeDto.NomeAnime ?? ""
            );

            if (objAnimeEntity == null) {
                // aqui cadastraria
                sn_operacao_ok = true;
            }

            return sn_operacao_ok;
        }

    }
}