using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL
    {
        public string id { get; set; }

        public string pergunta { get; set; }

        public List<Cliente> BuscarTodos()
        {
            return new PerguntasDAL().BuscarTodos();
        }
    }
}
