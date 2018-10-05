using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//Nome da Classe: EntradaEstoque
//Desenvolvido por: Gabriel Viana Teodoro - gabriel2000_teodoro@hotmail.com
//Data: 26/09/2018
//Descrição da classe: Esta classe foi criada para realizar a entrada de produtos no estoque

//      Metodos:
//          - Inserir: Faz a inserção da Entrada no banco (Pronto)
//          - Alterar: Faz a atualização de uma entrada no banco (Pronto)
//          - Excluir:  deleta alguma entrada incorreta no banco (Pronto)
//      Sub Metodos:    
//          - BuscaIdProduto:
//          - BuscaProduto:
//          - BuscaMarca:
namespace EstoqueEsteticaSenac.Classes
{
    class EntradaEstoque
    {

        public bool Inserir(int Quantidade, int DataEntrada, int DataVencimento)
        {
            // se der certo a inserção no banco, retorna true
            // se der errado retorna false

            //1) preparar minha conexao com o banco
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            //2) fazer o SQL que vai para o banco
            SqlCommand cmd = new SqlCommand("insert into EntradaEstoque (Quantidade, DataEntrada, DataVencimento) values( '" + Quantidade + "', '" + DataEntrada + "', '" + DataVencimento + "')", string_conexao);

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
                int resultado = (int)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return 0;

                //DateTime.Now; Pegar hora e data
            }
        }

        public string BuscaProduto(string codigodebarras)
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
                string resultado = (string)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";

                //DateTime.Now; Pegar hora e data
            }
        }
        public string BuscaMarca(string codigodebarras)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("SELECT Marca.Nome_Marca FROM Produtos  INNER JOIN Marca ON Produtos.ID_Marca = Marca.ID_Marca WHERE Produtos.CodigoDeBarras = '" + codigodebarras + "'", string_conexao);

            try
            {

                // 3) Abrir a conexão com o banco.
                string_conexao.Open();

                // 4) Executar query no banco.
                string resultado = (string)cmd.ExecuteScalar();

                // 5) Fechar conexão com o banco.
                string_conexao.Close();

                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar no banco de dados \n" + e.Message);
                return "";

                //DateTime.Now; Pegar hora e data
            }
        }
    }
}
