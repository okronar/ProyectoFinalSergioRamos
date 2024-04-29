using Microsoft.Win32;
using System.Configuration;

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
