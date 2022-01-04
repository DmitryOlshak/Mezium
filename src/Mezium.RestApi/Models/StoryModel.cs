namespace Mezium.RestApi.Models;

public class StoryModel
{
    public string AuthorName { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string? Description { get; init; }
    public DateTimeOffset PublishDate { get; init; }
}