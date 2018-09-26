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
using EstoqueEsteticaSenac.Class;

namespace EstoqueEsteticaSenac.Forms
{
    public partial class FormPrincipal : Form
    {
        private bool trocarUsuario = false;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelNomeUsuario.Text = "Bem-Vindo, " + Properties.Settings.Default.nome_usuario;
            toolStripStatusLabelNomeUsuario.Text += " | DATA DO LOGIN: " + Properties.Settings.Default.login_atual;
            toolStripStatusLabelNomeUsuario.Text += " | ULTIMO LOGIN: " + Properties.Settings.Default.ultimo_login;
            toolStripStatusLabelNomeUsuario.Text += " | ADMINISTRADOR: ";

            if (Properties.Settings.Default.admin_usuario == "SIM")
                toolStripStatusLabelNomeUsuario.Text += "SIM";
            else
                toolStripStatusLabelNomeUsuario.Text += "NAO";

            if (Properties.Settings.Default.admin_usuario == "NAO")
            {
                usuáriosToolStripMenuItem.Enabled = false;
                configuraçõesToolStripMenuItem.Enabled = false;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trocarUsuario == false)
            {
                DialogResult dialogResult = MessageBox.Show("Você tem certeza?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Usuarios u = new Usuarios();
                    for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
                    {
                        if (Application.OpenForms[intIndex] != this)
                            Application.OpenForms[intIndex].Close();
                    }
                    u.SalvarEstadoUsuario();
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        private void trocarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Essa opeção irá fechar todas as janelas do sistema\nDeseja continuar?", "Trocar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FormLogin fl = new FormLogin();
                fl.Show();
                trocarUsuario = true;
                this.Close();
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto();
            fp.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Show();                 
        }

        private void entradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntradaProduto fep = new FormEntradaProduto();
            fep.Show();
        }

        private void saidaBaixaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaidaProduto fsp = new FormSaidaProduto();
            fsp.Show();
        }
    }
}
