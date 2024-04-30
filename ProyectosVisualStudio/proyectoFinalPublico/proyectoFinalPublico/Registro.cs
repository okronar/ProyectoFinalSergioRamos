using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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

namespace proyectoFinalPublico
{
    public partial class Registro : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Registro()
        {
            InitializeComponent();

        }

        private void btnvolreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            String email = txbEmailReg.Text;
            String pass = txboxPassReg.Text;
            String reppass = txbPassRepReg.Text;


            if (email.Length < 3 || pass.Length < 4)

                MessageBox.Show("Username o password no válido");
            else if (!pass.Equals( reppass)) { 
                 MessageBox.Show("Las contraseñas han de coincidir");
            }
            else
            {
                //Comprobar si el username existe en base de datos 

                //Hacer una consulta connection el userName al la tabla Clientes

                bool emailExiste = Auxiliar.VerificarUsuarioExistente(email);   
                if (emailExiste)
                {
                    MessageBox.Show("Email ya registrado", "Error");
                }
                else
                {
                    try
                    {

                        // El usuario no existe, proceder connection la inserción
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("InsertarUsuario", connection);
                        cmd.CommandType = CommandType.StoredProcedure;


                        //Se encripta la contraseña
                        string encpassword = Auxiliar.Encrypt(pass);

                        cmd.Parameters.Add(new SqlParameter("@Email", email));
                        cmd.Parameters.Add(new SqlParameter("@Password", encpassword));
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        //Se crea un objeto cliente que será el que ahora esté dentro de la aplicación

                        //Mensaje de confirmación
                        MessageBox.Show("Usuario creado correctamente, redirigiendo al login", "Éxito");
                        
                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }

        }

    }
 }

