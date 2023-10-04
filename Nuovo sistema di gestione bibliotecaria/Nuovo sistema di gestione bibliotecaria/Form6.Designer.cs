namespace Nuovo_sistema_di_gestione_bibliotecaria
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            pulsanteModificaLibro = new Button();
            menuModListaStato = new ComboBox();
            label10 = new Label();
            menuModListaCategoria = new ComboBox();
            label9 = new Label();
            menuModListaGenere = new ComboBox();
            label8 = new Label();
            modPresaDataAcquisizione = new DateTimePicker();
            label7 = new Label();
            casellaModCopieDisponibili = new RichTextBox();
            label6 = new Label();
            casellaModCodiceISBN = new RichTextBox();
            label5 = new Label();
            casellaModAnnoPubblicazione = new RichTextBox();
            label4 = new Label();
            casellaModAutore = new RichTextBox();
            label3 = new Label();
            casellaModTitolo = new RichTextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(666, 74);
            label1.TabIndex = 0;
            label1.Text = "Modifica i parametri di un libro se risultano non essere corretti";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(pulsanteModificaLibro);
            groupBox1.Controls.Add(menuModListaStato);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(menuModListaCategoria);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(menuModListaGenere);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(modPresaDataAcquisizione);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(casellaModCopieDisponibili);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(casellaModCodiceISBN);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(casellaModAnnoPubblicazione);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(casellaModAutore);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(casellaModTitolo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(57, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1250, 588);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form di modifica";
            // 
            // pulsanteModificaLibro
            // 
            pulsanteModificaLibro.BackColor = Color.DodgerBlue;
            pulsanteModificaLibro.FlatAppearance.BorderColor = Color.Black;
            pulsanteModificaLibro.FlatAppearance.BorderSize = 2;
            pulsanteModificaLibro.FlatStyle = FlatStyle.Flat;
            pulsanteModificaLibro.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteModificaLibro.ForeColor = Color.White;
            pulsanteModificaLibro.Location = new Point(62, 440);
            pulsanteModificaLibro.Name = "pulsanteModificaLibro";
            pulsanteModificaLibro.Size = new Size(495, 76);
            pulsanteModificaLibro.TabIndex = 18;
            pulsanteModificaLibro.Text = "Modifica";
            pulsanteModificaLibro.UseVisualStyleBackColor = false;
            pulsanteModificaLibro.Click += pulsanteModificaLibro_Click;
            // 
            // menuModListaStato
            // 
            menuModListaStato.FormattingEnabled = true;
            menuModListaStato.Items.AddRange(new object[] { "Disponibile", "In prestito", "In riparazione", "Venduto" });
            menuModListaStato.Location = new Point(760, 371);
            menuModListaStato.Name = "menuModListaStato";
            menuModListaStato.Size = new Size(306, 28);
            menuModListaStato.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(743, 348);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 16;
            label10.Text = "Stato";
            // 
            // menuModListaCategoria
            // 
            menuModListaCategoria.FormattingEnabled = true;
            menuModListaCategoria.Items.AddRange(new object[] { "Letteratura classica", "Letteratura contemporanea", "Fantasy epico", "Saggistica scientifica", "Giallo psicologico", "Storia antica", "Poesia moderna", "Fantascienza utopica", "Biografie di personaggi storici", "Memorie di viaggio" });
            menuModListaCategoria.Location = new Point(415, 371);
            menuModListaCategoria.Name = "menuModListaCategoria";
            menuModListaCategoria.Size = new Size(306, 28);
            menuModListaCategoria.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 348);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 14;
            label9.Text = "Categoria";
            // 
            // menuModListaGenere
            // 
            menuModListaGenere.FormattingEnabled = true;
            menuModListaGenere.Items.AddRange(new object[] { "Romanzo", "Fantasy", "Saggistica", "Giallo / Thriller", "Storia", "Poesia", "Scienza Fiction", "Biografia / Memoir", "Autobiografia", "Mistero" });
            menuModListaGenere.Location = new Point(62, 371);
            menuModListaGenere.Name = "menuModListaGenere";
            menuModListaGenere.Size = new Size(306, 28);
            menuModListaGenere.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 348);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 12;
            label8.Text = "Genere";
            // 
            // modPresaDataAcquisizione
            // 
            modPresaDataAcquisizione.Location = new Point(62, 282);
            modPresaDataAcquisizione.Name = "modPresaDataAcquisizione";
            modPresaDataAcquisizione.Size = new Size(306, 25);
            modPresaDataAcquisizione.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 259);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 10;
            label7.Text = "Data di acquisizione";
            // 
            // casellaModCopieDisponibili
            // 
            casellaModCopieDisponibili.Location = new Point(760, 178);
            casellaModCopieDisponibili.Name = "casellaModCopieDisponibili";
            casellaModCopieDisponibili.Size = new Size(306, 45);
            casellaModCopieDisponibili.TabIndex = 9;
            casellaModCopieDisponibili.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(743, 155);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 8;
            label6.Text = "Copie disponibili";
            // 
            // casellaModCodiceISBN
            // 
            casellaModCodiceISBN.Location = new Point(415, 178);
            casellaModCodiceISBN.Name = "casellaModCodiceISBN";
            casellaModCodiceISBN.Size = new Size(306, 45);
            casellaModCodiceISBN.TabIndex = 7;
            casellaModCodiceISBN.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 155);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Codice ISBN";
            // 
            // casellaModAnnoPubblicazione
            // 
            casellaModAnnoPubblicazione.Location = new Point(62, 178);
            casellaModAnnoPubblicazione.Name = "casellaModAnnoPubblicazione";
            casellaModAnnoPubblicazione.Size = new Size(306, 45);
            casellaModAnnoPubblicazione.TabIndex = 5;
            casellaModAnnoPubblicazione.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 155);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 4;
            label4.Text = "Anno di pubblicazione";
            // 
            // casellaModAutore
            // 
            casellaModAutore.Location = new Point(415, 76);
            casellaModAutore.Name = "casellaModAutore";
            casellaModAutore.Size = new Size(306, 45);
            casellaModAutore.TabIndex = 3;
            casellaModAutore.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 53);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Autore";
            // 
            // casellaModTitolo
            // 
            casellaModTitolo.Location = new Point(62, 76);
            casellaModTitolo.Name = "casellaModTitolo";
            casellaModTitolo.Size = new Size(306, 45);
            casellaModTitolo.TabIndex = 1;
            casellaModTitolo.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Titolo";
            // 
            // finestraModificaLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1731, 713);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "finestraModificaLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            FormClosed += finestraModificaLibro_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RichTextBox casellaModTitolo;
        private RichTextBox casellaModAnnoPubblicazione;
        private Label label4;
        private RichTextBox casellaModAutore;
        private Label label3;
        private RichTextBox casellaModCodiceISBN;
        private Label label5;
        private RichTextBox casellaModCopieDisponibili;
        private Label label6;
        private Label label7;
        private DateTimePicker modPresaDataAcquisizione;
        private ComboBox menuModListaGenere;
        private Label label8;
        private Button pulsanteModificaLibro;
        private ComboBox menuModListaStato;
        private Label label10;
        private ComboBox menuModListaCategoria;
        private Label label9;
    }
}