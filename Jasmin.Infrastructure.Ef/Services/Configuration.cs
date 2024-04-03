using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Jasmin.Infrastructure.Ef.Services;

public class Configuration
{
    public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<DataContext>();


    public static Action<SqlServerDbContextOptionsBuilder> GetConnectionString(string defaultconnection)
    {
        throw new NotImplementedException();
    }
}