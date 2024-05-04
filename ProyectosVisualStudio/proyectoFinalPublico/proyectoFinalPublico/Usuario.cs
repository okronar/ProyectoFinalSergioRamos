using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPublico
{
    public class Usuario
    {  
        
        
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Usuario(int id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }

      

    }
}
