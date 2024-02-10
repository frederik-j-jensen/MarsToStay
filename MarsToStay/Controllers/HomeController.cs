using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MarsToStay.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly GameRepository _gameRepository;

    public HomeController(ILogger<HomeController> logger, GameRepository gameRepository)
    {
        _logger = logger;
        _gameRepository = gameRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult StartGame()
    {
        var game = _gameRepository.Create();
        var gameId = game.Id;
        return View();
    }

    public IActionResult JoinGame(Guid gameId)
    {
        var game = _gameRepository.FindById(gameId);
        if(game == null)
        {
            return NotFound();
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
