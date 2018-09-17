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
using EstoqueEsteticaSenac.Class;

namespace EstoqueEsteticaSenac.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxLogin.Text) || String.IsNullOrEmpty(textBoxSenha.Text))
            {
                MessageBox.Show("Não deixe os Campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string senha = textBoxSenha.Text;
                senha = Convert.ToString(senha.GetHashCode());
                Usuarios u = new Usuarios();
                bool resultado = u.Login(textBoxLogin.Text, senha);
                if (resultado == true)
                {
                    this.Hide();
                    FormPrincipal p = new FormPrincipal();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Login e/ou senha Incorretos", "Erro ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
