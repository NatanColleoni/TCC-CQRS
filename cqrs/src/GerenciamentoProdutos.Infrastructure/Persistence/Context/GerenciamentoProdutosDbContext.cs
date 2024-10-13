using GerenciamentoProdutos.Domain.Entities.ItensPedidos;
using GerenciamentoProdutos.Domain.Entities.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Produtos;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Context;

public class GerenciamentoProdutosDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItensPedido> ItensPedido { get; set; }
}
