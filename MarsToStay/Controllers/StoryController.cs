using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MarsToStay.Models;

namespace MarsToStay.Controllers;

public class StoryController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public StoryController(ILogger<HomeController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
