namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    partial class finestraPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pulsanteSchermataAreaCliente = new Button();
            etichettaTitoloPaginaPrincipale = new Label();
            pulsanteSchermataAggiungiLibro = new Button();
            etichettaIstruzioneModificaLibro = new Label();
            listaLibriInseriti = new ListBox();
            SuspendLayout();
            // 
            // pulsanteSchermataAreaCliente
            // 
            pulsanteSchermataAreaCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pulsanteSchermataAreaCliente.BackColor = Color.DodgerBlue;
            pulsanteSchermataAreaCliente.Cursor = Cursors.Hand;
            pulsanteSchermataAreaCliente.FlatAppearance.BorderColor = Color.Black;
            pulsanteSchermataAreaCliente.FlatAppearance.BorderSize = 2;
            pulsanteSchermataAreaCliente.FlatStyle = FlatStyle.Flat;
            pulsanteSchermataAreaCliente.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteSchermataAreaCliente.ForeColor = Color.White;
            pulsanteSchermataAreaCliente.Location = new Point(1220, 12);
            pulsanteSchermataAreaCliente.Name = "pulsanteSchermataAreaCliente";
            pulsanteSchermataAreaCliente.Size = new Size(349, 73);
            pulsanteSchermataAreaCliente.TabIndex = 3;
            pulsanteSchermataAreaCliente.Text = "Area cliente";
            pulsanteSchermataAreaCliente.UseVisualStyleBackColor = false;
            pulsanteSchermataAreaCliente.Click += pulsanteSchermataAreaCliente_Click;
            // 
            // etichettaTitoloPaginaPrincipale
            // 
            etichettaTitoloPaginaPrincipale.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaTitoloPaginaPrincipale.ForeColor = Color.Black;
            etichettaTitoloPaginaPrincipale.Location = new Point(12, 1);
            etichettaTitoloPaginaPrincipale.Name = "etichettaTitoloPaginaPrincipale";
            etichettaTitoloPaginaPrincipale.Size = new Size(257, 73);
            etichettaTitoloPaginaPrincipale.TabIndex = 1;
            etichettaTitoloPaginaPrincipale.Text = "Pagina principale";
            etichettaTitoloPaginaPrincipale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pulsanteSchermataAggiungiLibro
            // 
            pulsanteSchermataAggiungiLibro.BackColor = Color.DodgerBlue;
            pulsanteSchermataAggiungiLibro.Cursor = Cursors.Hand;
            pulsanteSchermataAggiungiLibro.FlatAppearance.BorderColor = Color.Black;
            pulsanteSchermataAggiungiLibro.FlatAppearance.BorderSize = 2;
            pulsanteSchermataAggiungiLibro.FlatStyle = FlatStyle.Flat;
            pulsanteSchermataAggiungiLibro.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteSchermataAggiungiLibro.ForeColor = Color.White;
            pulsanteSchermataAggiungiLibro.Location = new Point(66, 77);
            pulsanteSchermataAggiungiLibro.Name = "pulsanteSchermataAggiungiLibro";
            pulsanteSchermataAggiungiLibro.Size = new Size(349, 73);
            pulsanteSchermataAggiungiLibro.TabIndex = 2;
            pulsanteSchermataAggiungiLibro.Text = "Aggiungi un libro";
            pulsanteSchermataAggiungiLibro.UseVisualStyleBackColor = false;
            pulsanteSchermataAggiungiLibro.Click += pulsanteSchermataAggiungiLibro_Click;
            // 
            // etichettaIstruzioneModificaLibro
            // 
            etichettaIstruzioneModificaLibro.Font = new Font("Cascadia Mono Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaIstruzioneModificaLibro.ForeColor = Color.Black;
            etichettaIstruzioneModificaLibro.Location = new Point(12, 208);
            etichettaIstruzioneModificaLibro.Name = "etichettaIstruzioneModificaLibro";
            etichettaIstruzioneModificaLibro.Size = new Size(592, 73);
            etichettaIstruzioneModificaLibro.TabIndex = 4;
            etichettaIstruzioneModificaLibro.Text = "Clicca su uno dei libri presenti in lista per modificarlo";
            etichettaIstruzioneModificaLibro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listaLibriInseriti
            // 
            listaLibriInseriti.BackColor = Color.Silver;
            listaLibriInseriti.BorderStyle = BorderStyle.FixedSingle;
            listaLibriInseriti.Font = new Font("Cascadia Mono Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listaLibriInseriti.ForeColor = Color.Black;
            listaLibriInseriti.FormattingEnabled = true;
            listaLibriInseriti.ItemHeight = 22;
            listaLibriInseriti.Location = new Point(66, 284);
            listaLibriInseriti.Name = "listaLibriInseriti";
            listaLibriInseriti.Size = new Size(891, 508);
            listaLibriInseriti.TabIndex = 5;
            listaLibriInseriti.SelectedIndexChanged += listaLibriInseriti_SelectedIndexChanged;
            // 
            // finestraPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1581, 823);
            Controls.Add(listaLibriInseriti);
            Controls.Add(etichettaIstruzioneModificaLibro);
            Controls.Add(pulsanteSchermataAggiungiLibro);
            Controls.Add(etichettaTitoloPaginaPrincipale);
            Controls.Add(pulsanteSchermataAreaCliente);
            Name = "finestraPrincipale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            Load += finestraPrincipale_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button pulsanteSchermataAreaCliente;
        private Label etichettaTitoloPaginaPrincipale;
        private Button pulsanteSchermataAggiungiLibro;
        private Label etichettaIstruzioneModificaLibro;
        private ListBox listaLibriInseriti;
    }
}