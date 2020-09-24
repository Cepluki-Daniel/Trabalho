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
    public partial class Adicionar : Form
    {
        Principal TelaPrincipal = new Principal();
        List<Produtos> ListaProdutos = new List<Produtos>();
        public Adicionar(Principal TelaPrincipal, List<Produtos> ListaProdutos)
        {
            InitializeComponent();
            this.TelaPrincipal = TelaPrincipal;
            this.ListaProdutos = ListaProdutos;
        }

        public void AdicionarProduto(string Produto, string Marca, string Categoria, string Preco)
        {
            if( Produto != "" && Marca != "" && Categoria != "" && Preco != "")
            {
                if (ListaProdutos.Count == 0)
                {
                    Produtos NovoProduto = new Produtos();
                    NovoProduto.Produto = Produto;
                    NovoProduto.Marca = Marca;
                    NovoProduto.Categoria = Categoria;
                    NovoProduto.Preco = Convert.ToInt16(Preco);
                    ListaProdutos.Add(NovoProduto);
                    MessageBox.Show("Cadastrado");
                    this.Close();
                }
                else
                {
                    for (int I = 0; I < ListaProdutos.Count; I++)
                    {
                        if (Produto == ListaProdutos[I].Produto && Marca == ListaProdutos[I].Marca)
                        {
                            MessageBox.Show("Produto já cadastrado");
                            break;
                        }
                        else
                        {
                            Produtos NovoProduto = new Produtos();
                            NovoProduto.Produto = Produto;
                            NovoProduto.Marca = Marca;
                            NovoProduto.Categoria = Categoria;
                            NovoProduto.Preco = Convert.ToInt16(Preco);
                            ListaProdutos.Add(NovoProduto);
                            MessageBox.Show("Cadastrado");
                            break; 
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarProduto(txtPoduto.Text, txtMarca.Text, txtCategoria.Text, txtPreco.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alterações não realizadas");
            this.Close();
        }
    }
}
