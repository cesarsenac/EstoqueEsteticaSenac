using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Classes;

namespace EstoqueEsteticaSenac.Forms.Estoque
{
    public partial class FormSaidaProduto : Form
    {
        public FormSaidaProduto()
        {
            InitializeComponent();
            textBoxCodigoBarras.Text = "";
            
        }

        private void FormSaidaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueEsteticaDataSet.SaidaEstoque' table. You can move, or remove it, as needed.
            this.saidaEstoqueTableAdapter.Fill(this.estoqueEsteticaDataSet.SaidaEstoque);
      
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if
               (String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxMarca.Text) ||
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataSaida.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataVencimento.Text)
               )
            {
                MessageBox.Show("Preencha os campos em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaidaEstoque s = new SaidaEstoque();
                maskedTextBoxDataSaida.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string DataSaida = maskedTextBoxDataSaida.Text;

                maskedTextBoxDataVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string DataVencimento = maskedTextBoxDataVencimento.Text;
                int resultadoIDProduto = s.BuscaIdProduto(textBoxCodigoBarras.Text);
                int resultadoIDMarca = s.BuscaIdMarca(textBoxMarca.Text);

                bool resultadoClasse = s.Inserir(Convert.ToInt32(textBoxQuantidade.Text), Convert.ToInt32(DataSaida), Convert.ToInt32(DataVencimento), resultadoIDMarca, resultadoIDProduto);


                if (resultadoClasse == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxCodigoProduto.Text = "";
                    textBoxCodigoBarras.Text = "";
                    textBoxProduto.Text = "";
                    textBoxMarca.Text = "";
                    textBoxQuantidade.Text = "";
                    maskedTextBoxDataSaida.Text = "";
                    maskedTextBoxDataVencimento.Text = "";
                    this.saidaEstoqueTableAdapter.Fill(this.estoqueEsteticaDataSet.SaidaEstoque);

                }
                else
                {
                    MessageBox.Show("Erro ao inserir os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCodigoProduto.Text) ||
                String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxMarca.Text) ||
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataSaida.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataVencimento.Text)
                 
               )
            {
                MessageBox.Show("Não deixe os campos em branco", "AVISO", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                SaidaEstoque s = new SaidaEstoque();
                maskedTextBoxDataSaida.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string dataEntrada = maskedTextBoxDataSaida.Text;

                maskedTextBoxDataVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string vencimento = maskedTextBoxDataVencimento.Text;

                bool resultadoClasse = s.Excluir(Convert.ToInt32(textBoxCodigoProduto.Text));

                if (resultadoClasse == true)
                {
                    MessageBox.Show("Dados excluidos com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxCodigoProduto.Text = "";
                    textBoxProduto.Text = "";
                    textBoxMarca.Text = "";
                    textBoxQuantidade.Text = "";
                    maskedTextBoxDataSaida.Text = "";
                    maskedTextBoxDataVencimento.Text = "";
                    this.saidaEstoqueTableAdapter.Fill(this.estoqueEsteticaDataSet.SaidaEstoque);

                }
                else
                {
                    MessageBox.Show("Erro ao excluir os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                this.Close();
        }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigoProduto.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxQuantidade.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBoxDataSaida.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxDataVencimento.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxMarca.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxProduto.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
           

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if
               (
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataSaida.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataVencimento.Text)
                )
            {
                MessageBox.Show("Preencha os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EntradaEstoque a = new EntradaEstoque();
                maskedTextBoxDataSaida.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string dataEntrada = maskedTextBoxDataSaida.Text;

                maskedTextBoxDataVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string vencimento = maskedTextBoxDataVencimento.Text;


                bool resultadoClasse = a.Alterar(Convert.ToInt32(textBoxCodigoProduto.Text), Convert.ToInt32(textBoxQuantidade.Text), Convert.ToInt32(dataEntrada), Convert.ToInt32(vencimento));


                if (resultadoClasse == true)
                {

                    MessageBox.Show("Dados alterados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxProduto.Text = "";
                    textBoxMarca.Text = "";
                    textBoxQuantidade.Text = "";
                    maskedTextBoxDataSaida.Text = "";
                    maskedTextBoxDataVencimento.Text = "";
                    this.saidaEstoqueTableAdapter.Fill(this.estoqueEsteticaDataSet.SaidaEstoque);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void textBoxCodigoBarras_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13) //Quando a tecla enter for presionada
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Não digite letras ou espaço.");
                    e.Handled = true;
                }
                else
                {
                    SaidaEstoque se = new SaidaEstoque();
                    int resultadoID = se.BuscaIdProduto(textBoxCodigoBarras.Text);
                    textBoxCodigoProduto.Text = Convert.ToString(resultadoID);

                    string produto = se.BuscaNomeProduto(textBoxCodigoBarras.Text);
                    textBoxProduto.Text = produto;

                    string marca = se.BuscaMarcaProduto(textBoxCodigoBarras.Text);
                    textBoxMarca.Text = marca;

                    textBoxQuantidade.Focus();


                }
            }
        }

        private void textBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Não digite letras ou espaço.");
                }
                else
                {
                    SaidaEstoque se = new SaidaEstoque();
                    maskedTextBoxDataSaida.Text = Convert.ToString(DateTime.Now);
                    maskedTextBoxDataVencimento.Text = se.BuscaDataVencimento(Convert.ToInt32(textBoxCodigoProduto.Text));
                    buttonInserir.Focus();
                }
            }
        }
    }
}
