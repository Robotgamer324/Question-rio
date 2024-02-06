
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class PerguntaDAL
    {
        public int Id { get; set; }

        public string Pergunta { get; set; }

        public List<Perguntas> BuscarTodos()
        {
            Perguntas perguntas;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Perguntas> perguntaslist = new List<Perguntas>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta FROM Perguntas;";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        perguntas = new Perguntas();
                        perguntas.Id = (int)rd["Id"];
                        perguntas.Pergunta = rd["pergunta"].ToString();
                        
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
    }
}