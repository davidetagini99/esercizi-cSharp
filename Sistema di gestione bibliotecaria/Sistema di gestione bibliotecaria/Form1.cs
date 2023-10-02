using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_di_gestione_bibliotecaria
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

        private finestraAggiungiLibro formAggiungiLibro = new finestraAggiungiLibro();

        private void btnAggiungiLibro_Click(object sender, EventArgs e)
        {
            Hide();

            formAggiungiLibro.Show();
        }

        private void finestraPrincipale_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
        }

        private finestraModificaLibro finestraModificaLibro = new finestraModificaLibro();

        private void pulsanteSchermataModificaLibro_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();

            Hide();

            finestraModificaLibro.Show();
        }
    }
}