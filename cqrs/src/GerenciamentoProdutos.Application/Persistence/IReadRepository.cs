using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Common.Contracts;

namespace GerenciamentoProdutos.Application.Persistence;

public interface IReadRepository<T> : IReadRepositoryBase<T> 
    where T : class, IAggregateRoot
{
}
