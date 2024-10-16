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

        public void AtualizarImagemProduto(Image imagem)
        {
            if (imagem != null)
            {
                imagemProdutosUser.Image = imagem; // Defina a imagem no pictureBox do UserControl
            }
        }

        private void btnEditaarProduto_Click(object sender, EventArgs e)
        {
            FormAdicionarProdutos formAdicionar = new FormAdicionarProdutos();
            // Carregar os dados atuais nos campos de texto
            formAdicionar.AdicionarProduto = lblAdicionarProduto.Text;
            formAdicionar.QuantiadadeEmEstoque = lblQuantidadeEmEstoque.Text;
            formAdicionar.ValorProduto = lblValorProduto.Text;
            formAdicionar.ImagemProduto = imagemProdutosUser.Image;
            // Mostrar o formulário e aguardar a resposta
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualiza os labels com as novas informações
                lblAdicionarProduto.Text = formAdicionar.AdicionarProduto;
                lblQuantidadeEmEstoque.Text = formAdicionar.QuantiadadeEmEstoque;
                lblValorProduto.Text = formAdicionar.ValorProduto;
                if (formAdicionar.ImagemProduto != null)
                {
                    imagemProdutosUser.Image = formAdicionar.ImagemProduto;
                }
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            ExcluirProdutos();
        }

        private void ExcluirProdutos()
        {
            // Verifica se o Parent do UserControl é o FormTelaPrincipal
            if (this.Parent is Panel panel && panel.Parent is FormTelaPrincipal formTelaPrincipal)
            {
                // Chama o método do FormTelaPrincipal para remover o UserControl
                formTelaPrincipal.RemoverProdutos(this);
            }
        }
    }
}
