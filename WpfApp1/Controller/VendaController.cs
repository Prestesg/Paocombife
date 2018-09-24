using Paocombife.Model;
using PaocomBife.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaocomBife.Controller
{
    class VendaController
    {
        private ContextoBase contexto;

        public VendaController()
        {
            contexto = new ContextoBase();
        }

        public Venda AddNewVenda(Produto produto)
        {
            var venda = new Venda { Valor = produto.Preço, IDProduto = produto, DataVenda= DateTime.Now };
            contexto.Vendas.Add(venda);
            contexto.SaveChanges();
            return venda;
        }
    }
}
