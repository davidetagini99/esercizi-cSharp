namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    partial class finestraRegistrazioneCliente
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
            etichettaIstruzioniRegistrazioneCliente = new Label();
            formRegistrazioneCliente = new GroupBox();
            pulsanteRegistrati = new Button();
            casellaConfermaPassword = new RichTextBox();
            etichettaConfermaPassword = new Label();
            casellaPassword = new RichTextBox();
            etichettaPassword = new Label();
            controlloSessoFemmina = new RadioButton();
            controlloSessoMaschio = new RadioButton();
            etichettaSesso = new Label();
            presaDataNascita = new DateTimePicker();
            etichettaPresaDataNascita = new Label();
            casellaIndirizzoEmail = new RichTextBox();
            etichettaIndirizzoEmail = new Label();
            casellaCognome = new RichTextBox();
            etichettaCognome = new Label();
            casellaNome = new RichTextBox();
            etichettaNome = new Label();
            formRegistrazioneCliente.SuspendLayout();
            SuspendLayout();
            // 
            // etichettaIstruzioniRegistrazioneCliente
            // 
            etichettaIstruzioniRegistrazioneCliente.Font = new Font("Cascadia Mono Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            etichettaIstruzioniRegistrazioneCliente.Location = new Point(12, 18);
            etichettaIstruzioniRegistrazioneCliente.Name = "etichettaIstruzioniRegistrazioneCliente";
            etichettaIstruzioniRegistrazioneCliente.Size = new Size(582, 48);
            etichettaIstruzioniRegistrazioneCliente.TabIndex = 0;
            etichettaIstruzioniRegistrazioneCliente.Text = "Compila tutti i campi per registrarti come cliente fisso";
            etichettaIstruzioniRegistrazioneCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formRegistrazioneCliente
            // 
            formRegistrazioneCliente.BackColor = Color.Silver;
            formRegistrazioneCliente.Controls.Add(pulsanteRegistrati);
            formRegistrazioneCliente.Controls.Add(casellaConfermaPassword);
            formRegistrazioneCliente.Controls.Add(etichettaConfermaPassword);
            formRegistrazioneCliente.Controls.Add(casellaPassword);
            formRegistrazioneCliente.Controls.Add(etichettaPassword);
            formRegistrazioneCliente.Controls.Add(controlloSessoFemmina);
            formRegistrazioneCliente.Controls.Add(controlloSessoMaschio);
            formRegistrazioneCliente.Controls.Add(etichettaSesso);
            formRegistrazioneCliente.Controls.Add(presaDataNascita);
            formRegistrazioneCliente.Controls.Add(etichettaPresaDataNascita);
            formRegistrazioneCliente.Controls.Add(casellaIndirizzoEmail);
            formRegistrazioneCliente.Controls.Add(etichettaIndirizzoEmail);
            formRegistrazioneCliente.Controls.Add(casellaCognome);
            formRegistrazioneCliente.Controls.Add(etichettaCognome);
            formRegistrazioneCliente.Controls.Add(casellaNome);
            formRegistrazioneCliente.Controls.Add(etichettaNome);
            formRegistrazioneCliente.FlatStyle = FlatStyle.Flat;
            formRegistrazioneCliente.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            formRegistrazioneCliente.ForeColor = Color.Black;
            formRegistrazioneCliente.Location = new Point(12, 79);
            formRegistrazioneCliente.Name = "formRegistrazioneCliente";
            formRegistrazioneCliente.Size = new Size(1175, 677);
            formRegistrazioneCliente.TabIndex = 1;
            formRegistrazioneCliente.TabStop = false;
            formRegistrazioneCliente.Text = "Form di registrazione";
            // 
            // pulsanteRegistrati
            // 
            pulsanteRegistrati.BackColor = Color.DodgerBlue;
            pulsanteRegistrati.Cursor = Cursors.Hand;
            pulsanteRegistrati.FlatAppearance.BorderColor = Color.Black;
            pulsanteRegistrati.FlatAppearance.BorderSize = 2;
            pulsanteRegistrati.FlatStyle = FlatStyle.Flat;
            pulsanteRegistrati.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteRegistrati.ForeColor = Color.White;
            pulsanteRegistrati.Location = new Point(53, 436);
            pulsanteRegistrati.Name = "pulsanteRegistrati";
            pulsanteRegistrati.Size = new Size(474, 72);
            pulsanteRegistrati.TabIndex = 15;
            pulsanteRegistrati.Text = "Registrati";
            pulsanteRegistrati.UseVisualStyleBackColor = false;
            pulsanteRegistrati.Click += pulsanteRegistrati_Click;
            // 
            // casellaConfermaPassword
            // 
            casellaConfermaPassword.Location = new Point(455, 332);
            casellaConfermaPassword.Name = "casellaConfermaPassword";
            casellaConfermaPassword.Size = new Size(353, 38);
            casellaConfermaPassword.TabIndex = 14;
            casellaConfermaPassword.Text = "";
            // 
            // etichettaConfermaPassword
            // 
            etichettaConfermaPassword.AutoSize = true;
            etichettaConfermaPassword.Location = new Point(444, 309);
            etichettaConfermaPassword.Name = "etichettaConfermaPassword";
            etichettaConfermaPassword.Size = new Size(162, 20);
            etichettaConfermaPassword.TabIndex = 13;
            etichettaConfermaPassword.Text = "Conferma password";
            // 
            // casellaPassword
            // 
            casellaPassword.Location = new Point(64, 332);
            casellaPassword.Name = "casellaPassword";
            casellaPassword.Size = new Size(353, 38);
            casellaPassword.TabIndex = 12;
            casellaPassword.Text = "";
            // 
            // etichettaPassword
            // 
            etichettaPassword.AutoSize = true;
            etichettaPassword.Location = new Point(53, 309);
            etichettaPassword.Name = "etichettaPassword";
            etichettaPassword.Size = new Size(81, 20);
            etichettaPassword.TabIndex = 11;
            etichettaPassword.Text = "Password";
            // 
            // controlloSessoFemmina
            // 
            controlloSessoFemmina.AutoSize = true;
            controlloSessoFemmina.Location = new Point(172, 264);
            controlloSessoFemmina.Name = "controlloSessoFemmina";
            controlloSessoFemmina.Size = new Size(93, 24);
            controlloSessoFemmina.TabIndex = 10;
            controlloSessoFemmina.TabStop = true;
            controlloSessoFemmina.Text = "Femmina";
            controlloSessoFemmina.UseVisualStyleBackColor = true;
            // 
            // controlloSessoMaschio
            // 
            controlloSessoMaschio.AutoSize = true;
            controlloSessoMaschio.Location = new Point(64, 264);
            controlloSessoMaschio.Name = "controlloSessoMaschio";
            controlloSessoMaschio.Size = new Size(93, 24);
            controlloSessoMaschio.TabIndex = 9;
            controlloSessoMaschio.TabStop = true;
            controlloSessoMaschio.Text = "Maschio";
            controlloSessoMaschio.UseVisualStyleBackColor = true;
            // 
            // etichettaSesso
            // 
            etichettaSesso.AutoSize = true;
            etichettaSesso.Location = new Point(53, 241);
            etichettaSesso.Name = "etichettaSesso";
            etichettaSesso.Size = new Size(54, 20);
            etichettaSesso.TabIndex = 8;
            etichettaSesso.Text = "Sesso";
            // 
            // presaDataNascita
            // 
            presaDataNascita.Location = new Point(455, 169);
            presaDataNascita.Name = "presaDataNascita";
            presaDataNascita.Size = new Size(353, 25);
            presaDataNascita.TabIndex = 7;
            // 
            // etichettaPresaDataNascita
            // 
            etichettaPresaDataNascita.AutoSize = true;
            etichettaPresaDataNascita.Location = new Point(444, 146);
            etichettaPresaDataNascita.Name = "etichettaPresaDataNascita";
            etichettaPresaDataNascita.Size = new Size(144, 20);
            etichettaPresaDataNascita.TabIndex = 6;
            etichettaPresaDataNascita.Text = "Data di nascita";
            // 
            // casellaIndirizzoEmail
            // 
            casellaIndirizzoEmail.Location = new Point(64, 169);
            casellaIndirizzoEmail.Name = "casellaIndirizzoEmail";
            casellaIndirizzoEmail.Size = new Size(353, 38);
            casellaIndirizzoEmail.TabIndex = 5;
            casellaIndirizzoEmail.Text = "";
            // 
            // etichettaIndirizzoEmail
            // 
            etichettaIndirizzoEmail.AutoSize = true;
            etichettaIndirizzoEmail.Location = new Point(53, 146);
            etichettaIndirizzoEmail.Name = "etichettaIndirizzoEmail";
            etichettaIndirizzoEmail.Size = new Size(144, 20);
            etichettaIndirizzoEmail.TabIndex = 4;
            etichettaIndirizzoEmail.Text = "Indirizzo email";
            // 
            // casellaCognome
            // 
            casellaCognome.Location = new Point(455, 82);
            casellaCognome.Name = "casellaCognome";
            casellaCognome.Size = new Size(353, 38);
            casellaCognome.TabIndex = 3;
            casellaCognome.Text = "";
            // 
            // etichettaCognome
            // 
            etichettaCognome.AutoSize = true;
            etichettaCognome.Location = new Point(444, 59);
            etichettaCognome.Name = "etichettaCognome";
            etichettaCognome.Size = new Size(72, 20);
            etichettaCognome.TabIndex = 2;
            etichettaCognome.Text = "Cognome";
            // 
            // casellaNome
            // 
            casellaNome.Location = new Point(64, 82);
            casellaNome.Name = "casellaNome";
            casellaNome.Size = new Size(353, 38);
            casellaNome.TabIndex = 1;
            casellaNome.Text = "";
            // 
            // etichettaNome
            // 
            etichettaNome.AutoSize = true;
            etichettaNome.Location = new Point(53, 59);
            etichettaNome.Name = "etichettaNome";
            etichettaNome.Size = new Size(45, 20);
            etichettaNome.TabIndex = 0;
            etichettaNome.Text = "Nome";
            // 
            // finestraRegistrazioneCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 858);
            Controls.Add(formRegistrazioneCliente);
            Controls.Add(etichettaIstruzioniRegistrazioneCliente);
            Name = "finestraRegistrazioneCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            FormClosed += finestraRegistrazioneCliente_FormClosed;
            Load += finestraRegistrazioneCliente_Load;
            formRegistrazioneCliente.ResumeLayout(false);
            formRegistrazioneCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label etichettaIstruzioniRegistrazioneCliente;
        private GroupBox formRegistrazioneCliente;
        private Label etichettaNome;
        private RichTextBox casellaNome;
        private RichTextBox casellaCognome;
        private Label etichettaCognome;
        private RichTextBox casellaIndirizzoEmail;
        private Label etichettaIndirizzoEmail;
        private DateTimePicker presaDataNascita;
        private Label etichettaPresaDataNascita;
        private RadioButton controlloSessoFemmina;
        private RadioButton controlloSessoMaschio;
        private Label etichettaSesso;
        private RichTextBox casellaPassword;
        private Label etichettaPassword;
        private RichTextBox casellaConfermaPassword;
        private Label etichettaConfermaPassword;
        private Button pulsanteRegistrati;
    }
}