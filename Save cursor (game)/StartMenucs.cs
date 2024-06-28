using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Save_cursor__game_
{
    public partial class StartMenu : Form
    {
        List<string[]> rows;
        DataBase db = new DataBase();
        public static Label nameLabel;
        public static string lastScore;
        public StartMenu()
        {
            InitializeComponent();
            nameLabel = lbPlayerName;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
            if (autorization.DialogResult == DialogResult.OK)
            {
                lbPlayerName.Text = Autorization.user_name;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.ShowDialog();
            this.Show();

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            UploadData();
            panel2.Visible = true;
            panel2.Enabled = true;
            panel1.Visible = false;
            panel1.Enabled = false;
        }
        private void UploadData()
        {
            rows = new List<string[]>();
            string query = "SELECT login_user, score FROM register";
            db.OpenConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(query, db.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string[] row;
                        int count = 1;
                        while (reader.Read())
                        {
                            try
                            {
                                row = new string[]
                                {
                                Convert.ToString(count),
                                Convert.ToString(reader["login_user"]),
                                Convert.ToString(reader["score"])
                                };
                                rows.Add(row);
                            }
                            catch (Exception ex)
                            { MessageBox.Show("Error in executing query: " + ex.Message); }
                            count++;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error in executing query: " + ex.Message); }
            finally
            {
                db.CloseConnection();
            }

            AddToListView();
        }
        private void AddToListView()
        {
            listView1.Items.Clear();
            foreach (string[] item in rows)
            {
                listView1.Items.Add(new ListViewItem(item));
            }
        }
        private void btnBackStatistic_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Enabled = false;
            panel1.Visible = true;
            panel1.Enabled = true;
            
        }

    }
}
