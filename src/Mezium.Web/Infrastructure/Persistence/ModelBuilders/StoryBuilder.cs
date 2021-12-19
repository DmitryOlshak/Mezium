using Mezium.Web.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mezium.Web.Infrastructure.Persistence.ModelBuilders;

public static class StoryBuilder
{
    public static void Build(ModelBuilder builder)
    {
        builder.Entity<Story>(BuildType);
        builder.Entity<Story>().HasData(new[]
        {
            new Story(
                "Mark Desent", 
                "You don’t need JWT anymore", 
                DateTimeOffset.UtcNow
            )
            {
                Id = 1,
                Description = "A simpler way to authenticate users with web3 using signed messages.",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Story(
                "Miroslaw Shpak", 
                "Why Senior Software Engineer Interviews Have Become So Damn Difficult", 
                DateTimeOffset.UtcNow.AddDays(-3)
            )
            {
                Id = 2,
                Description = "There is a general sense that interviews for senior positions are getting harder all the time.",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Story(
                "Nick Nolan", 
                "What Would Happen If You Bought $100 of Bitcoin Every Month For a Year?", 
                DateTimeOffset.UtcNow.AddDays(-5) 
            )
            {
                Id = 3,
                Description = "Here’s how much you’d have after a year.",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
        });
    }
    
    private static void BuildType(EntityTypeBuilder<Story> builder)
    {
        builder.HasKey(story => story.Id);
        builder.Property(story => story.AuthorName).IsRequired();
        builder.Property(story => story.Title).IsRequired();
        builder.Property(story => story.PublishDate).IsRequired();
    }
}