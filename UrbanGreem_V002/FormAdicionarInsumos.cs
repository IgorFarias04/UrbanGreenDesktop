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
    public partial class FormAdicionarInsumos : Form
    {
        public FormAdicionarInsumos()
        {
            InitializeComponent();
        }
        public string Insumo
        {
            get { return txtInsumo.Text; }
            set { txtInsumo.Text = value; }
        }
        public string QuantidadeInsumo
        {
            get { return txtQuantidadeInsumo.Text; }
            set { txtQuantidadeInsumo.Text = value; }
        }
        public string ValorInsumo
        {
            get { return txtValorInsumo.Text; }
            set { txtValorInsumo.Text = value; }
        }

        private void btnSalvarInsumos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInsumo.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidadeInsumo.Text) ||
                string.IsNullOrWhiteSpace(txtValorInsumo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtQuantidadeInsumo.Focus();
                txtQuantidadeInsumo.SelectAll();
            }
        }

        private void txtQuantidadeInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValorInsumo.Focus();
                txtValorInsumo.SelectAll();
            }
        }
    }
}
