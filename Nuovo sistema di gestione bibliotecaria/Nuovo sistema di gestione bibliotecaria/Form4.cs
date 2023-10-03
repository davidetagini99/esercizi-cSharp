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
using System.Net.Mail;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    public partial class finestraRegistrazioneCliente : Form
    {
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        public finestraRegistrazioneCliente()
        {
            sqlConnection = new SqlConnection("Data Source=LAPTOP-O6R5K7D8\\SQLEXPRESS; Initial Catalog = gestione_biblioteca; User Id=sa;Password=101199Dav99$SysADMIN");

            InitializeComponent();

            sqlCommand = new SqlCommand("SELECT DB_NAME()", sqlConnection);
        }

        public void registra_confermaUtente(string destinatario, string oggetto, string corpo)
        {
            string queryInserisciNuovoUtente = "INSERT INTO utenti (nome, cognome, indirizzo_email, data_nascita, sesso, password, conferma_password, account_confermato, account_attivo)" +
                "VALUES (@nome, @cognome, @indirizzo_email, @data_nascita, @sesso, @password, @conferma_password, 0, 0)";

            using (SqlCommand sqlCommand = new SqlCommand(queryInserisciNuovoUtente, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@nome", casellaNome.Text);
                sqlCommand.Parameters.AddWithValue("@cognome", casellaCognome.Text);
                sqlCommand.Parameters.AddWithValue("@indirizzo_email", casellaIndirizzoEmail.Text);
                sqlCommand.Parameters.AddWithValue("@data_nascita", presaDataNascita.Value);
                sqlCommand.Parameters.AddWithValue("@sesso", controlloSessoMaschio);
                sqlCommand.Parameters.AddWithValue("@sesso", controlloSessoFemmina);
                sqlCommand.Parameters.AddWithValue("@password", casellaPassword.Text);
                sqlCommand.Parameters.AddWithValue("@conferma_password", casellaConfermaPassword.Text);

                //rivedere se il radio button non funziona

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                // nel processo di registrazione, se la query avviene invia una email con il codice otp da inserire per confermare l'account

                string mittente = "davide.tagini99@gmail.com";
                string password = "kigwtorbkqmhetnu";
                string serverSMTP = "smtp.gmail.com";
                int portaSMTP = 587;

                using (MailMessage mail = new MailMessage(mittente, destinatario))
                {
                    mail.Subject = oggetto;
                    mail.Body = corpo;
                    mail.IsBodyHtml = true;

                    using (SmtpClient client = new SmtpClient(serverSMTP, portaSMTP))
                    {
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(mittente, password);
                        client.EnableSsl = true;

                        try
                        {
                            client.Send(mail);

                            MessageBox.Show("Ti arriverà una email contenente il tuo codice di conferma per attivare l'account");

                            Hide();

                            confermaRegistrazioneCliente.Show();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                    }
                }
            }
        }

        private finestraConfermaRegistrazioneCliente confermaRegistrazioneCliente = new finestraConfermaRegistrazioneCliente();

        private void finestraRegistrazioneCliente_Load(object sender, EventArgs e)
        {

        }

        private void finestraRegistrazioneCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale principale = new finestraPrincipale();

            principale.Show();
        }

        private void pulsanteRegistrati_Click(object sender, EventArgs e)
        {
            if (casellaNome.Text == "" || casellaCognome.Text == "" || casellaIndirizzoEmail.Text == "" || casellaPassword.Text == "" || casellaConfermaPassword.Text == "")
            {
                MessageBox.Show("Compila tutti i campi per completare la registrazione");
            }
            else
            {
                if (casellaPassword.Text != casellaConfermaPassword.Text)  
                {
                    MessageBox.Show("Le password inserite non corrispondono");
                }
                else
                {
                    try
                    {
                        sqlConnection.Open();

                        registra_confermaUtente(casellaIndirizzoEmail.Text, "Conferma registrazione", "Ciao, inserisci questo codice numerico di 6 cifre per completare la registrazione");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();

                        casellaNome.Text = "";
                        casellaCognome.Text = "";
                        casellaIndirizzoEmail.Text = "";
                        casellaPassword.Text = "";
                        casellaConfermaPassword.Text = "";
                    }
                }
            }
        }
    }
}
