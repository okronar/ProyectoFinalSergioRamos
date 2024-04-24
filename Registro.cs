﻿using GestionPapeleria.Auxiliar;
using GestionPapeleria.Clases;
using GestionPapeleria.Cliente;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionPapeleria
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        //Cerrar la ventana
        private void registro_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cierra el form de registro y vuelve al de login de "cliente"
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Login log = new Login("cliente");
            log.ShowDialog();
            this.Hide();
        }


        //Mostrar la contraseña introducida
        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            tb_passwordRepeat.PasswordChar = cb_password_repeat.Checked ? '\0' : '*';
        }
        private void cb_password_CheckedChanged_1(object sender, EventArgs e)
        {
            tb_password_reg.PasswordChar = cb_password.Checked ? '\0' : '*';
        }
       

        //Botón que realiza el registro y todos los procedimientos necesarios
        private void btn_registro_Click(object sender, EventArgs e)
        {
            string username = tb_user_reg.Text;

            if (tb_user_reg.Text.Length < 3 || tb_password_reg.Text.Length < 4)

                MessageBox.Show("Username o password no válido");

            else
            {
                //Comprobar si el username existe en base de datos 

                //Hacer una consulta con el userName al la tabla Clientes

                bool usuarioExiste = ExisteUsuario.VerificarClienteExistente(username);
                if (usuarioExiste)
                {
                    MessageBox.Show("Nombre de usuario ya registrado", "Error");
                }
                else
                {
                    try
                    {

                    // El usuario no existe, proceder con la inserción
                    SqlConnection con = new SqlConnection(GestionPapeleria.Auxiliar.GlobalVariables.DB_CONNECTION);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("RegisterCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    //Se encripta la contraseña
                    string encpassword = AesCrypt.Encrypt(tb_password_reg.Text);

                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@password", encpassword));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //Se crea un objeto cliente que será el que ahora esté dentro de la aplicación

                    //Mensaje de confirmación
                    MessageBox.Show("Usuario creado correctamente, redirigiendo al login", "Éxito");
                    Login vc = new Login("cliente");
                    vc.Show();
                    this.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString()); 
                    }
                }

            }
        }
    }
}
