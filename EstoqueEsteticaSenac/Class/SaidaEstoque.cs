using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Classes
{
    class SaidaEstoque
    {
        public bool Inserir(int Quantidade, int DataSaida, int DataVencimento, int ID_Marca, int ID_Produto)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("insert into SaidaEstoque (Quantidade, DataSaida, DataVencimento, ID_Marca, ID_Produto) values('" + Quantidade + "', '" + DataSaida + "', '" + DataVencimento + "', '" + ID_Marca + "', '" + ID_Produto + "')", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                cmd.ExecuteNonQuery();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return false;

                //DateTime.Now; Pegar hora e data
            }
        }

        public bool Excluir(int CodigoProduto)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("delete from SaidaEstoque where CodigoProduto = " + CodigoProduto, string_conexao);

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
        public bool Alterar(int CodigoProduto, int Quantidade, int DataSaida, int DataVencimento)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("update SaidaEstoque set Quantidade = '" + Quantidade + "', DataSaida = '" + DataSaida + "', DataVencimento = '" + DataVencimento + "' where CodigoProduto = " + CodigoProduto, string_conexao);

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

        public int BuscaIdProduto(string codigodebarras)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Produtos WHERE CodigoDeBarras = '" + codigodebarras + "'", string_conexao);

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
        

        public int BuscaIdMarca(string marca)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT ID_Marca FROM Marca WHERE Nome_Marca = '" + marca + "'", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                int resultadoIDproduto = Convert.ToInt32(cmd.ExecuteScalar());

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
            SqlCommand cmd = new SqlCommand("SELECT NomeProduto FROM Produtos WHERE CodigoDeBarras = '" + codigodebarras + "'", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string produto = (string)cmd.ExecuteScalar();


                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return produto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";
            }
        }

        public string BuscaMarcaProduto (string codigodebarras)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT Marca.Nome_Marca FROM Produtos  INNER JOIN Marca ON Produtos.ID_Marca = Marca.ID_Marca WHERE Produtos.CodigoDeBarras = '"+codigodebarras+"'", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string marca = (string)cmd.ExecuteScalar();


                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return marca;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";
            }
        }
        
        public string BuscaDataVencimento (int codigo_produto)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 DataVencimento FROM EntradaEstoque WHERE ID_Produto = "+codigo_produto+" ORDER BY DataVencimento DESC", string_conexao);

            try
            {
                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string produto = Convert.ToString(cmd.ExecuteScalar());

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return produto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e);
                return "";
            }
        }
    }
}
