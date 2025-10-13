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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_History = new System.Windows.Forms.Button();
            this.button_beaches = new System.Windows.Forms.Button();
            this.button_attractions = new System.Windows.Forms.Button();
            this.sound_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Επισκεφτείτε το Peru";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(19, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(71, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Ανάγνωση";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(108, 5);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(103, 23);
            this.btnPauseResume.TabIndex = 9;
            this.btnPauseResume.Text = "Παύση/Συνέχιση";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(234, 5);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnPauseResume);
            this.panel3.Controls.Add(this.btnRead);
            this.panel3.Location = new System.Drawing.Point(13, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 31);
            this.panel3.TabIndex = 18;
            // 
            // button_History
            // 
            this.button_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_History.Location = new System.Drawing.Point(448, 366);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(74, 60);
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
            this.button_beaches.Location = new System.Drawing.Point(247, 366);
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
            this.button_attractions.Location = new System.Drawing.Point(352, 366);
            this.button_attractions.Name = "button_attractions";
            this.button_attractions.Size = new System.Drawing.Size(78, 60);
            this.button_attractions.TabIndex = 7;
            this.button_attractions.Text = "Αξιοθέατα";
            this.button_attractions.UseVisualStyleBackColor = false;
            this.button_attractions.Click += new System.EventHandler(this.button_attractions_Click);
            this.button_attractions.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button_attractions.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // sound_btn
            // 
            this.sound_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.sound_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sound_btn.Location = new System.Drawing.Point(660, 398);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(90, 28);
            this.sound_btn.TabIndex = 20;
            this.sound_btn.Text = "Sound : ON";
            this.sound_btn.UseVisualStyleBackColor = false;
            this.sound_btn.Click += new System.EventHandler(this.sound_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TouristGuide.WinForms.Properties.Resources.peru_backgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.button_beaches);
            this.Controls.Add(this.button_attractions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button_History, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.button_attractions, 0);
            this.Controls.SetChildIndex(this.button_beaches, 0);
            this.Controls.SetChildIndex(this.sound_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_beaches;
        private System.Windows.Forms.Button button_attractions;
        private System.Windows.Forms.Button sound_btn;
    }
}