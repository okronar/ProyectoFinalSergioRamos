using GestionPapeleria.Auxiliar;
using GestionPapeleria.Clases;
using GestionPapeleria.Cliente;
using GestionPapeleria.Componentes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionPapeleria
{

    public partial class Login : Form
    {
        //Variables de objeto usuario (cliente), si el usuario es administrador, 
        public static Usuario clienteLogueado;
        public static bool esAdmin;
        public static string tipoUserLogin;


        //El login recibe el tipo de usuario como parámetro
        public Login(string tipoUser)
        {
            InitializeComponent();
            tipoUserLogin = tipoUser;
            setEsAdmin();
            
            //Hacer visibles elementos si es admin o cliente
            lbl_admin.Visible = esAdmin;
            btn_clear.Visible = !esAdmin;
    
        }

        //Cerrado de ventana
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que comprueba si el parámetro que recibe el login es admin o es cliente
        public static void setEsAdmin()
        {
            esAdmin = (tipoUserLogin != "cliente");
        }




        //Botón de login, realiza toda la lógica de buscar si existe el usuario insertado y que tipo de usuario es
        private void btn_login_Click(object sender, EventArgs e)
        {
        
            //Comprobar que está todo relleno
            if (tb_password.Text == String.Empty || tb_user.Text == String.Empty)
            {
                MessageBox.Show("Por favor rellene todos los campos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //Debe ser de cierta largura
                if (tb_user.Text.Length < 3 || tb_password.Text.Length <4)
                {
                    MessageBox.Show("Username o Password no válido");
                }
                else
                {
                    //Si es un cliente, busca el usuario en la tabla clientes
                    if (!esAdmin)
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

                    //Es usuario administrador
                   else
                    {

                        try
                        {

                            //Consulta sql
                            SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                            string username = tb_user.Text;
                            string password = AesCrypt.Encrypt(tb_password.Text);

                            con.Open();

                            SqlCommand command = new SqlCommand("loginadmin", con);
                            command.CommandType = CommandType.StoredProcedure;

   
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            SqlDataReader reader = command.ExecuteReader();

                            //Mientras hata datos
                            if (reader.Read())
                            {
                                //Se obtienen los datos 
                                string dbUsername = reader["nombre"].ToString();
                                string dbPassword = reader["passwordAdmin"].ToString();

                                //Se comprueban si coinciden los insertados con los encontrados
                                if (dbUsername == username && dbPassword == password)
                                {

                                    //Se obtiene el rol del usuario  (worker o admin)
                                    obtenerRol(username);
                                }
                                else
                                {
                                    MessageBox.Show("Error en el password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario no registrado", "Error");
                            }
                            reader.Close();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Fallo", "Error");
                            throw;
                        }
                    }
                } 
             }       
        }


        //Botón para abrir una venta de registro de nuevo cliente
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            Hide();

        }
        //Método que guarda el cliente que se loguea en la aplicación
        public void guardarClienteLogeado ()
        {
            //Select del id del cliente 
            string username = tb_user.Text;
            try
            {
                SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                con.Open();
                SqlCommand cmd = new SqlCommand("BuscarClienteporUsername", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();


                //Mientras se devuelvan datos
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        //Se obtiene los datos
                        int id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                        string nombreCompleto = reader["nombreCompleto"].ToString();
                        string correo = reader["correo"].ToString();
                        string telefono = reader["telefono"].ToString();
                        string direccion = reader["direccion"].ToString();

                        //Crear el nuevo usuario
                        clienteLogueado = new Usuario(id_cliente, nombreCompleto, correo, telefono, direccion, username);
                        VistaCliente.comprobarHayCliente();
                        VistaCliente.cargarAntiguosPedidos();
                      
                    }

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo", "Fail");
                throw;
            }
        }

        //Mostrar la contraseña introducida
        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_password.Checked ? '\0' : '*';
        }

        //Método que obtiene el rol del usuario insertado
        private void obtenerRol(string username)
        {
            try
            {
                SqlConnection dbConn = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);

                dbConn.Open();

                SqlCommand commandRol = new SqlCommand("GetRole", dbConn);
                commandRol.CommandType = CommandType.StoredProcedure;
                commandRol.Parameters.AddWithValue("@username", username);

                SqlDataReader readerRol = commandRol.ExecuteReader();

                //Mientras se lean datos
                if (readerRol.Read())
                {
                    string rol = readerRol["rol"].ToString();

                    MessageBox.Show("Bienvenido " + username, "Inicio");

                    //Enviamos el tipo de rol al Dashboard y se mostrarán las opciones dependiendo del rol
                    Dashboard form1 = new Dashboard(rol);
                    form1.Show();
                    this.Hide();
                    dbConn.Close();
                }
                               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
     }
    
}
