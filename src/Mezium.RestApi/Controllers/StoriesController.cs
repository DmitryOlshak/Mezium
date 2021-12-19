using Mezium.RestApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mezium.RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StoriesController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Story> List()
    {
        return Enumerable.Range(1, 5).Select(index => new Story()
            {
                PublishDate = DateTimeOffset.UtcNow.AddDays(index),
                AuthorName = "Random.Shared.Next(-20, 55)",
                Title = "Summaries[Random.Shared.Next(Summaries.Length)]",
                Description = "Summaries[Random.Shared.Next(Summaries.Length)]",
            })
            .ToArray();
    }
}