using Ardalis.Specification;
using GerenciamentoProdutos.Domain.Common.Contracts;

namespace GerenciamentoProdutos.Application.Persistence;

public interface IRepository<T> : IRepositoryBase<T>
where T : class, IAggregateRoot
{
}
