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
            lvKunden = new ListView();
            KundenNr = new ColumnHeader();
            Vorname = new ColumnHeader();
            Nachname = new ColumnHeader();
            Adresse = new ColumnHeader();
            KundeSeit = new ColumnHeader();
            SuspendLayout();
            // 
            // lvKunden
            // 
            lvKunden.Columns.AddRange(new ColumnHeader[] { KundenNr, Vorname, Nachname, Adresse, KundeSeit });
            lvKunden.Location = new Point(12, 12);
            lvKunden.Name = "lvKunden";
            lvKunden.Size = new Size(300, 426);
            lvKunden.TabIndex = 0;
            lvKunden.UseCompatibleStateImageBehavior = false;
            // 
            // KundenManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvKunden);
            Name = "KundenManager";
            Text = "KundenManager";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvKunden;
        private ColumnHeader KundenNr;
        private ColumnHeader Vorname;
        private ColumnHeader Nachname;
        private ColumnHeader Adresse;
        private ColumnHeader KundeSeit;
    }
}