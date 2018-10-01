using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

//Nome da classe: Produtos
//Desenvolvido Por: Victor Hugo Corrêa - ometaleiro696@gmail.com
//DATA: 26/09/2018
//Descrição da classe: Esta classe foi  construida para a adminstração dos produtos do curso Estetica do Senac Botucatu
//          METODOS: 
//              - Inserir: Faz a inserção do produto no banco (PRONTA) 
//              - Atualizar: Faz a atualização dos dados do produto no banco (PRONTA)
//              - Deletar: Faz a deleção do produto no banco (PRONTA)
//              - Pesquisar: Faz a pesquisa de um produto no banco de dados (EM DESENVOLVIMENTO)
//              - ProdutoExistente: Sub-Metodo do Inserir, para vericar se há um produto de mesmo nome ou mesmo codigo de barrras no banco (PRONTA)

namespace EstoqueEsteticaSenac.Class
{
    class Produto
    {
        public bool Atualizar(int ID, string Produto, string CodigoDeBarras, string Observacoes, int Marca)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            SqlCommand cmd = new SqlCommand("UPDATE Produtos SET NomeProduto = '" + Produto + "', CodigoDeBarras ='" + CodigoDeBarras + "', Observacoes ='" + Observacoes + "', ID_Marca = '" + Marca + "' WHERE id = " + ID, string_conexao);

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

        public bool Inserir(string NomeProduto, string CodigoDeBarras, string Observacoes, int Marca)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (NomeProduto, CodigoDeBarras, Observacoes, ID_Marca) VALUES('" + NomeProduto + "', '" + CodigoDeBarras + "', '" + Observacoes + "', '" + Marca + "')", string_conexao);

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
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

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
            Produto = Produto.ToLower();
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

        public int BuscaIdMarca(string marca)
        {
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("select ID_MARCA from marca WHERE Nome_Marca = '"+marca+"'", conexao);

            try
            {
                conexao.Open();
                int resultado = Convert.ToInt16(cmd.ExecuteScalar());
                conexao.Close();
                return resultado;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(""+e);
                return 0;
            }

        }
    }
}
