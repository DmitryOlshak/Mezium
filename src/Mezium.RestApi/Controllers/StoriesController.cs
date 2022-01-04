using Mezium.RestApi.Application;
using Mezium.RestApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mezium.RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StoriesController : ControllerBase
{
    private readonly IApplicationDbContext _dbContext;

    public StoriesController(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<IEnumerable<StoryModel>> List(CancellationToken token = default)
    {
        var stories = await _dbContext.Stories.ToListAsync(token);
        
        return stories.Select(story => new StoryModel()
            {
                PublishDate = story.PublishDate,
                AuthorName = story.AuthorName,
                Title = story.Title,
                Description = story.Description,
            })
            .ToArray();
    }
}