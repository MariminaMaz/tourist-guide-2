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

            // Path προς την βάση στο project folder
            _dbPath = Path.Combine(Application.StartupPath, @"..\..\Tourist_Guide.db");
            _dbPath = Path.GetFullPath(_dbPath);
            _connStr = $"Data Source={_dbPath};Version=3;";

            WireButtons();
        }

        private void WireButtons()
        {
            button1.Click += OnBeachClick;
            button10.Click += OnBeachClick;
            button3.Click += OnBeachClick;
            button4.Click += OnBeachClick;
            button5.Click += OnBeachClick;
            button6.Click += OnBeachClick;

            button1.Tag = "Máncora Beach";
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

            int? itemId = GetItemId(beachName);
            SaveHistory(Session.UserId, itemId.Value);
            
        }

        private int? GetItemId(string name)
        {
            using (var conn = new SQLiteConnection(_connStr))
            using (var cmd = new SQLiteCommand("SELECT Item_id FROM Items WHERE Item_name=@n LIMIT 1", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@n", name);
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return null;
                return Convert.ToInt32(result);
            }
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
