using Ardalis.Specification.EntityFrameworkCore;
using GerenciamentoProdutos.Application.Persistence;
using GerenciamentoProdutos.Domain.Common.Contracts;
using GerenciamentoProdutos.Infrastructure.Persistence.Context.Write;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Repository.Write;

public class GerenciamentoProdutosWriteDbRepository<T> : RepositoryBase<T>,  IRepository<T>
    where T : class, IAggregateRoot
{
    public GerenciamentoProdutosWriteDbRepository(GerenciamentoProdutosWriteDbContext context)
        : base(context)
    {

    }
}
