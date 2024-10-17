using Ardalis.Specification;

namespace GerenciamentoProdutos.Application.Persistence;

public interface IReadRepository<T> : IReadRepositoryBase<T> 
    where T : class
{
}
