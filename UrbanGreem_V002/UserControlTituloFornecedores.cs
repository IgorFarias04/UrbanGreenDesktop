using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanGreem_V002
{
    public partial class UserControlTituloFornecedores : UserControl
    {
        private FormTelaPrincipal formTelaPrincipal;

        public UserControlTituloFornecedores(FormTelaPrincipal principal)
        {
            InitializeComponent();
            formTelaPrincipal = principal;
        }

        private void btnAdicionarFornecedores_Click(object sender, EventArgs e)
        {
            FormAdicionarFornecedores formAdicionar = new FormAdicionarFornecedores();

            // Verifique se o ShowDialog() está retornando OK
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                UserControlFornecedores novoFornecedor = new UserControlFornecedores();

                // Preencher o UserControl com os dados do formulário
                novoFornecedor.Empresa = formAdicionar.Empresa;
                novoFornecedor.Responsavel = formAdicionar.Responsavel;
                novoFornecedor.Telefone = formAdicionar.Telefone;
                novoFornecedor.Email = formAdicionar.Email;
                novoFornecedor.Produto = formAdicionar.Produto;
                novoFornecedor.ValorTonelada = formAdicionar.ValorTonelada;

                // Adicionar o UserControl no panelPrincipal do FormTelaPrincipal
                formTelaPrincipal.AdicionarFornecedor(novoFornecedor);
            }
        }
    }
    
}
