namespace AutoVermietung
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AutoManagerbtn = new Button();
            KundenManagerbtn = new Button();
            Vermietungbtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AutoManagerbtn
            // 
            AutoManagerbtn.Location = new Point(12, 116);
            AutoManagerbtn.Name = "AutoManagerbtn";
            AutoManagerbtn.Size = new Size(99, 31);
            AutoManagerbtn.TabIndex = 0;
            AutoManagerbtn.Text = "Auto Manager";
            AutoManagerbtn.UseVisualStyleBackColor = true;
            AutoManagerbtn.Click += AutoManagerbtn_Click;
            // 
            // KundenManagerbtn
            // 
            KundenManagerbtn.Location = new Point(12, 153);
            KundenManagerbtn.Name = "KundenManagerbtn";
            KundenManagerbtn.Size = new Size(99, 30);
            KundenManagerbtn.TabIndex = 1;
            KundenManagerbtn.Text = "Kunden Manager";
            KundenManagerbtn.UseVisualStyleBackColor = true;
            KundenManagerbtn.Click += KundenManagerbtn_Click;
            // 
            // Vermietungbtn
            // 
            Vermietungbtn.Location = new Point(12, 207);
            Vermietungbtn.Name = "Vermietungbtn";
            Vermietungbtn.Size = new Size(99, 29);
            Vermietungbtn.TabIndex = 2;
            Vermietungbtn.Text = "Vermietung";
            Vermietungbtn.UseVisualStyleBackColor = true;
            Vermietungbtn.Click += Vermietungbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(30, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 63);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 273);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "also search us on ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(115, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 45);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(124, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 131);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(252, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "Menü";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(50, 20);
            menüToolStripMenuItem.Text = "Menü";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(252, 297);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Vermietungbtn);
            Controls.Add(KundenManagerbtn);
            Controls.Add(AutoManagerbtn);
            Controls.Add(menuStrip1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Auto Vermietung";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AutoManagerbtn;
        private Button KundenManagerbtn;
        private Button Vermietungbtn;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}