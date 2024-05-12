using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace proyectoFinalPublico
{
    public partial class BuscadorComparador : Form
    {
        Landing landing;
        public BuscadorComparador(Landing landing)
        {
            InitializeComponent();
            this.landing = landing;



        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            landing.Show();
        }

        private void BuscadorComparador_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            landing.Show();


        }
    }
}
