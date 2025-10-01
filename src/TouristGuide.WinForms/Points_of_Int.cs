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

            // --- Βρες το σωστό path για τη βάση ---
            _dbPath = Path.Combine(Application.StartupPath, @"..\..\Tourist_Guide.db");
            _dbPath = Path.GetFullPath(_dbPath);
            _connStr = $"Data Source={_dbPath};Version=3;";


            // Αν δεν υπάρχει στο bin/Debug, γύρνα στον φάκελο του project
            if (!File.Exists(_dbPath))
            {
                _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Tourist_Guide.db");
                _dbPath = Path.GetFullPath(_dbPath);
            }

            _connStr = $"Data Source={_dbPath};Version=3;";

            // Συνδέουμε τα κουμπιά με handler
            WireButtons();
        }

        private void WireButtons()
        {
            btn01.Click += OnPointClick;
            btn02.Click += OnPointClick;
            btn03.Click += OnPointClick;
            btn04.Click += OnPointClick;
            btn05.Click += OnPointClick;
            btn06.Click += OnPointClick;

            // Ονόματα points (Item_name στον πίνακα Items)
            btn01.Tag = "Machu Picchu";
            btn02.Tag = "Cusco";
            btn03.Tag = "Lake Titicaca";
            btn04.Tag = "Nazca Lines";
            btn05.Tag = "Colca Canyon";
            btn06.Tag = "Sacred Valley";
        }

        private void OnPointClick(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
            {
                MessageBox.Show("Οι επισκέπτες δεν αποθηκεύουν ιστορικό.");
                return;
            }

            var btn = sender as Button;
            if (btn == null) return;

            string pointName = btn.Tag as string ?? btn.Text;

            try
            {
                int? itemId = GetItemId(pointName, 2); // Section_id = 2
                if (itemId == null)
                {
                    MessageBox.Show($"Δεν βρέθηκε Item στη βάση με όνομα {pointName}");
                    return;
                }

                SaveHistory(Session.UserId, itemId.Value);
                MessageBox.Show($"Καταγράφηκε επίσκεψη: {pointName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα: " + ex.Message);
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

            // Debug για να βεβαιωθούμε ότι δείχνει στο σωστό αρχείο
            MessageBox.Show("DB Path: " + _dbPath);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var previous = new MainForm();
            previous.Show();
        }
    }
}
