using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    public partial class finestraAccessoCliente : Form
    {
        public finestraAccessoCliente()
        {
            InitializeComponent();
        }

        private void finestraAccessoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            finestraPrincipale principale = new finestraPrincipale();

            principale.Show();
        }

        private finestraRegistrazioneCliente registrazioneCliente = new finestraRegistrazioneCliente();

        private void etichettaSchermataRegistrazioneCliente_Click(object sender, EventArgs e)
        {
            Hide();

            registrazioneCliente.Show();
        }

        private void pulsanteAccedi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ciao, sono accedi");
        }
    }
}
