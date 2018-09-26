using EstoqueEsteticaSenac.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Forms
{
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Marca_Load(object sender, EventArgs e)
        {

            
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            MarcaCadastro m = new MarcaCadastro();
            if (String.IsNullOrEmpty(textBoxMarca.Text))
            {
                MessageBox.Show("Não deixe o campo marca em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool resultado = m.MarcaExiste(textBoxMarca.Text);
                if (resultado == true)
                {
                    MessageBox.Show("A marca " + textBoxMarca.Text + "já existe");
                }
                else
                {
                    bool resultadoClasse = m.Inserir(textBoxMarca.Text, textBoxObservacao.Text);

                    if (resultadoClasse == true)
                    {
                        MessageBox.Show("Dados gravados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        textBoxID.Text = "";
                        textBoxMarca.Text = "";
                        textBoxObservacao.Text = "";

                        
                    }
                    else
                    {
                        MessageBox.Show("Erro na gravação dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMarca.Text))
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MarcaCadastro u = new MarcaCadastro();
                bool resultadoClasse = u.Deletar(Convert.ToInt32(textBoxID.Text));

                if (resultadoClasse == true)
                {
                    MessageBox.Show("Dados deletados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    textBoxID.Text = "";
                    textBoxMarca.Text = "";
                    textBoxObservacao.Text = "";

                    
                }
                else
                {
                    MessageBox.Show("Erro na deleção dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void buttonAtualizar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMarca.Text))
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MarcaCadastro m = new MarcaCadastro();
                bool resultadoClasse = m.Atualizar( Convert.ToInt32(textBoxID.Text), textBoxMarca.Text, textBoxObservacao.Text);

                if (resultadoClasse == true)
                {
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    textBoxID.Text = "";
                    textBoxMarca.Text = "";
                    textBoxObservacao.Text = "";

                    
                }
                else
                {
                    MessageBox.Show("Erro na atualização dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxMarca.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxObservacao.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

