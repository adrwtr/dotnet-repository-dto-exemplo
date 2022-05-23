using Xunit;

using teste_mysql_do_zero.Services;
using teste_mysql_do_zero.Repositories;

namespace teste_mysql_do_zero.Tests.Services;

public class AnimeServiceTest
{
    [Fact]
    public void Test1()
    {
        AnimeService objAnimeService = new AnimeService(new AnimeMemoryRepository());

        Assert.True(
            objAnimeService.cadastrarAnime(
                new Models.Dtos.AnimeDto() {
                    Id =  10,
                    NomeAnime = "Ino Yasha",
                    DataCriacao = new DateTime()
                }
            )
        );

        Assert.False(
            objAnimeService.cadastrarAnime(
                new Models.Dtos.AnimeDto() {
                    Id =  10,
                    NomeAnime = "Dragon Ball",
                    DataCriacao = new DateTime()
                }
            )
        );
    }
}