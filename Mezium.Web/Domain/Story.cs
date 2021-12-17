namespace Mezium.Web.Domain;

public class Story
{
    public Story()
    {
        
    }
    
    public Story(string authorName, string title, DateTimeOffset publishDate)
    {
        AuthorName = authorName;
        Title = title;
        PublishDate = publishDate;
    }

    public int Id { get; set; }
    public string AuthorName { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTimeOffset PublishDate { get; set; }
    
    public string? Content { get; set; }
}