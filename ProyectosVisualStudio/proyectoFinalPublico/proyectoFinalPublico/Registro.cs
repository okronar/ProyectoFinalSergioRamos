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
    }
}
