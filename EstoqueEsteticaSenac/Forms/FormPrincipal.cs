using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Forms;
using EstoqueEsteticaSenac.Forms.Estoque;
using EstoqueEsteticaSenac.Forms.Cadastro;

namespace EstoqueEsteticaSenac.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza?", "Sair do Sistema", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza?", "Sair do Sistema", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelNomeUsuario.Text += Properties.Settings.Default.nome_usuario;
        }
    }
}
