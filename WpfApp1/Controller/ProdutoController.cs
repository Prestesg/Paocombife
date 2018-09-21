using Paocombife.Model;
using PaocomBife.Contexto;

namespace PaocomBife.Controller
{
    class ProdutoController
    {
        private readonly ContextoBase contexto;

        public ProdutoController()
        {
            contexto = new ContextoBase();
        }

        public Produto AddNewProduto(string nome, int preco)
        {
            var produto = new Produto { Nome = nome, Preço = preco };
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();

            return produto;
        }
    }
}
