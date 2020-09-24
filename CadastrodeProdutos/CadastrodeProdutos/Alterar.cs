using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrodeProdutos
{
    public partial class Alterar : Form
    {
        Principal TelaPrincipal = new Principal();
        List<Produtos> ListaProdutos = new List<Produtos>();
        public Alterar(Principal TelaPrincipal, List<Produtos> ListaProdutos)
        {
            InitializeComponent();
            this.TelaPrincipal = TelaPrincipal;
            this.ListaProdutos = ListaProdutos;
            ListaConcatenada();
            boxProdutos.Sorted = true;
        }

        public void ListaConcatenada()
        {
            for (int I = 0; I < ListaProdutos.Count; I++)
            {
                boxProdutos.Items.Add(ListaProdutos[I].Marca + " - " + ListaProdutos[I].Produto);
            }
        }

        public void AlterarProduto (string Produto, string Marca, string Categoria, string Preco)
        {
            string Selecionado = Convert.ToString(boxProdutos.SelectedItem);
            if (Selecionado != "")
            {
                if (txtNomeProduto.Text != "" && txtMarcaProduto.Text != "" && txtCategoriaProduto.Text != "")
                {
                    for (int I = 0; I < ListaProdutos.Count; I++)
                    {
                        string Concatenado = ListaProdutos[I].Marca + " - " + ListaProdutos[I].Produto;
                        if (Concatenado == Selecionado)
                        {
                            //Produtos NovoProduto = new Produtos();
                            //NovoProduto.Produto = Produto;
                            //NovoProduto.Marca = Marca;
                            //NovoProduto.Categoria = Categoria;
                            //NovoProduto.Preco = Convert.ToInt16(Preco);
                            //ListaProdutos.Add(NovoProduto);
                            ListaProdutos[I].Produto = Produto;
                            ListaProdutos[I].Marca = Marca;
                            ListaProdutos[I].Categoria = Categoria;
                            ListaProdutos[I].Preco = Convert.ToInt16(Preco);
                            MessageBox.Show("Atualizado");
                            this.Close();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencher campos para serem alterados");
                }
            }
            else
            {
                MessageBox.Show("Selecionar produto");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarProduto(txtNomeProduto.Text, txtMarcaProduto.Text, txtCategoriaProduto.Text, txtPreco.Text);
        }
    }
}
