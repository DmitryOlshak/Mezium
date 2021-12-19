namespace Mezium.RestApi.Models;

public class Story
{
    public string AuthorName { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public DateTimeOffset PublishDate { get; init; }
}