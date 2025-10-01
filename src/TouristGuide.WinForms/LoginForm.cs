using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    // Σταθερές για όλη την εφαρμογή
    public static class AppConfig
    {
        public static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tourist_Guide.db");
        public static readonly string ConnStr = $"Data Source={DbPath};Version=3;";
    }

    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Προαιρετικό debug
            // MessageBox.Show($"DB exists: {File.Exists(AppConfig.DbPath)}\nPath: {AppConfig.DbPath}");
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();

            if (!File.Exists(AppConfig.DbPath))
            {
                MessageBox.Show($"Η βάση δεν βρέθηκε: {AppConfig.DbPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new SQLiteConnection(AppConfig.ConnStr))
            {
                conn.Open();

                // Έλεγχος ύπαρξης χρήστη
                string query = "SELECT User_id FROM Users WHERE Username=@username AND Password=@password LIMIT 1";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int userId = Convert.ToInt32(result);

                        // Αποθήκευση στο Session
                        Session.IsVisitor = false;
                        Session.UserId = userId;
                        Session.Username = username;

                        MessageBox.Show("Login successful!");

                        // Άνοιγμα MainForm
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void button_visitor_Click(object sender, EventArgs e)
        {
            Session.IsVisitor = true;
            Session.UserId = 0;
            Session.Username = "Visitor";

            MessageBox.Show("Login as Visitor!");

            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            // Δεν χρειάζεται για το ιστορικό
        }
    }
}
