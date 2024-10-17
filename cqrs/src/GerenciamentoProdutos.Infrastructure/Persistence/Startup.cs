using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Infrastructure.Persistence.Context.Read;
using GerenciamentoProdutos.Infrastructure.Persistence.Context.Write;
using GerenciamentoProdutos.Infrastructure.Persistence.Repository;
using GerenciamentoProdutos.Infrastructure.Persistence.Repository.Write;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoProdutos.Infrastructure.Persistence;

internal static class Startup
{
    internal static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<GerenciamentoProdutosWriteDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("WriteConnection"), x => x.MigrationsAssembly("GerenciamentoProdutos.Infrastructure"));
        });

        services.AddDbContext<GerenciamentoProdutosReadDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ReadConnection"), x => x.MigrationsAssembly("GerenciamentoProdutos.Infrastructure"));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });

        services.AddRepositories();

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(GerenciamentoProdutosWriteDbRepository<>));
        services.AddScoped(typeof(IReadRepository<>), typeof(GerenciamentoProdutosReadDbRepository<>));

        foreach (var aggregateRootType in
            typeof(IAggregateRoot).Assembly.GetExportedTypes()
                .Where(t => typeof(IAggregateRoot).IsAssignableFrom(t) && t.IsClass)
                .ToList())
        {
            services.AddScoped(typeof(IReadRepository<>).MakeGenericType(aggregateRootType), sp =>
                sp.GetRequiredService(typeof(IRepository<>).MakeGenericType(aggregateRootType)));
        }

        return services;
    }
}
