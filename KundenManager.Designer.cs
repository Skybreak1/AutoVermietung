namespace AutoVermietung
{
    partial class KundenManager
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
            lbKunden = new ListBox();
            tbxVorname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxNachname = new TextBox();
            label3 = new Label();
            tbxAdresse = new TextBox();
            label4 = new Label();
            tbxKundenNr = new TextBox();
            label5 = new Label();
            tbxKundeSeit = new TextBox();
            SuspendLayout();
            // 
            // lbKunden
            // 
            lbKunden.FormattingEnabled = true;
            lbKunden.ItemHeight = 15;
            lbKunden.Location = new Point(12, 12);
            lbKunden.Name = "lbKunden";
            lbKunden.Size = new Size(288, 409);
            lbKunden.TabIndex = 0;
            lbKunden.SelectedIndexChanged += lbKunden_SelectedIndexChanged;
            // 
            // tbxVorname
            // 
            tbxVorname.Location = new Point(354, 173);
            tbxVorname.Name = "tbxVorname";
            tbxVorname.Size = new Size(100, 23);
            tbxVorname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 155);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 155);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Nachname";
            // 
            // tbxNachname
            // 
            tbxNachname.Location = new Point(474, 173);
            tbxNachname.Name = "tbxNachname";
            tbxNachname.Size = new Size(100, 23);
            tbxNachname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 210);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Adresse";
            // 
            // tbxAdresse
            // 
            tbxAdresse.Location = new Point(356, 228);
            tbxAdresse.Multiline = true;
            tbxAdresse.Name = "tbxAdresse";
            tbxAdresse.Size = new Size(218, 69);
            tbxAdresse.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 101);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 9;
            label4.Text = "Kunden-Nr.";
            // 
            // tbxKundenNr
            // 
            tbxKundenNr.Location = new Point(354, 119);
            tbxKundenNr.Name = "tbxKundenNr";
            tbxKundenNr.Size = new Size(100, 23);
            tbxKundenNr.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 101);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 11;
            label5.Text = "Kunde Seit";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // tbxKundeSeit
            // 
            tbxKundeSeit.Location = new Point(474, 119);
            tbxKundeSeit.Name = "tbxKundeSeit";
            tbxKundeSeit.Size = new Size(100, 23);
            tbxKundeSeit.TabIndex = 10;
            // 
            // KundenManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(label5);
            Controls.Add(tbxKundeSeit);
            Controls.Add(label4);
            Controls.Add(tbxKundenNr);
            Controls.Add(tbxAdresse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxNachname);
            Controls.Add(label1);
            Controls.Add(tbxVorname);
            Controls.Add(lbKunden);
            Name = "KundenManager";
            Text = "KundenManager";
            Load += KundenManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbKunden;
        private TextBox tbxVorname;
        private Label label1;
        private Label label2;
        private TextBox tbxNachname;
        private Label label3;
        private TextBox tbxAdresse;
        private Label label4;
        private TextBox tbxKundenNr;
        private Label label5;
        private TextBox tbxKundeSeit;
    }
}