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
            MessageBox.Show("Load event εκτελέστηκε!");

            MessageBox.Show($"DEBUG: Session.UserId = {Session.UserId}");
            if (Session.UserId <= 0 || Session.IsVisitor)
            {
                MessageBox.Show("Οι επισκέπτες δεν έχουν ιστορικό.");
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
                    ORDER BY H.Visited_at DESC
                    LIMIT 5;";

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
    }
    }

