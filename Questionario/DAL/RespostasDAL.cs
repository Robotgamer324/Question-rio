using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RespostasDAL
    {
        public int id { get; set; }
        public string Resposta { get; set; }
        public int Pergunta_id { get; set; }
        public bool Correta { get; set; }
        public List<Respostas> BuscarTodos()
        {
            Respostas resposta;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Respostas> respostalist = new List<Respostas>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, pergunta_id, correta, resposta from Respostas";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        resposta = new Respostas();
                        resposta.id = (int)rd["Id"];
                        resposta.Pergunta_id = (int)rd["pergunta_id"];
                        resposta.Correta = (bool)rd["correta"];
                        resposta.Resposta = rd["resposta"].ToString();

                        respostalist.Add(resposta);
                    }

                }
                return respostalist;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as repostas.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Respostas> BuscarPorResposta(string _resposta)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Respostas> respostaList = new List<Respostas>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, pergunta_id, correta, resposta from Respostas LIKE @resposta";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@resposta", _resposta + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Respostas resposta = new Respostas();
                        resposta.id = (int)rd["Id"];
                        resposta.Pergunta_id = (int)rd["pergunta_id"];
                        resposta.Correta = (bool)rd["correta"];
                        resposta.Resposta = rd["resposta"].ToString();

                        respostaList.Add(resposta);

                    }
                }
                return respostaList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar novas resposta");
            }
            finally
            {
                cn.Close();
            }

        }
        public void Inserir()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"INSERT INTO Respostas(id, pergunta_id, correta, resposta) 
                              VALUES(@id, @pergunta_id, @correta,@resposta)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", this.id);
                        cmd.Parameters.AddWithValue("@pergunta_id", this.Pergunta_id);
                        cmd.Parameters.AddWithValue("@correta", this.Correta);
                        cmd.Parameters.AddWithValue("@reposta", this.Resposta);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar inserir o Resposta no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void Alterar()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"UPDATE Perguntas
                              SET id = @id,
                                  pergunta = @pergunta,
                              WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.Parameters.AddWithValue("@pergunta", this.Pergunta);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar atualizar o pergunta no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public Perguntas BuscarPorId(int _id)
        {
            Perguntas perguntas;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta FROM Perguntas WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    perguntas = new Perguntas();
                    while (rd.Read())
                    {
                        perguntas.Id = (int)rd["Id"];
                        perguntas.Pergunta = rd["Nome"].ToString();

                    }
                }
                return perguntas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir o perguntas no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
