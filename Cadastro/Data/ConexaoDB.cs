using Cadastro.Verificacao;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Cadastro.Data
{
    class ConnectionDB
    {
        public static MySqlConnection Conn;

        public static MySqlCommand Comm;

        public static MySqlDataReader Dr;

        public ConnectionDB()
        {
            string server = "localhost";
            string dataBase = "proverdb";
            string useId = "Thiago";
            string password = "Rayane18@";
            string port = "3306";

            string connectionString = "server=" + server + ";user id=" + useId + ";database=" + dataBase + "; password=" + password +"; port=" + port;

            Conn = new MySqlConnection(connectionString);
        }
    }
    class CheckData : ConnectionDB
    {
        public bool CheckDatabase(string usuario, string senha)
        {
            using (Comm = new MySqlCommand())
            {
                bool check = false;
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "SELECT * FROM USUARIOPROVERDB WHERE USUARIO = @USUARIO";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@USUARIO", usuario);

                    Dr = Comm.ExecuteReader();
                    Dr.Read();

                    string usua = Convert.ToString(Dr["USUARIO"]);
                    string pass = Convert.ToString(Dr["SENHA"]);
                    senha.SetaSenha();

                    if (usuario == usua && senha == pass)
                    {
                        check = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
                return check;
            }
        }
    }
    class DataInsert : ConnectionDB
    {
        public void InsertToDatabase(string usuario, string senha)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "INSERT INTO USUARIOPROVERDB (USUARIO, SENHA) " +
                                                  "VALUES (@USUARIO, @SENHA)";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@USUARIO", usuario.ValidacaoString());
                    Comm.Parameters.AddWithValue("@SENHA", senha.SetaSenha());


                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw new Exception(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }


        }


    }
    class DataInsertFuncionario : ConnectionDB
    {
        public void InsertFuncionario( int id, string nome, string telefone, DateTime dataDeNascimento, int idade, string sexo, string ativo, string cargo)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "INSERT INTO FUNCIONARIODB (ID, NOME, TELEFONE, DATADENASCIMENTO, IDADE, SEXO)" +
                                                  " VALUES (@ID, @NOME, @TELEFONE, @DATADENASCIMENTO, @IDADE, @SEXO)";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@ID", id);
                    Comm.Parameters.AddWithValue("@NOME", nome.ValidacaoString());
                    Comm.Parameters.AddWithValue("@TELEFONE", telefone.ValidacaoString());
                    Comm.Parameters.AddWithValue("@DATADENASCIMENTO", dataDeNascimento);
                    Comm.Parameters.AddWithValue("@IDADE", idade);
                    Comm.Parameters.AddWithValue("@SEXO", sexo.ValidacaoString());


                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw new Exception(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }


        }


    }
    class DataInsertCaegoDB : ConnectionDB
    {
        public void InsertCargoDB(int id, string cargo, string ativo)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "INSERT INTO CARGODB (ID, CARGO, ATIVO) VALUES (@ID, @CARGO, @ATIVO)";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@ID", id);
                    Comm.Parameters.AddWithValue("@CARGO", cargo.ValidacaoString());
                    Comm.Parameters.AddWithValue("@ATIVO", ativo.ValidacaoString());
                   


                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw new Exception(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }


        }


    }
    class SenhaUpdate : ConnectionDB
    {
        public void NewSenha(string usuario, string senha)
        {
            using (Comm = new MySqlCommand())
            {
                try
                {
                    Conn.Open();
                    string instructionInsertSql = "UPDATE USUARIOPROVERDB SET SENHA = @SENHA WHERE USUARIO = @USUARIO";
                    Comm.CommandText = instructionInsertSql;
                    Comm.CommandType = CommandType.Text;
                    Comm.Connection = Conn;

                    Comm.Parameters.AddWithValue("@USUARIO", usuario.ValidacaoString());
                    Comm.Parameters.AddWithValue("@SENHA", senha.SetaSenha());

                    Comm.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw new Exception(Ex.Message);
                }
                finally
                {
                    Conn.Close();
                    Comm = null;
                }
            }
        }
    }
}