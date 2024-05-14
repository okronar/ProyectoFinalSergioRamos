using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPublico
{
    public class Guitarra
    {
     
        public int id { get; set; }
        public String modelo { get; set; }
        public String marca { get; set; }
        public String year { get; set; }
        public String cuerpo { get; set; }
        public String fijacion { get; set; }
        public String escala { get; set; }
        public String mcuerpo { get; set; }
        public String mmastil { get; set; }
        public String mdiapason { get; set; }
        public String puente { get; set; }
        public String pastillas { get; set; }
        public String url { get; set; }
        public String imagen { get; set; }


        public Guitarra(string modelo, string marca, int id, string year, string cuerpo, string fijacion, string escala, string mcuerpo, string mmastil, string mdiapason, string puente, string pastillas, string url, string imagen)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.id = id;
            this.year = year;
            this.cuerpo = cuerpo;
            this.fijacion = fijacion;
            this.escala = escala;
            this.mcuerpo = mcuerpo;
            this.mmastil = mmastil;
            this.mdiapason = mdiapason;
            this.puente = puente;
            this.pastillas = pastillas;
            this.url = url;
            this.imagen = imagen;
        }

        public Guitarra(String modelo, String marca, int id) { 
        this.modelo = modelo;
        this.marca = marca;
        this.id = id;
        }



    }
}
