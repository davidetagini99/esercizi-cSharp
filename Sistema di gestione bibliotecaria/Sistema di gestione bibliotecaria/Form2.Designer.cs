namespace Sistema_di_gestione_bibliotecaria
{
    partial class finestraAggiungiLibro
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
            formInserimentoLibro = new GroupBox();
            pulsanteAggiungiLibro = new Button();
            menuListaStato = new ComboBox();
            label10 = new Label();
            presaData = new DateTimePicker();
            label9 = new Label();
            menuListaCategoria = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            casellaCodiceISBN = new TextBox();
            label6 = new Label();
            menuListaGenere = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            casellaAnnoPubblicazione = new TextBox();
            casellaAutore = new TextBox();
            casellaTitolo = new TextBox();
            etichettaAggiungiLibro = new Label();
            listaLibriShortcut = new ListBox();
            casellaNumeroCopie = new TextBox();
            formInserimentoLibro.SuspendLayout();
            SuspendLayout();
            // 
            // formInserimentoLibro
            // 
            formInserimentoLibro.BackColor = Color.LightGray;
            formInserimentoLibro.Controls.Add(casellaNumeroCopie);
            formInserimentoLibro.Controls.Add(pulsanteAggiungiLibro);
            formInserimentoLibro.Controls.Add(menuListaStato);
            formInserimentoLibro.Controls.Add(label10);
            formInserimentoLibro.Controls.Add(presaData);
            formInserimentoLibro.Controls.Add(label9);
            formInserimentoLibro.Controls.Add(menuListaCategoria);
            formInserimentoLibro.Controls.Add(label8);
            formInserimentoLibro.Controls.Add(label7);
            formInserimentoLibro.Controls.Add(casellaCodiceISBN);
            formInserimentoLibro.Controls.Add(label6);
            formInserimentoLibro.Controls.Add(menuListaGenere);
            formInserimentoLibro.Controls.Add(label5);
            formInserimentoLibro.Controls.Add(label4);
            formInserimentoLibro.Controls.Add(label3);
            formInserimentoLibro.Controls.Add(label2);
            formInserimentoLibro.Controls.Add(casellaAnnoPubblicazione);
            formInserimentoLibro.Controls.Add(casellaAutore);
            formInserimentoLibro.Controls.Add(casellaTitolo);
            formInserimentoLibro.FlatStyle = FlatStyle.Flat;
            formInserimentoLibro.Location = new Point(12, 118);
            formInserimentoLibro.Name = "formInserimentoLibro";
            formInserimentoLibro.Size = new Size(781, 727);
            formInserimentoLibro.TabIndex = 1;
            formInserimentoLibro.TabStop = false;
            formInserimentoLibro.Text = "Form di inserimento";
            // 
            // pulsanteAggiungiLibro
            // 
            pulsanteAggiungiLibro.BackColor = Color.Coral;
            pulsanteAggiungiLibro.FlatStyle = FlatStyle.Popup;
            pulsanteAggiungiLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteAggiungiLibro.ForeColor = Color.White;
            pulsanteAggiungiLibro.Location = new Point(31, 606);
            pulsanteAggiungiLibro.Name = "pulsanteAggiungiLibro";
            pulsanteAggiungiLibro.Size = new Size(467, 65);
            pulsanteAggiungiLibro.TabIndex = 11;
            pulsanteAggiungiLibro.Text = "Aggiungi il libro";
            pulsanteAggiungiLibro.UseVisualStyleBackColor = false;
            pulsanteAggiungiLibro.Click += pulsanteAggiungiLibro_Click;
            // 
            // menuListaStato
            // 
            menuListaStato.FormattingEnabled = true;
            menuListaStato.Items.AddRange(new object[] { "Disponibile", "In prestito", "In riparazione", "Venduto" });
            menuListaStato.Location = new Point(31, 486);
            menuListaStato.Name = "menuListaStato";
            menuListaStato.Size = new Size(306, 28);
            menuListaStato.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 437);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 17;
            label10.Text = "Stato";
            // 
            // presaData
            // 
            presaData.Location = new Point(403, 379);
            presaData.Name = "presaData";
            presaData.Size = new Size(250, 27);
            presaData.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(403, 328);
            label9.Name = "label9";
            label9.Size = new Size(144, 20);
            label9.TabIndex = 15;
            label9.Text = "Data di acquisizione";
            // 
            // menuListaCategoria
            // 
            menuListaCategoria.FormattingEnabled = true;
            menuListaCategoria.Items.AddRange(new object[] { "Lettura Classica", "Lettura Contemporanea", "Fantasy Epico", "Saggistica Scientifica", "Giallo Psicologico", "Storia Antica", "Poesia Moderna", "Fantascienza Utopica", "Biografie di Personaggi Storici", "Memorie di Viaggio" });
            menuListaCategoria.Location = new Point(31, 378);
            menuListaCategoria.Name = "menuListaCategoria";
            menuListaCategoria.Size = new Size(306, 28);
            menuListaCategoria.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 328);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 13;
            label8.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 230);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 11;
            label7.Text = "Numero di copie";
            // 
            // casellaCodiceISBN
            // 
            casellaCodiceISBN.BorderStyle = BorderStyle.FixedSingle;
            casellaCodiceISBN.Location = new Point(31, 271);
            casellaCodiceISBN.Multiline = true;
            casellaCodiceISBN.Name = "casellaCodiceISBN";
            casellaCodiceISBN.Size = new Size(306, 40);
            casellaCodiceISBN.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 230);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 9;
            label6.Text = "Codice ISBN";
            // 
            // menuListaGenere
            // 
            menuListaGenere.FormattingEnabled = true;
            menuListaGenere.Items.AddRange(new object[] { "Romanzo", "Fantasy", "Saggistica", "Giallo / Thriller", "Storia", "Poesia", "Scienza Fiction", "Biografia / Memoir", "Autobiografia", "Mistero" });
            menuListaGenere.Location = new Point(403, 173);
            menuListaGenere.Name = "menuListaGenere";
            menuListaGenere.Size = new Size(306, 28);
            menuListaGenere.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 135);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Genere";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 135);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 6;
            label4.Text = "Anno di pubblicazione";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 45);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Autore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 45);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Titolo";
            // 
            // casellaAnnoPubblicazione
            // 
            casellaAnnoPubblicazione.BorderStyle = BorderStyle.FixedSingle;
            casellaAnnoPubblicazione.Location = new Point(31, 174);
            casellaAnnoPubblicazione.Multiline = true;
            casellaAnnoPubblicazione.Name = "casellaAnnoPubblicazione";
            casellaAnnoPubblicazione.Size = new Size(306, 40);
            casellaAnnoPubblicazione.TabIndex = 4;
            // 
            // casellaAutore
            // 
            casellaAutore.BorderStyle = BorderStyle.FixedSingle;
            casellaAutore.Location = new Point(403, 77);
            casellaAutore.Multiline = true;
            casellaAutore.Name = "casellaAutore";
            casellaAutore.Size = new Size(306, 40);
            casellaAutore.TabIndex = 3;
            // 
            // casellaTitolo
            // 
            casellaTitolo.BorderStyle = BorderStyle.FixedSingle;
            casellaTitolo.Location = new Point(31, 77);
            casellaTitolo.Multiline = true;
            casellaTitolo.Name = "casellaTitolo";
            casellaTitolo.Size = new Size(306, 40);
            casellaTitolo.TabIndex = 2;
            // 
            // etichettaAggiungiLibro
            // 
            etichettaAggiungiLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaAggiungiLibro.Location = new Point(12, 19);
            etichettaAggiungiLibro.Name = "etichettaAggiungiLibro";
            etichettaAggiungiLibro.Size = new Size(337, 42);
            etichettaAggiungiLibro.TabIndex = 0;
            etichettaAggiungiLibro.Text = "Aggiungi un nuovo libro\r\n";
            etichettaAggiungiLibro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listaLibriShortcut
            // 
            listaLibriShortcut.BackColor = Color.LightGray;
            listaLibriShortcut.BorderStyle = BorderStyle.FixedSingle;
            listaLibriShortcut.FormattingEnabled = true;
            listaLibriShortcut.ItemHeight = 20;
            listaLibriShortcut.Location = new Point(857, 118);
            listaLibriShortcut.Name = "listaLibriShortcut";
            listaLibriShortcut.Size = new Size(674, 722);
            listaLibriShortcut.TabIndex = 2;
            // 
            // casellaNumeroCopie
            // 
            casellaNumeroCopie.BorderStyle = BorderStyle.FixedSingle;
            casellaNumeroCopie.Location = new Point(403, 270);
            casellaNumeroCopie.Multiline = true;
            casellaNumeroCopie.Name = "casellaNumeroCopie";
            casellaNumeroCopie.Size = new Size(306, 41);
            casellaNumeroCopie.TabIndex = 18;
            // 
            // finestraAggiungiLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1624, 861);
            Controls.Add(listaLibriShortcut);
            Controls.Add(etichettaAggiungiLibro);
            Controls.Add(formInserimentoLibro);
            Name = "finestraAggiungiLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software biblioteca";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form2_FormClosed;
            Load += finestraAggiungiLibro_Load;
            formInserimentoLibro.ResumeLayout(false);
            formInserimentoLibro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox formInserimentoLibro;
        private TextBox casellaTitolo;
        private TextBox casellaAnnoPubblicazione;
        private TextBox casellaAutore;
        private Label label2;
        private Label label3;
        private ComboBox menuListaGenere;
        private Label label5;
        private Label label4;
        private TextBox casellaCodiceISBN;
        private Label label6;
        private Label label7;
        private ComboBox menuListaCategoria;
        private Label label8;
        private Label label9;
        private DateTimePicker presaData;
        private ComboBox menuListaStato;
        private Label label10;
        private Button pulsanteAggiungiLibro;
        private Label etichettaAggiungiLibro;
        private ListBox listaLibriShortcut;
        private TextBox casellaNumeroCopie;
    }
}