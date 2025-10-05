namespace TouristGuide.WinForms
{
    partial class MainForm :BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_History = new System.Windows.Forms.Button();
            this.button_beaches = new System.Windows.Forms.Button();
            this.button_attractions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 83);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Καλώς ήρθατε στον τουριστικό οδηγό για το Περού. Παρακάτω θα βρείτε περισσότερες " +
    "πληροφορίες σχετικά με τις παραλίες και τα αξιοθέατα.";
            // 
            // button_History
            // 
            this.button_History.Location = new System.Drawing.Point(332, 351);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(67, 60);
            this.button_History.TabIndex = 5;
            this.button_History.Text = "Ιστορικό";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            this.button_History.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button_History.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button_beaches
            // 
            this.button_beaches.BackColor = System.Drawing.Color.White;
            this.button_beaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_beaches.Location = new System.Drawing.Point(242, 351);
            this.button_beaches.Name = "button_beaches";
            this.button_beaches.Size = new System.Drawing.Size(84, 60);
            this.button_beaches.TabIndex = 6;
            this.button_beaches.Text = "Παραλίες";
            this.button_beaches.UseVisualStyleBackColor = false;
            this.button_beaches.Click += new System.EventHandler(this.button_beaches_Click);
            this.button_beaches.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button_beaches.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button_attractions
            // 
            this.button_attractions.BackColor = System.Drawing.Color.White;
            this.button_attractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_attractions.Location = new System.Drawing.Point(405, 351);
            this.button_attractions.Name = "button_attractions";
            this.button_attractions.Size = new System.Drawing.Size(78, 60);
            this.button_attractions.TabIndex = 7;
            this.button_attractions.Text = "Αξιοθέατα";
            this.button_attractions.UseVisualStyleBackColor = false;
            this.button_attractions.Click += new System.EventHandler(this.button_attractions_Click);
            this.button_attractions.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button_attractions.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Επισκεπτείτε το Peru";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(57, 158);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(71, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Ανάγνωση";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(134, 158);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(103, 23);
            this.btnPauseResume.TabIndex = 9;
            this.btnPauseResume.Text = "Παύση/Συνέχιση";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(243, 158);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Διακοπή";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TouristGuide.WinForms.Properties.Resources.paralia1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(550, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 155);
            this.panel1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TouristGuide.WinForms.Properties.Resources.peru_backgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.button_attractions);
            this.Controls.Add(this.button_beaches);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.button_History, 0);
            this.Controls.SetChildIndex(this.button_beaches, 0);
            this.Controls.SetChildIndex(this.button_attractions, 0);
            this.Controls.SetChildIndex(this.btnRead, 0);
            this.Controls.SetChildIndex(this.btnPauseResume, 0);
            this.Controls.SetChildIndex(this.btnStop, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_beaches;
        private System.Windows.Forms.Button button_attractions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}