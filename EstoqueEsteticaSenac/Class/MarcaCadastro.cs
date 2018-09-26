using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEsteticaSenac.Class
{
    class MarcaCadastro
    {
        public bool Inserir(string marca, string observacao)
        {
            SqlConnection string_conexao = new SqlConnection(Properties.Settings.Default.string_conexao);

            SqlCommand cmd = new SqlCommand("insert into Marca(Nome_Marca, Observacao_Marca) values('"+ marca +"', '"+ observacao +"')", string_conexao);

            try
            {
                string_conexao.Open();

                cmd.ExecuteNonQuery();

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
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);

            SqlCommand cmd = new SqlCommand("Delete from Marca where ID_Marca ="+ ID, string_conexao);

            try
            {
                string_conexao.Open();

                cmd.ExecuteNonQuery();

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
            SqlConnection string_conexao = new SqlConnection(Properties.Resources.string_conexao);

            SqlCommand cmd = new SqlCommand("UPDATE Marca SET Nome_Marca = '" + marca + "', Observacao_Marca = '" + observacao +"'Where ID_Marca = "+ID, string_conexao);

            try
            {
                string_conexao.Open();

                cmd.ExecuteNonQuery();

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
            SqlConnection conexao = new SqlConnection(Properties.Resources.string_conexao);
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
