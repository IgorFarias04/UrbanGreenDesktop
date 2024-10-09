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
    public partial class UserControlFuncionarios : UserControl
    {
        public event Action<UserControlFuncionarios> OnExcluirFuncionarios;

        public UserControlFuncionarios()
        {
            InitializeComponent();
        }

        public string Usuario
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }
        public string EmailFuncionarios
        {
            get { return lblEmailFuncionarios.Text; }
            set { lblEmailFuncionarios.Text = value; }
        }
        public string Senha
        {
            get { return lblSenha.Text; }
            set { lblSenha.Text = value; }
        }
        public string Role
        {
            get { return lblRole.Text; }
            set { lblRole.Text = value; }

        }

        private void btnEditarFuncionarios_Click(object sender, EventArgs e)
        {
            // Criar uma nova instância do formulário de adicionar fornecedores
            FormAdicionarFuncionarios formAdicionarFuncionarios = new FormAdicionarFuncionarios();

            // Carregar os dados atuais nos campos de texto
            formAdicionarFuncionarios.Usuario = lblUsuario.Text;
            formAdicionarFuncionarios.EmailFuncionarios = lblEmailFuncionarios.Text;
            formAdicionarFuncionarios.Senha = lblSenha.Text;
            formAdicionarFuncionarios.Role = lblRole.Text;


            // Mostrar o formulário e aguardar a resposta
            if (formAdicionarFuncionarios.ShowDialog() == DialogResult.OK)
            {
                // Atualiza os labels com as novas informações
                lblUsuario.Text = formAdicionarFuncionarios.Usuario;
                lblEmailFuncionarios.Text = formAdicionarFuncionarios.EmailFuncionarios;
                lblSenha.Text = formAdicionarFuncionarios.Senha;
                lblRole.Text = formAdicionarFuncionarios.Role;

            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario();
        }

        private void ExcluirFuncionario()
        {
            // Verifica se o Parent do UserControl é o FormTelaPrincipal
            if (this.Parent is Panel panel && panel.Parent is FormTelaPrincipal formTelaPrincipal)
            {
                // Chama o método do FormTelaPrincipal para remover o UserControl
                formTelaPrincipal.RemoverFuncionario(this);
            }
        }
    }
}
