using System.Diagnostics;
using Mezium.Web.Application;
using Microsoft.AspNetCore.Mvc;
using Mezium.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Mezium.Web.Controllers;

public class HomeController : Controller
{
    private readonly IApplicationDbContext _dbContext;

    public HomeController(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index(CancellationToken token)
    {
        var stories = await _dbContext.Stories.ToArrayAsync(token);

        var models = stories.Select(story => new StoryViewModel
        {
            AuthorName = story.AuthorName,
            Title = story.Title,
            Description = story.Description!,
            PublishDate = story.PublishDate
        }).ToArray();
        
        return View(models);
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