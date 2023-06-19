using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros_Forms
{
    public partial class Tela_de_Busca : Form
    {
        public Tela_de_Busca()
        {
            InitializeComponent();
        }

        private void Call_TelaClientes(object sender, EventArgs e)
        {
            Pesquisa_Cliente Pesquisa_Cliente = new Pesquisa_Cliente();
            Pesquisa_Cliente.Show();
            this.Close();

        }

        private void Call_TelaFuncionarios(object sender, EventArgs e)
        {
            Pesquisa_Funcionarío Pesquisa_Funcionaro = new Pesquisa_Funcionarío();
            Pesquisa_Funcionaro.Show();
            this.Close();
        }

        private void Call_TelaProdutos(object sender, EventArgs e)
        {
            Pesquisa_Produto Pesquisa_Produto = new Pesquisa_Produto();
            Pesquisa_Produto.Show();
            this.Close();
        }
    }
}
