using Microsoft.Data.SqlClient;
using proyectoFinalAdministrador;
using proyectoFinalPublico;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace ProyectoFinalBuscador
{
    public partial class Administrador : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        public Administrador()
        {
            InitializeComponent();
            visualizarGuitarras();
            visualizarUsuarios();
        }

        private void visualizarGuitarras()
        {
            string sqlQuery = "SELECT * FROM Guitarras";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GridActualizarGuitarra.DataSource = dt;
                dataGridguitborrar.DataSource = dt;

            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }
        private void visualizarUsuarios()
        {
            string sqlQuery = "SELECT * FROM Usuarios";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridBorrarUsuarios.DataSource = dt;


            }
            catch (Exception)
            {

                MessageBox.Show("Fallo");
                throw;


            }
        }

        private void CargarIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                picmuestra.Image = img;


            }

        }

        private void cargImgAct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                picmuestraAct.Image = img;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbCuerpo.Text != null && txtbModelo.Text != null && txtbMarca.Text != null && txtBEscala.Text != null && txtbFijac.Text != null && txtbMaderaCuer.Text != null
                    && txtbMaderaDiapa.Text != null && txtbMaderaMastil.Text != null && txtbPuente.Text != null && txtbUrl.Text != null && txtbYear.Text != null && picmuestra.Image != null)
                {


                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("insertarGuitarra", connection);

                    //esto es para especificar que es un procedimiento 
                    cmd.CommandType = CommandType.StoredProcedure;


                    String modelo = txtbModelo.Text;
                    String marca = txtbMarca.Text;
                    String year = txtbMarca.Text;
                    String cuerpo = txtbCuerpo.Text;
                    String fijacion = txtbFijac.Text;
                    String escala = txtBEscala.Text;
                    String maderacuerpo = txtbMaderaCuer.Text;
                    String maderamastil = txtbMaderaMastil.Text;
                    String maderadiapason = txtbMaderaDiapa.Text;
                    String puente = txtbPuente.Text;
                    String pastillas = txtbPastillas.Text;
                    String url = txtbUrl.Text;
                    String imagen = Auxiliar.imgToString(new Bitmap(picmuestra.Image));



                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                    cmd.Parameters.Add(new SqlParameter("@marca", marca));
                    cmd.Parameters.Add(new SqlParameter("@year", year));
                    cmd.Parameters.Add(new SqlParameter("@cuerpo", cuerpo));
                    cmd.Parameters.Add(new SqlParameter("@fijacion", fijacion));
                    cmd.Parameters.Add(new SqlParameter("@escala", escala));
                    cmd.Parameters.Add(new SqlParameter("@maderacuerpo", maderacuerpo));
                    cmd.Parameters.Add(new SqlParameter("@maderamastil", maderamastil));
                    cmd.Parameters.Add(new SqlParameter("@maderadiapason", maderadiapason));
                    cmd.Parameters.Add(new SqlParameter("@puente", puente));
                    cmd.Parameters.Add(new SqlParameter("@pastillas", pastillas));
                    cmd.Parameters.Add(new SqlParameter("@url", url));
                    cmd.Parameters.Add(new SqlParameter("@imagen", imagen));


                    cmd.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Exito insertando guitarra");
                    visualizarGuitarras();
                }

                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo, revise si el producto ya existe");

                throw;
            }

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (picmuestraAct.Image != null && txbCuerpoActu.Text != null && txbModeloAct.Text != null && txbMarcaActu.Text != null && txbEscalaActu.Text != null && txbFijaActu.Text != null && txbMCuerActu.Text != null
                    && txbMDiapActu.Text != null && txbMMastActu.Text != null && txbPuenteActu.Text != null && txbURLActu.Text != null && txbYearActu.Text != null)
                {

                    if (int.TryParse(txbIdActu.Text, out int idActu))
                    {
                        // El valor se ha convertido correctamente



                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("actualizarGuitarra", connection);

                        //esto es para especificar que es un procedimiento 
                        cmd.CommandType = CommandType.StoredProcedure;


                        String modelo = txbModeloAct.Text;
                        String marca = txbMarcaActu.Text;
                        String year = txbYearActu.Text;
                        String cuerpo = txbCuerpoActu.Text;
                        String fijacion = txbFijaActu.Text;
                        String escala = txbEscalaActu.Text;
                        String maderacuerpo = txbMCuerActu.Text;
                        String maderamastil = txbMMastActu.Text;
                        String maderadiapason = txbMDiapActu.Text;
                        String puente = txbPuenteActu.Text;
                        String pastillas = txbPastActu.Text;
                        String url = txbURLActu.Text;
                        String imagen = Auxiliar.imgToString(new Bitmap(picmuestraAct.Image));





                        cmd.Parameters.Add(new SqlParameter("@id", idActu));
                        cmd.Parameters.Add(new SqlParameter("@modelo", modelo));
                        cmd.Parameters.Add(new SqlParameter("@marca", marca));
                        cmd.Parameters.Add(new SqlParameter("@year", year));
                        cmd.Parameters.Add(new SqlParameter("@cuerpo", cuerpo));
                        cmd.Parameters.Add(new SqlParameter("@fijacion", fijacion));
                        cmd.Parameters.Add(new SqlParameter("@escala", escala));
                        cmd.Parameters.Add(new SqlParameter("@maderacuerpo", maderacuerpo));
                        cmd.Parameters.Add(new SqlParameter("@maderamastil", maderamastil));
                        cmd.Parameters.Add(new SqlParameter("@maderadiapason", maderadiapason));
                        cmd.Parameters.Add(new SqlParameter("@puente", puente));
                        cmd.Parameters.Add(new SqlParameter("@pastillas", pastillas));
                        cmd.Parameters.Add(new SqlParameter("@url", url));
                        cmd.Parameters.Add(new SqlParameter("@imagen", imagen));



                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exito actualizando guitarra");
                            visualizarGuitarras();
                        }
                        else
                        {
                            MessageBox.Show("El ID especificado no existe en la base de datos");
                            txbIdActu.Text = null;
                        }



                        connection.Close();

                    }
                    else
                    {
                        // Manejar el caso en que el valor no se puede convertir a entero
                        MessageBox.Show("debe introducir un numero para el identificador");
                    }
                }

                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo actualizando");

                throw;
            }

        }

        private void btnBorrarEmail_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("deleteUsuario", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String usuarioBorrar = txboxUsuarioBorrar.Text;

                cmd.Parameters.Add(new SqlParameter("@Email", usuarioBorrar));


                cmd.ExecuteNonQuery();

                connection.Close();

                //borramos directorio tambien
                EliminarDirectorioCliente(usuarioBorrar);

                visualizarUsuarios();

                txboxUsuarioBorrar.Text = null;

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al borrar cliente y su historial");
                throw;
            }
        }

        private void EliminarDirectorioCliente(string clienteId)
        {
            try
            {
                string proyectoPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location); // Ruta del ejecutable del proyecto
                string rutaDatosUsuarios = Path.Combine(proyectoPath, @"..\..\..\..\..\proyectoFinalPublico\proyectoFinalPublico\bin\Debug\net8.0-windows\data\", clienteId);

                if (Directory.Exists(rutaDatosUsuarios))
                {
                    Directory.Delete(rutaDatosUsuarios, true); // true para eliminar subdirectorios y archivos
                    MessageBox.Show("Directorio del cliente eliminado correctamente.");

                }
                else
                {
                    MessageBox.Show("El directorio del cliente no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el directorio del cliente: " + ex.Message);
            }
        }



        private void GridActualizarGuitarra_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var rN = e.RowIndex;
            int col = -1;
            int rowCount = GridActualizarGuitarra.Rows.Count;

            if (rN >= 0 && rN < rowCount - 1)
            {

                txbModeloAct.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[0].FormattedValue;
                txbMarcaActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[1].FormattedValue;
                txbIdActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[2].FormattedValue;
                txbYearActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[3].FormattedValue;
                txbCuerpoActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[4].FormattedValue;
                txbFijaActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[5].FormattedValue;
                txbEscalaActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[6].FormattedValue;
                txbMCuerActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[7].FormattedValue;
                txbMMastActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[8].FormattedValue;
                txbMDiapActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[9].FormattedValue;
                txbPuenteActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[10].FormattedValue;
                txbPastActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[11].FormattedValue;
                txbURLActu.Text = (string)GridActualizarGuitarra.Rows[rN].Cells[12].FormattedValue;


                try
                {
                    String imgstr = (string)GridActualizarGuitarra.Rows[rN].Cells[13].FormattedValue;
                    Image img = new Bitmap(Auxiliar.stringToImg(imgstr));
                    picmuestraAct.Image = img;
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




        }

        private void btnBorrarGuitarra_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("deleteGuitarra", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String guitarraBorrar = txboxIdBorrar.Text;

                cmd.Parameters.Add(new SqlParameter("@id", guitarraBorrar));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Exito al borrar guitarra");
                    visualizarGuitarras();
                }
                else
                {
                    MessageBox.Show("La guitarra con el ID especificado no existe");
                }



                connection.Close();

                txboxIdBorrar.Text = null;



            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al borrar guitarra");

            }
        }

        private void dataGridguitborrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Para borrar, introduzca manualmente el id");
        }

       
    }
}
