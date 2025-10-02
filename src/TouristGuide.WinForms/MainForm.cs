using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class MainForm : BaseForm
    {
       

        private SpeechSynthesizer tts = new SpeechSynthesizer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_beaches_Click(object sender, EventArgs e)
        {
            BeachesForm main = new BeachesForm();
            main.Show();
            this.Hide();
        }

        private void button_attractions_Click(object sender, EventArgs e)
        {
            PointsOfInterestForm main = new PointsOfInterestForm();
            main.Show();
            this.Hide();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.Show();

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Color.LightBlue;  // χρώμα όταν περνάει το ποντίκι
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = SystemColors.Control; // επαναφορά default
        } 

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
            {
                // Κρύβει το κουμπί Ιστορικό για Visitor
                button_History.Visible = false;
            }
            else
            {
                // Ο User βλέπει το κουμπί Ιστορικό
                button_History.Visible = true;

                tts.Volume = 100;
                tts.Rate = 0;

                try
                {
                    
                    tts.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Adult, 0, new CultureInfo("el-GR"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Δεν βρέθηκε ελληνική φωνή el-GR.\r\n" + ex.Message);
                }

               
            }

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            // Να καλύπτουν όλο το χώρο & να κάνουν Zoom
            pictureBox1.Dock = pictureBox2.Dock = pictureBox3.Dock = pictureBox4.Dock = pictureBox5.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = pictureBox2.SizeMode = pictureBox3.SizeMode = pictureBox4.SizeMode = pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;

            // Timer
            timer1.Stop();
            timer1.Interval = 2000;        // κάθε 2 δευτερόλεπτα
            timer1.Tick -= timer1_Tick;    // αποφυγή διπλού binding
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var text = string.IsNullOrWhiteSpace(richTextBox1.SelectedText)
                ? richTextBox1.Text
                : richTextBox1.SelectedText;

            if (string.IsNullOrWhiteSpace(text)) return;

            tts.SpeakAsyncCancelAll();
            tts.SpeakAsync(text);

        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (tts.State == SynthesizerState.Speaking)
                tts.Pause();
            else if (tts.State == SynthesizerState.Paused)
                tts.Resume();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tts.SpeakAsyncCancelAll();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            tts.SpeakAsyncCancelAll(); 
            tts.Dispose();            
            base.OnFormClosed(e);     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible== true)
            {   
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

            }
            else if (pictureBox2.Visible == true)
            {  pictureBox2.Visible = false;
               pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible ==true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        