using PaocomBife.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
