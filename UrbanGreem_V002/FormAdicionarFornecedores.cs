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
    public partial class FormAdicionarFornecedores : Form
    {

        public FormTelaPrincipal formTelaPrincipal;

        public FormAdicionarFornecedores()
        {
            InitializeComponent();
            txtValorTonelada.KeyPress += txtValorTonelada_KeyPress;
            txtValorTonelada.Leave += txtValorTonelada_Leave;
        }
        public string Empresa
        {
            get { return txtEmpresa.Text; }
            set { txtEmpresa.Text = value; }
        }
        public string Responsavel
        {
            get { return txtResponsavel.Text; }
            set { txtResponsavel.Text = value; }
        }
        public string Telefone
        {
            get { return txtTelefone.Text; }
            set { txtTelefone.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }
        public string Produto
        {
            get { return txtProduto.Text; }
            set { txtProduto.Text = value; }
        }

        public string ValorTonelada
        {
            get { return txtValorTonelada.Text; }
            set { txtValorTonelada.Text = value; }
        }
        private void btnSalvarFornecedores_Click(object sender, EventArgs e)
        {
    // Você pode adicionar validações aqui, como verificar se os campos estão preenchidos

    if (string.IsNullOrWhiteSpace(txtEmpresa.Text) || 
        string.IsNullOrWhiteSpace(txtResponsavel.Text) || 
        string.IsNullOrWhiteSpace(txtTelefone.Text) || 
        string.IsNullOrWhiteSpace(txtEmail.Text) || 
        string.IsNullOrWhiteSpace(txtProduto.Text) || 
        string.IsNullOrWhiteSpace(txtValorTonelada.Text)) 
    {
        MessageBox.Show("Por favor, preencha todos os campos.");
        return; // Não fecha o formulário se a validação falhar
    }

    // Se a validação passar, fecha o formulário
    this.DialogResult = DialogResult.OK; 
    this.Close(); // Fecha o formulário
        }

        private void txtValorTonelada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Rejeita a entrada
            }
            if (e.KeyChar == '.' && txtValorTonelada.Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Rejeita a entrada
            }

        }
        private void txtValorTonelada_Leave(object sender, EventArgs e)
        {
            // Tenta converter o texto para decimal
            if (decimal.TryParse(txtValorTonelada.Text.Replace("R$ ", "").Trim(), out decimal valor))
            {
                // Formata o valor e coloca o símbolo R$
                txtValorTonelada.Text = $"R$ {valor:N2}";
            }
            else
            {
                // Se não for um número válido, mantém o valor digitado sem formatação
                // Você pode decidir se deseja mostrar uma mensagem de erro ou não
                // Exemplo: txtValorTonelada.Text = ""; // Limpa o campo se não for válido
            }
        }

        private void txtValorTonelada_Enter(object sender, EventArgs e)
        {
            // Remove o R$ ao entrar no campo para edição
            txtValorTonelada.Text = txtValorTonelada.Text.Replace("R$ ", "").Trim();
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtResponsavel.Focus();
                txtResponsavel.SelectAll();
            }
        }

        private void txtResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTelefone.Focus();
                txtTelefone.SelectAll();
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtProduto.Focus();
                txtProduto.SelectAll();
            }
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValorTonelada.Focus();
                txtValorTonelada.SelectAll();
            }
        }
    }
}
