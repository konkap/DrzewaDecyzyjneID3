namespace SysUczace
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usun1kolumneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzewoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budujDrzewoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rysujDrzewoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infAtrubutuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zyskAtrubutuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ekranRTB = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.konsolaTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daneToolStripMenuItem,
            this.drzewoToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybierzPlikToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.pokazToolStripMenuItem,
            this.usun1kolumneToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // wybierzPlikToolStripMenuItem
            // 
            this.wybierzPlikToolStripMenuItem.Name = "wybierzPlikToolStripMenuItem";
            this.wybierzPlikToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wybierzPlikToolStripMenuItem.Text = "Wybierz plik";
            this.wybierzPlikToolStripMenuItem.Click += new System.EventHandler(this.wybierzPlikToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj dane";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click_1);
            // 
            // pokazToolStripMenuItem
            // 
            this.pokazToolStripMenuItem.Name = "pokazToolStripMenuItem";
            this.pokazToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pokazToolStripMenuItem.Text = "Pokaż dane";
            this.pokazToolStripMenuItem.Click += new System.EventHandler(this.wyswietlToolStripMenuItem_Click);
            // 
            // usun1kolumneToolStripMenuItem
            // 
            this.usun1kolumneToolStripMenuItem.CheckOnClick = true;
            this.usun1kolumneToolStripMenuItem.Name = "usun1kolumneToolStripMenuItem";
            this.usun1kolumneToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.usun1kolumneToolStripMenuItem.Text = "Usun 1 kolumnę";
            this.usun1kolumneToolStripMenuItem.CheckedChanged += new System.EventHandler(this.usun1kolumneToolStripMenuItem_CheckedChanged);
            // 
            // drzewoToolStripMenuItem
            // 
            this.drzewoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budujDrzewoToolStripMenuItem,
            this.rysujDrzewoToolStripMenuItem});
            this.drzewoToolStripMenuItem.Name = "drzewoToolStripMenuItem";
            this.drzewoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.drzewoToolStripMenuItem.Text = "Drzewo";
            // 
            // budujDrzewoToolStripMenuItem
            // 
            this.budujDrzewoToolStripMenuItem.Name = "budujDrzewoToolStripMenuItem";
            this.budujDrzewoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.budujDrzewoToolStripMenuItem.Text = "Buduj drzewo";
            this.budujDrzewoToolStripMenuItem.Click += new System.EventHandler(this.budujDrzewoToolStripMenuItem_Click);
            // 
            // rysujDrzewoToolStripMenuItem
            // 
            this.rysujDrzewoToolStripMenuItem.Name = "rysujDrzewoToolStripMenuItem";
            this.rysujDrzewoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rysujDrzewoToolStripMenuItem.Text = "Rysuj drzewo";
            this.rysujDrzewoToolStripMenuItem.Click += new System.EventHandler(this.rysujDrzewoToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // eRPToolStripMenuItem
            // 
            this.eRPToolStripMenuItem.Name = "eRPToolStripMenuItem";
            this.eRPToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // infAtrubutuToolStripMenuItem
            // 
            this.infAtrubutuToolStripMenuItem.Name = "infAtrubutuToolStripMenuItem";
            this.infAtrubutuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // zyskAtrubutuToolStripMenuItem
            // 
            this.zyskAtrubutuToolStripMenuItem.Name = "zyskAtrubutuToolStripMenuItem";
            this.zyskAtrubutuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ekranRTB
            // 
            this.ekranRTB.Location = new System.Drawing.Point(12, 27);
            this.ekranRTB.Name = "ekranRTB";
            this.ekranRTB.ReadOnly = true;
            this.ekranRTB.Size = new System.Drawing.Size(268, 227);
            this.ekranRTB.TabIndex = 1;
            this.ekranRTB.Text = "Wybierz plik";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "Nie wybrano pliku";
            // 
            // konsolaTB
            // 
            this.konsolaTB.Location = new System.Drawing.Point(12, 260);
            this.konsolaTB.Name = "konsolaTB";
            this.konsolaTB.Size = new System.Drawing.Size(268, 20);
            this.konsolaTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 305);
            this.Controls.Add(this.konsolaTB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ekranRTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SysUczące";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox ekranRTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usun1kolumneToolStripMenuItem;
        private System.Windows.Forms.TextBox konsolaTB;
        private System.Windows.Forms.ToolStripMenuItem pokazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infAtrubutuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zyskAtrubutuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybierzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzewoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budujDrzewoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rysujDrzewoToolStripMenuItem;
    }
}

