﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string senha  { get; set; }
        public bool administrador { get; set; }

        //usuario, senha, administrador
}
}
