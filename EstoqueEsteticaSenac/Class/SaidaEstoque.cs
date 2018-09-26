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
        public bool Inserir(int Quantidade, int DataSaida, int DataVencimento)
        {
            // 1) Preparando conexão.
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            // 2) SQL que vai para o banco.
            SqlCommand cmd = new SqlCommand("insert into SaidaEstoque (Quantidade, DataSaida, DataVencimento) values('" +Quantidade+ "', '" + DataSaida + "', '" + DataVencimento + "')", string_conexao);

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
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);
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
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);
            SqlCommand cmd = new SqlCommand("update SaidaEstoque set Quantidade = '" +Quantidade+ "', DataSaida = '" +DataSaida+ "', DataVencimento = '" + DataVencimento + "' where CodigoProduto = " +CodigoProduto, string_conexao);

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
    }
}
