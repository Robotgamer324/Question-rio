using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAL
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public Categoria BuscarPorId(int _id)
        {
            Categoria categoria;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                categoria = new Categoria();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, Categoria from Categoria WHERE id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    categoria = new Categoria();
                    while (rd.Read())
                    {
                        categoria = new Categoria();
                        categoria.id = (int)rd["Id"];
                        categoria.categoria = rd["categoria"].ToString(); 

                    }
                }
                return categoria;
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
    }
}
