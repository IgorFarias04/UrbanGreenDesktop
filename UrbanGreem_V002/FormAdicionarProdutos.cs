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
    public partial class FormAdicionarProdutos : Form
    {
        public FormAdicionarProdutos()
        {
            InitializeComponent();
        }
        public string AdicionarProduto
        {
            get { return txtAdicionarProduto.Text; }
            set { txtAdicionarProduto.Text = value; }
        }
        public string QuantiadadeEmEstoque
        {
            get { return txtQuantidadeEmEstoque.Text; }
            set { txtQuantidadeEmEstoque.Text = value; }
        }
        public string ValorProduto
        {
            get { return txtValorProduto.Text; }
            set { txtValorProduto.Text = value; }
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdicionarProduto.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidadeEmEstoque.Text) ||
                string.IsNullOrWhiteSpace(txtValorProduto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtAdicionarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtQuantidadeEmEstoque.Focus();
                txtQuantidadeEmEstoque.SelectAll();
            }
        }

        private void txtQuantidadeEmEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValorProduto.Focus();
                txtValorProduto.SelectAll();
            }
        }
    }
}
