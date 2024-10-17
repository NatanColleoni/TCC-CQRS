using GerenciamentoProdutos.Domain.Entities.Read.ItensPedidos;
using GerenciamentoProdutos.Domain.Entities.Read.Pedidos;
using GerenciamentoProdutos.Domain.Entities.Read.Produtos;
using GerenciamentoProdutos.Infrastructure.Persistence.Configurations.ItensPedidos;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProdutos.Infrastructure.Persistence.Context.Read;

public class GerenciamentoProdutosReadDbContext(DbContextOptions<GerenciamentoProdutosReadDbContext> options) : DbContext(options)
{
    public DbSet<ProdutoRead> Produtos { get; set; }
    public DbSet<PedidoRead> Pedidos { get; set; }
    public DbSet<ItensPedidoRead> ItensPedido { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ItensPedidoConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
