using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class MainForm : BaseForm
    {
        private Label lblWelcome;
        private Button btnBeaches;
        private Button btnAttractions;
        private Button btnRestaurants;
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
            if (Session.IsVisitor)
            {
                MessageBox.Show("Οι επισκέπτες δεν έχουν ιστορικό!");
            }
            else
            {
                MessageBox.Show("Τελευταία παραλία που είδατε: Ναυάγιο");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
            {
                MessageBox.Show("Welcome Visitor! Limited functionality.");

                // Κρύβει το κουμπί Ιστορικό για Visitor
                button_History.Visible = false;
            }
            else
            {
                MessageBox.Show($"Welcome {Session.Username}!");

                // Ο User βλέπει το κουμπί Ιστορικό
                button_History.Visible = true;
            }
        
        }
    }
}

        