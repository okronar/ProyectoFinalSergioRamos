using Microsoft.Data.SqlClient;
using proyectoFinalAdministrador;
using proyectoFinalPublico;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Windows.Forms;


namespace ProyectoFinalBuscador
{
    public partial class Administrador : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        public Administrador()
        {
            InitializeComponent();
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
                if (picmuestra.Image != null && txtbCuerpo.Text != null && txtbModelo.Text != null && txtbMarca.Text != null && txtBEscala.Text != null && txtbFijac.Text != null && txtbMaderaCuer.Text != null
                    && txtbMaderaDiapa.Text != null && txtbMaderaMastil.Text != null && txtbPuente.Text != null && txtbUrl.Text != null && txtbYear.Text != null)
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

        
    }
}
