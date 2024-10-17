using GerenciamentoProdutos.Domain.Entities.Write.Produtos;
using MediatR;

namespace GerenciamentoProdutos.Application.Commands.Produtos;

public class CriarProdutoCommand : IRequest<Produto?>
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
}
