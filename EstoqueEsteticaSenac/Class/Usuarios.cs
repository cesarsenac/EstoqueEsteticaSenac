using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// Nome da Classe: Usuarios
// Desenvolvido por: Cesar Oliveira Jr (oliveiraugusto)

namespace EstoqueEsteticaSenac.Class
{
    public class Usuarios
    {
        public bool Login(string login, string senha)
        {
            login = login.ToLower();
            senha = Convert.ToString(senha.GetHashCode());
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM usuarios WHERE login = '"+login+"' AND senha = '"+senha+"'", conexao);

            try
            {
                conexao.Open();
                int resultado = (int)cmd.ExecuteScalar();
                if(resultado == 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT nome FROM usuarios WHERE login = '"+login+"' AND senha = '"+senha+"'", conexao);
                    SqlCommand cmd3 = new SqlCommand("SELECT ultimo_login FROM usuarios WHERE login = '" + login + "' AND senha = '" + senha + "'", conexao);
                    SqlCommand cmd4 = new SqlCommand("SELECT administrador FROM usuarios WHERE login = '" + login + "' AND senha = '" + senha + "'", conexao);
                    Properties.Settings.Default.nome_usuario = (string)cmd2.ExecuteScalar();
                    Properties.Settings.Default.ultimo_login = (string)cmd3.ExecuteScalar();
                    Properties.Settings.Default.admin_usuario = (string)cmd4.ExecuteScalar();
                    
                    conexao.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            } catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Houve uma falha ao conectar ao banco de dados\nCodigo do Mensagem: " + e);
                return false;
            }


        }

        public bool InserirUsuario(string nome, string email, string login, string senha, string administrador)
        {
            email = email.ToLower();
            login = login.ToLower();
            senha = Convert.ToString(senha.GetHashCode());

            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);            
            SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (nome, email, login, senha, administrador) VALUES " +
                                                "('"+nome+"','"+email+"','"+login+"','"+senha+"', '"+administrador+"')", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch(Exception e)
            {
                if(MessageBox.Show("Houve um erro ao Inserir no Banco de dados. \n(clique em OK para ver detalhes do erro)", 
                            "Erro ao Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message);
                }
                conexao.Close();
                return false;
            }
        }

        public bool AtualizaUsuario(int id, string nome, string email, string login, string senha, string admin)
        {
            senha = Convert.ToString(senha.GetHashCode());
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nome = '" + nome +
                                                      "', email = '" + email + "', login = '" + login +
                                                      "', senha = '" + senha + 
                                                      "', administrador = '"+admin+"' WHERE id = " + id + " ", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Houve um erro ao atualizar o usuario.\n(clique em OK para ver detalhes do erro)",
                                        "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message);
                }
                conexao.Close();
                return false;
            }
        }

        public bool DeletaUsuario(int id)
        {
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("DELETE FROM usuarios WHERE id = '"+id+"'", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Houve um erro ao deletar o usuario.\n(clique em OK para ver detalhes do erro)",
                                        "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message);
                }
                conexao.Close();
                return false;
            }

        }

        public void PesquisarUsuario(int id, string nome, string email, string login, string senha)
        {

        }

        //Esse metodo publico faz a verificação se o login ou email ja foram cadastrados no sistema
            // Se o metodo retornar 0: não encontrou login ou email cadastrado no banco
            // Se o metodo retornar 1: encontrou o login cadastrado no banco
            // Se o metodo retornar 2: encontrou email cadastrado no banco
            // Se o metodo retornar 3: erro na pesquisa (sera tratado como erro)
        public int LoginOuEmailExistente(string login, string email)
        {
            login = login.ToLower();
            email = email.ToLower();
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd_nome = new SqlCommand("SELECT COUNT(*) FROM usuarios WHERE login = '"+login+"'", conexao);
            SqlCommand cmd_email = new SqlCommand("SELECT COUNT(*) FROM usuarios WHERE email = '" + email + "'", conexao);
            try
            {
                conexao.Open();
                int resultado_nome = (int)cmd_nome.ExecuteScalar();
                int resultado_email = (int)cmd_email.ExecuteScalar();
                conexao.Close();
                if (resultado_nome == 0 && resultado_email == 0)
                    return 0;
                else if (resultado_nome == 1)
                    return 1;
                else if (resultado_email == 1)
                    return 2;
                else
                    return 3;
            }
            catch(Exception e)
            {
                if (MessageBox.Show("Houve um erro ao Pesquisar o Nome ou Email.\n(clique em OK para ver detalhes do erro)",
                                        "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message);
                }
                conexao.Close();
                return 3;
            }
        }

        public void SalvarEstadoUsuario()
        {
            SqlConnection conexao = new SqlConnection(Properties.Settings.Default.string_conexao);
            SqlCommand cmd = new SqlCommand("UPDATE usuarios SET ultimo_login = " +
                                                "'"+Properties.Settings.Default.login_atual+"' WHERE nome = '"+Properties.Settings.Default.nome_usuario+"'", conexao);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Houve um erro ao Inserir no Banco de dados. \n(clique em OK para ver detalhes do erro)",
                            "Erro ao Inserir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    MessageBox.Show(e.Message);
                }
                conexao.Close();
            }
        }
        
    }
}
