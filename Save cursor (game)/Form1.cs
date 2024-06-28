using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Save_cursor__game_
{
    public partial class Form1 : Form
    {
        List<Panel> traps = new List<Panel>();
        int step = 2;
        int step2 = 10;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await TrapsMoving();
        }
        private async void timer2_Tick(object sender, EventArgs e)
        {
            await CreateTraps();
        }
        private async Task TrapsMoving()
        {
            foreach (Panel but in traps)
            {
                if (but.Tag == "1") 
                {
                    if (but.Location.X < 0) { Controls.Remove(but); traps.Remove(but); break; }
                    but.Location = new Point(but.Location.X - step, but.Location.Y);
                }
                else
                {
                    but.Location = new Point(but.Location.X, but.Location.Y - step);
                    if (but.Location.Y < 0) { Controls.Remove(but); traps.Remove(but); break; }
                }
            }
        }
        private async Task CreateTraps()
        {
            if (traps.Count <= 15)
            {
                if (timer2.Interval > 2) timer2.Interval -= 2;
                int coordinate = random.Next(1, 500);
                Panel newPanel = new Panel();
                if (random.Next(1, 3) == 1)  // generate traps behavior 
                { newPanel.Location = new System.Drawing.Point(500, coordinate); newPanel.Tag = "1"; }
                else newPanel.Location = new System.Drawing.Point(coordinate, 500);
                newPanel.BackColor = SystemColors.ControlDarkDark;
                newPanel.Margin = new Padding(0);
                newPanel.Size = new Size(30, 30);
                newPanel.MouseEnter += new EventHandler(MouseOverTheTrap);

                Controls.Add(newPanel);
                traps.Add(newPanel);
                lbScoreOnTheScreen.SendToBack();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            step += 1;
        }


        private void MouseOverTheTrap(object sender, EventArgs e)
        {
            EndGame();
        }
        private void EndGame()
        {
            lbScoreOnTheScreen.Visible = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            lbGameOver.Visible = true;
            lbScore.Text = lbScoreOnTheScreen.Text;
            panel1.Visible = true;
            panel1.Enabled = true;
            UpdateUserScore();
        }
        private void UpdateUserScore()
        {
            string lastScore = lbScoreOnTheScreen.Text;
            DataBase db = new DataBase();

            if (lastScore != null)
            {
                try
                {
                    string query = $"UPDATE register SET score = @score1 WHERE login_user = @login_user AND score < @score2; ";
                    db.OpenConnection();
                    using (SqlCommand command = new SqlCommand(query, db.GetConnection())) 
                    {
                        command.Parameters.Add(new SqlParameter("@login_user", SqlDbType.NVarChar, 50) { Value = StartMenu.nameLabel.Text });
                        command.Parameters.Add(new SqlParameter("@score1", SqlDbType.NVarChar, 50) { Value = Convert.ToInt32(lastScore) });
                        command.Parameters.Add(new SqlParameter("@score2", SqlDbType.NVarChar, 100) { Value = Convert.ToInt32(lastScore) });
                        command.ExecuteNonQuery();
                    }
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { db.CloseConnection(); }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lbScoreOnTheScreen.Text = (Convert.ToInt32(lbScoreOnTheScreen.Text) + 1).ToString();
        }
        private void lbScoreOnTheScreen_SizeChanged(object sender, EventArgs e)
        {
            CenterLabel();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPosition = PointToClient(Cursor.Position);

            int clientWidth = ClientSize.Width;
            int clientHeight = ClientSize.Height;


            if (cursorPosition.X == 0 || cursorPosition.X > clientWidth - 1 ||
                cursorPosition.Y == 0 || cursorPosition.Y > clientHeight - 1)
            {
                EndGame();
            }
        }

        private void CenterLabel()
        {
            lbScoreOnTheScreen.Location = new Point(
                (this.ClientSize.Width - lbScoreOnTheScreen.Width) / 2,
                (this.ClientSize.Height - lbScoreOnTheScreen.Height) / 2
            );
        }
        private void DefaultSettings()
        {
            lbGameOver.Visible = false;
            if (this.WindowState != FormWindowState.Minimized && this.Visible)
            {
                Point clientCenter = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
                Point screenCenter = this.PointToScreen(clientCenter);
                Cursor.Position = screenCenter;
            }
            else
            {
                MessageBox.Show("The form is inactive or collapsed!");
            }

            while (traps.Count != 0)
            {
                Controls.Remove(traps[0]);
                traps.Remove(traps[0]);
            }
            traps = new List<Panel>();
            lbScoreOnTheScreen.Text = "0";
            lbScoreOnTheScreen.Visible = true;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            lbGameOver.Visible = false;
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DefaultSettings();
        }

    }
}
