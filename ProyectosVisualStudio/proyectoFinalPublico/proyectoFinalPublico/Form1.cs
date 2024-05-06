using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;
using System.Data;

namespace proyectoFinalPublico
{
    public partial class Landing : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Landing()
        {

            InitializeComponent();




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Comprobar que está todo relleno
            if (txbEmailInicio.Text == String.Empty || txtbPassInicio.Text == String.Empty)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    //Consulta sql 
                    SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                    string username = tb_user.Text;
                    string encryptedPassword = AesCrypt.Encrypt(tb_password.Text);
                    con.Open();

                    SqlCommand command = new SqlCommand("login", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", encryptedPassword);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        //Coger los datos de la consulta
                        string dbUsername = reader["username"].ToString();
                        string dbPassword = reader["contrasenaCliente"].ToString();

                        //Comprobar si coinciden
                        if (dbUsername == username && dbPassword == encryptedPassword)
                        {

                            MessageBox.Show("¡Bienvenido!", "Inicio");

                            //Se guarda el cliente para poder usar sus datos en la aplicación de vista cliente
                            guardarClienteLogeado();

                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Error en el password", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado", "Error");
                    }

                    reader.Close();
                    con.Close(); // Cierra la conexión
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo", "Error");
                    throw;
                }



            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            //respuesta al boton
            Registro registro = new Registro();
            registro.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TerminosYCondiciones terms = new TerminosYCondiciones();
            terms.Show();
        }
    }
}
