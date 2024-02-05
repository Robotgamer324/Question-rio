using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL
    {
        public string id { get; set; }

        public string pergunta { get; set; }



        public void List<pergunta> BuscarTodos()
        {
            Pergunta pergunta
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Pergunta> Perguntalist = new List<char>();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT id, pergunta FROM Perguntas"
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using(SqlDataReader rd = cmd.ExecuteReader()) 
                {
                    while (rd.Read())
                    {
                        pergunta = new Pergunta();
                        pergunta.id = (int)rd["id"];
                        pergunta.pergunta = rd["pergunta"]
                    }
                }
                return Perguntalist
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar perguntas.", ex);
            }
            finally { cn.Close(); }
        }
    }
}
