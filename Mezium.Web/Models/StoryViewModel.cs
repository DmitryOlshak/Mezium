namespace Mezium.Web.Models;

public class StoryViewModel
{
    public string AuthorName { get; init; } = String.Empty;
    public string Title { get; init; } = String.Empty;
    public string Description { get; init; } = String.Empty;
    public DateTimeOffset PublishDate { get; init; } 
}