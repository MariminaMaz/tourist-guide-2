namespace TouristGuide.WinForms
{
    partial class BaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ιστορικόToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εκκαθάρισηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αποθήκευσηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχείοToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ιστορικόToolStripMenuItem});
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            this.αρχείοToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // ιστορικόToolStripMenuItem
            // 
            this.ιστορικόToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εκκαθάρισηToolStripMenuItem,
            this.αποθήκευσηToolStripMenuItem});
            this.ιστορικόToolStripMenuItem.Name = "ιστορικόToolStripMenuItem";
            this.ιστορικόToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ιστορικόToolStripMenuItem.Text = "Ιστορικό ";
            // 
            // εκκαθάρισηToolStripMenuItem
            // 
            this.εκκαθάρισηToolStripMenuItem.Name = "εκκαθάρισηToolStripMenuItem";
            this.εκκαθάρισηToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.εκκαθάρισηToolStripMenuItem.Text = "Εκκαθάριση";
            // 
            // αποθήκευσηToolStripMenuItem
            // 
            this.αποθήκευσηToolStripMenuItem.Name = "αποθήκευσηToolStripMenuItem";
            this.αποθήκευσηToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.αποθήκευσηToolStripMenuItem.Text = "Αποθήκευση";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpInstructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpInstructionsToolStripMenuItem
            // 
            this.helpInstructionsToolStripMenuItem.Name = "helpInstructionsToolStripMenuItem";
            this.helpInstructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpInstructionsToolStripMenuItem.Text = "Οδηγίες";
            this.helpInstructionsToolStripMenuItem.Click += new System.EventHandler(this.helpInstructionsToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "Base Form";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ιστορικόToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εκκαθάρισηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αποθήκευσηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpInstructionsToolStripMenuItem;
    }
}

