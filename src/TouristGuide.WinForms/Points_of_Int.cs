using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class PointsOfInterestForm : BaseForm
    {
        private readonly string _dbPath;
        private readonly string _connStr;

        public PointsOfInterestForm()
        {
            InitializeComponent();

            // Ορισμός διαδρομής προς τη βάση
            _dbPath = Path.Combine(Application.StartupPath, @"..\..\Tourist_Guide.db");
            _dbPath = Path.GetFullPath(_dbPath);
            _connStr = $"Data Source={_dbPath};Version=3;";
        }

        private void OnPointClick(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
                return;

            if (!(sender is Button btn))
                return;

            string pointName = btn.Text.Trim();

            var item = GetItem(pointName, 2);
            if (item.ItemId == null)
            {
                MessageBox.Show("Δεν βρέθηκαν πληροφορίες για αυτό το σημείο ενδιαφέροντος.",
                    "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveHistory(Session.UserId, item.ItemId.Value);

            // Εμφάνιση περιγραφής
            MessageBox.Show($"{pointName}\n\n{item.Description}", "Πληροφορίες",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private (int? ItemId, string Description) GetItem(string name, int sectionId)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand(
                "SELECT Item_id, Description FROM Items WHERE Item_name=@n AND Section_id=@s LIMIT 1", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", sectionId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int itemId = reader.GetInt32(0);
                        string description = reader.GetString(1);
                        return (itemId, description);
                    }
                }
            }
            return (null, null);
        }

        private void SaveHistory(int userId, int itemId)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand(
                "INSERT INTO UserHistory (User_id, Item_id) VALUES (@u, @i)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@i", itemId);
                cmd.ExecuteNonQuery();
            }
        }
        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var previous = new MainForm();
            previous.Show();
        }
    }
}
