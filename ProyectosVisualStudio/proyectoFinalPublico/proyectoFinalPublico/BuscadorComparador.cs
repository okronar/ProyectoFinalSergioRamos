using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;



namespace proyectoFinalPublico
{
    public partial class BuscadorComparador : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        Landing landing;
        private String url;
        private String url2;
        static int ObtenerUltimaSesion()
        {
            int ultimaSesion = 0;

            string sqlQuery = "SELECT TOP 1 Sesion FROM Busquedas ORDER BY Sesion DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    connection.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ultimaSesion = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la última sesión: " + ex.Message);
            }

            return ultimaSesion;
        }
        int sesionActual = ObtenerUltimaSesion() + 1;
        public BuscadorComparador(Landing landing)
        {
            InitializeComponent();
            this.landing = landing;




        }




        private void btnVolver_Click(object sender, EventArgs e)
        {   landing.Show();
            this.Hide();
            landing.usuario = null;
            
        }

        private void BuscadorComparador_FormClosing(object sender, FormClosingEventArgs e)
        {

            landing.Close();
            int ObtenerUltimaSesion()
            {
                int ultimaSesion = 0;

                string sqlQuery = "SELECT TOP 1 Sesion FROM Busquedas ORDER BY Sesion DESC";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                        connection.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            ultimaSesion = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la última sesión: " + ex.Message);
                }

                return ultimaSesion;
            }
            int sesionActual = ObtenerUltimaSesion() + 1;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txboxBuscar.Text == "")
            {      MessageBox.Show("Escribe algo anda");
               
            }
            else { 
                 if (visualizarGuitarrasBusqueda(txboxBuscar.Text))
                {
                    gridBuscar.Visible = true;


                }
                else
                {
                    MessageBox.Show("No se han encontrado resultados");

                }
            }

        }


        private bool visualizarGuitarrasBusqueda(string nombreGuitarra)
        {
            string sqlQuery = "SELECT * FROM Guitarras WHERE Modelo LIKE '%' + @nombreGuitarra + '%' OR Marca LIKE '%' + @nombreGuitarra + '%';";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@nombreGuitarra", nombreGuitarra);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridBuscar.DataSource = dt;

                // Retornar true si hay filas en el DataTable, false si no hay filas
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: " + ex.Message);
                return false;
            }
        }

        private bool visualizarGuitarrasBusqueda2(string nombreGuitarra2)
        {
            string sqlQuery = "SELECT * FROM Guitarras WHERE Modelo LIKE '%' + @nombreGuitarra + '%' OR Marca LIKE '%' + @nombreGuitarra + '%';";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@nombreGuitarra", nombreGuitarra2);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridComparar.DataSource = dt;

                // Retornar true si hay filas en el DataTable, false si no hay filas
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo: " + ex.Message);
                return false;
            }
        }

        private void gridBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableLayoutPanel13.Visible = true;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel17.Visible = true;
            tableLayoutPanel11.Visible = true;




            var rN = e.RowIndex;
            int col = -1;
            int rowCount = gridBuscar.Rows.Count;

            if (rN >= 0 && rN < rowCount)
            {

                labelmodelo1.Text = (string)gridBuscar.Rows[rN].Cells[0].FormattedValue;
                labelmarca1.Text = (string)gridBuscar.Rows[rN].Cells[1].FormattedValue;

                labelyear1.Text = (string)gridBuscar.Rows[rN].Cells[3].FormattedValue;
                labelcuerpo1.Text = (string)gridBuscar.Rows[rN].Cells[4].FormattedValue;
                labelfijacion1.Text = (string)gridBuscar.Rows[rN].Cells[5].FormattedValue;
                labelescala1.Text = (string)gridBuscar.Rows[rN].Cells[6].FormattedValue;
                labelMcuerpo1.Text = (string)gridBuscar.Rows[rN].Cells[7].FormattedValue;
                labelMdiapason1.Text = (string)gridBuscar.Rows[rN].Cells[8].FormattedValue;
                labelMmastil1.Text = (string)gridBuscar.Rows[rN].Cells[9].FormattedValue;
                labelPuente1.Text = (string)gridBuscar.Rows[rN].Cells[10].FormattedValue;
                labelPastilla1.Text = (string)gridBuscar.Rows[rN].Cells[11].FormattedValue;

                url = (string)gridBuscar.Rows[rN].Cells[12].FormattedValue;

                int idGuit = int.Parse(gridBuscar.Rows[rN].Cells[2].FormattedValue.ToString());

                Guitarra guit1 = new Guitarra(labelmodelo1.Text, labelmarca1.Text, idGuit);

                InsertarBusqueda(guit1.modelo, guit1.marca, sesionActual, landing.usuario.id, guit1.id);
                EscribirEnHistorial(landing.usuario.email, guit1.modelo);

                try
                {
                    String imgstr = (string)gridBuscar.Rows[rN].Cells[13].FormattedValue;
                    Image img = new Bitmap(Auxiliar.stringToImg(imgstr));
                    picGuitar1.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al convertir la cadena de texto en imagen: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Error, clica dentro de los valores");
            }
            gridBuscar.Visible = false;




        }
        private void linkTienda1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(url))
            {
                // Abrir la URL en el navegador predeterminado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

            if (textBoxcomparar.Text == "")
            {
                MessageBox.Show("Escribe algo aqui también anda");

            }
            else
            {
                if (visualizarGuitarrasBusqueda2(textBoxcomparar.Text))
                {
                    gridComparar.Visible = true;


                }
                else
                {
                    MessageBox.Show("No se han encontrado resultados");

                }
            }
        }

        private void gridComparar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tableLayoutPanel5.Visible = true;
            tableLayoutPanel8.Visible = true;





            var rN = e.RowIndex;
            int col = -1;
            int rowCount = gridComparar.Rows.Count;

            if (rN >= 0 && rN < rowCount)
            {

                lblModelo2.Text = (string)gridComparar.Rows[rN].Cells[0].FormattedValue;
                lblMarca2.Text = (string)gridComparar.Rows[rN].Cells[1].FormattedValue;

                lblYear2.Text = (string)gridComparar.Rows[rN].Cells[3].FormattedValue;
                lblCuerpo2.Text = (string)gridComparar.Rows[rN].Cells[4].FormattedValue;
                lblFijacion2.Text = (string)gridComparar.Rows[rN].Cells[5].FormattedValue;
                lblEscala2.Text = (string)gridComparar.Rows[rN].Cells[6].FormattedValue;
                lblMaderaCuerpo2.Text = (string)gridComparar.Rows[rN].Cells[7].FormattedValue;
                lblMaderaDiapason2.Text = (string)gridComparar.Rows[rN].Cells[8].FormattedValue;
                lblMaderaMastil2.Text = (string)gridComparar.Rows[rN].Cells[9].FormattedValue;
                lblPuente2.Text = (string)gridComparar.Rows[rN].Cells[10].FormattedValue;
                lblPastillas2.Text = (string)gridComparar.Rows[rN].Cells[11].FormattedValue;


                int idGuit = int.Parse(gridComparar.Rows[rN].Cells[2].FormattedValue.ToString());
                Guitarra guit2 = new Guitarra(lblModelo2.Text, lblMarca2.Text, idGuit);
                url2 = (string)gridComparar.Rows[rN].Cells[12].FormattedValue;
                InsertarBusqueda(guit2.modelo, guit2.marca, sesionActual, landing.usuario.id, guit2.id);
                EscribirEnHistorial(landing.usuario.email, guit2.modelo);

                try
                {
                    String imgstr = (string)gridComparar.Rows[rN].Cells[13].FormattedValue;
                    Image img = new Bitmap(Auxiliar.stringToImg(imgstr));
                    picGuit2.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al convertir la cadena de texto en imagen: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Error, clica dentro de los valores");
            }
            gridComparar.Visible = false;






        }
        private void linkTienda2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(url2))
            {
                // Abrir la URL en el navegador predeterminado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url2,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertarBusqueda(string modelo, string marca, int sesion, int idEmail, int idGuitarra)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("insertarBusqueda", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@Marca", marca));
                    cmd.Parameters.Add(new SqlParameter("@Sesion", sesion));
                    cmd.Parameters.Add(new SqlParameter("@IdEmail", idEmail));
                    cmd.Parameters.Add(new SqlParameter("@IdGuitarra", idGuitarra));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la búsqueda: " + ex.Message);
            }
        }
        private void EscribirEnHistorial(string emailUsuario, string modeloGuitarra)
        {
            try
            {
                // Ruta al directorio base donde están almacenados los directorios de los usuarios
                string basePath = "data"; // Ajusta esta ruta según tu estructura de directorios
                string userDirectory = Path.Combine(basePath, emailUsuario);

                // Asegúrate de que el directorio del usuario exista
                if (!Directory.Exists(userDirectory))
                {
                    MessageBox.Show("El directorio del usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ruta al archivo de historial
                string historialFilePath = Path.Combine(userDirectory, "historial.ls");

                // Abrir el archivo en modo de adición (append mode) para añadir texto al final sin sobrescribir el contenido existente
                using (StreamWriter writer = new StreamWriter(historialFilePath, true))
                {
                    writer.WriteLine(modeloGuitarra);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir en el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del archivo de historial
                string email = landing.usuario.email; // Reemplazar con el email del usuario actual
                string filePath = $"data\\{email}\\historial.ls";

                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Leer el contenido del archivo
                    string historial = File.ReadAllText(filePath);

                    // Mostrar el contenido en un MessageBox
                    MessageBox.Show(historial, "Historial");
                }
                else
                {
                    MessageBox.Show("El archivo de historial no existe.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de historial: {ex.Message}", "Error");
            }
        }

        //private void RealizarBusqueda(string nombreGuitarra)
        //{
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        connection.Open();

        //        // Consulta SQL para buscar guitarras por nombre
        //        string query = "SELECT * FROM Guitarras WHERE Modelo LIKE @nombreGuitarra";

        //        // Crear el comando SQL con la consulta y la conexión
        //        SqlCommand cmd = new SqlCommand(query, connection);

        //        // Parametrizar la consulta para buscar coincidencias parciales del nombre de la guitarra
        //        cmd.Parameters.AddWithValue("@nombreGuitarra", "%" + nombreGuitarra + "%");

        //        // Ejecutar la consulta y obtener los resultados
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        // Mostrar los resultados en el DataGridView
        //        gridBuscar.DataSource = dt;

        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
        //    }
        //}
        //private void RealizarComparacion(string nombreGuitarra)
        //{
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        connection.Open();

        //        // Consulta SQL para buscar guitarras por nombre
        //        string query = "SELECT * FROM Guitarras WHERE Modelo LIKE @nombreGuitarra";

        //        // Crear el comando SQL con la consulta y la conexión
        //        SqlCommand cmd = new SqlCommand(query, connection);

        //        // Parametrizar la consulta para buscar coincidencias parciales del nombre de la guitarra
        //        cmd.Parameters.AddWithValue("@nombreGuitarra", "%" + nombreGuitarra + "%");

        //        // Ejecutar la consulta y obtener los resultados
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        // Mostrar los resultados en el DataGridView
        //        gridComparar.DataSource = dt;

        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
        //    }
        //}



    }

}
