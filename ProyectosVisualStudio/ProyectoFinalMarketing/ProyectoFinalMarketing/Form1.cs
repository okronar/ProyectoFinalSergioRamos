using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoFinalMarketing
{
    public partial class Marketing : Form
    {
        public Marketing()
        {
            InitializeComponent();
        }



        // mas popular
        //SELECT Modelo, COUNT(Modelo) AS Cantidad
        //FROM Busquedas
        //GROUP BY Modelo
        //ORDER BY Cantidad DESC;


        //mas popular por marca 
        //        WITH GuitarrasPopulares AS(
        //    SELECT Modelo, Marca, ROW_NUMBER() OVER (PARTITION BY Marca ORDER BY COUNT(Modelo) DESC) AS Popularidad
        //    FROM Busquedas
        //    GROUP BY Marca, Modelo
        //)
        //SELECT Marca, Modelo
        //FROM GuitarrasPopulares
        //WHERE Popularidad = 1;


        //menos populares por marca
//        WITH GuitarrasPopulares AS(
//    SELECT Modelo, Marca, ROW_NUMBER() OVER (PARTITION BY Marca ORDER BY COUNT(Modelo) ASC) AS Popularidad
//    FROM Busquedas
//    GROUP BY Marca, Modelo
//)
//SELECT Marca, Modelo
//FROM GuitarrasPopulares
//WHERE Popularidad = 1;

    }
}
