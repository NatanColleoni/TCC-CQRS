using Ardalis.Specification.EntityFrameworkCore;
using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Infrastructure.Persistence.Context;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Repository;

public class GerenciamentoProdutosDbRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T>
    where T : class, IAggregateRoot
{
    public GerenciamentoProdutosDbRepository(GerenciamentoProdutosDbContext context)
        : base(context)
    {

    }
}
