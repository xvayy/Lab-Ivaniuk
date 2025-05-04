namespace Lab_Ivaniuk
{
    partial class myBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myBD));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openTableTerytoria = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableBiocenologia = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableVzeni = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableRoslyny = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableTvaryny = new System.Windows.Forms.ToolStripMenuItem();
            this.територіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTableTerytoria,
            this.адмініструванняToolStripMenuItem,
            this.калькуляторToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openTableTerytoria
            // 
            this.openTableTerytoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTableBiocenologia,
            this.openTableVzeni,
            this.openTableRoslyny,
            this.openTableTvaryny,
            this.територіяToolStripMenuItem});
            this.openTableTerytoria.Name = "openTableTerytoria";
            this.openTableTerytoria.Size = new System.Drawing.Size(81, 20);
            this.openTableTerytoria.Text = "Таблиці БД";
            // 
            // openTableBiocenologia
            // 
            this.openTableBiocenologia.Image = ((System.Drawing.Image)(resources.GetObject("openTableBiocenologia.Image")));
            this.openTableBiocenologia.Name = "openTableBiocenologia";
            this.openTableBiocenologia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.openTableBiocenologia.Size = new System.Drawing.Size(186, 22);
            this.openTableBiocenologia.Text = "Біоценологія";
            this.openTableBiocenologia.Click += new System.EventHandler(this.openTableBiocenologia_Click);
            // 
            // openTableVzeni
            // 
            this.openTableVzeni.Image = ((System.Drawing.Image)(resources.GetObject("openTableVzeni.Image")));
            this.openTableVzeni.Name = "openTableVzeni";
            this.openTableVzeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.openTableVzeni.Size = new System.Drawing.Size(186, 22);
            this.openTableVzeni.Text = "Вчені";
            this.openTableVzeni.Click += new System.EventHandler(this.openTableVzeni_Click);
            // 
            // openTableRoslyny
            // 
            this.openTableRoslyny.Image = ((System.Drawing.Image)(resources.GetObject("openTableRoslyny.Image")));
            this.openTableRoslyny.Name = "openTableRoslyny";
            this.openTableRoslyny.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.openTableRoslyny.Size = new System.Drawing.Size(186, 22);
            this.openTableRoslyny.Text = "Рослини";
            // 
            // openTableTvaryny
            // 
            this.openTableTvaryny.Image = ((System.Drawing.Image)(resources.GetObject("openTableTvaryny.Image")));
            this.openTableTvaryny.Name = "openTableTvaryny";
            this.openTableTvaryny.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.openTableTvaryny.Size = new System.Drawing.Size(186, 22);
            this.openTableTvaryny.Text = "Тварини";
            // 
            // територіяToolStripMenuItem
            // 
            this.територіяToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("територіяToolStripMenuItem.Image")));
            this.територіяToolStripMenuItem.Name = "територіяToolStripMenuItem";
            this.територіяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.територіяToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.територіяToolStripMenuItem.Text = "Територія";
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // myBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "myBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Біоценологія";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myBD_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openTableTerytoria;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTableBiocenologia;
        private System.Windows.Forms.ToolStripMenuItem openTableVzeni;
        private System.Windows.Forms.ToolStripMenuItem openTableRoslyny;
        private System.Windows.Forms.ToolStripMenuItem openTableTvaryny;
        private System.Windows.Forms.ToolStripMenuItem територіяToolStripMenuItem;
    }
}

