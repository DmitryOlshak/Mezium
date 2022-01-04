using Mezium.RestApi.Application;
using Mezium.RestApi.Infrastructure.Persistence;

namespace Mezium.RestApi.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
    }
}