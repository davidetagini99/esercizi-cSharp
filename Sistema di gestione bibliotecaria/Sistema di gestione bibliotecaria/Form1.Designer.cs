namespace Sistema_di_gestione_bibliotecaria
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
            pulsanteSchermataAggiungiLibro = new Button();
            pulsanteSchermataModificaLibro = new Button();
            pulsanteSchermataCancellazioneLibro = new Button();
            etichettaOperazioniDisponibili = new Label();
            SuspendLayout();
            // 
            // pulsanteSchermataAggiungiLibro
            // 
            pulsanteSchermataAggiungiLibro.BackColor = Color.Coral;
            pulsanteSchermataAggiungiLibro.FlatAppearance.BorderSize = 0;
            pulsanteSchermataAggiungiLibro.FlatStyle = FlatStyle.Popup;
            pulsanteSchermataAggiungiLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteSchermataAggiungiLibro.ForeColor = Color.White;
            pulsanteSchermataAggiungiLibro.Location = new Point(24, 84);
            pulsanteSchermataAggiungiLibro.Name = "pulsanteSchermataAggiungiLibro";
            pulsanteSchermataAggiungiLibro.Size = new Size(425, 60);
            pulsanteSchermataAggiungiLibro.TabIndex = 1;
            pulsanteSchermataAggiungiLibro.Text = "Aggiungi un nuovo libro";
            pulsanteSchermataAggiungiLibro.UseVisualStyleBackColor = false;
            pulsanteSchermataAggiungiLibro.Click += btnAggiungiLibro_Click;
            // 
            // pulsanteSchermataModificaLibro
            // 
            pulsanteSchermataModificaLibro.BackColor = Color.Coral;
            pulsanteSchermataModificaLibro.FlatAppearance.BorderSize = 0;
            pulsanteSchermataModificaLibro.FlatStyle = FlatStyle.Popup;
            pulsanteSchermataModificaLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteSchermataModificaLibro.ForeColor = Color.White;
            pulsanteSchermataModificaLibro.Location = new Point(487, 84);
            pulsanteSchermataModificaLibro.Name = "pulsanteSchermataModificaLibro";
            pulsanteSchermataModificaLibro.Size = new Size(425, 60);
            pulsanteSchermataModificaLibro.TabIndex = 2;
            pulsanteSchermataModificaLibro.Text = "Modifica un libro esistente";
            pulsanteSchermataModificaLibro.UseVisualStyleBackColor = false;
            pulsanteSchermataModificaLibro.Click += pulsanteSchermataModificaLibro_Click;
            // 
            // pulsanteSchermataCancellazioneLibro
            // 
            pulsanteSchermataCancellazioneLibro.BackColor = Color.Coral;
            pulsanteSchermataCancellazioneLibro.FlatAppearance.BorderSize = 0;
            pulsanteSchermataCancellazioneLibro.FlatStyle = FlatStyle.Popup;
            pulsanteSchermataCancellazioneLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteSchermataCancellazioneLibro.ForeColor = Color.White;
            pulsanteSchermataCancellazioneLibro.Location = new Point(948, 84);
            pulsanteSchermataCancellazioneLibro.Name = "pulsanteSchermataCancellazioneLibro";
            pulsanteSchermataCancellazioneLibro.Size = new Size(425, 60);
            pulsanteSchermataCancellazioneLibro.TabIndex = 3;
            pulsanteSchermataCancellazioneLibro.Text = "Gestisci la cancellazione dei libri";
            pulsanteSchermataCancellazioneLibro.UseVisualStyleBackColor = false;
            // 
            // etichettaOperazioniDisponibili
            // 
            etichettaOperazioniDisponibili.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaOperazioniDisponibili.Location = new Point(24, 22);
            etichettaOperazioniDisponibili.Name = "etichettaOperazioniDisponibili";
            etichettaOperazioniDisponibili.Size = new Size(261, 37);
            etichettaOperazioniDisponibili.TabIndex = 0;
            etichettaOperazioniDisponibili.Text = "Operazioni disponibili";
            etichettaOperazioniDisponibili.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // finestraPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 553);
            Controls.Add(etichettaOperazioniDisponibili);
            Controls.Add(pulsanteSchermataCancellazioneLibro);
            Controls.Add(pulsanteSchermataModificaLibro);
            Controls.Add(pulsanteSchermataAggiungiLibro);
            Name = "finestraPrincipale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            Load += finestraPrincipale_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button pulsanteSchermataAggiungiLibro;
        private Button pulsanteSchermataModificaLibro;
        private Button pulsanteSchermataCancellazioneLibro;
        private Label etichettaOperazioniDisponibili;
    }
}