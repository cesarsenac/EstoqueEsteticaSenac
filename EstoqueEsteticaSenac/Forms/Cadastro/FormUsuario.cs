using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Class;

namespace EstoqueEsteticaSenac.Forms.Cadastro
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            textBoxID.Text = "";
            textBoxNomeCompleto.Text = "";
            textBoxLogin.Text = "";
            textBoxEmail.Text = "";
            textBoxSenha.Text = "";
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueEsteticaDataSet1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter1.Fill(this.estoqueEsteticaDataSet1.usuarios);
            Limpar();
            comboBoxAdministrador.SelectedIndex = 0;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            if (String.IsNullOrEmpty(textBoxNomeCompleto.Text) || String.IsNullOrEmpty(textBoxLogin.Text) || 
                String.IsNullOrEmpty(textBoxEmail.Text) || String.IsNullOrEmpty(textBoxSenha.Text))
            {
                MessageBox.Show("Não Deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int pesquisaLoginEmail = u.LoginOuEmailExistente(textBoxLogin.Text, textBoxEmail.Text);
                if(pesquisaLoginEmail == 0)
                {
                    string senha = textBoxSenha.Text;
                    senha = Convert.ToString(senha.GetHashCode());
                    bool resultado = u.InserirUsuario(textBoxNomeCompleto.Text, textBoxEmail.Text, textBoxLogin.Text, senha, comboBoxAdministrador.Text);

                    if (resultado == true)
                    {
                        MessageBox.Show("Dados gravados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpar();
                        this.usuariosTableAdapter1.Fill(this.estoqueEsteticaDataSet1.usuarios);
                    }
                    else
                    {
                        MessageBox.Show("Erro na gravação dos dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(pesquisaLoginEmail == 1)
                    MessageBox.Show("O usuario '"+textBoxLogin.Text+
                        "' não pode ser utilizado, pois, já existe no sistema", 
                        "Aviso: usuário ja existe!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(pesquisaLoginEmail == 2)
                    MessageBox.Show("O email '" + textBoxEmail.Text+
                        "' não pode ser utilizado, pois, já existe no sistema",
                        "Aviso: email ja existe!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Houve um erro ao verificar os dados!\n Entre em contato com o suporte",
                        "Erro: Impossivel verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            if (String.IsNullOrEmpty(textBoxNomeCompleto.Text) || String.IsNullOrEmpty(textBoxLogin.Text) ||
                String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Não Deixe os campos em branco", "Aviso", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(textBoxSenha.Text == "parangaricokitmiromuaro")
                {
                    MessageBox.Show("Digite uma senha para alterar o usuário", "Aviso", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool resultado = u.AtualizaUsuario(Convert.ToInt32(textBoxID.Text), 
                                        textBoxNomeCompleto.Text, textBoxEmail.Text, 
                                        textBoxLogin.Text, textBoxSenha.Text, comboBoxAdministrador.Text);

                    if (resultado == true)
                    {
                        MessageBox.Show("Dados atualizados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpar();
                        this.usuariosTableAdapter1.Fill(this.estoqueEsteticaDataSet1.usuarios);
                    }
                    else
                    {
                        MessageBox.Show("Erro na atualização dos dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            if (String.IsNullOrEmpty(textBoxNomeCompleto.Text) || String.IsNullOrEmpty(textBoxLogin.Text) ||
                String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Não Deixe os campos em branco", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool resultado = u.DeletaUsuario(Convert.ToInt32(textBoxID.Text));

                if (resultado == true)
                {
                    MessageBox.Show("Dados deletados com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpar();
                    this.usuariosTableAdapter1.Fill(this.estoqueEsteticaDataSet1.usuarios);
                }
                else
                {
                    MessageBox.Show("Erro na deleção dos dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNomeCompleto.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLogin.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxEmail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSenha.Text = "parangaricokitmiromuaro";
            comboBoxAdministrador.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
