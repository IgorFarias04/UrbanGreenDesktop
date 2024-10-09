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
    public partial class FormTelaLogin : Form
    {
        public FormTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormTelaPrincipal telaprincipal = new FormTelaPrincipal();
            telaprincipal.ShowDialog();
        }

        private void FormTelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
