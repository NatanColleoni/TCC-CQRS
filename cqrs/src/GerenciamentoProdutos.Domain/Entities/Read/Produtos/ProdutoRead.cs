using GerenciamentoProdutos.Domain.Common.Contracts;

namespace GerenciamentoProdutos.Domain.Entities.Read.Produtos;

public class ProdutoRead : BaseEntity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal ValorUnitario { get; set; }
}
