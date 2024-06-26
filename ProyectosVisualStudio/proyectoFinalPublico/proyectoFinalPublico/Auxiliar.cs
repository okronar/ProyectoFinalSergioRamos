﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace proyectoFinalPublico
{
    public static class Auxiliar
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        public static string IV = "aldoej45f8r564gh"; // 16 chars = 128 bits
        public static string key = "aldoej45f8r564ghaldoej45f8r564gh"; // 32 chars



        //llamada al servicio de criptografia
        public static string Encrypt(string decrypted)
        {

            //recuperarmos el texto sin cifrar
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);

            //configuracion del objeto que nos permitira ejecutar el encriptador

            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //encriptador 
            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);

        }
        public static string Decrypt(string encrypted)
        {

            //recuperarmos el texto sin cifrar
            byte[] textbytes = Convert.FromBase64String(encrypted);

            //configuracion del objeto que nos permitira ejecutar el encriptador

            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = ASCIIEncoding.ASCII.GetBytes(key);
            encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //encriptador 
            ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

            byte[] dec = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);

        }

        public static String imgToString(Bitmap img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);

            byte[] arr = ms.GetBuffer();
            string output = Convert.ToBase64String(arr);
            return output;

        }

        public static Bitmap stringToImg(string consultaSql)
        {
            byte[] arr = Convert.FromBase64String(consultaSql);

            MemoryStream ms = new MemoryStream();
            ms.Write(arr, 0, Convert.ToInt32(arr.Length));

            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }

        //Método que comprueba si existe un usuario en la base de datos
        public static bool VerificarUsuarioExistente(string email)
        {
            bool usuarioExiste = false;

            try
            {
                
                SqlConnection connection = new SqlConnection(connectionString);
                
                connection.Open();

                SqlCommand cmd = new SqlCommand("ComprobarUserExiste", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);

                // Obtiene el número de clientes con ese nombre de usuario
                int count = (int)cmd.ExecuteScalar();

                //Si el resultado es mayor a 0, exite un usuario
                if (count > 0)
                {
                    usuarioExiste = true;
                }
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario existente");
                throw;
            }

            return usuarioExiste;
        }
        public static Usuario ObtenerUsuario(string email, string password)
        {
            Usuario usuario = null;

            try
            {
                string query = "SELECT id, email, password FROM Usuarios WHERE email = @Email AND password = @Password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string Email = reader["email"].ToString();
                                string Password = reader["password"].ToString();

                                usuario = new Usuario(id, Email);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show("Error al obtener el usuario: " + ex.Message);
            }

            return usuario;
        }





    }
}
