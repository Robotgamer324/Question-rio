using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PerguntaBLL
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }

        public List<Perguntas> BuscarTodos()
        {
            return new PerguntasDAL().BuscarTodos();
        }
    }
}
