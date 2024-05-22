using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace ProyectoFinalMarketing
{
    public partial class Marketing : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Marketing()
        {
            InitializeComponent();

            visualizarPopular();
            visualizarMenosPopular();
            visualizarMasPopuMarca();



        }

        private void visualizarPopular()
        {
            string sqlQuery = "SELECT DISTINCT B.Modelo, B.IdGuitarra, CountModelos.Cantidad FROM Busquedas B INNER JOIN (SELECT Modelo, COUNT(Modelo) AS Cantidad FROM Busquedas GROUP BY Modelo) CountModelos ON B.Modelo = CountModelos.Modelo" +
                " ORDER BY CountModelos.Cantidad DESC;";


            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridMasPopu.DataSource = dt;
                

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }
        private void visualizarMenosPopular()
        {
            string sqlQuery = "SELECT DISTINCT B.Modelo, B.IdGuitarra, CountModelos.Cantidad FROM Busquedas B INNER JOIN (SELECT Modelo, COUNT(Modelo) AS Cantidad FROM Busquedas GROUP BY Modelo) CountModelos ON B.Modelo = CountModelos.Modelo" +
                " ORDER BY CountModelos.Cantidad ASC;";


            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridMenosPopu.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void visualizarMasPopuMarca()
        {
            string sqlQuery = @"
        WITH GuitarraPopularPorMarca AS (
            SELECT 
                Modelo, 
                Marca, 
                IdGuitarra, 
                COUNT(*) AS NumeroDeBusquedas,
                ROW_NUMBER() OVER (PARTITION BY Marca ORDER BY COUNT(*) DESC) AS Rank
            FROM Busquedas
            GROUP BY Marca, Modelo, IdGuitarra
        )
        SELECT 
            Modelo, 
            Marca, 
            IdGuitarra,
            NumeroDeBusquedas
        FROM GuitarraPopularPorMarca
        WHERE Rank = 1;
    ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridPopuMarca.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: " + ex.Message);
                throw;
            }
        }

        //private void visualizarMasPopuMarca()
        //{
        //    string sqlQuery = "WITH GuitarraPopularPorMarca AS (SELECT Modelo, Marca, IdGuitarra, ROW_NUMBER() OVER (PARTITION BY Marca ORDER BY COUNT(*) DESC) AS Rank FROM " +
        //        "Busquedas GROUP BY Marca, Modelo, IdGuitarra) SELECT Modelo, Marca, IdGuitarra FROM GuitarraPopularPorMarca WHERE Rank = 1;";


        //    try
        //    {

        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
        //        SqlConnection connection = new SqlConnection(connectionString);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        gridPopuMarca.DataSource = dt;


        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Fallo");
        //        throw;


        //    }
        //}







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
