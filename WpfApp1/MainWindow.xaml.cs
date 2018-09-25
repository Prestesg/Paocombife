﻿using Paocombife.Model;
using PaocomBife;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fechamento = PaocomBife.Fechamento;
using PaocomBife.Controller;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        Produto produto;
        Pedido pedido;
        Fechamento fechamento;
        Venda venda;
        private List<Produto> produtos;
        ProdutoController produtocontrole;
        VendaController vendacontrole;

        public MainWindow()
        {
                int iRow = -1;

            InitializeComponent();
            foreach(RowDefinition row in Griddebotoes.RowDefinitions)
            {
                iRow++;
                int iCol = -1;
                foreach (ColumnDefinition col in Griddebotoes.ColumnDefinitions)
                {
                    iCol++;
                    Border panel = new Border();
                    Grid.SetColumn(panel,iCol);
                    Grid.SetRow(panel, iRow);
                    Button botao = new Button();
                    panel.Child = botao;
                        /*
                                < Button x: Name = "Produto" Tag = "1"  HorizontalAlignment = "Left" Margin = "10,36,0,0" VerticalAlignment = "Top" Width = "91" Height = "84" Click = "CarregarCarrinho" >
                            < StackPanel Width = "91" >
                                 < Image Source = "marmitex.png" VerticalAlignment = "Top" Height = "29" Width = "36" RenderTransformOrigin = "0.5,0.5" >
                                          </ Image >
                                          < Label x: Name = "Nome" HorizontalAlignment = "Center" Content = "Marmita" FontWeight = "Bold" Height = "24" />
                                                    < Label x: Name = "Valor" HorizontalAlignment = "Left" Content = "Valor: R$10" />
                                                      </ StackPanel >
                                                  </ Button >*/
                }
            }
            //Mandas Carregar Lista de Produtos PARA EXIBIR BOTÕES OK

            //List<Produto> listaprodutos = produtocontrole.ListProdutos();

            //ITERAR LISTA PARA GERAR BOTÕES FALTA
        }

        private void CarregarCarrinho(object sender, RoutedEventArgs e)
        {
            
            try
            {
                produto = new Produto();
                var buttonTag = ((Button)sender).Tag;
                string tag = buttonTag.ToString();
                //Busca produtos de insere no carrinho OK
                /*produto = produtocontrole.FindProduto(Int32.Parse(tag));
                Carrinho.Items.Add(produto);*/

                switch (buttonTag)
                {
                    case "1" :
                        produto.ID = 1;
                        produto.Nome = "Marmita";
                        produto.Preço = 10;
                        produto.Imagem = "TESTE";
                        break;
                    case "2":
                        produto.ID = 2;
                        produto.Nome = "Buffet Livre";
                        produto.Preço = 12;
                        produto.Imagem = "TESTE";
                        break;
                    case "3":
                        produto.ID = 3;
                        produto.Nome = "Combo";
                        produto.Preço = 15;
                        produto.Imagem = "TESTE";
                        break;
                    case "4":
                        produto.ID = 4;
                        produto.Nome = "Refigerante 1";
                        produto.Preço = 2;
                        produto.Imagem = "TESTE";
                        break;
                    case "5":
                        produto.ID = 5;
                        produto.Nome = "Refigerante 2";
                        produto.Preço = 4;
                        produto.Imagem = "TESTE";
                        break;
                    case "6":
                        produto.ID = 6;
                        produto.Nome = "Refigerante 3";
                        produto.Preço = 6;
                        produto.Imagem = "TESTE";
                        break;
                }
                Carrinho.Items.Add(produto);
                var total = Int32.Parse(Total.Text);
                var subtotal = Int32.Parse(Subtotal.Text);
                total = total + produto.Preço;
                subtotal = subtotal + produto.Preço;
                Total.Text = total.ToString();
                Subtotal.Text = subtotal.ToString();
            }
            catch{
                MessageBox.Show("Deu Ruim");
            }
        }

        private void DescarregarCarrinho(object sender, RoutedEventArgs e)
        {
            try
            {
                var total = Int32.Parse(Total.Text);
                var subtotal = Int32.Parse(Subtotal.Text);
                Produto selecionado = Carrinho.Items[Carrinho.SelectedIndex] as Produto;
                total = total - selecionado.Preço;
                subtotal = subtotal - selecionado.Preço;
                Total.Text = total.ToString();
                Subtotal.Text = subtotal.ToString();
                Carrinho.Items.RemoveAt(Carrinho.Items.IndexOf(Carrinho.SelectedItem));
            }
            catch
            {
                MessageBox.Show("Selecione um item do carrinho para descarrega-lo");
            }
        }
    
        private void QuandoapertarEnterDescontar(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    var desconto = Int32.Parse(Desconto.Text);
                    var total = Int32.Parse(Total.Text);
                    total = total - desconto;
                    Total.Text = total.ToString();
                }
            }catch
            {
                MessageBox.Show("Informe somente números inteiros");
            }
        }

        private void QuandoapertarEnterPago(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    var total = Int32.Parse(Total.Text);
                    var pago = Int32.Parse(Pago.Text);
                    total = pago - total;
                    Troco.Text = total.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Informe somente números inteiros");
            }
        }

        private void FinalizaCompra(object sender, RoutedEventArgs e)
        {
            var subtotal = Int32.Parse(Subtotal.Text);
            var total = Int32.Parse(Total.Text);
            var desconto = Int32.Parse(Desconto.Text);
            var pago = Int32.Parse(Pago.Text);

            foreach (var produto in Carrinho.Items.OfType<Produto>())
            {
                //MANDAR FAZER QUERY DE INSERÇÃO EM VENDAS OK
                //vendacontrole.AddNewVenda(produto);
                MessageBox.Show("Adicionou"+ produto.Nome);
            }
            this.Zerarcampos();
        }

        private void inCardapio_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Cardapio();
            w.ShowDialog();
        }

        private void inFechamento_Click(object sender, RoutedEventArgs e)
        {
            //FAZER QUER DE SOMA DE TODAS AS VENDAS
            Window w = new Fechamento();
            w.ShowDialog();
        }

        private void inPedido_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Pedidos();
            w.ShowDialog();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Zerarcampos();
        }


        public void Zerarcampos()
        {
            Carrinho.Items.Clear();
            Troco.Text = 0.ToString();
            Total.Text = 0.ToString();
            Pago.Text = 0.ToString();
            Desconto.Text = 0.ToString();
            Subtotal.Text = 0.ToString();
        }

    }
}
