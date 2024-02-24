using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool administrador { get; set; }

        public Usuario BuscarPorIdUsuario(int _id)
        {
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, usuario, senha, administrador from usuario WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    usuario = new Usuario();
                    while (rd.Read())
                    {
                        usuario.id = (int)rd["Id"];
                        usuario.usuario = rd["usuario"].ToString();
                        usuario.senha = rd["senha"].ToString();
                        usuario.administrador = (bool)rd["administrador"];

                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuarios no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarPorUsuario(string _nome)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Usuario> usuarioList = new List<Usuario>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, usuario, senha, administrador from usuario LIKE @usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@usuario", _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.id = (int)rd["Id"];
                        usuario.usuario = rd["usuario"].ToString();
                        usuario.senha = rd["senha"].ToString();
                        usuario.administrador = (bool)rd["administrador"];

                        usuarioList.Add(usuario);

                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar por usuarios");
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Usuario> BuscarPorSenha(string _nome)
        {

            SqlConnection cn = new SqlConnection(Constantes.StringDeConexao);
            List<Usuario> usuarioList = new List<Usuario>();
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "select id, usuario, senha, administrador from usuario LIKE @senha";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@senha", _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.id = (int)rd["Id"];
                        usuario.usuario = rd["usuario"].ToString();
                        usuario.administrador = (bool)rd["administrador"];

                        usuarioList.Add(usuario);

                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar por usuarios");
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
