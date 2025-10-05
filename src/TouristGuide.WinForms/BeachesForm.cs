using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class BeachesForm : BaseForm
    {
        private readonly string _dbPath;
        private readonly string _connStr;
        public BeachesForm()
        {
            InitializeComponent();
            _dbPath = Path.Combine(Application.StartupPath, @"..\..\Tourist_Guide.db");    // Path προς την βάση 
            _dbPath = Path.GetFullPath(_dbPath);
            _connStr = $"Data Source={_dbPath};Version=3;";
            WireButtons();
        }
        private void WireButtons()
        {
            button9.Click += OnBeachClick;
            button10.Click += OnBeachClick;
            button3.Click += OnBeachClick;
            button4.Click += OnBeachClick;
            button5.Click += OnBeachClick;
            button6.Click += OnBeachClick;

            button9.Tag = "Máncora Beach";
            button10.Tag = "Los Órganos Beach";
            button3.Tag = "Punta Sal Beach";
            button4.Tag = "Playa Roja";
            button5.Tag = "Las Pocitas";
            button6.Tag = "Belluga";
        }
        private void OnBeachClick(object sender, EventArgs e)
        {
            if (Session.IsVisitor)
            {
                return;
            }

            var btn = sender as Button;
            if (btn == null) return;

            string beachName = btn.Tag as string ?? btn.Text;
            var item = GetItem(beachName);
            SaveHistory(Session.UserId, item.ItemId.Value);
             // Εμφάνιση περιγραφής
             MessageBox.Show($"{beachName}\n\n{item.Description}","Πληροφορίες", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private (int? ItemId, string Description) GetItem(string name)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand(
                "SELECT Item_id, Description FROM Items WHERE Item_name=@n LIMIT 1", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@n", name);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int itemId = reader.GetInt32(0);           // Item_id
                        string description = reader.GetString(1);  // Description
                        return (itemId, description);
                    }
                }
            }
            return (null, null);
        }
        private void SaveHistory(int userId, int itemId)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand("INSERT INTO UserHistory (User_id, Item_id) VALUES (@u, @i)", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@u", userId);
                cmd.Parameters.AddWithValue("@i", itemId);
                cmd.ExecuteNonQuery();
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var previous = new MainForm();
            previous.Show();
        }
        private void BeachesForm_Load(object sender, EventArgs e)
        {
        }
    }
}