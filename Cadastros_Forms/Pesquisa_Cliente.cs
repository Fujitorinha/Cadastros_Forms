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
    public partial class Pesquisa_Cliente : Form
    {
        public Pesquisa_Cliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main Tela_Iniial = new Main();
            Tela_Iniial.Show();
            this.Close();
        }
    }
}
