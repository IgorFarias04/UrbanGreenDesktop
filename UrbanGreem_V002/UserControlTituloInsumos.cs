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
    public partial class UserControlTituloInsumos : UserControl
    {
        private FormTelaPrincipal formTelaPrincipal;

        public UserControlTituloInsumos(FormTelaPrincipal principal)
        {
            InitializeComponent();
            formTelaPrincipal = principal;
        }

        private void btnAdicionarInsumos_Click(object sender, EventArgs e)
        {
            FormAdicionarInsumos formAdicionar = new FormAdicionarInsumos();
            // Verifique se o ShowDialog() está retornando OK
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                UserControlInsumos novoInsumo = new UserControlInsumos();

                // Preencher o UserControl com os dados do formulário
                novoInsumo.Insumo = formAdicionar.Insumo;
                novoInsumo.QuantidadeInsumo = formAdicionar.QuantidadeInsumo;
                novoInsumo.ValorInsumo = formAdicionar.ValorInsumo;
                // Adicionar o UserControl no panelPrincipal do FormTelaPrincipal
                formTelaPrincipal.AdicionarInsumos(novoInsumo);
            }
        }
    }
}
