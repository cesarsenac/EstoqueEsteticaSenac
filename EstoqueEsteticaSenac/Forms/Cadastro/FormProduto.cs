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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            Produto p = new Produto();
            if (String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxCodigoDeBarras.Text))                
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxCodigoDeBarras.TextLength < 13)
                {
                    MessageBox.Show("Codigo de Barras invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int resultado = p.ProdutoExistente(textBoxProduto.Text, textBoxCodigoDeBarras.Text);

                    if (resultado == 1)
                    {
                        MessageBox.Show("O Nome do Produto " + textBoxProduto.Text + " ja existe");
                    }
                    else if (resultado == 2)
                    {
                        MessageBox.Show("Codigo De Barras " + textBoxCodigoDeBarras.Text + " já cadastrado");
                    }
                    else if (resultado == 3)
                    {
                        bool resultadoClasse = p.Inserir(textBoxProduto.Text, "", textBoxCodigoDeBarras.Text, textBoxObservacoes.Text);
                        if (resultadoClasse == true)
                        {
                            MessageBox.Show("Dados gravados com sucesso!", "Secesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //atualiza o datagridview
                            
                        }

                        else
                        {
                            MessageBox.Show("Erro na gravação dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ButtonDeletar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text) ||
                String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxCodigoDeBarras.Text) ||
                String.IsNullOrEmpty(comboBoxMarca.Text))
            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                Produto p = new Produto();
                bool ResultadoClasse = p.Deletar(Convert.ToInt32(textBoxID.Text));

                if (ResultadoClasse == true)
                {
                    MessageBox.Show("Dados Deletados com sucesso!", "Secesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpar();

                    //atualiza o datagridview
                    
                }

                else
                {
                    MessageBox.Show("Erro na Deleção dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = this.dataGridViewProduto.CurrentRow.Cells[0].Value.ToString();
            textBoxProduto.Text = this.dataGridViewProduto.CurrentRow.Cells[1].Value.ToString();
            textBoxCodigoDeBarras.Text = this.dataGridViewProduto.CurrentRow.Cells[2].Value.ToString();
            textBoxObservacoes.Text = this.dataGridViewProduto.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text) ||
                String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxCodigoDeBarras.Text))

            {
                MessageBox.Show("Não deixe os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                Produto p = new Produto();
                bool ResultadoClasse = p.Atualizar(Convert.ToInt32(textBoxID.Text), textBoxProduto.Text, "", "", textBoxCodigoDeBarras.Text, textBoxObservacoes.Text);

                if (ResultadoClasse == true)
                {
                    MessageBox.Show("Dados Alterados com sucesso!", "Secesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpar();

                    //atualiza o datagridview
                    
                }

                else
                {
                    MessageBox.Show("Erro na Alteração dos dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }

        void Limpar()
        {
            textBoxID.Text = "";
            textBoxProduto.Text = "";
            textBoxCodigoDeBarras.Text = "";
            textBoxObservacoes.Text = "";
            comboBoxMarca.Text = "";
        }

        private void textBoxCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Nao digite Letras ou espaços no codigo de barras");
                e.Handled = true;

            }
        }
    }
}
