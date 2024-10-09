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
    public partial class FormAdicionarFuncionarios : Form
    {
        public FormTelaPrincipal formTelaPrincipal;

        public FormAdicionarFuncionarios()
        {
            InitializeComponent();
        }

        public string Usuario
        {
            get { return txtUsuario.Text; }
            set { txtUsuario.Text = value; }
        }
        public string EmailFuncionarios
        {
            get { return txtEmailFuncionarios.Text; }
            set { txtEmailFuncionarios.Text = value; }
        }
        public string Senha
        {
            get { return txtSenha.Text; }
            set { txtSenha.Text = value; }
        }
        public string Role
        {
            get { return txtRole.Text; }
            set { txtRole.Text = value; }
        }

        private void btnSalvarFuncioarios_Click(object sender, EventArgs e)
        {
            //Você pode adicionar validações aqui, como verificar se os campos estão preenchidos

                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtEmailFuncionarios.Text) ||
                    string.IsNullOrWhiteSpace(txtSenha.Text) ||
                    string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return; // Não fecha o formulário se a validação falhar
            }

            // Se a validação passar, fecha o formulário
            this.DialogResult = DialogResult.OK;
            this.Close(); // Fecha o formulário
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmailFuncionarios.Focus();
                txtEmailFuncionarios.SelectAll();
            }
        }

        private void txtEmailFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
                txtSenha.SelectAll();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRole.Focus();
                txtRole.SelectAll();
            }
        }

        private void txtRole_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
