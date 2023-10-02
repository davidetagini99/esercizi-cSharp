using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_di_gestione_bibliotecaria
{
    public partial class finestraModificaLibro : Form
    {
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        public finestraModificaLibro()
        {
            sqlConnection = new SqlConnection("Data Source=LAPTOP-O6R5K7D8\\SQLEXPRESS; Initial Catalog = gestione_biblioteca; User Id=sa;Password=101199Dav99$SysADMIN");

            InitializeComponent();

            sqlCommand = new SqlCommand("SELECT DB_NAME()", sqlConnection);
        }

        private void finestraModificaLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale finestraPrincipale = new finestraPrincipale();

            finestraPrincipale.Show();
        }

        private void finestraModificaLibro_Load(object sender, EventArgs e)
        {

        }

        private void modificaLibro()
        {
            string queryModificaLibro = "UPDATE libri SET" + "titolo = @titolo" + "autore=@autore" + "anno_pubblicazione=@anno_pubblicazione" + "genere=@genere" + "codice_isbn =@codice_isbn" + "qta_disponibile=@qta_disponibile" + "data_acquisizione=@data_acquisizione" + "stato=@stato" + "categoria=@categoria" + "WHERE codice_isbn = @codice_isbn";

            sqlCommand = new SqlCommand(queryModificaLibro, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@titolo", casellaModificaTitoloLibro.Text);
            sqlCommand.Parameters.AddWithValue("@autore", casellaModificaAutore.Text);
            sqlCommand.Parameters.AddWithValue("@anno_pubblicazione", casellaModificaAnnoPubblicazione.Text);
            sqlCommand.Parameters.AddWithValue("@genere", menuListaModificaGenere.Text);
            sqlCommand.Parameters.AddWithValue("@codice_isbn", casellaModificaCodiceISBN.Text);
            sqlCommand.Parameters.AddWithValue("@qta_disponibile", casellaModificaQtaDisponibile.Maximum); // metto direttamente a maximum poiché in questa casella puoi inserire solo numeri
            sqlCommand.Parameters.AddWithValue("@categoria", listaModificaCategoria.Text);
            sqlCommand.Parameters.AddWithValue("@data_acquisizione", presaModificaDataAcquisizione.Value);
            sqlCommand.Parameters.AddWithValue("@stato", menuListaModificaStato.Text);
        }

        private void pulsanteModificaLibro_Click(object sender, EventArgs e)
        {
            if(casellaModificaTitoloLibro.Text==""||casellaModificaAutore.Text==""||casellaModificaAnnoPubblicazione.Text==""||menuListaModificaGenere.Text==""||casellaModificaCodiceISBN.Text==""||casellaModificaQtaDisponibile.Maximum==0||presaModificaDataAcquisizione.Text==""||menuListaModificaStato.Text==""||listaModificaCategoria.Text=="")
            {
                MessageBox.Show("Compila tutti i campi per modificare un libro");
            }
            else
            {
                try
                {
                    sqlConnection.Open();

                    modificaLibro();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    sqlConnection.Close();

                    casellaModificaTitoloLibro.Text = "";
                    casellaModificaAutore.Text = "";
                    casellaModificaAnnoPubblicazione.Text = "";
                    menuListaModificaGenere.Text = "";
                    casellaModificaCodiceISBN.Text = "";
                    casellaModificaQtaDisponibile.Maximum = 0;
                    presaModificaDataAcquisizione.Text = "";
                    menuListaModificaStato.Text = "";
                    listaModificaCategoria.Text = "";
                }
            }
        }
    }
}
