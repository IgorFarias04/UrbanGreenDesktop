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
    public partial class UserControlFornecedores : UserControl
    {
        public event Action<UserControlFornecedores> OnExcluirFornecedor;

        public UserControlFornecedores()
        {
            InitializeComponent();
        }

        // Propriedades públicas para setar os dados nas labels
        public string Empresa
        {
            get { return lblEmpresa.Text; }
            set { lblEmpresa.Text = value; }
        }
        public string Responsavel
        {
            get { return lblResponsavel.Text; }
            set { lblResponsavel.Text = value; }
        }
        public string Telefone
        {
            get { return lblTelefone.Text; }
            set { lblTelefone.Text = value; }
        }
        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }
        public string Produto
        {
            get { return lblProduto.Text; }
            set { lblProduto.Text = value; }
        }
        public string ValorTonelada
        {
            get { return lblValorTonelada.Text; }
            set { lblValorTonelada.Text = value; }
        }

        private void btnEditarFornecedores_Click(object sender, EventArgs e)
        {
            FormAdicionarFornecedores formAdicionar = new FormAdicionarFornecedores();

            // Carregar os dados atuais nos campos de texto
            formAdicionar.Empresa = lblEmpresa.Text;
            formAdicionar.Responsavel = lblResponsavel.Text;
            formAdicionar.Telefone = lblTelefone.Text;
            formAdicionar.Email = lblEmail.Text;
            formAdicionar.Produto = lblProduto.Text;
            formAdicionar.ValorTonelada = lblValorTonelada.Text;

            // Mostrar o formulário e aguardar a resposta
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualiza os labels com as novas informações
                lblEmpresa.Text = formAdicionar.Empresa;
                lblResponsavel.Text = formAdicionar.Responsavel;
                lblTelefone.Text = formAdicionar.Telefone;
                lblEmail.Text = formAdicionar.Email;
                lblProduto.Text = formAdicionar.Produto;
                lblValorTonelada.Text = formAdicionar.ValorTonelada;
            }
        }

        private void btnExcluirFornecedores_Click(object sender, EventArgs e)
        {
            ExcluirFornecedor();
        }

        private void ExcluirFornecedor()
        {
            // Verifica se o Parent do UserControl é o FormTelaPrincipal
            if (this.Parent is Panel panel && panel.Parent is FormTelaPrincipal formTelaPrincipal)
            {
                // Chama o método do FormTelaPrincipal para remover o UserControl
                formTelaPrincipal.RemoverFornecedor(this);
            }
        }

    }
}
