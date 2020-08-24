using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.Util
{
    public class Result
    {
        public  Int32?  Resultado { set; get; } 
        public String Mensaje { set; get; }
        public Object Datos { set; get; }
        public String Token { set; get; }
    }
}
