using Paocombife.Model;
using PaocomBife.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace PaocomBife.Controller
{
    class ProdutoController
    {
        private readonly ContextoBase contexto;

        public static List<Produto> produtopersist; 

        public ProdutoController()
        {
            contexto = new ContextoBase();
            produtopersist = new List<Produto>();
        }

        public List<Produto> AddNewProduto(Produto produto)
        {
            produtopersist.Add(produto);
            //contexto.Produtos.Add(produto);
            //contexto.SaveChanges();
            return produtopersist;
        }

        public List<Produto> ListProdutos()
        {
            var produtos = contexto.Produtos;
            return produtos.ToList();
        }

        //Função para persistir em array em tempo de execução
        public List<Produto> ExibirLista()
        {
            Produto produto = new Produto();
            produto.ID = 1;
            produto.Nome = "TESTE";
            produto.Preço = 10;
            produto.Imagem ="TESTE";

            produtopersist.Add(produto);
            return produtopersist.ToList();
        }

        public Produto FindProduto(int id)
        {
            Produto produto = contexto.Produtos.Find(id);
            return produto;
        }

        public Produto RemoveProduto(int id)
        {
            Produto produto = contexto.Produtos.Find(id);
            contexto.Produtos.Remove(produto);
            return produto;
        }

        public Produto ChangeProduto(Produto produtochange)
        {
            Produto produtobase = new Produto();// = contexto.Produtos.Find(produtochange.ID);
            produtobase.Nome = produtochange.Nome;
            produtobase.Preço = produtochange.Preço;
            produtobase.Imagem = produtochange.Imagem;
            return produtobase;
        }
    }
}
