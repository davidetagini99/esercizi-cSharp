namespace Nuovo_sistema_di_gestione_bibliotecaria
{
    partial class finestraConfermaRegistrazioneCliente
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(489, 9);
            label1.Name = "label1";
            label1.Size = new Size(732, 69);
            label1.TabIndex = 0;
            label1.Text = "Inserisci il codice OTP per confermare la registrazione";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(618, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(487, 51);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(562, 196);
            button1.Name = "button1";
            button1.Size = new Size(633, 73);
            button1.TabIndex = 2;
            button1.Text = "Conferma account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // finestraConfermaRegistrazioneCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 707);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "finestraConfermaRegistrazioneCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Software di gestione bibliotecaria";
            WindowState = FormWindowState.Maximized;
            Load += finestraConfermaRegistrazioneCliente_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}