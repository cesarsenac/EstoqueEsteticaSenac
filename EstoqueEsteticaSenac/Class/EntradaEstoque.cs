using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Classes
{
    class EntradaEstoque
    {

        public bool Inserir(int Quantidade, int DataEntrada, int DataVencimento, int produto, int marca)
        {
            // se der certo a inserção no banco, retorna true
            // se der errado retorna false

            //1) preparar minha conexao com o banco
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            //2) fazer o SQL que vai para o banco
            SqlCommand cmd = new SqlCommand("INSERT INTO EntradaEstoque (Quantidade, DataEntrada, DataVencimento, ID_Marca, ID_Produto) values( '" + Quantidade + "', '" + DataEntrada + "', '" + DataVencimento + "', '"+marca+"', '"+produto+"')", string_conexao);

            try
            {
                //3) Abrir a conexao com o banco
                string_conexao.Open();
                //4) executei a query no banco
                cmd.ExecuteNonQuery();
                //5 fechar conexao
                string_conexao.Close();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO: " + e.Message);
                return false;
            }
        }

        public bool Excluir(int CodigoProduto)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);
            SqlCommand cmd = new SqlCommand("delete from EntradaEstoque where CodigoProduto  = " + CodigoProduto, string_conexao);
            try
            {
                string_conexao.Open();
                cmd.ExecuteNonQuery();
                string_conexao.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO:\n" + e);
                return false;
            }
        }

        public bool Alterar(int CodigoProduto, int Quantidade, int DataEntrada, int DataVencimento)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);
            SqlCommand cmd = new SqlCommand("UPDATE EntradaEstoque SET Quantidade = '" + Quantidade + "', DataEntrada = '" + DataEntrada + "', DataVencimento = '" + DataVencimento + "' WHERE CodigoProduto = " + CodigoProduto, string_conexao);
            try
            {
                string_conexao.Open();
                cmd.ExecuteNonQuery();
                string_conexao.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO: \n" + e);
                return false;
            }

        }

        public int BuscaIdProduto(string codigodebarras)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Produtos WHERE CodigoDeBarras = '" +codigodebarras+ "'", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                int resultadoIDproduto = (int)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultadoIDproduto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return 0;

                //DateTime.Now; Pegar hora e data
            }
        }

        public string BuscaNomeProduto(string codigodebarras)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT NomeProduto FROM Produtos WHERE CodigoDeBarras = '" +codigodebarras+ "'", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string resultadoProdutoE = (string)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultadoProdutoE;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";

                //DateTime.Now; Pegar hora e data
            }
        }
        public string BuscaNomeMarca(string codigodebarras)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT Marca.Nome_Marca FROM Produtos  INNER JOIN Marca ON Produtos.ID_Marca = Marca.ID_Marca WHERE Produtos.CodigoDeBarras = '" + codigodebarras + "'", string_conexao);

            try
            {

                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string resultadoMarcaE = (string)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultadoMarcaE;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";

                //DateTime.Now; Pegar hora e data
            }
        }
        public int BuscaIdMarca(string marca)
        {
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("select ID_MARCA from marca WHERE Nome_Marca = '" + marca + "'", conexao);

            try
            {
                conexao.Open();
                int resultadoIDmarca = Convert.ToInt16(cmd.ExecuteScalar());
                conexao.Close();
                return resultadoIDmarca;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("" + e);
                return 0;
            }

        }
    }
}
