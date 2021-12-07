using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mezium.Web.Models;

namespace Mezium.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var stories = new StoryViewModel[]
        {
            new StoryViewModel()
            {
                AuthorName = "Mark Desent",
                Title = "You don’t need JWT anymore",
                Description = "A simpler way to authenticate users with web3 using signed messages.",
                PublishDate = DateOnly.FromDateTime(DateTime.Now)
            },
            new StoryViewModel()
            {
                AuthorName = "Miroslaw Shpak",
                Title = "Why Senior Software Engineer Interviews Have Become So Damn Difficult",
                Description = "There is a general sense that interviews for senior positions are getting harder all the time.",
                PublishDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-2))
            },
            new StoryViewModel()
            {
                AuthorName = "Nick Nolan",
                Title = "What Would Happen If You Bought $100 of Bitcoin Every Month For a Year?",
                Description = "Here’s how much you’d have after a year.",
                PublishDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-5))
            }
        };

        return View(stories);
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