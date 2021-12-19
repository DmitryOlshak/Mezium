using Mezium.Web.Application;
using Mezium.Web.Domain;
using Mezium.Web.Infrastructure.Persistence.ModelBuilders;
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
        StoryBuilder.Build(modelBuilder);
    }

    public static async Task InitAsync()
    {
        await using var context = new ApplicationDbContext();
        await context.Database.EnsureDeletedAsync();
        await context.Database.EnsureCreatedAsync();
    }
}