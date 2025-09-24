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
    }
}

