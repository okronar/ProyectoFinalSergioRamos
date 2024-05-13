using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalPublico
{
    public partial class TerminosYCondiciones : Form
    {
        public Landing land;
        public TerminosYCondiciones(Landing land)
        {
            InitializeComponent();
            this.land = land;
        }

        private void btnVolvTer_Click(object sender, EventArgs e)
        {
            this.Hide();
            land.Show();

        }


        private void TerminosYCondiciones_FormClosed(object sender, FormClosedEventArgs e)
        {


            this.Hide();
            land.Show();

        }
    }
}
