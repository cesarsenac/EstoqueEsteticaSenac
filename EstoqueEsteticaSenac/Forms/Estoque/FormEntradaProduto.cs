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
    public partial class FormEntradaProduto : Form
    {
        public FormEntradaProduto()
        {
            InitializeComponent();
        }

        private void FormEntradaProduto_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'estoqueEsteticaDataSet.EntradaEstoque' table. You can move, or remove it, as needed.
            this.entradaEstoqueTableAdapter.Fill(this.estoqueEsteticaDataSet.EntradaEstoque);

            
        }


        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxMarca.Text) ||
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataEntrada.Text) ||
                String.IsNullOrEmpty(maskedTextBoxVencimento.Text)
               )
            {
                MessageBox.Show("Preencha os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EntradaEstoque ex = new EntradaEstoque();
                maskedTextBoxDataEntrada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string dataEntrada = maskedTextBoxDataEntrada.Text;

                maskedTextBoxVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string vencimento = maskedTextBoxVencimento.Text;

                MessageBox.Show("Codigo: " + textBoxCodigoProduto.Text + "\n Quantidade: " + textBoxQuantidade.Text + "\n Entrada: " + maskedTextBoxDataEntrada.Text + " \n Vencimento: " + maskedTextBoxVencimento.Text);
                bool resultadoClasse = ex.Inserir(Convert.ToInt32(textBoxQuantidade.Text), Convert.ToInt32(dataEntrada), Convert.ToInt32(vencimento));

                if (resultadoClasse == true)
                {

                    MessageBox.Show("Dados Inseridos com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
                }
                else
                {                   
                    MessageBox.Show("Erro ao Inserir os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if
               (
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataEntrada.Text) ||
                String.IsNullOrEmpty(maskedTextBoxVencimento.Text)
                )
            {
                    MessageBox.Show("Preencha os campos em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
            }
            else
            {
                EntradaEstoque a = new EntradaEstoque();
                 maskedTextBoxDataEntrada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string dataEntrada = maskedTextBoxDataEntrada.Text;

                maskedTextBoxVencimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string vencimento = maskedTextBoxVencimento.Text;

                MessageBox.Show("Codigo: " + textBoxCodigoProduto.Text + "\n Quantidade: " + textBoxQuantidade.Text + "\n Entrada: " + maskedTextBoxDataEntrada.Text + " \n Vencimento: " + maskedTextBoxVencimento.Text);
                bool resultadoClasse = a.Alterar(Convert.ToInt32(textBoxCodigoProduto.Text),Convert.ToInt32(textBoxQuantidade.Text), Convert.ToInt32(dataEntrada), Convert.ToInt32(vencimento));


                if (resultadoClasse == true)
                {

                    MessageBox.Show("Dados alterados com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                    textBoxProduto.Text = "";
                    textBoxMarca.Text = "";
                    textBoxQuantidade.Text = "";
                    maskedTextBoxDataEntrada.Text = "";
                    maskedTextBoxVencimento.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxProduto.Text) ||
                String.IsNullOrEmpty(textBoxMarca.Text) ||
                String.IsNullOrEmpty(textBoxQuantidade.Text) ||
                String.IsNullOrEmpty(maskedTextBoxDataEntrada.Text) ||
                String.IsNullOrEmpty(maskedTextBoxVencimento.Text)
                )
            {
                MessageBox.Show("Não deixe os campos em branco", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EntradaEstoque ee = new EntradaEstoque();
                bool resultadoClasse = ee.Excluir(Convert.ToInt32(textBoxCodigoProduto.Text));


                if (resultadoClasse == true)
                {

                    MessageBox.Show("Dados Excluidos com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxProduto.Text = "";
                    textBoxMarca.Text = "";
                    textBoxQuantidade.Text = "";
                    maskedTextBoxDataEntrada.Text = "";
                    maskedTextBoxVencimento.Text = "";

                    
                }
                else
                {
                    MessageBox.Show("Erro ao excluir os dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Tem Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado == DialogResult.Yes)
            this.Close();
        }
             

        private void textBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Nao digite LETRAS ou ESPAÇOS...");
                    e.Handled = true;
                }
                else
                {
                    maskedTextBoxDataEntrada.Text = Convert.ToString(DateTime.Now);

                    maskedTextBoxDataEntrada.Focus();
                }
            }
        }       

        private void textBoxCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Não digite letras ou espaço.");
                e.Handled = true;
            }
            else
            {
                EntradaEstoque ee = new EntradaEstoque();
                int resultadoID = ee.BuscaIdProduto(textBoxCodigoBarras.Text);
                textBoxCodigoProduto.Text = Convert.ToString(resultadoID);

                   
                 string Produto = ee.BuscaProduto(textBoxCodigoBarras.Text);
                 textBoxProduto.Text = Produto;

                 string marca = ee.BuscaMarca(textBoxCodigoBarras.Text);
                 textBoxMarca.Text = marca;

                    textBoxQuantidade.Focus();
            }
        }

        private void dataGridViewEntradaEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigoProduto.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[0].Value.ToString();
            maskedTextBoxDataEntrada.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[1].Value.ToString();
            textBoxProduto.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[2].Value.ToString();
            textBoxMarca.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[3].Value.ToString();
            textBoxQuantidade.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[4].Value.ToString();
            maskedTextBoxVencimento.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
