using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Class
{
    class Produto
    {
        public bool Atualizar(int ID, string Produto, string CodigoDeBarras, string Observacoes)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            SqlCommand cmd = new SqlCommand("UPDATE Produtos SET NomeProduto = '" + Produto + "', CodigoDeBarras ='" + CodigoDeBarras + "', Observacoes ='" + Observacoes + "' WHERE id = " + ID, string_conexao);

            try
            {
                string_conexao.Open();
                cmd.ExecuteNonQuery();
                string_conexao.Close();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("ERRO: \n" + e.Message);
                return false;
            }
        }

        public bool Inserir(string NomeProduto, string CodigoDeBarras, string Observacoes)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);

            SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (NomeProduto, CodigoDeBarras, Observacoes) VALUES('" + NomeProduto + "', '" + CodigoDeBarras + "', '" + Observacoes + "')", string_conexao);

            try
            {
                // 3) Abrir conexão com o banco
                string_conexao.Open();

                // 4) Execute a query no banco
                cmd.ExecuteNonQuery();

                // 5) Fechar conexao
                string_conexao.Close();

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("ERRO AO GRAVAR NO BANCO DE DADOS\n" + e.Message);
                return false;
            }
        }

        public bool Deletar(int ID)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);

            SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE ID = " + ID, string_conexao);

            try
            {
                // 3) Abrir conexão com o banco
                string_conexao.Open();

                // 4) Execute a query no banco
                cmd.ExecuteNonQuery();

                // 5) Fechar conexao
                string_conexao.Close();

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("ERRO AO DELETAR NO BANCO DE DADOS\n" + e.Message);
                return false;
            }
        }

        //Tratando um produto existente
        //1 = Produto existente
        //2 = Codigo De Barras Existente
        //3 = Não existe nada no banco
        public int ProdutoExistente(string Produto, string CodigoDeBarras)
        {
            //Produto = Produto.ToLower();
            CodigoDeBarras = CodigoDeBarras.ToLower();
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmdProduto = new SqlCommand("SELECT COUNT(*) FROM Produtos WHERE NomeProduto = '" + Produto + "'", conexao);
            SqlCommand cmdCodigoDeBarras = new SqlCommand("SELECT COUNT(*) FROM Produtos WHERE CodigoDeBarras = '" + CodigoDeBarras + "'", conexao);
            
            try
            {
                conexao.Open();
                int ResultadoProduto = (int)cmdProduto.ExecuteScalar();
                int ResultadoCodigoDeBarras = (int)cmdCodigoDeBarras.ExecuteScalar();
                conexao.Close();
                if (ResultadoProduto == 1)
                    return 1;
                else if (ResultadoCodigoDeBarras == 1)
                    return 2;
                else
                    return 3;
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Houve um erro ao pesquisar.\n(Clique em OK para ver detalhes do erro", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message + "\n \n"+e);
                }
                conexao.Close();
                return 3;
            }



        }
    }
}
