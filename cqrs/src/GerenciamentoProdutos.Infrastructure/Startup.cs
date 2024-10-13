using GerenciamentoProdutos.Infrastructure.Common;
using GerenciamentoProdutos.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoProdutos.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {   
        return services
            .AddPersistence(configuration)
            .AddServices();
    }
}
