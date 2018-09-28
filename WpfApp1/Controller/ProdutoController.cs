using Paocombife.Model;
using PaocomBife.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace PaocomBife.Controller
{
    class ProdutoController
    {
        private readonly ContextoBase contexto;

        public ProdutoController()
        {
            contexto = new ContextoBase();
        }

        public List<Produto> AddNewProduto(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
            return contexto.Produtos.ToList();
        }

        public List<Produto> ListProdutos()
        {
            var produtos = contexto.Produtos;
            return produtos.ToList();
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
            Produto produtobase = contexto.Produtos.Find(produtochange.ID);
            produtobase.Nome = produtochange.Nome;
            produtobase.Preço = produtochange.Preço;
            produtobase.Imagem = produtochange.Imagem;
            return produtobase;
        }
    }
}
