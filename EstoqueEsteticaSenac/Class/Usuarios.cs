using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EstoqueEsteticaSenac.Class
{
    public class Usuarios
    {
        public bool Login(string login, string senha)
        {
            SqlConnection conexao = new SqlConnection(Properties.Resources.string_conexao);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM usuarios WHERE login = '"+login+"' AND senha = '"+senha+"'", conexao);

            try
            {
                conexao.Open();
                int resultado = (int)cmd.ExecuteScalar();
                if(resultado == 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT nome FROM usuarios WHERE login = '"+login+"' AND senha = '"+senha+"'", conexao);
                    Properties.Settings.Default.nome_usuario = (string)cmd2.ExecuteScalar();
                    conexao.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            } catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Houve uma falha ao conectar ao banco de dados\nCodigo do Mensagem: " + e.Message);
                return false;
            }

        }

        public bool InserirUsuario(string nome, string email, string login, string senha)
        {
            return true;
        }

        public bool AtualizaUsuario(int id, string nome, string email, string login, string senha)
        {
            return true;
        }

        public bool DeletaUsuario(int id)
        {
            return true;
        }

        public void PesquisarUsuario(int id, string nome, string email, string login, string senha)
        {

        }
    }
}
