using Mezium.Web.Application;
using Mezium.Web.Domain;
using Microsoft.EntityFrameworkCore;

namespace Mezium.Web.Infrastructure.Persistence;

public sealed class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Story> Stories => Set<Story>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=meziumdb;Username=admin;Password=123qweASD");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Story>().HasData(new[]
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

    public static async Task InitAsync()
    {
        await using var context = new ApplicationDbContext();
        await context.Database.EnsureCreatedAsync();
    }
}