using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    public partial class finestraModificaLibro : Form
    {
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        public finestraModificaLibro(string titolo)
        {
            sqlConnection = new SqlConnection("Data Source=LAPTOP-O6R5K7D8\\SQLEXPRESS; Initial Catalog=gestione_biblioteca; User Id=sa;Password=101199Dav99$SysADMIN");

            InitializeComponent();

            sqlCommand = new SqlCommand("SELECT DB_NAME()", sqlConnection);

            caricaDettagliLibro(titolo);
        }

        private void caricaDettagliLibro(string titolo)
        {
            sqlConnection.Open();

            string queryDettagliLibro = "SELECT * FROM libri WHERE titolo = @titolo";

            using (SqlCommand sqlCommand = new SqlCommand(queryDettagliLibro, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@titolo", titolo);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string titoloLibro = reader["titolo"].ToString();
                        string autore = reader["autore"].ToString();
                        string annoPubblicazione = reader["anno_pubblicazione"].ToString();
                        string codiceISBN = reader["codice_isbn"].ToString();
                        string copieDisponibili = reader["qta_disponibile"].ToString();
                        string presaDataAcquisizioneImpostata = reader["data_acquisizione"].ToString();
                        string genereImpostato = reader["genere"].ToString();
                        string categoriaImpostata = reader["categoria"].ToString();
                        string statoImpostato = reader["stato"].ToString();

                        casellaModTitolo.Text = titoloLibro;
                        casellaModAutore.Text = autore;
                        casellaModAnnoPubblicazione.Text = annoPubblicazione;
                        casellaModCodiceISBN.Text = codiceISBN;
                        casellaModCopieDisponibili.Text = copieDisponibili;
                        modPresaDataAcquisizione.Text = presaDataAcquisizioneImpostata;
                        menuModListaGenere.Text = genereImpostato;
                        menuModListaCategoria.Text = categoriaImpostata;
                        menuModListaStato.Text = statoImpostato;
                    }
                }
            }

            sqlConnection.Close();
        }

        public void modificaLibro()
        {
            sqlConnection.Open();

            string queryModificaLibro = "UPDATE libri SET autore = @autore, anno_pubblicazione = @anno, codice_isbn = @isbn, qta_disponibile = @copie, data_acquisizione = @dataAcq, genere = @genere, categoria = @categoria, stato = @stato WHERE titolo = @titolo";

            using (SqlCommand sqlCommand = new SqlCommand(queryModificaLibro, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@titolo", casellaModTitolo.Text);
                sqlCommand.Parameters.AddWithValue("@autore", casellaModAutore.Text);
                sqlCommand.Parameters.AddWithValue("@anno", casellaModAnnoPubblicazione.Text);
                sqlCommand.Parameters.AddWithValue("@isbn", casellaModCodiceISBN.Text);
                sqlCommand.Parameters.AddWithValue("@copie", casellaModCopieDisponibili.Text);
                sqlCommand.Parameters.AddWithValue("@dataAcq", modPresaDataAcquisizione.Value);
                sqlCommand.Parameters.AddWithValue("@genere", menuModListaGenere.Text);
                sqlCommand.Parameters.AddWithValue("@categoria", menuModListaCategoria.Text);
                sqlCommand.Parameters.AddWithValue("@stato", menuModListaStato.Text);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Libro modificato con successo!");
            }

            sqlConnection.Close();
        }

        private void finestraModificaLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale principale = new finestraPrincipale();

            principale.Show();
        }

        private void pulsanteModificaLibro_Click(object sender, EventArgs e)
        {
            modificaLibro();
        }
    }
}
