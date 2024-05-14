using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace proyectoFinalPublico
{
    public partial class BuscadorComparador : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        Landing landing;
        public BuscadorComparador(Landing landing)
        {
            InitializeComponent();
            this.landing = landing;



        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            landing.Show();
        }

        private void BuscadorComparador_FormClosing(object sender, FormClosingEventArgs e)
        {

            landing.Close();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (visualizarGuitarrasBusqueda())
            {
                gridBuscar.Visible = true;


            }
            else
            {
                MessageBox.Show("No se han encontrado resultados");

            }
        }


        private bool visualizarGuitarrasBusqueda()
        {
            string sqlQuery = "SELECT * FROM Guitarras";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridBuscar.DataSource = dt;

                // Retornar true si hay filas en el DataTable, false si no hay filas
                return dt.Rows.Count > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }
        private bool visualizarGuitarrasBusqueda2()
        {
            string sqlQuery = "SELECT * FROM Guitarras";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gridComparar.DataSource = dt;

                // Retornar true si hay filas en el DataTable, false si no hay filas
                return dt.Rows.Count > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo");
                throw;
            }
        }

        private void gridBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableLayoutPanel13.Visible = true;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel17.Visible = true;
            tableLayoutPanel11.Visible = true;




            var rN = e.RowIndex;
            int col = -1;
            int rowCount = gridBuscar.Rows.Count;

            if (rN >= 0 && rN < rowCount)
            {

                labelmodelo1.Text = (string)gridBuscar.Rows[rN].Cells[0].FormattedValue;
                labelmarca1.Text = (string)gridBuscar.Rows[rN].Cells[1].FormattedValue;

                labelyear1.Text = (string)gridBuscar.Rows[rN].Cells[3].FormattedValue;
                labelcuerpo1.Text = (string)gridBuscar.Rows[rN].Cells[4].FormattedValue;
                labelfijacion1.Text = (string)gridBuscar.Rows[rN].Cells[5].FormattedValue;
                labelescala1.Text = (string)gridBuscar.Rows[rN].Cells[6].FormattedValue;
                labelMcuerpo1.Text = (string)gridBuscar.Rows[rN].Cells[7].FormattedValue;
                labelMdiapason1.Text = (string)gridBuscar.Rows[rN].Cells[8].FormattedValue;
                labelMmastil1.Text = (string)gridBuscar.Rows[rN].Cells[9].FormattedValue;
                labelPuente1.Text = (string)gridBuscar.Rows[rN].Cells[10].FormattedValue;
                labelPastilla1.Text = (string)gridBuscar.Rows[rN].Cells[11].FormattedValue;

                // txbURLActu.Text = (string)gridBuscar.Rows[rN].Cells[12].FormattedValue;


                try
                {
                    String imgstr = (string)gridBuscar.Rows[rN].Cells[13].FormattedValue;
                    Image img = new Bitmap(Auxiliar.stringToImg(imgstr));
                    picGuitar1.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al convertir la cadena de texto en imagen: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Error, clica dentro de los valores");
            }
            gridBuscar.Visible = false;




        }
        private void btnCompare_Click(object sender, EventArgs e)
        {

            if (visualizarGuitarrasBusqueda2())
            {
                gridComparar.Visible = true;


            }
            else
            {
                MessageBox.Show("No se han encontrado resultados");

            }
        }

        private void gridComparar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tableLayoutPanel13.Visible = true;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel17.Visible = true;
            tableLayoutPanel11.Visible = true;




            var rN = e.RowIndex;
            int col = -1;
            int rowCount = gridBuscar.Rows.Count;

            if (rN >= 0 && rN < rowCount)
            {

                lblModelo2.Text = (string)gridComparar.Rows[rN].Cells[0].FormattedValue;
                lblMarca2.Text = (string)gridComparar.Rows[rN].Cells[1].FormattedValue;

                lblYear2.Text = (string)gridComparar.Rows[rN].Cells[3].FormattedValue;
                lblCuerpo2.Text = (string)gridComparar.Rows[rN].Cells[4].FormattedValue;
                lblFijacion2.Text = (string)gridComparar.Rows[rN].Cells[5].FormattedValue;
                lblEscala2.Text = (string)gridComparar.Rows[rN].Cells[6].FormattedValue;
                lblMaderaCuerpo2.Text = (string)gridComparar.Rows[rN].Cells[7].FormattedValue;
                lblMaderaDiapason2.Text = (string)gridComparar.Rows[rN].Cells[8].FormattedValue;
                lblMaderaMastil2.Text = (string)gridComparar.Rows[rN].Cells[9].FormattedValue;
                lblPuente2.Text = (string)gridComparar.Rows[rN].Cells[10].FormattedValue;
                lblPastillas2.Text = (string)gridComparar.Rows[rN].Cells[11].FormattedValue;

                // txbURLActu.Text = (string)gridBuscar.Rows[rN].Cells[12].FormattedValue;


                try
                {
                    String imgstr = (string)gridComparar.Rows[rN].Cells[13].FormattedValue;
                    Image img = new Bitmap(Auxiliar.stringToImg(imgstr));
                    picGuit2.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al convertir la cadena de texto en imagen: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Error, clica dentro de los valores");
            }
            gridComparar.Visible = false;






        }
    }

}
