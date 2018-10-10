using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nome da Classe: MarcaCadastro
//Desenvolvido por: Mateus Justino da Rocha - mateusjrocha.ruim@gmail.com
//Data: 26/09/2018
//Descrição da classe: Esta clase foi criada para realizar o cadastro de marca, e controlar o Marca

//      Metodos:
//          - Inserir: Faz a inserção de uma marca ao banco (Pronto)
//          - Atualizar: Faz a atualização de uma marca no banco (Pronto)
//          - Deletar: Faz a deleção de uma marca no banco (Pronto)
//          - Pesquisar: Faz a pesquisa de uma marca no banco (em desenvolvimento)
//          - MarcaExiste: Confere se a marca a ser cadastrada existe, caso existir nao podera ser cadastrado (Pronta) 

namespace EstoqueEsteticaSenac.Class
{
    class MarcaCadastro
    {
        public bool Inserir(string marca, string observacao)
        {
            // se der certo a inserção no banco,retornar true
            // se der errado retornar false

            // 1) Preparar minha conexao com o banco
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            // 2) Fazer o SQL que vai para o banco
            SqlCommand cmd = new SqlCommand("insert into Marca(Nome_Marca, Observacao_Marca) values('"+ marca +"', '"+ observacao +"')", string_conexao);

            try
            {
                // 3) abrir conexao com banco
                string_conexao.Open();
                // 4) executei a query no banco
                cmd.ExecuteNonQuery();
                // 5) fechar conexao com banco
                string_conexao.Close();

                return true;
            }

            catch(Exception e)
            {
                MessageBox.Show("erro: \n"+e);
                return false;
            }
        }

        public bool Deletar(int ID)
        {
            // se der certo a inserção no banco,retornar true
            // se der errado retornar false

            // 1) Preparar minha conexao com o banco
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            // 2) Fazer o SQL que vai para o banco
            SqlCommand cmd = new SqlCommand("Delete from Marca where ID_Marca ="+ ID, string_conexao);

            try
            {
                // 3) abrir conexao com banco
                string_conexao.Open();
                // 4) executei a query no banco
                cmd.ExecuteNonQuery();
                // 5) fechar conexao com banco
                string_conexao.Close();

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("erro: \n" + e);
                return false;
            }
        }

        public bool Atualizar(int ID, string marca, string observacao)
        {
            // 1) Preparar minha conexao com o banco
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            // 2) Fazer o SQL que vai para o banco
            SqlCommand cmd = new SqlCommand("UPDATE Marca SET Nome_Marca = '" + marca + "', Observacao_Marca = '" + observacao +"'Where ID_Marca = "+ID, string_conexao);

            try
            {
                // 3) abrir conexao com banco
                string_conexao.Open();
                // 4) executei a query no banco
                cmd.ExecuteNonQuery();
                // 5) fechar conexao com banco
                string_conexao.Close();

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("erro: \n" + e);
                return false;
            }
        }

        public bool MarcaExiste(string marca)
        {
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Marca WHERE Nome_Marca = '"+marca+"'", conexao);

            try
            {
                conexao.Open();
                int resultado = (int)cmd.ExecuteScalar();

                if(resultado == 1)
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            } catch (Exception e)
            {
                conexao.Close();
                MessageBox.Show("Erro: \n" + e);
                return false;
            }
        }
    }

}
