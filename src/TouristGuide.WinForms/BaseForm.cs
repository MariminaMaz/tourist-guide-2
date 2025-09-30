using System;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent(); // φορτώνει το menuStrip1 από τον Designer
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // Δεν κάνουμε τίποτα εδώ προς το παρόν
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "Tourist Guide Application\n\n" +
                       "Created by: Χρήστος Κενανίδης και Μαριμίνα Μάζη\n";

            MessageBox.Show(aboutText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

