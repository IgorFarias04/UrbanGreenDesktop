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
    public partial class UserControlTituloProdutos : UserControl
    {
        private FormTelaPrincipal formTelaPrincipal;
        public UserControlTituloProdutos(FormTelaPrincipal principal)
        {
            InitializeComponent();
            formTelaPrincipal = principal;
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            FormAdicionarProdutos formAdicionar = new FormAdicionarProdutos();

            // Verifique se o ShowDialog() está retornando OK
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                UserControlProdutos novoProduto = new UserControlProdutos();

                // Preencher o UserControl com os dados do formulário
                novoProduto.AdicionarProduto = formAdicionar.AdicionarProduto;
                novoProduto.QuantidadeEmEstoque = formAdicionar.QuantiadadeEmEstoque;
                novoProduto.ValorProduto = formAdicionar.ValorProduto;
                // Adicionar o UserControl no panelPrincipal do FormTelaPrincipal
                formTelaPrincipal.AdicionarProdutos(novoProduto);
            }

        }
    }
}
