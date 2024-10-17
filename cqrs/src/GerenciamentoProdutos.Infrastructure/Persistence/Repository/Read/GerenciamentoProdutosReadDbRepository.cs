using Ardalis.Specification.EntityFrameworkCore;
using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Infrastructure.Persistence.Context.Read;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Repository;

public class GerenciamentoProdutosReadDbRepository<T> : RepositoryBase<T>, IReadRepository<T>
    where T : class
{
    public GerenciamentoProdutosReadDbRepository(GerenciamentoProdutosReadDbContext context) 
        : base(context)
    {

    }
}
