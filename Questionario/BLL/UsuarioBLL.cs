using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool administrador { get; set; }

        public List<Usuario> BuscarPorUsuario(string _nome)
        {
            return new UsuarioDAL().BuscarPorUsuario(_nome);
        }
        public List<Usuario> BuscarPorSenha(string _nome)
        {
            return new UsuarioDAL().BuscarPorSenha(_nome);
        }
        public Usuario BuscarPorIdUsuario(int _id)
        {
            return new UsuarioDAL().BuscarPorIdUsuario(_id);
        }
        public bool ConfirmarUsuario(string usuario, string senha)
        {
            return new UsuarioDAL().ComfirmarUsuario(usuario, senha).Any();
        }
    }
}
