using Paocombife.Model;
using PaocomBife.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaocomBife.Controller
{
    class PedidoController
    {
        private readonly ContextoBase contexto;

        public PedidoController()
        {
            contexto = new ContextoBase();
        }

        public Pedido AddNewPedido(Produto produto)
        {
            var pedido = new Pedido { IDProduto = produto };
            contexto.Vendas.Add(pedido);
            contexto.SaveChanges();

            return pedido;
        }
    }
}
