using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanGreem_V002
{
    public partial class UserControlProdutos : UserControl
    {
        public UserControlProdutos()
        {
            InitializeComponent();
        }
        public string AdicionarProduto
        {
            get { return lblAdicionarProduto.Text; }
            set { lblAdicionarProduto.Text = value; }
        }
        public string QuantidadeEmEstoque
        {
            get { return lblQuantidadeEmEstoque.Text; }
            set { lblQuantidadeEmEstoque.Text = value; }
        }
        public string ValorProduto
        {
            get { return lblValorProduto.Text; }
            set { lblValorProduto.Text = value; }
        }

        private void btnEditaarProduto_Click(object sender, EventArgs e)
        {
            FormAdicionarProdutos formAdicionar = new FormAdicionarProdutos();

            // Carregar os dados atuais nos campos de texto
            formAdicionar.AdicionarProduto = lblAdicionarProduto.Text;
            formAdicionar.QuantiadadeEmEstoque = lblQuantidadeEmEstoque.Text;
            formAdicionar.ValorProduto = lblValorProduto.Text;

            // Mostrar o formulário e aguardar a resposta
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualiza os labels com as novas informações
                lblAdicionarProduto.Text = formAdicionar.AdicionarProduto;
                lblQuantidadeEmEstoque.Text = formAdicionar.QuantiadadeEmEstoque;
                lblValorProduto.Text = formAdicionar.ValorProduto;
      
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
