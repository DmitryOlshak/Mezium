using Mezium.Domain;
using Microsoft.EntityFrameworkCore;

namespace Mezium.RestApi.Application;

public interface IApplicationDbContext
{
    DbSet<Story> Stories { get; }
}