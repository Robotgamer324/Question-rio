using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBLL
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public Categoria BuscarPorId(int _id)
        {
            return new CategoriaDAL().BuscarPorId(_id);
        }
    }
}
