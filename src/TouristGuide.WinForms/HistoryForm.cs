using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TouristGuide.WinForms
{
    public partial class HistoryForm : BaseForm
    {
        public HistoryForm()
        {
            InitializeComponent();
            this.Load += HistoryForm_Load; 
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (Session.UserId <= 0 || Session.IsVisitor)
            {
                return;
            }
            LoadHistorySection(listBox1, 1); // Παραλίες
            LoadHistorySection(listBox2, 2); // Αξιοθέατα
        }
        private void LoadHistorySection(ListBox listBox, int sectionId)
        {
            listBox.Items.Clear();

            using (var conn = new SQLiteConnection(AppConfig.ConnStr))
            {
                conn.Open();

                string query = @"
                    SELECT I.Item_name, H.Visited_at
                    FROM UserHistory H
                    JOIN Items I ON H.Item_id = I.Item_id
                    WHERE H.User_id=@UserId AND I.Section_id=@SectionId
                    ORDER BY H.Visited_at DESC;";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                    cmd.Parameters.AddWithValue("@SectionId", sectionId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            string itemName = reader["Item_name"].ToString();
                            string visitedAt = reader["Visited_at"].ToString();
                            listBox.Items.Add($"{itemName}  ({visitedAt})");
                        }
                        if (count == 0)
                            listBox.Items.Add("(Δεν υπάρχει ιστορικό)");
                    }
                }
            }
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            string line = null;
            if (listBox1.SelectedItem != null)
                line = listBox1.SelectedItem.ToString();
            else if (listBox2.SelectedItem != null)
                line = listBox2.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("("))
            {
                MessageBox.Show("Διάλεξε μια καταχώρηση από τη λίστα.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Αποθήκευση πληροφοριών";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "tourist-info.txt"; 

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, line, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
                        MessageBox.Show("Αποθηκεύτηκε επιτυχώς.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Αποτυχία αποθήκευσης:\r\n" + ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnallExport_Click_1(object sender, EventArgs e)
        {
            // Συγκέντρωση όλων των στοιχείων από τις λίστες
            var sb = new StringBuilder();

            sb.AppendLine("=== Παραλίες ===");
            foreach (var item in listBox1.Items)
            {
                if (item != null && !item.ToString().StartsWith("("))
                    sb.AppendLine(item.ToString());
            }

            sb.AppendLine();
            sb.AppendLine("=== Αξιοθέατα ===");
            foreach (var item in listBox2.Items)
            {
                if (item != null && !item.ToString().StartsWith("("))
                    sb.AppendLine(item.ToString());
            }

            if (sb.Length == 0)
            {
                MessageBox.Show("Δεν υπάρχουν καταχωρήσεις για εξαγωγή.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Αποθήκευση ιστορικού";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "history.txt";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
                        MessageBox.Show("Το ιστορικό αποθηκεύτηκε επιτυχώς.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Αποτυχία αποθήκευσης:\r\n" + ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void clear_history_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Είσαι σίγουρος ότι θέλεις να διαγράψεις ολόκληρο το ιστορικό σου;",
                "Επιβεβαίωση Διαγραφής",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string dbPath = Path.Combine(Application.StartupPath, @"..\..\Tourist_Guide.db");
                    dbPath = Path.GetFullPath(dbPath);
                    string connStr = $"Data Source={dbPath};Version=3;";

                    using (var conn = new SQLiteConnection(connStr))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM UserHistory WHERE User_id = @UserId;";
                        using (var cmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                            int rows = cmd.ExecuteNonQuery();

                            MessageBox.Show($"Διαγράφηκαν {rows} εγγραφές από το ιστορικό σου.",
                                "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    // Καθαρίζουμε και τα ListBox
                    listBox1.Items.Clear();
                    listBox1.Items.Add("(Δεν υπάρχει ιστορικό)");
                    listBox2.Items.Clear();
                    listBox2.Items.Add("(Δεν υπάρχει ιστορικό)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Σφάλμα κατά τη διαγραφή του ιστορικού:\r\n" + ex.Message,
                        "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}