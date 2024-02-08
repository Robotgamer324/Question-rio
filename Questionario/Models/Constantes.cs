using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Constantes
    {
        public static string stringDeConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=Questionario;User ID=SA;Password=Senailab02";
        public static string StringDeConexao
        {
            get 
            { 
                return stringDeConexao; 
            }
        }
    }
}
