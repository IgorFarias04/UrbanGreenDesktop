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
    public partial class FormTelaPrincipal : Form
    {

        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelTitulo.Visible = false;
            panelPrincipal.Size = new Size (1579, 898);
            panelPrincipal.Location = new Point (296, 96);
            panelPrincipal.Controls.Clear();
            UserControlInicio userControl = new UserControlInicio();
            userControl.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(userControl);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelTitulo.Controls.Clear();
            panelTitulo.Visible = true;
            panelPrincipal.Size = new Size (1579, 806);
            panelPrincipal.Location = new Point(296, 188);
            UserControlTituloFuncionarios tituloFuncionarios = new UserControlTituloFuncionarios(this);
            tituloFuncionarios.Dock = DockStyle.Fill;
            panelTitulo.Controls.Add(tituloFuncionarios);
            ExibirFuncionario();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelTitulo.Controls.Clear();
            panelTitulo.Visible = true;
            panelPrincipal.Size = new Size(1579, 806);
            panelPrincipal.Location = new Point(296, 188);           
            UserControlTituloFornecedores tituloFornecedores = new UserControlTituloFornecedores(this);
            tituloFornecedores.Dock = DockStyle.Fill;
            panelTitulo.Controls.Add(tituloFornecedores);
            ExibirFornecedores();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelTitulo.Controls.Clear();
            panelTitulo.Visible = true;
            panelPrincipal.Size = new Size(1579, 806);
            panelPrincipal.Location = new Point(296, 188);
            UserControlTituloProducao tituloProducao = new UserControlTituloProducao();
            tituloProducao.Dock = DockStyle.Fill;
            panelTitulo.Controls.Add(tituloProducao);
        }

        //----------- FORNECEDORES ----------

        public void RemoverFornecedor(UserControlFornecedores fornecedor)
        {
            // Verifica se o panelPrincipal contém o UserControl e o remove
            if (panelPrincipal.Controls.Contains(fornecedor))
            {
                panelPrincipal.Controls.Remove(fornecedor);
                fornecedor.Dispose(); // Libera os recursos do UserControl
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.ToLower();

            // Percorre todos os controles do panelPrincipal
            foreach (Control controle in panelPrincipal.Controls)
            {
                // Verifica se o controle é um UserControlFornecedores
                if (controle is UserControlFornecedores fornecedor)
                {
                    // Verifica se o texto de pesquisa corresponde à empresa ou responsável
                    bool visivel = fornecedor.Empresa.ToLower().Contains(pesquisa) ||
                                   fornecedor.Responsavel.ToLower().Contains(pesquisa);

                    // Mostra ou esconde o UserControlFornecedores com base na correspondência
                    fornecedor.Visible = visivel;
                }
            }
        }


        private List<UserControlFornecedores> fornecedores = new List<UserControlFornecedores>();

        // Método para adicionar fornecedor na lista e no painel
        public void AdicionarFornecedor(UserControlFornecedores fornecedor)
        {
            fornecedor.Dock = DockStyle.Top;
            fornecedores.Add(fornecedor);
            panelPrincipal.Controls.Add(fornecedor);
        }

        // Método para reexibir os fornecedores
        public void ExibirFornecedores()
        {
            panelPrincipal.Controls.Clear(); // Limpa o painel para exibir os fornecedores
            foreach (var fornecedor in fornecedores)
            {
                panelPrincipal.Controls.Add(fornecedor); // Reimprime todos os fornecedores
            }
        }

        //------------ FUNCIONARIOS ---------------

        public void RemoverFuncionario(UserControlFuncionarios funcionarios)
        {
            // Verifica se o panelPrincipal contém o UserControl e o remove
            if (panelPrincipal.Controls.Contains(funcionarios))
            {
                panelPrincipal.Controls.Remove(funcionarios);
                funcionarios.Dispose(); // Libera os recursos do UserControl
            }
        }

        private List<UserControlFuncionarios> funcionarios = new List<UserControlFuncionarios>();

        // Método para adicionar fornecedor na lista e no painel
        public void AdicionarFuncionario(UserControlFuncionarios funcionario)
        {
            funcionario.Dock = DockStyle.Top;
            funcionarios.Add(funcionario);
            panelPrincipal.Controls.Add(funcionario);
        }

        // Método para reexibir os fornecedores
        public void ExibirFuncionario()
        {
            panelPrincipal.Controls.Clear(); // Limpa o painel para exibir os fornecedores
            foreach (var funcionario in funcionarios)
            {
                panelPrincipal.Controls.Add(funcionario); // Reimprime todos os fornecedores
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTelaLogin telaLogin = new FormTelaLogin();
            telaLogin.ShowDialog();
        }

    }
}
