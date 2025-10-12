using System;
using System.Drawing;
using System.Globalization;
using System.Speech.Synthesis;
using System.Media;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class MainForm : BaseForm
    {
        private SpeechSynthesizer tts = new SpeechSynthesizer();
        private Image[] slideshowImages;
        private int currentIndex = 0;
        private readonly SoundPlayer _tropical = new SoundPlayer(Properties.Resources.tropical);

        public MainForm()
        {
            InitializeComponent();
            _tropical.Load();
        }
        private void button_beaches_Click(object sender, EventArgs e)
        {
            _tropical.Play();
            BeachesForm main = new BeachesForm();
            main.Show();
            this.Hide();
        }

        private void button_attractions_Click(object sender, EventArgs e)
        {
            _tropical.Play();
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
                btn.BackColor = Color.LightBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = SystemColors.Control;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
            {
                button_History.Visible = false;
            }
            else
            {
                button_History.Visible = true;
                tts.Volume = 100;
                tts.Rate = 0;
                tts.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.Adult, 0, new CultureInfo("el-GR"));
            }

            slideshowImages = new Image[]
            {
                Properties.Resources.paralia1,
                Properties.Resources.paralia2,
                Properties.Resources.paralia3,
                Properties.Resources.paralia4
            };

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            currentIndex = 0;
            pictureBox1.Image = slideshowImages[currentIndex];

            // Timer: ασφαλής εγγραφή ενός μόνο handler
            timer1.Stop();
            timer1.Interval = 2000;

            // Αφαιρούμε πρώτα τον handler (αν υπάρχει) και μετά τον προσθέτουμε
            timer1.Tick -= timer1_Tick;
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
            if (slideshowImages == null || slideshowImages.Length == 0)
                return;

            currentIndex++;
            if (currentIndex >= slideshowImages.Length)
                currentIndex = 0;

            pictureBox1.Image = slideshowImages[currentIndex];
        }
    }
}