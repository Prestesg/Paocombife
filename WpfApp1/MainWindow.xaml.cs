﻿using Paocombife.Model;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        Produto produto;
        Pedido pedido;
        Fechamento fechamento;
        Venda venda;
        private List<Produto> produtos;

        public MainWindow()
        {

            InitializeComponent();

            produtos = new List<Produto>();

            Produto marmita = new Produto();
            marmita.Nome = "Marmita";
            marmita.Preço = 15;

            produtos.Add(marmita);
        }

        private void Cardapio_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void Pedidos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fechamento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CarregarCarrinho(object sender, RoutedEventArgs e)
        {
            
            try
            {
                produto = new Produto();
                var buttonTag = ((Button)sender).Tag;
                string tag = buttonTag.ToString();

                switch (buttonTag)
                {
                    case "1" :
                        produto.ID = 1;
                        produto.Nome = "Marmita";
                        produto.Preço = 10;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                    case "2":
                        produto.ID = 2;
                        produto.Nome = "Buffet Livre";
                        produto.Preço = 12;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                    case "3":
                        produto.ID = 3;
                        produto.Nome = "Combo";
                        produto.Preço = 15;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                    case "4":
                        produto.ID = 4;
                        produto.Nome = "Refigerante 1";
                        produto.Preço = 2;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                    case "5":
                        produto.ID = 5;
                        produto.Nome = "Refigerante 2";
                        produto.Preço = 4;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                    case "6":
                        produto.ID = 6;
                        produto.Nome = "Refigerante 3";
                        produto.Preço = 6;
                        produto.Imagem = "TESTE";
                        Carrinho.Items.Add(produto);
                        break;
                }
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

        }
    }
}
