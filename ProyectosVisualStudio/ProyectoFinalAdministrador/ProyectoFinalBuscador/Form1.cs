using Microsoft.Data.SqlClient;
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
                if(picmuestra.Image != null && txtbCuerpo.Text != null && txtbModelo.Text !=null && txtbMarca.Text != null && txtBEscala.Text != null && txtbFijac.Text != null && txtbMaderaCuer.Text != null
                    && txtbMaderaDiapa.Text != null && txtbMaderaMastil.Text != null && txtbPuente.Text != null && txtbUrl.Text != null && txtbYear.Text != null) {
                
               
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SaveProduct", connection);

                //esto es para especificar que es un procedimiento 
                cmd.CommandType = CommandType.StoredProcedure;

                String codigoProducto = txboxCodigo.Text;
                String nombreProducto = txboxNombre.Text;
                String familiaProducto = txboxFamilia.Text;
                String marcaProducto = txboxMarca.Text;
                float precioProducto = float.Parse(txboxPrecio.Text);

                cmd.Parameters.Add(new SqlParameter("@codigoProducto", codigoProducto));
                cmd.Parameters.Add(new SqlParameter("@nombreProducto", nombreProducto));
                cmd.Parameters.Add(new SqlParameter("@familiaProducto", familiaProducto));
                cmd.Parameters.Add(new SqlParameter("@marcaProducto", marcaProducto));
                cmd.Parameters.Add(new SqlParameter("@precioProducto", precioProducto));

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
