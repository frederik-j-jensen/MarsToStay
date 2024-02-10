using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MarsToStay.Controllers;

public class GameController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public GameController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult EndGame(Guid gameId)
    {
        return View();
    }

    public IActionResult LeaveGame(Guid gameId)
    {
        return View();
    }

    public IActionResult SelectCharacter(Guid gameId, Guid playerId, Guid characterId)
    {
        return View();
    }

    public IActionResult SetStartPlayer(Guid gameId, Guid playerId){
        return View();
    }

    public IActionResult BeginStory(Guid gameId){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
