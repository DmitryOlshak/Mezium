using Mezium.Web.Application;
using Mezium.Web.Infrastructure.Persistence;

namespace Mezium.Web.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
    }
}