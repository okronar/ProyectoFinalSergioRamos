using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace proyectoFinalPublico
{
    public partial class Landing : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Usuario usuario = new Usuario();
        public Landing()
        {

            InitializeComponent();




        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Comprobar que está todo relleno
            if (txbEmailInicio.Text == String.Empty || txtbPassInicio.Text == String.Empty)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Consulta SQL 
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string email = txbEmailInicio.Text;
                        string encryptedPassword = Auxiliar.Encrypt(txtbPassInicio.Text);

                        SqlCommand command = new SqlCommand("login", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", encryptedPassword);
                        command.Parameters.Add("@loginSuccessful", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();

                        int loginSuccessful = (int)command.Parameters["@loginSuccessful"].Value;

                        if (loginSuccessful == 1)
                        {

                            MessageBox.Show("¡Bienvenido!", "Inicio");
                            usuario = Auxiliar.ObtenerUsuario(email, encryptedPassword);
                            BuscadorComparador buscador = new BuscadorComparador(this);
                            buscador.Show();
                            this.Hide();
                            
                            
                        }else if (loginSuccessful == 0) {
                           
                        }
                        else if (loginSuccessful == -1) {
                         
                            MessageBox.Show("Usuario no registrado", "Error");
                        }

                        else {

                            MessageBox.Show("Error desconocido", "Error");
                        }
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo", "Error");
                    throw;
                }
            }
        }

        private void guardarUsuario(Usuario usu)
        {
            
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{

        //    //Comprobar que está todo relleno
        //    if (txbEmailInicio.Text == String.Empty || txtbPassInicio.Text == String.Empty)
        //    {
        //        MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {

        //        try
        //        {
        //            //Consulta sql 
        //            SqlConnection connection = new SqlConnection(connectionString);
        //            connection.Open();
        //            string email = txbEmailInicio.Text;
        //            string encryptedPassword = Auxiliar.Encrypt(txtbPassInicio.Text);


        //            SqlCommand command = new SqlCommand("login", connection);
        //            command.CommandType = CommandType.StoredProcedure;

        //            command.Parameters.AddWithValue("@email", email);
        //            command.Parameters.AddWithValue("@password", encryptedPassword);

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                //Coger los datos de la consulta
        //                string dbUsername = reader["email"].ToString();
        //                string dbPassword = reader["password"].ToString();

        //                //Comprobar si coinciden
        //                if (dbUsername == email && dbPassword == encryptedPassword)
        //                {

        //                    MessageBox.Show("¡Bienvenido!", "Inicio");

        //                    //guardarUsuario();

        //                    this.Close();

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Error en el password", "Error");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Usuario no registrado", "Error");
        //            }

        //            reader.Close();
        //            connection.Close(); // Cierra la conexión
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Fallo", "Error");
        //            throw;
        //        }



        //    }
        //}

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
