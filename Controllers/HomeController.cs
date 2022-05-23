using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using teste_mysql_do_zero.Models;
using teste_mysql_do_zero.Services;
using teste_mysql_do_zero.Models.Dtos;
using teste_mysql_do_zero.Contexts;

using teste_mysql_do_zero.Services.Interfaces;

namespace teste_mysql_do_zero.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAnimeService _animeService;

    public HomeController(
        ILogger<HomeController> logger,
        IAnimeService animeService
    ) {
        _logger = logger;
        _animeService = animeService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ListarAnimes()
    {
        List<AnimeDto> objListAnimeDto = _animeService.getListaDeAnimes();

        return View(
            objListAnimeDto
        );
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {
            RequestId = Activity.Current?.Id
            ?? HttpContext.TraceIdentifier
        });
    }
}
