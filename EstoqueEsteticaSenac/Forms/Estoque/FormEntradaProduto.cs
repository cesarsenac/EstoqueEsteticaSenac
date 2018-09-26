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
            
            textBoxProduto.Focus();
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
                    //textBoxProduto.Text = "";
                    //textBoxMarca.Text = "";                       
                    //textBoxQuantidade.Text = "";
                    //maskedTextBoxDataEntrada.Text = "";
                    //maskedTextBoxVencimento.Text = "";
                    
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

        

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
           // textBoxCodigoProduto.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[0].Value.ToString();            
           // textBoxQuantidade.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[1].Value.ToString();
           // maskedTextBoxDataEntrada.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[2].Value.ToString();
           // maskedTextBoxVencimento.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[3].Value.ToString();
        //}

        private void dataGridViewEntradaEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigoProduto.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[0].Value.ToString();
            textBoxQuantidade.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[1].Value.ToString();
            maskedTextBoxDataEntrada.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxVencimento.Text = this.dataGridViewEntradaEstoque.CurrentRow.Cells[3].Value.ToString();
        }


        private void textBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Nao digite LETRAS ou ESPAÇOS no ESPAÇO QUANTIDADE");
                e.Handled = true;
            }
        }

        private void textBoxProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)//digitou enter
            {
                maskedTextBoxDataEntrada.Text = Convert.ToString(DateTime.Now);
                textBoxQuantidade.Focus();
            }
        }
    }
}
