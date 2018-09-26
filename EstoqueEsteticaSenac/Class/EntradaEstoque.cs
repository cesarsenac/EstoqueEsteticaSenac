using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            SqlCommand cmd = new SqlCommand("insert into EntradaEstoque (Quantidade, DataEntrada, DataVencimento) values( '"+Quantidade+ "', '"+DataEntrada+ "', '"+DataVencimento+"')", string_conexao);

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
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO: "+e.Message);
                return false;
            }
        }

        public bool Excluir(int CodigoProduto)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);
            SqlCommand cmd = new SqlCommand("delete from EntradaEstoque where CodigoProduto  = " +CodigoProduto, string_conexao);
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
            SqlCommand cmd = new SqlCommand("UPDATE EntradaEstoque SET Quantidade = '" +Quantidade+ "', DataEntrada = '" +DataEntrada+ "', DataVencimento = '" +DataVencimento+ "' WHERE CodigoProduto = "+CodigoProduto, string_conexao);
            try
            {
                string_conexao.Open();
                cmd.ExecuteNonQuery();
                string_conexao.Close();
                return true;
            }
           catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("ERRO: \n" +e);
                return false;
            }
            
        }

    }
}
