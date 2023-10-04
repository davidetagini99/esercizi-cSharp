using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    public partial class finestraAggiungiLibro : Form
    {
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        public finestraAggiungiLibro()
        {
            sqlConnection = new SqlConnection("Data Source=LAPTOP-O6R5K7D8\\SQLEXPRESS; Initial Catalog = gestione_biblioteca; User Id=sa;Password=101199Dav99$SysADMIN");

            InitializeComponent();

            sqlCommand = new SqlCommand("SELECT DB_NAME()", sqlConnection);
        }

        public void inserisciLibro()
        {
            string queryInserisciLibro = "INSERT INTO libri (titolo, autore, anno_pubblicazione, genere, codice_isbn, qta_disponibile, categoria, data_acquisizione, stato)" +
                                         "VALUES (@titolo, @autore, @anno_pubblicazione, @genere, @codice_isbn, @qta_disponibile, @categoria, @data_acquisizione, @stato)";

            using (SqlCommand sqlCommand = new SqlCommand(queryInserisciLibro, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@titolo", casellaTitolo.Text);
                sqlCommand.Parameters.AddWithValue("@autore", casellaAutore.Text);
                sqlCommand.Parameters.AddWithValue("@anno_pubblicazione", casellaAnnoPubblicazione.Text);
                sqlCommand.Parameters.AddWithValue("@genere", menuListaGenere.Text);
                sqlCommand.Parameters.AddWithValue("@codice_isbn", casellaCodiceISBN.Text);
                sqlCommand.Parameters.AddWithValue("@qta_disponibile", casellaNumeroCopie.Text);
                sqlCommand.Parameters.AddWithValue("@categoria", menuListaCategoria.Text);
                sqlCommand.Parameters.AddWithValue("@data_acquisizione", presaData.Value);
                sqlCommand.Parameters.AddWithValue("@stato", menuListaStato.Text);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void pulsanteAggiungiLibro_Click(object sender, EventArgs e)
        {
            if (casellaTitolo.Text == "" || casellaAutore.Text == "" || casellaAnnoPubblicazione.Text == "" || menuListaGenere.Text == "" || casellaCodiceISBN.Text == "" || casellaNumeroCopie.Text == "" || menuListaCategoria.Text == "" || presaData.Text == "" || menuListaStato.Text == "")
            {
                MessageBox.Show("Compila tutti i campi per aggiungere un nuovo libro");
            }
            else
            {
                try
                {
                    inserisciLibro();

                    MessageBox.Show("Hai aggiunto un nuovo libro");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    sqlConnection.Close();

                    casellaTitolo.Text = "";
                    casellaAutore.Text = "";
                    casellaAnnoPubblicazione.Text = "";
                    menuListaGenere.Text = "";
                    casellaCodiceISBN.Text = "";
                    casellaNumeroCopie.Text = "";
                    menuListaCategoria.Text = "";
                    presaData.Text = "";
                    menuListaStato.Text = "";
                }
            }
        }

        private void casellaAnnoPubblicazione_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void casellaCodiceISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; 
            }
        }

        private void casellaNumeroCopie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private string RemoveInvalidCharacters(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '-')
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private void casellaAnnoPubblicazione_TextChanged(object sender, EventArgs e)
        {
            casellaAnnoPubblicazione.Text = RemoveInvalidCharacters(casellaAnnoPubblicazione.Text);
        }

        private void casellaCodiceISBN_TextChanged(object sender, EventArgs e)
        {
            casellaCodiceISBN.Text = RemoveInvalidCharacters(casellaCodiceISBN.Text);
        }

        private void casellaNumeroCopie_TextChanged(object sender, EventArgs e)
        {
            casellaNumeroCopie.Text = RemoveInvalidCharacters(casellaNumeroCopie.Text);
        }

        private void finestraAggiungiLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale principale = new finestraPrincipale();

            principale.Show();
        }
    }
}