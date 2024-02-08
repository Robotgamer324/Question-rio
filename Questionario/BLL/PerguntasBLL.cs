using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PerguntasBLL
    {
        public int Id { get; set; }

        public string Pergunta { get; set; }

        public int id_categoria { get; set; }
        public  List<Perguntas> BuscarTodos()
        {
            return new PerguntasDAL().BuscarTodos();
        }
        public List<Perguntas> BuscarPorPergunta(string _nome)
        {
            return new PerguntasDAL().BuscarPorPergunta(_nome);
        }
        public void Alterar()
        {
            new PerguntasDAL().Alterar();
        }

        public void Excluir()
        {
            new PerguntasDAL().Excluir();
        }
        public void Inserir()
        {
            new PerguntasDAL().Inserir();
        }
        public Perguntas BuscarPorId(int _id)
        {
            return new PerguntasDAL().BuscarPorId(_id);
        }
        public void BuscarPorIdCategoria(int _idCategoria)
        {
            new PerguntasDAL().BuscarPorIdCategoria(_idCategoria);
        }

    }
}
