namespace Mezium.Domain;

public class Story
{
    public Story(string authorName, string title, DateTimeOffset publishDate)
    {
        AuthorName = authorName;
        Title = title;
        PublishDate = publishDate;
    }

    public int Id { get; set; }
    public string AuthorName { get; }
    public string Title { get; }
    public string? Description { get; set; }
    public DateTimeOffset PublishDate { get; }
    
    public string? Content { get; set; }
}