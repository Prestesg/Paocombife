using Paocombife.Model;
using PaocomBife.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PaocomBife
{
    public partial class Cardapio : Window
    {
        Produto produto;

        ProdutoController produtocontrole = new ProdutoController();

        public Cardapio()
        {
            InitializeComponent();
            //FAZER QUERY PARA CARREGAR LISTVIEW DE PRODUTOS OK
            //var list = produtocontrole.ListProdutos();
            List<Produto> list = new List<Produto>();
            if (list != null)
            {
                ListaCardapio.ItemsSource= list.ToList();
            }
        }

        private void Adicionar_Produto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                produto = new Produto();
                produto.ID = 1;
                produto.Imagem = "TESTE";
                produto.Nome = Produto.Text;
                produto.Preço = Int32.Parse(Preço.Text);

                //
                List<Produto> produtosteste = new List<Produto>();
                produtosteste.Add(produto);
                //

                //MANDAR FAZER QUERY DE INSERÇÃO DE PRODUTO ok
                produtocontrole.AddNewProduto(produto);
                ListaCardapio.ItemsSource = produtosteste.ToList();
               // ListaCardapio.ItemsSource = produtocontrole.AddNewProduto(produto).ToList();
            }
            catch
            {
                MessageBox.Show("Não deu boa");
            }
        }

        private void Excluir_Produto_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //QUERY DE EXCLUSÃO
              //  var teste = ListaCardapio.Items[ListaCardapio.SelectedIndex];
            Produto selecionado = ListaCardapio.Items[ListaCardapio.SelectedIndex] as Produto;
            MessageBox.Show(selecionado.ID.ToString());
          //  produtocontrole.RemoveProduto(selecionado.ID);
                ListaCardapio.Items.RemoveAt(ListaCardapio.Items.IndexOf(ListaCardapio.SelectedItem));
            }
            catch
            {
                MessageBox.Show("Selecione o item que deseja excluir");
            }
        }

        private void AlterarDadosBotao_Click(object sender, RoutedEventArgs e)
        {
            Produto selecionado = ListaCardapio.Items[ListaCardapio.SelectedIndex] as Produto;
            produtocontrole.ChangeProduto(produto);
        }
    }
}
