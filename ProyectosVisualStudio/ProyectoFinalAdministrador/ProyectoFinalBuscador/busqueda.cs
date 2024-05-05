using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPublico
{
    public class busqueda
    {
       

        public int id { get; set; }
        public string modelo { get; set; }
        public string  marca { get; set; }

        public int sesion { get; set; }

        public int idguitarra { get; set; }
        public int idusuario { get; set; }
        
        
        public busqueda(int id, string modelo, string marca, int sesion, int idguitarra, int idusuario)
        {
            this.id = id;
            this.modelo = modelo;
            this.marca = marca;
            this.sesion = sesion;
            this.idguitarra = idguitarra;
            this.idusuario = idusuario;
        }

    }
}
