using Paocombife.Model;
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
    /// <summary>
    /// Lógica interna para Cardapio.xaml
    /// </summary>
    public partial class Cardapio : Window
    {
        Produto produto;

        public Cardapio()
        {
            InitializeComponent();
            //FAZER QUERY PARA CARREGAR LISTVIEW DE PRODUTOS
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
                //MANDAR FAZER QUERY DE INSERÇÃO DE PRODUTO
                ListaCardapio.Items.Add(produto);
            }
            catch
            {
                MessageBox.Show("Não deu boa");
            }
        }

        private void Excluir_Produto_Click(object sender, RoutedEventArgs e)
        {
            Produto selecionado = ListaCardapio.Items[ListaCardapio.SelectedIndex] as Produto;
            MessageBox.Show(selecionado.ID.ToString());
            //QUERY DE EXCLUSÃO
        }
    }
}
