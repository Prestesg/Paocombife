using Paocombife.Model;
using System.Data.Entity;

namespace PaocomBife.Contexto
{
    class ContextoBase : DbContext 
    {
        public ContextoBase() : base("Default")
        {
        }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Fechamento> Fechamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
