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
        private readonly ContextoBase contexto;

        public VendaController()
        {
            contexto = new ContextoBase();
        }

        public Venda AddNewVenda(int valor, Produto produto)
        {
            var venda = new Venda { Valor = valor, IDProduto = produto, DataVenda= DateTime.Now };
            contexto.Vendas.Add(venda);
            contexto.SaveChanges();

            return venda;
        }
    }
}
