using Microsoft.Data.SqlClient;
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
