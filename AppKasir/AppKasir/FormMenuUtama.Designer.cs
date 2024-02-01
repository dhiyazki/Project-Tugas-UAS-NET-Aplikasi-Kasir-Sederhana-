namespace AppKasir
{
    partial class FormMenuUtama
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
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            kasirToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(180, 22);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(180, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(180, 22);
            menuExit.Text = "Exit";
            menuExit.Click += exitToolStripMenuItem_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { kasirToolStripMenuItem, barangToolStripMenuItem });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(55, 20);
            menuMaster.Text = "Master";
            // 
            // kasirToolStripMenuItem
            // 
            kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            kasirToolStripMenuItem.Size = new Size(111, 22);
            kasirToolStripMenuItem.Text = "Kasir";
            kasirToolStripMenuItem.Click += kasirToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(111, 22);
            barangToolStripMenuItem.Text = "Barang";
            barangToolStripMenuItem.Click += barangToolStripMenuItem_Click;
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            Text = "FormMenuUtama";
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
    }
}