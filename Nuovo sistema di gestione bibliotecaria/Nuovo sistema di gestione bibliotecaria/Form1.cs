using System.Data.SqlClient;

namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    public partial class finestraPrincipale : Form
    {
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        public finestraPrincipale()
        {
            sqlConnection = new SqlConnection("Data Source=LAPTOP-O6R5K7D8\\SQLEXPRESS; Initial Catalog = gestione_biblioteca; User Id=sa;Password=101199Dav99$SysADMIN");

            InitializeComponent();

            sqlCommand = new SqlCommand("SELECT DB_NAME()", sqlConnection);
        }

        public void visualizzaLibro()
        {
            sqlConnection.Open();

            string queryVisualizzaLibro = "SELECT titolo FROM libri";

            using (SqlCommand sqlCommand = new SqlCommand(queryVisualizzaLibro, sqlConnection))
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string titoloLibro = reader["titolo"].ToString();
                        listaLibriInseriti.Items.Add(titoloLibro);
                    }
                }
            }

            sqlConnection.Close();
        }

        private void finestraPrincipale_Load(object sender, EventArgs e)
        {
            visualizzaLibro();
        }

        private finestraAggiungiLibro aggiungiLibro = new finestraAggiungiLibro();

        private void pulsanteSchermataAggiungiLibro_Click(object sender, EventArgs e)
        {
            Hide();

            aggiungiLibro.Show();
        }

        private finestraAccessoCliente accessoCliente = new finestraAccessoCliente();

        private void pulsanteSchermataAreaCliente_Click(object sender, EventArgs e)
        {
            Hide();

            accessoCliente.Show();
        }

        //private finestraModificaLibro modificaLibro = new finestraModificaLibro();

        private void listaLibriInseriti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaLibriInseriti.SelectedItem != null)
            {
                string titoloSelezionato = listaLibriInseriti.SelectedItem.ToString();

                sqlConnection.Close();

                finestraModificaLibro modificaLibro = new finestraModificaLibro(titoloSelezionato);

                //modificaLibro.titoloLibroSelezionato = titoloSelezionato;

                Hide();

                modificaLibro.Show();
            }
        }
    }
}