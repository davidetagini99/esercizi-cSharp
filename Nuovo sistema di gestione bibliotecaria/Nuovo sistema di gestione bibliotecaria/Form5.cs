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
    public partial class finestraConfermaRegistrazioneCliente : Form
    {
        public finestraConfermaRegistrazioneCliente()
        {
            InitializeComponent();
        }

        private void finestraConfermaRegistrazioneCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ciao, sono conferma account");
        }
    }
}
