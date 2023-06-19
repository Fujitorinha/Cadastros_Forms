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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Call_CadastrarClientes(object sender, EventArgs e)
        {
            Cadastrar_Clientes Tela_CadastrarClientes = new Cadastrar_Clientes();
            Tela_CadastrarClientes.Show();
        }

        private void Call_CadastrarFuncionario(object sender, EventArgs e)
        {
            Cadastrar_Funcionarios Tela_CadastrarFuncionarios = new Cadastrar_Funcionarios();
            Tela_CadastrarFuncionarios.Show();
        }

        private void Call_CadastrarProduto(object sender, EventArgs e)
        {
            Cadastrar_Produto Tela_CadastarProduto = new Cadastrar_Produto();
            Tela_CadastarProduto.Show();
        }

        private void Call_TeladeBusca(object sender, EventArgs e)
        {
            Tela_de_Busca Tela_de_Busca = new Tela_de_Busca();
            Tela_de_Busca.Show();
        }
    }
}