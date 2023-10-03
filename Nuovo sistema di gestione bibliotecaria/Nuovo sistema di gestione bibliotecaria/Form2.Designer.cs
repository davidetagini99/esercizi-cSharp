namespace Nuovo_sistema_di_gestione_bibliotecaria
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            pulsanteAggiungiLibro = new Button();
            menuListaStato = new ComboBox();
            label10 = new Label();
            menuListaGenere = new ComboBox();
            label9 = new Label();
            menuListaCategoria = new ComboBox();
            label8 = new Label();
            presaData = new DateTimePicker();
            label7 = new Label();
            casellaNumeroCopie = new RichTextBox();
            label6 = new Label();
            casellaCodiceISBN = new RichTextBox();
            label5 = new Label();
            casellaAnnoPubblicazione = new RichTextBox();
            label4 = new Label();
            casellaAutore = new RichTextBox();
            label3 = new Label();
            casellaTitolo = new RichTextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(363, 84);
            label1.TabIndex = 0;
            label1.Text = "Aggiungi un nuovo libro";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(pulsanteAggiungiLibro);
            groupBox1.Controls.Add(menuListaStato);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(menuListaGenere);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(menuListaCategoria);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(presaData);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(casellaNumeroCopie);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(casellaCodiceISBN);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(casellaAnnoPubblicazione);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(casellaAutore);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(casellaTitolo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(89, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1347, 572);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form di inserimento";
            // 
            // pulsanteAggiungiLibro
            // 
            pulsanteAggiungiLibro.BackColor = Color.DodgerBlue;
            pulsanteAggiungiLibro.Cursor = Cursors.Hand;
            pulsanteAggiungiLibro.FlatAppearance.BorderColor = Color.Black;
            pulsanteAggiungiLibro.FlatAppearance.BorderSize = 2;
            pulsanteAggiungiLibro.FlatStyle = FlatStyle.Flat;
            pulsanteAggiungiLibro.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteAggiungiLibro.ForeColor = Color.White;
            pulsanteAggiungiLibro.Location = new Point(52, 412);
            pulsanteAggiungiLibro.Name = "pulsanteAggiungiLibro";
            pulsanteAggiungiLibro.Size = new Size(404, 73);
            pulsanteAggiungiLibro.TabIndex = 15;
            pulsanteAggiungiLibro.Text = "Aggiungi";
            pulsanteAggiungiLibro.UseVisualStyleBackColor = false;
            pulsanteAggiungiLibro.Click += pulsanteAggiungiLibro_Click;
            // 
            // menuListaStato
            // 
            menuListaStato.FormattingEnabled = true;
            menuListaStato.Items.AddRange(new object[] { "Disponibile", "In prestito", "In riparazione", "Venduto" });
            menuListaStato.Location = new Point(735, 318);
            menuListaStato.Name = "menuListaStato";
            menuListaStato.Size = new Size(311, 28);
            menuListaStato.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(724, 295);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 16;
            label10.Text = "Stato";
            // 
            // menuListaGenere
            // 
            menuListaGenere.FormattingEnabled = true;
            menuListaGenere.Items.AddRange(new object[] { "Romanzo", "Fantasy", "Saggistica", "Giallo / Thriller", "Storia", "Poesia", "Scienza Fiction", "Biografia / Memoir", "Autobiografia", "Mistero" });
            menuListaGenere.Location = new Point(52, 318);
            menuListaGenere.Name = "menuListaGenere";
            menuListaGenere.Size = new Size(311, 28);
            menuListaGenere.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 295);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 14;
            label9.Text = "Genere";
            // 
            // menuListaCategoria
            // 
            menuListaCategoria.FormattingEnabled = true;
            menuListaCategoria.Items.AddRange(new object[] { "Letteratura classica", "Letteratura contemporanea", "Fantasy epico", "Saggistica scientifica", "Giallo psicologico", "Storia antica", "Poesia moderna", "Fantascienza utopica", "Biografie di personaggi storici", "Memorie di viaggio" });
            menuListaCategoria.Location = new Point(393, 318);
            menuListaCategoria.Name = "menuListaCategoria";
            menuListaCategoria.Size = new Size(311, 28);
            menuListaCategoria.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 295);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 12;
            label8.Text = "Categoria";
            // 
            // presaData
            // 
            presaData.Location = new Point(52, 251);
            presaData.Name = "presaData";
            presaData.Size = new Size(311, 25);
            presaData.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 228);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 10;
            label7.Text = "Data di acquisizione";
            // 
            // casellaNumeroCopie
            // 
            casellaNumeroCopie.Location = new Point(746, 163);
            casellaNumeroCopie.Name = "casellaNumeroCopie";
            casellaNumeroCopie.Size = new Size(311, 45);
            casellaNumeroCopie.TabIndex = 9;
            casellaNumeroCopie.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(735, 140);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 8;
            label6.Text = "Copie disponibili";
            // 
            // casellaCodiceISBN
            // 
            casellaCodiceISBN.Location = new Point(404, 163);
            casellaCodiceISBN.Name = "casellaCodiceISBN";
            casellaCodiceISBN.Size = new Size(311, 45);
            casellaCodiceISBN.TabIndex = 7;
            casellaCodiceISBN.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 140);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Codice ISBN";
            // 
            // casellaAnnoPubblicazione
            // 
            casellaAnnoPubblicazione.Location = new Point(52, 163);
            casellaAnnoPubblicazione.Name = "casellaAnnoPubblicazione";
            casellaAnnoPubblicazione.Size = new Size(311, 45);
            casellaAnnoPubblicazione.TabIndex = 5;
            casellaAnnoPubblicazione.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 140);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 4;
            label4.Text = "Anno di pubblicazione";
            // 
            // casellaAutore
            // 
            casellaAutore.Location = new Point(404, 67);
            casellaAutore.Name = "casellaAutore";
            casellaAutore.Size = new Size(311, 45);
            casellaAutore.TabIndex = 3;
            casellaAutore.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 44);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Autore";
            // 
            // casellaTitolo
            // 
            casellaTitolo.Location = new Point(52, 67);
            casellaTitolo.Name = "casellaTitolo";
            casellaTitolo.Size = new Size(311, 45);
            casellaTitolo.TabIndex = 1;
            casellaTitolo.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Titolo";
            // 
            // finestraAggiungiLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1581, 698);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "finestraAggiungiLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            FormClosed += finestraAggiungiLibro_FormClosed;
            Load += finestraAggiungiLibro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RichTextBox casellaTitolo;
        private RichTextBox casellaAutore;
        private Label label3;
        private RichTextBox casellaCodiceISBN;
        private Label label5;
        private RichTextBox casellaAnnoPubblicazione;
        private Label label4;
        private Label label7;
        private RichTextBox casellaNumeroCopie;
        private Label label6;
        private DateTimePicker presaData;
        private ComboBox menuListaCategoria;
        private Label label8;
        private ComboBox menuListaStato;
        private Label label10;
        private ComboBox menuListaGenere;
        private Label label9;
        private Button pulsanteAggiungiLibro;
    }
}