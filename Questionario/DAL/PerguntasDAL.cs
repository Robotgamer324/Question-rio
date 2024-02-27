
using Microsoft.VisualBasic;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class PerguntasDAL
    {
        public int Id { get; set; }

        public string Pergunta { get; set; }

        public int id_categoria { get; set; }

        public List<Perguntas> BuscarTodos()
        {
            Perguntas perguntas;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Perguntas> perguntaslist = new List<Perguntas>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta, id_categoria FROM Perguntas";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        perguntas = new Perguntas();
                        perguntas.id = (int)rd["Id"];
                        perguntas.pergunta = rd["pergunta"].ToString();
                        perguntas.id_categoria = (int)rd["id_categoria"];

                        perguntaslist.Add(perguntas);
                    }

                }
                return perguntaslist;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os perguntas.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Perguntas> BuscarPorIdCategoria(int _idCategoria)
        {
            Perguntas perguntas;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Perguntas> perguntaslist = new List<Perguntas>();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta, id_categoria FROM Perguntas WHERE id_categoria LIKE @Id_categoria";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id_categoria", _idCategoria + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    perguntas = new Perguntas();
                    while (rd.Read())
                    {
                        perguntas = new Perguntas();
                        perguntas.id = (int)rd["Id"];
                        perguntas.pergunta = rd["pergunta"].ToString();
                        perguntas.id_categoria = (int)rd["id_categoria"];

                        perguntaslist.Add(perguntas);

                    }
                }
                return perguntaslist;
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
        public List<Perguntas> BuscarPorPergunta(string _nome)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Perguntas> perguntasList = new List<Perguntas>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta, id_categoria FROM Perguntas LIKE @pergunta";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@pergunta", _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Perguntas perguntas = new Perguntas();
                        perguntas.id = (int)rd["Id"];
                        perguntas.pergunta = rd["pergunta"].ToString();
                        perguntas.id_categoria = (int)rd["id_categoria"];

                        perguntasList.Add(perguntas);

                    }
                }
                return perguntasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar novos perguntas");
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

                    string sql = @"INSERT INTO Perguntas(id, pergunta) 
                              VALUES(@id, @pergunta)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.Parameters.AddWithValue("@pergunta", this.Pergunta);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar inserir o pergunta no banco de dados.", ex);
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

                    string sql = @"update Perguntas set pergunta = @pergunta, id_categoria = @id_categoria where id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@pergunta", this.Pergunta);
                        cmd.Parameters.AddWithValue("@id_categoria", this.id_categoria);
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
                perguntas = new Perguntas();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta, id_categoria FROM Perguntas WHERE id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    perguntas = new Perguntas();
                    while (rd.Read())
                    {
                        perguntas = new Perguntas();
                        perguntas.id = (int)rd["Id"];
                        perguntas.pergunta = rd["pergunta"].ToString();
                        perguntas.id_categoria = (int)rd["id_categoria"];
                       
                    }
                }
                return perguntas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o perguntas no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir()
        {
            using (SqlConnection cn = new SqlConnection(Constantes.StringDeConexao))
            {
                try
                {
                    cn.Open();

                    string sql = @"DELETE FROM pergunta WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar excluir o produto no banco de dados.", ex);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

    }
}