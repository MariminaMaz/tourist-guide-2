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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_History = new System.Windows.Forms.Button();
            this.button_beaches = new System.Windows.Forms.Button();
            this.button_attractions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Τουριστικός οδηγός\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(39, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(197, 104);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Καλώς ήρθατε στο τουριστικό οδηγό για τη @@@ παρακάτω θα βρείτε περισσοτέρες πληρ" +
    "οφορίες.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_History
            // 
            this.button_History.Location = new System.Drawing.Point(252, 383);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(75, 23);
            this.button_History.TabIndex = 5;
            this.button_History.Text = "Ιστορικό";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // button_beaches
            // 
            this.button_beaches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_beaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_beaches.Location = new System.Drawing.Point(104, 327);
            this.button_beaches.Name = "button_beaches";
            this.button_beaches.Size = new System.Drawing.Size(87, 23);
            this.button_beaches.TabIndex = 6;
            this.button_beaches.Text = "Παραλίες";
            this.button_beaches.UseVisualStyleBackColor = false;
            this.button_beaches.Click += new System.EventHandler(this.button_beaches_Click);
            // 
            // button_attractions
            // 
            this.button_attractions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_attractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button_attractions.Location = new System.Drawing.Point(379, 327);
            this.button_attractions.Name = "button_attractions";
            this.button_attractions.Size = new System.Drawing.Size(83, 23);
            this.button_attractions.TabIndex = 7;
            this.button_attractions.Text = "Αξιοθέατα";
            this.button_attractions.UseVisualStyleBackColor = false;
            this.button_attractions.Click += new System.EventHandler(this.button_attractions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.button_attractions);
            this.Controls.Add(this.button_beaches);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.button_History, 0);
            this.Controls.SetChildIndex(this.button_beaches, 0);
            this.Controls.SetChildIndex(this.button_attractions, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_beaches;
        private System.Windows.Forms.Button button_attractions;
    }
}