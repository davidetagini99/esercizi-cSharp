namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    partial class finestraAccessoCliente
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
            label3 = new Label();
            formAccesso = new GroupBox();
            etichettaSchermataRegistrazioneCliente = new Label();
            pulsanteAccedi = new Button();
            casellaPassword = new RichTextBox();
            label2 = new Label();
            casellaNomeUtente = new RichTextBox();
            label1 = new Label();
            formAccesso.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(603, 20);
            label3.TabIndex = 1;
            label3.Text = "Inserisci i tuoi dati personali per accedere alla tua area cliente";
            // 
            // formAccesso
            // 
            formAccesso.BackColor = Color.Silver;
            formAccesso.Controls.Add(etichettaSchermataRegistrazioneCliente);
            formAccesso.Controls.Add(pulsanteAccedi);
            formAccesso.Controls.Add(casellaPassword);
            formAccesso.Controls.Add(label2);
            formAccesso.Controls.Add(casellaNomeUtente);
            formAccesso.Controls.Add(label1);
            formAccesso.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            formAccesso.Location = new Point(12, 46);
            formAccesso.Name = "formAccesso";
            formAccesso.Size = new Size(711, 535);
            formAccesso.TabIndex = 2;
            formAccesso.TabStop = false;
            formAccesso.Text = "Form di accesso";
            // 
            // etichettaSchermataRegistrazioneCliente
            // 
            etichettaSchermataRegistrazioneCliente.Cursor = Cursors.Hand;
            etichettaSchermataRegistrazioneCliente.Font = new Font("Cascadia Mono Light", 13F, FontStyle.Bold, GraphicsUnit.Point);
            etichettaSchermataRegistrazioneCliente.ForeColor = Color.Red;
            etichettaSchermataRegistrazioneCliente.Location = new Point(17, 42);
            etichettaSchermataRegistrazioneCliente.Name = "etichettaSchermataRegistrazioneCliente";
            etichettaSchermataRegistrazioneCliente.Size = new Size(586, 53);
            etichettaSchermataRegistrazioneCliente.TabIndex = 5;
            etichettaSchermataRegistrazioneCliente.Text = "Clicca qui se vuoi registrarti";
            etichettaSchermataRegistrazioneCliente.TextAlign = ContentAlignment.MiddleLeft;
            etichettaSchermataRegistrazioneCliente.Click += etichettaSchermataRegistrazioneCliente_Click;
            // 
            // pulsanteAccedi
            // 
            pulsanteAccedi.BackColor = Color.DodgerBlue;
            pulsanteAccedi.FlatAppearance.BorderColor = Color.Black;
            pulsanteAccedi.FlatAppearance.BorderSize = 2;
            pulsanteAccedi.FlatStyle = FlatStyle.Flat;
            pulsanteAccedi.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pulsanteAccedi.ForeColor = Color.White;
            pulsanteAccedi.Location = new Point(53, 295);
            pulsanteAccedi.Name = "pulsanteAccedi";
            pulsanteAccedi.Size = new Size(395, 65);
            pulsanteAccedi.TabIndex = 4;
            pulsanteAccedi.Text = "Accedi";
            pulsanteAccedi.UseVisualStyleBackColor = false;
            pulsanteAccedi.Click += pulsanteAccedi_Click;
            // 
            // casellaPassword
            // 
            casellaPassword.Location = new Point(53, 222);
            casellaPassword.Name = "casellaPassword";
            casellaPassword.Size = new Size(326, 45);
            casellaPassword.TabIndex = 3;
            casellaPassword.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 199);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // casellaNomeUtente
            // 
            casellaNomeUtente.Location = new Point(53, 137);
            casellaNomeUtente.Name = "casellaNomeUtente";
            casellaNomeUtente.Size = new Size(326, 45);
            casellaNomeUtente.TabIndex = 1;
            casellaNomeUtente.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 114);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome utente";
            // 
            // finestraAccessoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1592, 698);
            Controls.Add(formAccesso);
            Controls.Add(label3);
            Name = "finestraAccessoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            FormClosed += finestraAccessoCliente_FormClosed;
            formAccesso.ResumeLayout(false);
            formAccesso.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private GroupBox formAccesso;
        private RichTextBox casellaNomeUtente;
        private Label label1;
        private RichTextBox casellaPassword;
        private Label label2;
        private Button pulsanteAccedi;
        private Label etichettaSchermataRegistrazioneCliente;
    }
}