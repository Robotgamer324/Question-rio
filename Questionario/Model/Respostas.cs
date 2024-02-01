using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Respostas
    {
        public int id { get; set; }
        public string Resposta { get; set; }
        public int Pergunta_id { get; set; }
        public bool Correta { get; set; }
    }
}
