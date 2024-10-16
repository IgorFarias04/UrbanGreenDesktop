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
    public partial class UserControlInsumos : UserControl
    {
        public UserControlInsumos()
        {
            InitializeComponent();
        }

        public string Insumo
        {
            get { return lblInsumo.Text; }
            set { lblInsumo.Text = value; }
        }
        public string QuantidadeInsumo
        {
            get { return lblQuantidadeInsumo.Text; }
            set { lblQuantidadeInsumo.Text = value; }
        }
        public string ValorInsumo
        {
            get { return lblValorInsumo.Text; }
            set { lblValorInsumo.Text = value; }
        }

        private void btnEditarInsumos_Click(object sender, EventArgs e)
        {
            FormAdicionarInsumos formAdicionar = new FormAdicionarInsumos();
            // Carregar os dados atuais nos campos de texto
            formAdicionar.Insumo = lblInsumo.Text;
            formAdicionar.QuantidadeInsumo = lblQuantidadeInsumo.Text;
            formAdicionar.ValorInsumo = lblValorInsumo.Text;
            // Mostrar o formulário e aguardar a resposta
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualiza os labels com as novas informações
                lblInsumo.Text = formAdicionar.Insumo;
                lblQuantidadeInsumo.Text = formAdicionar.QuantidadeInsumo;
                lblValorInsumo.Text = formAdicionar.ValorInsumo;
            }
        }

        private void btnExcluirInsumos_Click(object sender, EventArgs e)
        {
            ExcluirInsumos();
        }

        private void ExcluirInsumos()
        {
            // Verifica se o Parent do UserControl é o FormTelaPrincipal
            if (this.Parent is Panel panel && panel.Parent is FormTelaPrincipal formTelaPrincipal)
            {
                // Chama o método do FormTelaPrincipal para remover o UserControl
                formTelaPrincipal.RemoverInsumos(this);
            }
        }
    }
}
