using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MarsToStay.Controllers;

public class GamesController : Controller
{
    private readonly ILogger<GamesController> _logger;

    private readonly GamesRepository _gamesRepository;

    public GamesController(ILogger<GamesController> logger, GamesRepository gamesRepository)
    {
        _logger = logger;
        _gamesRepository = gamesRepository;
    }

    public async Task<IActionResult> Start()
    {
        var game = await _gamesRepository.Create();

        return View(game);
    }

    public IActionResult Join(string id)
    {
        var game = _gamesRepository.FindById(id);
        if (game == null)
        {
            return NotFound();
        }

        return View(game);
    }

    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var game = await _gamesRepository.FindById(id.Value);
        if (game == null)
        {
            return NotFound();
        }

        return View(game);
    }

    public IActionResult AssignCharacter(Guid gameId, Guid playerId, Guid characterId)
    {
        return View();
    }

    public IActionResult SetStartPlayer(Guid gameId, Guid playerId)
    {
        return View();
    }

    public IActionResult BeginStory(Guid gameId)
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private IActionResult View(Game game)
    {
        ViewData["GameId"] = game.Id;
        ViewData["Game"] = game;

        return View();
    }
}
