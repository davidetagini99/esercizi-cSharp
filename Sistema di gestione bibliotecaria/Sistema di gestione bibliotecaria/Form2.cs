﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_di_gestione_bibliotecaria
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

        private void finestraAggiungiLibro_Load(object sender, EventArgs e)
        {
            visualizzaLibro();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale finestraPrincipale = new finestraPrincipale();
            finestraPrincipale.Show();
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
                        listaLibriShortcut.Items.Add(titoloLibro);
                    }
                }
            }

            sqlConnection.Close();
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
    }
}