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
    public partial class UserControlTituloFuncionarios : UserControl
    {

        private FormTelaPrincipal formTelaPrincipal;

        public UserControlTituloFuncionarios(FormTelaPrincipal principal)
        {
            InitializeComponent();
            formTelaPrincipal = principal;
        }

        private void btnAdicionarFuncionarios_Click(object sender, EventArgs e)
        {
            FormAdicionarFuncionarios formAdicionarFuncionarios = new FormAdicionarFuncionarios();

            // Verifique se o ShowDialog() está retornando OK
            if (formAdicionarFuncionarios.ShowDialog() == DialogResult.OK)
            {
                UserControlFuncionarios novoFuncionario = new UserControlFuncionarios();

                // Preencher o UserControl com os dados do formulário
                novoFuncionario.Usuario = formAdicionarFuncionarios.Usuario;
                novoFuncionario.EmailFuncionarios = formAdicionarFuncionarios.EmailFuncionarios;
                novoFuncionario.Senha = formAdicionarFuncionarios.Senha;
                novoFuncionario.Role = formAdicionarFuncionarios.Role;

                // Adicionar o UserControl no panelPrincipal do FormTelaPrincipal
                formTelaPrincipal.AdicionarFuncionario(novoFuncionario);
            }
        }
    }
}
