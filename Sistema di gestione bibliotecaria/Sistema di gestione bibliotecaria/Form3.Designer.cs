namespace Sistema_di_gestione_bibliotecaria
{
    partial class finestraModificaLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            etichettaModificaLibro = new Label();
            formModificaLibro = new GroupBox();
            pulsanteModificaLibro = new Button();
            menuListaModificaStato = new ComboBox();
            etichettaModificaStato = new Label();
            listaModificaCategoria = new ComboBox();
            etichettaModificaCategoria = new Label();
            presaModificaDataAcquisizione = new DateTimePicker();
            etichettaModificaDataAcquisizione = new Label();
            casellaModificaQtaDisponibile = new NumericUpDown();
            etichettaModificaQtaDisponibile = new Label();
            casellaModificaCodiceISBN = new TextBox();
            etichettaModificaCodiceISBN = new Label();
            menuListaModificaGenere = new ComboBox();
            etichettaModificaGenere = new Label();
            casellaModificaAnnoPubblicazione = new TextBox();
            etichettaModificaAnnoPubblicazione = new Label();
            casellaModificaAutore = new TextBox();
            etichettaModificaAutore = new Label();
            casellaModificaTitoloLibro = new TextBox();
            etichettaModificaTitoloLibro = new Label();
            formModificaLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)casellaModificaQtaDisponibile).BeginInit();
            SuspendLayout();
            // 
            // etichettaModificaLibro
            // 
            etichettaModificaLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaModificaLibro.Location = new Point(12, 24);
            etichettaModificaLibro.Name = "etichettaModificaLibro";
            etichettaModificaLibro.Size = new Size(258, 52);
            etichettaModificaLibro.TabIndex = 0;
            etichettaModificaLibro.Text = "Modifica libro";
            etichettaModificaLibro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formModificaLibro
            // 
            formModificaLibro.BackColor = Color.Silver;
            formModificaLibro.Controls.Add(pulsanteModificaLibro);
            formModificaLibro.Controls.Add(menuListaModificaStato);
            formModificaLibro.Controls.Add(etichettaModificaStato);
            formModificaLibro.Controls.Add(listaModificaCategoria);
            formModificaLibro.Controls.Add(etichettaModificaCategoria);
            formModificaLibro.Controls.Add(presaModificaDataAcquisizione);
            formModificaLibro.Controls.Add(etichettaModificaDataAcquisizione);
            formModificaLibro.Controls.Add(casellaModificaQtaDisponibile);
            formModificaLibro.Controls.Add(etichettaModificaQtaDisponibile);
            formModificaLibro.Controls.Add(casellaModificaCodiceISBN);
            formModificaLibro.Controls.Add(etichettaModificaCodiceISBN);
            formModificaLibro.Controls.Add(menuListaModificaGenere);
            formModificaLibro.Controls.Add(etichettaModificaGenere);
            formModificaLibro.Controls.Add(casellaModificaAnnoPubblicazione);
            formModificaLibro.Controls.Add(etichettaModificaAnnoPubblicazione);
            formModificaLibro.Controls.Add(casellaModificaAutore);
            formModificaLibro.Controls.Add(etichettaModificaAutore);
            formModificaLibro.Controls.Add(casellaModificaTitoloLibro);
            formModificaLibro.Controls.Add(etichettaModificaTitoloLibro);
            formModificaLibro.Location = new Point(20, 97);
            formModificaLibro.Name = "formModificaLibro";
            formModificaLibro.Size = new Size(1311, 728);
            formModificaLibro.TabIndex = 1;
            formModificaLibro.TabStop = false;
            formModificaLibro.Text = "Form di modifica";
            // 
            // pulsanteModificaLibro
            // 
            pulsanteModificaLibro.BackColor = Color.Coral;
            pulsanteModificaLibro.FlatStyle = FlatStyle.Popup;
            pulsanteModificaLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteModificaLibro.ForeColor = Color.Transparent;
            pulsanteModificaLibro.Location = new Point(18, 593);
            pulsanteModificaLibro.Name = "pulsanteModificaLibro";
            pulsanteModificaLibro.Size = new Size(481, 74);
            pulsanteModificaLibro.TabIndex = 18;
            pulsanteModificaLibro.Text = "Modifica libro";
            pulsanteModificaLibro.UseVisualStyleBackColor = false;
            pulsanteModificaLibro.Click += pulsanteModificaLibro_Click;
            // 
            // menuListaModificaStato
            // 
            menuListaModificaStato.FormattingEnabled = true;
            menuListaModificaStato.Location = new Point(18, 510);
            menuListaModificaStato.Name = "menuListaModificaStato";
            menuListaModificaStato.Size = new Size(274, 28);
            menuListaModificaStato.TabIndex = 17;
            // 
            // etichettaModificaStato
            // 
            etichettaModificaStato.Location = new Point(18, 482);
            etichettaModificaStato.Name = "etichettaModificaStato";
            etichettaModificaStato.Size = new Size(165, 25);
            etichettaModificaStato.TabIndex = 16;
            etichettaModificaStato.Text = "Stato";
            etichettaModificaStato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listaModificaCategoria
            // 
            listaModificaCategoria.FormattingEnabled = true;
            listaModificaCategoria.Location = new Point(469, 426);
            listaModificaCategoria.Name = "listaModificaCategoria";
            listaModificaCategoria.Size = new Size(274, 28);
            listaModificaCategoria.TabIndex = 15;
            // 
            // etichettaModificaCategoria
            // 
            etichettaModificaCategoria.Location = new Point(469, 398);
            etichettaModificaCategoria.Name = "etichettaModificaCategoria";
            etichettaModificaCategoria.Size = new Size(165, 25);
            etichettaModificaCategoria.TabIndex = 14;
            etichettaModificaCategoria.Text = "Categoria";
            etichettaModificaCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // presaModificaDataAcquisizione
            // 
            presaModificaDataAcquisizione.Location = new Point(18, 427);
            presaModificaDataAcquisizione.Name = "presaModificaDataAcquisizione";
            presaModificaDataAcquisizione.Size = new Size(274, 27);
            presaModificaDataAcquisizione.TabIndex = 13;
            // 
            // etichettaModificaDataAcquisizione
            // 
            etichettaModificaDataAcquisizione.Location = new Point(18, 398);
            etichettaModificaDataAcquisizione.Name = "etichettaModificaDataAcquisizione";
            etichettaModificaDataAcquisizione.Size = new Size(165, 25);
            etichettaModificaDataAcquisizione.TabIndex = 12;
            etichettaModificaDataAcquisizione.Text = "Data di acquisizione";
            etichettaModificaDataAcquisizione.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // casellaModificaQtaDisponibile
            // 
            casellaModificaQtaDisponibile.AutoSize = true;
            casellaModificaQtaDisponibile.Location = new Point(469, 317);
            casellaModificaQtaDisponibile.Name = "casellaModificaQtaDisponibile";
            casellaModificaQtaDisponibile.Size = new Size(274, 27);
            casellaModificaQtaDisponibile.TabIndex = 11;
            // 
            // etichettaModificaQtaDisponibile
            // 
            etichettaModificaQtaDisponibile.Location = new Point(469, 289);
            etichettaModificaQtaDisponibile.Name = "etichettaModificaQtaDisponibile";
            etichettaModificaQtaDisponibile.Size = new Size(165, 25);
            etichettaModificaQtaDisponibile.TabIndex = 10;
            etichettaModificaQtaDisponibile.Text = "Quantità disponibile";
            etichettaModificaQtaDisponibile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // casellaModificaCodiceISBN
            // 
            casellaModificaCodiceISBN.BorderStyle = BorderStyle.FixedSingle;
            casellaModificaCodiceISBN.Location = new Point(18, 317);
            casellaModificaCodiceISBN.Multiline = true;
            casellaModificaCodiceISBN.Name = "casellaModificaCodiceISBN";
            casellaModificaCodiceISBN.Size = new Size(274, 46);
            casellaModificaCodiceISBN.TabIndex = 9;
            // 
            // etichettaModificaCodiceISBN
            // 
            etichettaModificaCodiceISBN.Location = new Point(18, 289);
            etichettaModificaCodiceISBN.Name = "etichettaModificaCodiceISBN";
            etichettaModificaCodiceISBN.Size = new Size(165, 25);
            etichettaModificaCodiceISBN.TabIndex = 8;
            etichettaModificaCodiceISBN.Text = "Codice ISBN";
            etichettaModificaCodiceISBN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuListaModificaGenere
            // 
            menuListaModificaGenere.FormattingEnabled = true;
            menuListaModificaGenere.Location = new Point(469, 207);
            menuListaModificaGenere.Name = "menuListaModificaGenere";
            menuListaModificaGenere.Size = new Size(274, 28);
            menuListaModificaGenere.TabIndex = 7;
            // 
            // etichettaModificaGenere
            // 
            etichettaModificaGenere.Location = new Point(469, 179);
            etichettaModificaGenere.Name = "etichettaModificaGenere";
            etichettaModificaGenere.Size = new Size(165, 25);
            etichettaModificaGenere.TabIndex = 6;
            etichettaModificaGenere.Text = "Genere";
            etichettaModificaGenere.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // casellaModificaAnnoPubblicazione
            // 
            casellaModificaAnnoPubblicazione.BorderStyle = BorderStyle.FixedSingle;
            casellaModificaAnnoPubblicazione.Location = new Point(18, 207);
            casellaModificaAnnoPubblicazione.Multiline = true;
            casellaModificaAnnoPubblicazione.Name = "casellaModificaAnnoPubblicazione";
            casellaModificaAnnoPubblicazione.Size = new Size(274, 46);
            casellaModificaAnnoPubblicazione.TabIndex = 5;
            // 
            // etichettaModificaAnnoPubblicazione
            // 
            etichettaModificaAnnoPubblicazione.Location = new Point(18, 179);
            etichettaModificaAnnoPubblicazione.Name = "etichettaModificaAnnoPubblicazione";
            etichettaModificaAnnoPubblicazione.Size = new Size(165, 25);
            etichettaModificaAnnoPubblicazione.TabIndex = 4;
            etichettaModificaAnnoPubblicazione.Text = "Anno di pubblicazione";
            etichettaModificaAnnoPubblicazione.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // casellaModificaAutore
            // 
            casellaModificaAutore.BorderStyle = BorderStyle.FixedSingle;
            casellaModificaAutore.Location = new Point(469, 76);
            casellaModificaAutore.Multiline = true;
            casellaModificaAutore.Name = "casellaModificaAutore";
            casellaModificaAutore.Size = new Size(274, 46);
            casellaModificaAutore.TabIndex = 3;
            // 
            // etichettaModificaAutore
            // 
            etichettaModificaAutore.Location = new Point(469, 48);
            etichettaModificaAutore.Name = "etichettaModificaAutore";
            etichettaModificaAutore.Size = new Size(165, 25);
            etichettaModificaAutore.TabIndex = 2;
            etichettaModificaAutore.Text = "Autore";
            etichettaModificaAutore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // casellaModificaTitoloLibro
            // 
            casellaModificaTitoloLibro.BorderStyle = BorderStyle.FixedSingle;
            casellaModificaTitoloLibro.Location = new Point(18, 76);
            casellaModificaTitoloLibro.Multiline = true;
            casellaModificaTitoloLibro.Name = "casellaModificaTitoloLibro";
            casellaModificaTitoloLibro.Size = new Size(274, 46);
            casellaModificaTitoloLibro.TabIndex = 1;
            // 
            // etichettaModificaTitoloLibro
            // 
            etichettaModificaTitoloLibro.Location = new Point(18, 48);
            etichettaModificaTitoloLibro.Name = "etichettaModificaTitoloLibro";
            etichettaModificaTitoloLibro.Size = new Size(165, 25);
            etichettaModificaTitoloLibro.TabIndex = 0;
            etichettaModificaTitoloLibro.Text = "Titolo";
            etichettaModificaTitoloLibro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // finestraModificaLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1376, 855);
            Controls.Add(formModificaLibro);
            Controls.Add(etichettaModificaLibro);
            Name = "finestraModificaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            FormClosed += finestraModificaLibro_FormClosed;
            Load += finestraModificaLibro_Load;
            formModificaLibro.ResumeLayout(false);
            formModificaLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)casellaModificaQtaDisponibile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label etichettaModificaLibro;
        private GroupBox formModificaLibro;
        private Label etichettaModificaTitoloLibro;
        private TextBox casellaModificaTitoloLibro;
        private Label etichettaModificaAutore;
        private TextBox casellaModificaAutore;
        private Label etichettaModificaAnnoPubblicazione;
        private TextBox casellaModificaAnnoPubblicazione;
        private ComboBox menuListaModificaGenere;
        private Label etichettaModificaGenere;
        private TextBox casellaModificaCodiceISBN;
        private NumericUpDown casellaModificaQtaDisponibile;
        private Label etichettaModificaQtaDisponibile;
        private Label etichettaModificaCodiceISBN;
        private DateTimePicker presaModificaDataAcquisizione;
        private Label etichettaModificaDataAcquisizione;
        private Label etichettaModificaCategoria;
        private ComboBox listaModificaCategoria;
        private ComboBox menuListaModificaStato;
        private Label etichettaModificaStato;
        private Button pulsanteModificaLibro;
    }
}