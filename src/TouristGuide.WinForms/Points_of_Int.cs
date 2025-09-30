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

            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tourist_Guide.db");
            _connStr = $"Data Source={_dbPath};Version=3;";

            // Συνδέουμε όλα τα κουμπιά σε έναν κοινό handler
            WireButtons();
        }

        private void WireButtons()
        {
            // Συνδέουμε όλα τα κουμπιά στον ίδιο handler
            btn01.Click += OnPointClick;
            btn02.Click += OnPointClick;
            btn03.Click += OnPointClick;
            btn04.Click += OnPointClick;
            btn05.Click += OnPointClick;
            btn06.Click += OnPointClick;

            // Ορίζουμε τα Tag με τα ονόματα των points (Section_id = 2)
            btn01.Tag = "Machu Picchu";
            btn02.Tag = "Cusco";
            btn03.Tag = "Lake Titicaca";
            btn04.Tag = "Nazca Lines";
            btn05.Tag = "Colca Canyon";
            btn06.Tag = "Sacred Valley";
        }


        private void OnPointClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            string pointName = btn.Tag as string ?? btn.Text;

            int? itemId = GetItemId(pointName, 2); // Section_id = 2

            if (itemId != null)
            {
                SaveHistory(Session.UserId, itemId.Value);

                // ---- DEBUG HISTORY ----
                using (var conn = new SQLiteConnection(_connStr))
                using (var cmd = new SQLiteCommand(
                    "SELECT uh.History_id, i.Item_name, uh.Visited_at " +
                    "FROM UserHistory uh JOIN Items i ON uh.Item_id=i.Item_id " +
                    "WHERE uh.User_id=@u ORDER BY uh.Visited_at DESC", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@u", Session.UserId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        string msg = "Current UserHistory:\n";
                        while (reader.Read())
                        {
                            msg += $"#{reader["History_id"]} - {reader["Item_name"]} at {reader["Visited_at"]}\n";
                        }
                        MessageBox.Show(msg);
                    }
                }
                // ------------------------

                MessageBox.Show($"Visit saved: {pointName}");
            }
        }



        private int? GetItemId(string name, int sectionId)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand(
                "SELECT Item_id FROM Items WHERE Item_name=@n AND Section_id=@s LIMIT 1", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@s", sectionId);
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return null;
                return Convert.ToInt32(result);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();         // κρύβεις την τρέχουσα
            var previous = new MainForm();
            previous.Show();     
        }
    }
}
